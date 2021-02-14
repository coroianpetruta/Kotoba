using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 


namespace Kotoba
{
    public partial class NewUserForm : Form
    {
        string email, username, password;

        

        public NewUserForm()
        {
            InitializeComponent();
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            email = textBox_Email.Text;
            username = textBox_Username.Text;
            password = textBox_Password.Text;
            try {
                if (email == "" || username == "" || password == "")
                {
                    Notification complete = new Notification("Please complete all fields.");
                    complete.ShowDialog();
                }
                else
                {
                    Users_DB.Add_User(email, username, password);
                    Notification created = new Notification("User has been created!");
                    created.ShowDialog();
                    textBox_Email.Text = "";
                    textBox_Username.Text = "";
                    textBox_Password.Text = "";
                }

            }
            catch (Exception ex)
            {
                Notification exception = new Notification(ex.Message);
                exception.ShowDialog();
            }
        }
    }
}
