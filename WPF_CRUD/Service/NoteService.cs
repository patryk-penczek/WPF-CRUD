using AutoMapper;
using WPF_CRUD.DTO;
using WPF_CRUD.Mapper;
using WPF_CRUD.Model;
using WPF_CRUD.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_CRUD.Service
{
    public class NoteService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public NoteService(string connectionString)
        {
            _appDbContext = new AppDbContext(connectionString);
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new NoteMappingProfile());
            });
            _mapper = mapperConfiguration.CreateMapper();
        }

        public IEnumerable<NoteDto> GetNotes()
        {
            var query = "SELECT * FROM Notes;";
            var notes = _appDbContext.GetFromDatabase<NoteEntity>(query);
            return _mapper.Map<IEnumerable<NoteDto>>(notes);
        }
        public void CreateNote(NoteDto note)
        {
            _appDbContext.CreateNote(note);
        }
        public void ReadNote(string name)
        {
            _appDbContext.ReadNote(name);
        }
        public void UpdateNote(NoteDto note, int id)
        {
            _appDbContext.UpdateNote(note, id);
        }
        public void DeleteNote(string name)
        {
            _appDbContext.DeleteNote(name);
        }
    }
}
