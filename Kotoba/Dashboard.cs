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
    public partial class Dashboard : Form
    {
        string username = "";
        public DataTable decksDT; 
        public int userid;
        

        public Dashboard(int user_id)
        {
            userid = user_id;
            InitializeComponent();
            Fill_listBoxDecks(user_id);
            username = Users_DB.get_Username(user_id);
            label_Dashboard.Text = "Welcome, " + username + "!";
            
         }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            label_Dashboard.Parent = pictureBox_Background;
            label_Dashboard.BackColor = Color.Transparent;
            button_AddDeck.FlatStyle = FlatStyle.Flat;
            button_AddDeck.FlatAppearance.BorderSize = button_View.FlatAppearance.BorderSize = button_Practice.FlatAppearance.BorderSize = button_Test.FlatAppearance.BorderSize = button_DeleteDeck.FlatAppearance.BorderSize = 0;
            button_AddDeck.FlatAppearance.MouseOverBackColor = button_AddDeck.BackColor;
            button_AddDeck.FlatAppearance.MouseDownBackColor = button_AddDeck.BackColor;
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button_AddDeck.ForeColor = System.Drawing.Color.CornflowerBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button_AddDeck.ForeColor = System.Drawing.Color.RoyalBlue;

        }

        public void Fill_listBoxDecks(int userid)
        {
            try
            {
                decksDT = Decks_DB.select_Decks(userid);
                // Am incarcat in DataTable filmeDT filmele din domeniul selectat
                // apoi setez acest filmeDT ca sursa de date pentru checkedListBoxFilme
                // din care se afiseaza coloana "date_film" fiecare rand cu id asociat "idf"
                listBox_Decks.DataSource = decksDT;
                listBox_Decks.ValueMember = "deckid";
                listBox_Decks.DisplayMember = "deckname";
                if (listBox_Decks.Items.Count == 0)// sau: (filmeDT.Rows.Count == 0)
                {
                    label_Empty.Visible = true;
                    pictureBox_Empty.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Notification exception = new Notification(ex.Message);
                exception.ShowDialog();
            }
        }

        private void button_AddDeck_Click(object sender, EventArgs e)
        {
            Add_Deck newdeck = new Add_Deck(userid, this);
            newdeck.ShowDialog();
        }

        

        private void button_View_Click(object sender, EventArgs e)
        {
            try
            {
                string itemvalue = (listBox_Decks.SelectedItem as DataRowView)["deckid"].ToString();
                string decktext = (listBox_Decks.SelectedItem as DataRowView)["deckname"].ToString();
                Cards_View view = new Cards_View(itemvalue, decktext);
                view.ShowDialog();
            }
            catch (Exception ex)
            {
                Notification exception = new Notification(ex.Message);
                exception.ShowDialog();
            }
        }

        private void button_DeleteDeck_Click(object sender, EventArgs e)
        {
            Confirmation c = new Confirmation("Deleting the deck will delete all cards within it. Are you sure?");
            DialogResult dr = c.ShowDialog();
            try
            {
                if (dr == DialogResult.Yes)
                {
                    string itemvalue = (listBox_Decks.SelectedItem as DataRowView)["deckid"].ToString();
                    int deckid = Int32.Parse(itemvalue);
                    Cards_DB.Delete_Deck_Cards(deckid);
                    Fill_listBoxDecks(userid);
                }
            }

            catch (Exception ex)
            {
                Notification exception = new Notification(ex.Message);
                exception.ShowDialog();
            }
        }

        private void button_Practice_Click(object sender, EventArgs e)
        {
            try
            {
                string itemvalue = (listBox_Decks.SelectedItem as DataRowView)["deckid"].ToString();
                string deckname = (listBox_Decks.SelectedItem as DataRowView)["deckname"].ToString();
                int deckid = Int32.Parse(itemvalue);
                Practice session = new Practice(deckid, deckname);
                
                session.ShowDialog();
            }
            catch (Exception ex)
            {
                Notification exception = new Notification(ex.Message);
                exception.ShowDialog();
            }
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            
                try
                {

                    string itemvalue = (listBox_Decks.SelectedItem as DataRowView)["deckid"].ToString();
                    string deckname = (listBox_Decks.SelectedItem as DataRowView)["deckname"].ToString();
                    int deckid = Int32.Parse(itemvalue);
                    Test session = new Test(deckid, deckname);
                    session.ShowDialog();

                }
                catch (Exception ex)
                {
                    Notification exception = new Notification(ex.Message);
                    exception.ShowDialog();
                }
            }
        }
    }

