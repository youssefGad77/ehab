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
    /// Interaction logic for LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        LibrarySystemEntities db = new LibrarySystemEntities();
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LogInButton(object sender, RoutedEventArgs e)
        {
            string AdminEmail = "@1";
            string AdminPass = "1";
            if (txtEmail.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Unfilled Fieled");
                return;
            }
            
            if(txtEmail.Text == AdminEmail && txtPass.Text == AdminPass)
            {
                MessageBox.Show("Log In as Admin Successfully");
                this.NavigationService.Navigate(new AdminPage());
                return;
            }

            var User = db.Users.Where(x=>x.Email == txtEmail.Text && x.UserPassword == txtPass.Text).FirstOrDefault();
            if(User != null)
            {
                MessageBox.Show("Log In as User Successfully");
                this.NavigationService.Navigate(new LibraryUser());
            }
            else
            {
                MessageBox.Show("Incorrect Email or Password");
            }
        }

        private void SignUpButton(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SignUpPage());
        }
    }
}
