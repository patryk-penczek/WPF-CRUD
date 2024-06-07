using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Reflection.Metadata;

namespace WPF_CRUD
{
    public partial class UpdateNoteWindow : Window
    {
        public string UpdateNewNoteTitle { get; set; }
        public string UpdateNewNoteCategory { get; set; }
        public string UpdateNewNoteContent { get; set; }
        public DateTime UpdateNewNoteModificationDate { get; set; }
        public bool IsUpdateRequest { get; set; } = false;

        public UpdateNoteWindow(string title, string category, string content)
        {
            InitializeComponent();
            UpdateNewNoteTitle = title;
            UpdateNewNoteCategory = category;
            UpdateNewNoteContent = content;

            NewNoteTitle_TextBox.Text = UpdateNewNoteTitle;
            NewNoteCategory_TextBox.Text = UpdateNewNoteCategory;
            NewNoteContent_TextBox.Text = UpdateNewNoteContent;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            UpdateNewNoteTitle = NewNoteTitle_TextBox.Text;
            UpdateNewNoteCategory = NewNoteCategory_TextBox.Text;
            UpdateNewNoteContent = NewNoteContent_TextBox.Text;
            UpdateNewNoteModificationDate = DateTime.Now;
            IsUpdateRequest = true;
            this.Close();
        }

    }
}
