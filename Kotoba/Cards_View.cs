using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Pentru legatura cu baza de date
using System.Data; // Pentru DataTable
using System.Collections; // Pentru ArrayList

namespace Kotoba
{
    public partial class Cards_View : Form
    {
        
        int deckid;
        static MySqlConnection conn = new MySqlConnection("DataSource=localhost; UserID=root; database = kotoba;Charset=utf8;");
        MySqlDataAdapter adapt;
        DataTable cardsDT = new DataTable();
        MySqlCommandBuilder cb;


        public Cards_View(string svalue, string text)
        {
            deckid = Int32.Parse(svalue);
            InitializeComponent();
            label_DeckName.Text = "Deck: " + text;
            Populate_Grid(deckid);
            Style_DataGridView();



        }

        private void button_UpdateCards_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cb = new MySqlCommandBuilder(adapt);
                adapt.Update(cardsDT);
                Notification modified = new Kotoba.Notification("Cards have been updated.");
                modified.ShowDialog();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Populate_Grid(int deckid)
        {
            try
            {
                conn.Open();
                adapt = new MySqlDataAdapter("SELECT * FROM cards where deckid = @paramDeckid", conn);
                adapt.SelectCommand.Parameters.AddWithValue("@paramDeckid", deckid);
                cardsDT.Clear();
                adapt.Fill(cardsDT);
                dataGridView_Cards.DataSource = cardsDT;
                dataGridView_Cards.Columns["deckid"].Visible = false;
                dataGridView_Cards.Columns["cardid"].Visible = false;
                dataGridView_Cards.Columns["stage"].Visible = false;
                dataGridView_Cards.Columns["revision_time"].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_AddCard_Click(object sender, EventArgs e)
        {
            Add_Card newcard = new Add_Card(deckid, this);
            newcard.ShowDialog();
        }

        private void button_DeleteCard_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewCell oneCell in dataGridView_Cards.SelectedCells)
            {
                try
                {
                    if (oneCell.Selected)
                    dataGridView_Cards.Rows.RemoveAt(oneCell.RowIndex);
                
                    conn.Open();
                    cb = new MySqlCommandBuilder(adapt);
                    adapt.Update(cardsDT);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
    }
        
        void Style_DataGridView()
        {
            //dataGridView_Cards.BorderStyle = BorderStyle.None;
            dataGridView_Cards.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_Cards.EnableHeadersVisualStyles = false;
            dataGridView_Cards.RowTemplate.Height = 30;
            //dataGridView_Cards.RowTemplate.DefaultCellStyle.Padding = new Padding(3, 10, 3, 10);




        }
        
    }
}
