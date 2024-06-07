using AutoMapper;
using WPF_CRUD.DTO;
using WPF_CRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_CRUD.Mapper
{
    public class NoteMappingProfile : Profile
    {
        public NoteMappingProfile()
        {
            CreateMap<NoteEntity, NoteDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
        }
    }
}
