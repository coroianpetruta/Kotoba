using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data; // Pentru DataTable

namespace Kotoba
{
    public partial class Add_Deck : Form
    {
        string name;
        int user_id_new_deck;
        private Dashboard _dashboard;

        public Add_Deck(int userid, Dashboard dashboard)
        {
            InitializeComponent();
            user_id_new_deck = userid;
            _dashboard = dashboard;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_AddDeck_Click(object sender, EventArgs e)
        {
            name = textBox_DeckName.Text;
            
            
            try
            {
                if (name == "")
                {
                    Notification complete = new Notification("Deck must have a name.");
                    complete.ShowDialog();
                }
                else
                {
                    Decks_DB.Add_NewDeck(user_id_new_deck, name);
                    _dashboard.Fill_listBoxDecks(user_id_new_deck);
                    
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
