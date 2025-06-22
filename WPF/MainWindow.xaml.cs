using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace HomeLibrary
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Book> books;

        public MainWindow()
        {
            InitializeComponent();
            books = new ObservableCollection<Book>(MyBookCollection.GetMyCollection());
            BookList.ItemsSource = books;
            BookDetails.DeleteRequested += BookDetails_DeleteRequested;
        }

        private void BookList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BookDetails.SelectedBook = BookList.SelectedItem as Book;
        }

        private void BookDetails_DeleteRequested(object sender, Book e)
        {
            books.Remove(e);
        }
    }
}
