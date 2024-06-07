using Dapper;
using WPF_CRUD.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WPF_CRUD.Persistence
{
    public class AppDbContext
    {
        private static readonly string DB_NAME = "WPF_APP1";

        private readonly SqlConnection _sqlConnection;

        public AppDbContext(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
            _sqlConnection.Open();
            CreateAppDbContext();
        }

        public void CreateNote(NoteDto noteDto)
        {
            string insertCommand = "INSERT INTO Notes (Title, Content, Category, CreationDate, ModificationDate) VALUES (@Title, @Content, @Category, @CreationDate, @ModificationDate);";
            _sqlConnection.Execute(insertCommand, noteDto);
        }

        public NoteDto ReadNote(string title)
        {
            string selectCommand = "SELECT * FROM Notes WHERE Title = @Title";
            return _sqlConnection.QueryFirstOrDefault<NoteDto>(selectCommand, new { Title = title });
        }

        public void UpdateNote(NoteDto noteDto, int id)
        {
            string updateCommand = "UPDATE Notes SET Title = @Title, Content = @Content, Category = @Category, ModificationDate = @ModificationDate WHERE Id = @Id;";

            var parameters = new DynamicParameters();
            parameters.Add("Id", id);
            parameters.Add("Title", noteDto.Title);
            parameters.Add("Content", noteDto.Content);
            parameters.Add("Category", noteDto.Category);
            parameters.Add("ModificationDate", noteDto.ModificationDate);

            _sqlConnection.Execute(updateCommand, parameters);
        }


        public void DeleteNote(string title)
        {
            string deleteCommand = "DELETE FROM Notes WHERE Title = @Title";
            _sqlConnection.Execute(deleteCommand, new { Title = title });
        }

        public IEnumerable<T> GetFromDatabase<T>(string query)
        {
            return _sqlConnection.Query<T>(query);
        }

        public void CreateAppDbContext()
        {
            CreateDatabaseIfNotExist();
            CreateTableIfNotExist();
        }

        public void CreateDatabaseIfNotExist()
        {
            var command = "IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = '" + DB_NAME + "') BEGIN CREATE DATABASE " + DB_NAME + "; END;";
            SqlCommand sqlCommand = new SqlCommand(command);
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.ExecuteNonQuery();
            ChangeDatabase();
        }

        public void ChangeDatabase()
        {
            _sqlConnection.ChangeDatabase(DB_NAME);
        }

        public void CreateTableIfNotExist()
        {
            var command = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Notes' AND type = 'U')
                BEGIN
                    CREATE TABLE Notes(
                        Id INT IDENTITY(1,1) PRIMARY KEY,
                        Title NVARCHAR(255),
                        Content NVARCHAR(MAX),
                        Category NVARCHAR(255),
                        CreationDate DATETIME,
                        ModificationDate DATETIME
                    );
                END;";
            SqlCommand sqlCommand = new SqlCommand(command);
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.ExecuteNonQuery();
        }
    }
}
