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
    public partial class Add_Card : Form
    {
        string front, back;
        int _deckid;
        private Cards_View _cardview;

        public Add_Card(int deckid, Cards_View cardview)
        {
            InitializeComponent();
            _cardview = cardview;
            _deckid = deckid;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_AddCard_Click(object sender, EventArgs e)
        {
            front = textBox_Front.Text;
            back = textBox_Back.Text;


            try
            {
                if (front == "" || back == "")
                {
                    Notification complete = new Notification("Please complete both fields.");
                    complete.ShowDialog();
                }
                else
                {
                    Cards_DB.Add_NewCard(_deckid, front, back);
                    _cardview.Populate_Grid(_deckid);

                    this.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
