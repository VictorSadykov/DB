using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApplication1.Data.Repos.Classes;
using WebApplication1.Data;
using WebApplication1.Data.Repos.Interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Desktop
{
    public partial class AuthorizationForm : Form
    {
        IUserRepository _userRepo = new UserRepository(new DataBaseContext());
        
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private async void signInButton_click(object sender, EventArgs e) // Вход
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;


            var users = await _userRepo.GetUsers();
            User user = users.FirstOrDefault(u => u.Login == login);
            
            if (user.RoleNumber == 1)
            {
                label1.Text = "Добро пожаловать админ";
            }
        }
    }
}
