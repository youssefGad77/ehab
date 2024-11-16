using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        LibrarySystemEntities db = new LibrarySystemEntities();
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void SignUpButton(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtPass.Text == "" || txtCPass.Text == "")
            {
                MessageBox.Show("Unfilled Fieled");
                return;
            }

            if (txtPass.Text != txtCPass.Text)
            {
                MessageBox.Show("Password don't Match");
                return;
            }

            if (!(Regex.IsMatch(txtPass.Text, "[a-z]") && Regex.IsMatch(txtPass.Text, "[A-Z]") && Regex.IsMatch(txtPass.Text, "[! - # - $ - * - %]") && Regex.IsMatch(txtPass.Text, "[\\d]")))
            {
                MessageBox.Show("Weak Password");
                return;
            }

            var user = db.Users.Where(x => x.UserName == txtName.Text).FirstOrDefault();
            if (user != null)
            {
                MessageBox.Show("Name already exists");
                return;
            }

            User u = new User();
            u.UserName = txtName.Text;
            u.Email = txtEmail.Text;
            u.UserPassword = txtPass.Text;
            db.Users.Add(u);
            db.SaveChanges();
            MessageBox.Show("Sign Up Successfully");
            this.NavigationService.Navigate(new LogInPage());

        }
    }
}
