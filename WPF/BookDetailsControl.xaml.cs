using System;
using System.Windows;
using System.Windows.Controls;

namespace HomeLibrary
{
    public partial class BookDetailsControl : UserControl
    {
        public Book SelectedBook
        {
            get => (Book)DataContext;
            set => DataContext = value;
        }

        public event EventHandler<Book> DeleteRequested;

        public BookDetailsControl()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this book?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                DeleteRequested?.Invoke(this, SelectedBook);
            }
        }
    }
}
