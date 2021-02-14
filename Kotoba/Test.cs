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
    public partial class Test : Form
    {
        int deckid;
        string deckname;
        DataTable cardsDT;
        List<Card> all_cards = new List<Card>();
        List<Card> test_cards = new List<Card>();
        int i = 0;
        int answered_correct = 0;
        int answered_wrong = 0;

        public Test(int _deckid, string _deckname)
        {
            InitializeComponent();
            deckid = _deckid;
            deckname = _deckname;
            cardsDT = Cards_DB.select_Cards(deckid);
            
            Load_Test_List();
            Start_View();
            
        }


        private void Load_Test_List()
        {
            
            foreach (DataRow row in cardsDT.Rows)
            {
                all_cards.Add(new Card(row));
               

            }
            foreach (Card card in all_cards)
            {
                if (card.revision_time <= DateTime.Now)
                    test_cards.Add(card);
            }
        }

            public void Start_View()
        {
            label_Front.Text = "Deck: " + deckname;
            if (test_cards.Count > 0)
            {
                label_Back.Text = "Cards to review: " + test_cards.Count;
                button_Begin.Visible = true;
            }
            else
            {
                label_Back.Text = "There are no cards to review.";
                button_Begin.Visible = false;
            }

            button_Next.Visible = false;
            button_Check.Visible = false;
            button_Exit.Visible = false;
            textBox_Answer.Visible = false;
            pictureBox1.Visible = false;
            
        }

        private void button_Begin_Click(object sender, EventArgs e)
        {
            Load_Next();

        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            label_Back.Visible = true;
            button_Check.Visible = false;
            button_Next.Visible = true;
            string correct = label_Back.Text.ToLower();
            string answer = textBox_Answer.Text.ToLower();
            String[] correct_answers = correct.Split(';').Select(word => word.Trim()).ToArray();
            if (Array.Exists(correct_answers, element => element == answer)) {
                answered_correct += 1;
                if (test_cards[i].stage < 8)
                    test_cards[i].stage += 1;
                change_Revision_Time(test_cards[i]);
                textBox_Answer.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                answered_wrong += 1;
                if (test_cards[i].stage > 0)
                    test_cards[i].stage -= 1;
                change_Revision_Time(test_cards[i]);
                textBox_Answer.BackColor = System.Drawing.Color.Red;
            }
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            i++;
            Load_Next();
            
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Update_Cards();
            Cards_DB.Modify_Cards(deckid, cardsDT);
        }

        private void change_Revision_Time(Card card)
        {
            int stage = card.stage;
            switch (stage)
            {
                
                case 1:
                    card.revision_time = card.revision_time.AddDays(1);
                    break;
                case 2:
                    card.revision_time = card.revision_time.AddDays(2);
                    break;
                case 3:
                    card.revision_time = card.revision_time.AddDays(3);
                    break;
                case 4:
                    card.revision_time = card.revision_time.AddDays(5);
                    break;
                case 5:
                    card.revision_time = card.revision_time.AddDays(10);
                    break;
                case 6:
                    card.revision_time = card.revision_time.AddDays(30);
                    break;
                case 7:
                    card.revision_time = card.revision_time.AddDays(60);
                    break;
                case 8:
                    card.revision_time = card.revision_time.AddDays(90);
                    break;
                default:
                    card.revision_time = DateTime.Now;
                    break;
            }
        }

        private void Load_Next()
        {
            if (i < test_cards.Count)
            {
                label_Front.Text = test_cards[i].front;
                label_Back.Text = test_cards[i].back;
                label_Back.Visible = false;
                textBox_Answer.Visible = true;
                textBox_Answer.BackColor = System.Drawing.Color.White;
                textBox_Answer.Text = "";
                button_Next.Visible = false;
                button_Check.Visible = true;
                button_Exit.Visible = false;
                button_Begin.Visible = false;
            }
            else
            {
                label_Front.Text = "You're Done!";
                label_Back.Text = "Correct answers: " + answered_correct.ToString() + "\n Incorrect answers: " + answered_wrong.ToString();
                button_Next.Visible = false;
                //button_Exit.Visible = true;
                textBox_Answer.Visible = false;
                pictureBox1.Visible = true;
            }
        }

            public void Update_Cards()
        {
            foreach (DataRow row in cardsDT.Rows)
            {
                foreach (Card card in test_cards)
                {
                    if (card.id == Int32.Parse(row["cardid"].ToString()))
                    {
                        row["stage"] = card.stage;
                        row["revision_time"] = card.revision_time;
                    }
                }
            }
        
        }
    }
}
