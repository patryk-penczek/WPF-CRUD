using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_CRUD
{
    public partial class CreateNoteWindow : Window 
    {
        public string CreateNewNoteTitle { get; set; }
        public string CreateNewNoteCategory { get; set; }
        public string CreateNewNoteContent { get; set; }
        public DateTime CreateNewNoteCreationDate { get; set; }
        public DateTime CreateNewNoteModificationDate { get; set; }
        public bool IsCreateRequest { get; set; } = false;

        public CreateNoteWindow()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            CreateNewNoteTitle = NewNoteTitle_TextBox.Text;
            CreateNewNoteCategory = NewNoteCategory_TextBox.Text;
            CreateNewNoteContent = NewNoteContent_TextBox.Text;
            CreateNewNoteCreationDate = DateTime.Now;
            CreateNewNoteModificationDate = DateTime.Now;
            IsCreateRequest = true;
            this.Close();
        }
    }
}
