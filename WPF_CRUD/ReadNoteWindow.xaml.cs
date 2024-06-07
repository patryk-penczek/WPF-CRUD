using System;
using System.Windows;

namespace WPF_CRUD
{
    public partial class ReadNoteWindow : Window
    {
        public string ReadNewNoteTitle { get; private set; }
        public string ReadNewNoteCategory { get; private set; }
        public string ReadNewNoteContent { get; private set; }
        public DateTime ReadNewNoteCreationDate { get; private set; }
        public DateTime ReadNewNoteModificationDate { get; private set; }

        public ReadNoteWindow(string title, string category, string content, DateTime creationDate, DateTime modificationDate)
        {
            InitializeComponent();
            ReadNewNoteTitle = title;
            ReadNewNoteCategory = category;
            ReadNewNoteContent = content;
            ReadNewNoteCreationDate = creationDate;
            ReadNewNoteModificationDate = modificationDate;

            NewNoteTitle_TextBox.Text = ReadNewNoteTitle;
            NewNoteCategory_TextBox.Text = ReadNewNoteCategory;
            NewNoteContent_TextBox.Text = ReadNewNoteContent;
            NewNoteCreationDate_TextBox.Text = ReadNewNoteCreationDate.ToString();
            NewNoteModificationDate_TextBox.Text = ReadNewNoteModificationDate.ToString();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
