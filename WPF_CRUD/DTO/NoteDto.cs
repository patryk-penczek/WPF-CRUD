using System;

namespace WPF_CRUD.DTO
{
    public class NoteDto
    {
        private string updateNewNoteName;
        private string updateNewNoteDescription;

        public int Id { get; set; }
        public string Title { get; set; } 
        public string Content { get; set; }
        public string Category { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }

        public NoteDto(string title, string category, string content, DateTime modificationDate, DateTime? creationDate = null)
        {
            Title = title;
            Category = category;
            Content = content;
            CreationDate = creationDate ?? DateTime.Now;
            ModificationDate = modificationDate;
        }


        public NoteDto(string updateNewNoteName, string updateNewNoteDescription)
        {
            this.updateNewNoteName = updateNewNoteName;
            this.updateNewNoteDescription = updateNewNoteDescription;
        }
    }
}
