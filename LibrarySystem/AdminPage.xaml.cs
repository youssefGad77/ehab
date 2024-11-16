using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        LibrarySystemEntities db = new LibrarySystemEntities();
        public AdminPage()
        {
            InitializeComponent();
            Refresh();
        }
        public void Refresh()
        {
            BooksDataGrid.ItemsSource = db.Books.Select(x => new { ID = x.BookID, Title = x.Title, Author = x.Author, Genre = x.Genre, BookStatus = x.BookStatus }).ToList();
        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            if (txtId.Text != "")
            {
                MessageBox.Show("ID auto increament");
                return;
            }
            Book b = new Book();
            b.Title = txtTitle.Text;
            b.Author = txtAuthor.Text;
            b.Genre = txtGenre.Text;
            b.BookStatus = txtAvailable.Text;
            db.Books.Add(b);
            db.SaveChanges();
            Refresh();

        }

        private void DeleteButton(object sender, RoutedEventArgs e)
        {
            int BID = int.Parse(txtId.Text);
            var b = db.Books.FirstOrDefault(x=>x.BookID == BID);
            if(b != null)
            {
                db.Books.Remove(b);
                db.SaveChanges();
                MessageBox.Show("Book Deleted Successfully");
            }
            else
            {
                MessageBox.Show("ID Not Found");
            }
            Refresh();
        }

        private void UpdateButton(object sender, RoutedEventArgs e)
        {
            int BID = int.Parse(txtId.Text);
            var b = db.Books.FirstOrDefault(x => x.BookID == BID);
            if(b != null)
            {
                //ternary operator
                b.Title = txtTitle.Text == "" ? b.Title : txtTitle.Text;
                b.Author = txtAuthor.Text == "" ? b.Author : txtAuthor.Text;
                b.Genre = txtGenre.Text == "" ? b.Genre : txtGenre.Text;
                b.BookStatus = txtAvailable.Text == "" ? b.BookStatus : txtAvailable.Text;
                //db.Books.AddOrUpdate(b);
                db.SaveChanges();
                MessageBox.Show("Updated Successfully");

            }
            else
            {
                MessageBox.Show("There is no Data !");
            }
        }
    }
}
