using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;
using System.Windows.Forms;

namespace modul15_2311104012
{
    public partial class Form1 : Form
    {
        TextBox txtUsername, txtPassword;
        Button btnRegister, btnLogin;

        public Form1()
        {
            InitializeComponent();

            Label lblUser = new Label() { Text = "Username", Left = 30, Top = 20 };
            Label lblPass = new Label() { Text = "Password", Left = 30, Top = 60 };

            txtUsername = new TextBox() { Left = 120, Top = 20, Width = 200 };
            txtPassword = new TextBox() { Left = 120, Top = 60, Width = 200, UseSystemPasswordChar = true };

            btnRegister = new Button() { Text = "Register", Left = 120, Top = 100, Width = 90 };
            btnLogin = new Button() { Text = "Login", Left = 230, Top = 100, Width = 90 };

            btnRegister.Click += BtnRegister_Click;
            btnLogin.Click += BtnLogin_Click;

            Controls.Add(lblUser);
            Controls.Add(lblPass);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            if (!ValidUsername(user))
            {
                MessageBox.Show("Username harus 4–20 huruf ASCII.");
                return;
            }

            if (!ValidPassword(pass, user))
            {
                MessageBox.Show("Password minimal 8 karakter, mengandung angka, simbol, dan tidak boleh mengandung username.");
                return;
            }

            var users = LoadUsers();
            if (users.ContainsKey(user))
            {
                MessageBox.Show("Username sudah terdaftar.");
                return;
            }

            users[user] = HashPassword(pass);
            SaveUsers(users);
            MessageBox.Show("Registrasi berhasil.");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            var users = LoadUsers();
            if (users.ContainsKey(user) && users[user] == HashPassword(pass))
            {
                MessageBox.Show("Login berhasil!");
            }
            else
            {
                MessageBox.Show("Login gagal.");
            }
        }

        private bool ValidUsername(string username)
        {
            return username.Length >= 4 && username.Length <= 20 && username.All(char.IsLetter);
        }

        private bool ValidPassword(string password, string username)
        {
            return password.Length >= 8 &&
                   password.Length <= 20 &&
                   password.Any(char.IsDigit) &&
                   password.Any(c => "!@#$%^&*".Contains(c)) &&
                   !password.ToLower().Contains(username.ToLower());
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private Dictionary<string, string> LoadUsers()
        {
            string path = "users.json";
            if (!File.Exists(path)) return new Dictionary<string, string>();
            return JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(path));
        }

        private void SaveUsers(Dictionary<string, string> users)
        {
            File.WriteAllText("users.json", JsonSerializer.Serialize(users));
        }
    }
}
