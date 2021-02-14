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
    public partial class Notification : Form
    {
        public Notification(string message)
        {
            InitializeComponent();
            label_Message.Text = message;
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
