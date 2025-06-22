using HomeLibrary;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WPF_TSD_project
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Book> books;

        public MainWindow()
        {
            InitializeComponent();
            books = new ObservableCollection<Book>(MyBookCollection.GetMyCollection());
            BooksListBox.ItemsSource = books;
        }

        private void BooksListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Book selectedBook = BooksListBox.SelectedItem as Book;
            BookDetailsControl.SetBook(selectedBook);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            int newId = books.Count > 0 ? books[^1].Id + 1 : 1;
            Book newBook = new Book(newId) { Title = "New Book", Author = "", Year = 2025, Format = BookFormat.PaperBack, IsRead = false };
            books.Add(newBook);
            BooksListBox.SelectedItem = newBook;
        }

        private void BookDetailsControl_DeleteRequested(object sender, Book e)
        {
            if (books.Contains(e))
            {
                books.Remove(e);
            }
        }

        private void DarknessSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (SliderValueText != null)
            {
                SliderValueText.Text = $"Value {(int)e.NewValue}";
            }
        }
    }
}
