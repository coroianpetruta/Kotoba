using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kotoba
{
    public partial class Form1 : Form
    {
        string user, password;
        int user_id;
        

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                user = textBox_Username.Text.Trim();
                password = textBox_Password.Text;
                if (user == "" || password == "")
                {
                    Notification fill = new Notification("Please complete both fields.");
                    fill.ShowDialog();
                }
                else
                {
                    user_id = Users_DB.find_User(user, password);
                    if (user_id <= 0)
                    {
                        Notification wronginfo = new Notification("Username or password incorrect. Please try again.");
                        wronginfo.ShowDialog();
                    }
                    else
                    {
                        Dashboard dash = new Dashboard(user_id);
                        dash.ShowDialog();
                        textBox_Username.Text = "";
                        textBox_Password.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Notification exception = new Notification(ex.Message);
                exception.ShowDialog();
            }
            
        }

        private void button_NewUser_Click(object sender, EventArgs e)
        {
            NewUserForm new_user = new NewUserForm();
            new_user.ShowDialog();
        }
    }
}
