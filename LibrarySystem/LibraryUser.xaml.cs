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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibrarySystem
{
    /// <summary>
    /// Interaction logic for LibraryUser.xaml
    /// </summary>
    public partial class LibraryUser : Page
    {
        LibrarySystemEntities db = new LibrarySystemEntities();
        public LibraryUser()
        {
            InitializeComponent();
            Refresh();
            combo.ItemsSource = db.Books.Select(x => x.Genre).Distinct().ToList();

        }
        public void Refresh()        {
            BooksDataGrid.ItemsSource = db.Books.Select(x => new { ID = x.BookID, Title = x.Title, Author = x.Author, Genre = x.Genre, BookStatus = x.BookStatus }).ToList();
        }

        private void SearchButton(object sender, RoutedEventArgs e)
        {
            if(txtSearch.Text == "")
            {
                Refresh();
            }
            else
            {
                var Selected = combo.SelectedItem.ToString();
                var book = db.Books.Where(x=>x.Title.Contains(txtSearch.Text)|| x.Author.Contains(txtSearch.Text) 
                || x.Genre.Contains(txtSearch.Text) && x.Genre == Selected).Select(x=> new {ID = x.BookID , Title = x.Title , Author = x.Author , Genre = x.Genre , BookStatus = x.BookStatus}).ToList();
                BooksDataGrid.ItemsSource = book;

            }

        }

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = combo.SelectedItem.ToString();
            var book = db.Books.Where(x => x.Genre == selectedItem).Select(x => new { ID = x.BookID, Title = x.Title, Author = x.Author, Genre = x.Genre, BookStatus = x.BookStatus }).Distinct().ToList();
            BooksDataGrid.ItemsSource = book;
        }
    }
}
