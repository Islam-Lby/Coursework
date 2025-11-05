using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Coursework
{
    public partial class LoginForm : Form
    {
        private bool btnLoginWasClicked = false;
        private bool btnRegisterWasClicked = false;


        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtPword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLoginWasClicked = true; // flag that states the login button was clicked
            string user = txtUsername.Text; // username enterd by user is stored 
            string pWord = txtPword.Text; // password entered by user is stored
            ValidateUser(user, pWord); // the 2 variable are validated
        }

        private void ValidateUser(string username, string password)
        {
            bool userExists = false; // username doesn't exist right now
            bool correctPassword = false; // neither does password
            try
            {
                StreamReader reader = new StreamReader("users&Passwords.csv"); // reads the file
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 2)
                    {
                        if (parts[0] == username) // // first column stores username
                        {
                            userExists = true; // user exists in the file
                            if (parts[1] == password) // compares entered password with password in the file
                            {
                                correctPassword = true; // password is correct
                            }
                        }

                    }
                }
                reader.Close();
                if (btnLoginWasClicked) // when the 'Login' button is clicked...
                {
                    if (userExists && correctPassword)
                    {
                        User.uName = username; // username is stored in global attribute so that it can be passed between different forms
                        TopicSelectionForm topicFrm = new TopicSelectionForm(); // topic selection form is shown
                        topicFrm.Show();
                        this.Hide(); // login form is hidden
                        // this if statement only runs if both the username and password entered by the user match the password and username 
                    }
                    else if (userExists)
                    {
                        MessageBox.Show("Invalid password. Try again"); // if the username is correct but the password isn't, a message is output saying that the password is invalid.

                    }
                    else
                    {
                        MessageBox.Show("Username not found. Register before logging in"); // if both the username and password are non-existent in the file, user can't login, they MUST register 

                    }
                }
                if (btnRegisterWasClicked) // when the 'Register' button is clicked
                {
                    if (userExists) // if the username is already in the file
                    {
                        MessageBox.Show("You cannot register with the same username as before. Choose a different username."); // user cannot register with same username twice
                        
                    }
                    else
                    {
                        StreamWriter writer = File.AppendText("users&Passwords.csv"); // if otherrwise, the username and password is written to the file and stored there
                        writer.WriteLine(username + ',' + password);
                        writer.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("File doesnt exist"); // if the file desn't exist, this output message is shown
                Environment.Exit(1);// program stops 
            }

        }   

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DodgerBlue;
            lblPassword.ForeColor = System.Drawing.Color.White;
            lblUsername.ForeColor = System.Drawing.Color.White;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            btnRegisterWasClicked = true; // indicates that the button has been clicked
            string user = txtUsername.Text; // username entered into text box is stored as a string
            string password = txtPword.Text; // password entered into text box is stored as a string
            User.uName = user; 
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Enter a username & password"); // if text boxes are empty, program tells user to enter a value into the text box
                return;
            }
            if (user.Contains("@"))
            {
                MessageBox.Show("Please Enter a valid username"); // if username is an email, Program asks user to enter valid passsword
                return;

            }
            if (password.Length < 8)
            {
                MessageBox.Show("Please Enter a valid password that is at least 8 characters long"); // if password length is less than 8, password is invalid
                return;
            }
            ValidateUser(user, password); // validates username and password entered
            
        }
    }
}
