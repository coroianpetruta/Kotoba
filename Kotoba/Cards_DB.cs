using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Pentru legatura cu baza de date
using System.Data; // Pentru DataTable
using System.Collections; // Pentru ArrayList

namespace Kotoba
{
    class Cards_DB
    {
        static string connstr = "Data Source=localhost;UserId=root;database=Kotoba;Charset=utf8;";
        static MySqlConnection conn = new MySqlConnection(connstr);
        static MySqlCommandBuilder cb;
        static MySqlDataAdapter cardsAdapt;

        

         public static DataTable select_Cards(int deckid)
         {
             // -- Operatia de interogare --
             // Cautam si aducem din baza de date DBvideoteca tabela domenii
             // toate inregistrarile (toate domeniile) ordonate alfabetic
             MySqlCommand comCards = new MySqlCommand();
             comCards.Connection = conn;
             comCards.CommandText = "SELECT * FROM cards where deckid = @paramDeckid";
             comCards.Parameters.AddWithValue("@paramDeckid", deckid);
             MySqlDataAdapter cardsAdapt = new MySqlDataAdapter(comCards);
             DataTable cardsDT = new DataTable();
             try
             {
                 conn.Open();
                 cardsAdapt.Fill(cardsDT);
             }
             catch (Exception)
             {
                 // Aruncam exceptia in Afisare.cs (modulul apelant)
                 throw;
             }
             finally
             {
                 // Inchidem conexiunea cu baza de date
                 conn.Close();
             }
             return cardsDT;
         }

         /*public static void Modify_Cards(DataTable cardsDT)
         {
             try
             {
                 conn.Open();
                 cb = new MySqlCommandBuilder(cardsAdapt);
                 cardsAdapt.Update(cardsDT);
                 conn.Close();
             }
             catch (Exception ex)
             {
                 throw;
             }
         }*/

        public static void Add_NewCard(int deckid, string front, string back)
        {
            MySqlCommand cmdAddCard = new MySqlCommand();
            cmdAddCard.Connection = conn;
            cmdAddCard.CommandText = "INSERT INTO cards(front, back, deckid, stage, revision_time) VALUES(@paramFront, @paramBack, @paramDeckid, 0, @paramRevisiontime); ";
            try
            {
                conn.Open();
                cmdAddCard.Parameters.AddWithValue("@paramFront", front);
                cmdAddCard.Parameters.AddWithValue("@paramBack", back);
                cmdAddCard.Parameters.AddWithValue("@paramDeckid", deckid);
                cmdAddCard.Parameters.AddWithValue("@paramRevisiontime", DateTime.Now);
                cmdAddCard.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
    }

        public static void Delete_Deck_Cards(int deckid)
        {
            conn.Open();
            MySqlCommand delete_cards = new MySqlCommand("DELETE from cards WHERE deckid = @paramDeckid", conn);
            MySqlCommand delete_deck = new MySqlCommand("DELETE from decks WHERE deckid = @paramDeckid", conn);
            MySqlTransaction tx = conn.BeginTransaction();
            try
            {
                delete_cards.Transaction = tx;
                delete_deck.Transaction = tx;
                delete_cards.Parameters.AddWithValue("@paramDeckid", deckid);
                
                delete_cards.ExecuteNonQuery();
                delete_cards.Parameters.Clear();
                delete_deck.Parameters.AddWithValue("@paramDeckid", deckid);
                delete_deck.ExecuteNonQuery();
                delete_deck.Parameters.Clear();

                tx.Commit();
            }
            
            catch (Exception){
                tx.Rollback();
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void Modify_Cards(int deckid, DataTable modCards)
        {
            
            conn.Open();
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM cards where deckid = @paramDeckid", conn);
                adp.SelectCommand.Parameters.AddWithValue("@paramDeckid", deckid);
                MySqlCommandBuilder bld = new MySqlCommandBuilder(adp);
                DataTable currentCards = new DataTable();
                adp.Fill(currentCards);
                currentCards = modCards;
                adp.Update(currentCards);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
}
}
