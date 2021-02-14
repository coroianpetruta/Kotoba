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
using System.Collections; // Pentru ArrayList
using System.Linq;

namespace Kotoba
{
    public partial class Practice : Form
    {
        int deckid;
        string deckname;
        DataTable cardsDT;
        string[] cardsFront;
        string[] cardsBack;
        int RoundNumber = 0;

        public Practice(int _deckid, string _deckname)
        {
            InitializeComponent();
            deckid = _deckid;
            deckname = _deckname;
            cardsDT = Cards_DB.select_Cards(deckid);
            cardsFront = cardsDT.AsEnumerable().Select(r => r.Field<string>("front")).ToArray();
            cardsBack = cardsDT.AsEnumerable().Select(r => r.Field<string>("back")).ToArray();
            label_Front.Text = "Deck: " + deckname;
            label_Back.Text = "Total cards: " + cardsFront.Length.ToString();
            button_Exit.Visible = false;
            pictureBox1.Visible = false;
            label_EndMessage.Visible = false;

            
            
            
        }

        public void next_Round()
        {   if (RoundNumber < cardsFront.Length)
            {
                label_Front.Text = cardsFront[RoundNumber];
                label_Back.Text = cardsBack[RoundNumber];
                label_Back.Visible = false;
                button_Next.Visible = false;
                button_Show.Visible = true;
            }
        else
            {
                label_EndMessage.Text = "You're done! You've reviewed " + cardsFront.Length.ToString() + " cards.";
                label_EndMessage.Visible = true;  
                label_Back.Visible = false;
                label_Front.Visible = false;
                button_Next.Visible = false;
                button_Show.Visible = false;
                panel1.Visible = false;
                //button_Exit.Visible = true;
                pictureBox1.Visible = true;

            }
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            label_Back.Visible = true;
            button_Show.Visible = false;
            button_Next.Visible = true;
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            RoundNumber += 1;
            next_Round();
        }

        private void button_Begin_Click(object sender, EventArgs e)
        {
            button_Begin.Visible = false;
            if (checkBox_Reverse.Checked)
            {
                Array.Reverse(cardsFront);
                Array.Reverse(cardsBack);
            }
            next_Round();
            
            checkBox_Reverse.Visible = false;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
