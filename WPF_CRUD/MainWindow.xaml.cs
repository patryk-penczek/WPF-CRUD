using WPF_CRUD.DTO;
using WPF_CRUD.Model;
using WPF_CRUD.Service;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Dapper.SqlMapper;

namespace WPF_CRUD
{
    public partial class MainWindow : Window
    {
        private NoteDto selectedNote;
        private readonly NoteService _noteService;
        private ObservableCollection<NoteDto> observableNotes;

        public MainWindow()
        {
            InitializeComponent();
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            _noteService = new NoteService(connectionString);
            observableNotes = new ObservableCollection<NoteDto>();
            UpdateObservableNotes();
            Note_ListView.ItemsSource = observableNotes;
            DataContext = this;
        }

        private void CreateNote_Button_Click(object sender, RoutedEventArgs e)
        {
            var createNoteWindow = new CreateNoteWindow();
            createNoteWindow.Activate();
            createNoteWindow.Show();
            createNoteWindow.Closing += OnCreateNoteWindowClose;
        }

        private void OnCreateNoteWindowClose(object sender, CancelEventArgs e)
        {
            CreateNoteWindow eventSender = (CreateNoteWindow)sender;
            if (eventSender.IsCreateRequest)
            {
                DTO.NoteDto newNote = new DTO.NoteDto(
                    eventSender.CreateNewNoteTitle,
                    eventSender.CreateNewNoteCategory,
                    eventSender.CreateNewNoteContent,
                    DateTime.Now,
                    DateTime.Now);

                _noteService.CreateNote(newNote);
                UpdateObservableNotes();
            }
        }


        private void UpdateObservableNotes()
        {
            observableNotes.Clear();
            var notes = _noteService.GetNotes();
            foreach (var item in notes)
            {
                observableNotes.Add(item);
            }
        }

        private void Note_ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedNote = Note_ListView.SelectedItem as NoteDto;
        }


        private void ReadNote_Button_Click(object sender, RoutedEventArgs e)
        {
            if (selectedNote != null)
            {
                var readNoteWindow = new ReadNoteWindow(selectedNote.Title, selectedNote.Category, selectedNote.Content, selectedNote.CreationDate, selectedNote.ModificationDate);
                readNoteWindow.Show();
            }
            else
            {
                MessageBox.Show("Select a note from the list!", "Error");
            }
        }

        private void OnRead(object sender, EventArgs e)
        {
            _noteService.ReadNote(selectedNote.Title);
        }
        private void UpdateNote_Button_Click(object sender, RoutedEventArgs e)
        {
            if (selectedNote != null)
            {
                var updateNoteWindow = new UpdateNoteWindow(selectedNote.Title, selectedNote.Category, selectedNote.Content);
                updateNoteWindow.Activate();
                updateNoteWindow.Show();
                updateNoteWindow.Closing += OnUpdateNoteWindowClose;
            }
            else
            {
                MessageBox.Show("Select a note from the list!", "Error");
            }
        }

        private void OnUpdateNoteWindowClose(object sender, CancelEventArgs e)
        {
            UpdateNoteWindow eventSender = (UpdateNoteWindow)sender;
            if (eventSender.IsUpdateRequest)
            {
                DateTime? creationDate = selectedNote.CreationDate;
                int id = selectedNote.Id;

                DTO.NoteDto updatedNote = new DTO.NoteDto(
                    eventSender.UpdateNewNoteTitle,
                    eventSender.UpdateNewNoteCategory,
                    eventSender.UpdateNewNoteContent,
                    eventSender.UpdateNewNoteModificationDate,
                    creationDate);

                _noteService.UpdateNote(updatedNote, id);
                UpdateObservableNotes();
            }
        }

        private void DeleteNote_Button_Click(object sender, RoutedEventArgs e)
        { 
            if (selectedNote == null)
            {
                MessageBox.Show("Select a note from the list!", "Error");    
                return;
            }
            var deleteNoteWindow = new DeleteNoteWindow();
            deleteNoteWindow.Activate();
            deleteNoteWindow.Show();
            deleteNoteWindow.Closing += OnDeleteNoteWindowClose;  
        }

        private void OnDeleteNoteWindowClose(object sender, CancelEventArgs e)
        {
            DeleteNoteWindow eventSender = (DeleteNoteWindow)sender;
            if (eventSender.IsCreateRequest)
            {
                _noteService.DeleteNote(selectedNote.Title);
                UpdateObservableNotes();
            }
        }
    }

}