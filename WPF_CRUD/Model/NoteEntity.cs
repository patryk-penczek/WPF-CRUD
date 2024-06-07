using System;

namespace WPF_CRUD.Model
{
    internal class NoteEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }

        public NoteEntity()
        {

        }

        public NoteEntity(int id, string title, string content, string category, DateTime creationDate, DateTime modificationDate)
        {
            Id = id;
            Title = title;
            Content = content;
            Category = category;
            CreationDate = creationDate;
            ModificationDate = modificationDate;
        }
    }
}
