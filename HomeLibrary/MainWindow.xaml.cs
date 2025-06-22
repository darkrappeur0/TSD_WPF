using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Linq; 
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

            if (books.Any())
            {
                BookList.SelectedItem = books.First();
            }
        }

        private void BookList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BookDetails.SelectedBook = BookList.SelectedItem as Book;
        }

        private void BookDetails_DeleteRequested(object sender, Book e)
        {
            books.Remove(e);
            if (books.Any())
            {
                BookList.SelectedItem = books.First();
            }
            else
            {
                BookDetails.SelectedBook = null; 
            }
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            int newId = books.Any() ? books.Max(b => b.Id) + 1 : 1;
            Book newBook = new Book(newId)
            {
                Title = "New Book Title",
                Author = "Unknown Author",
                Year = System.DateTime.Now.Year,
                Format = BookFormat.PaperBack,
                IsRead = false
            };
            books.Add(newBook);
            BookList.SelectedItem = newBook;
        }

        private void DarknessSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
        }
    }
}
