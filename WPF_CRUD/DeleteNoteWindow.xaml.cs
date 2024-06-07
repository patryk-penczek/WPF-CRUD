using WPF_CRUD.DTO;
using WPF_CRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_CRUD
{
    public partial class DeleteNoteWindow : Window
    {
        public bool IsCreateRequest { get; set; } = false;

        public DeleteNoteWindow()
        {
            InitializeComponent();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {          
            IsCreateRequest = true;
            this.Close();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
