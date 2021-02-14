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
    class Decks_DB
    {
        static string connstr = "Data Source=localhost;UserId=root;database=Kotoba;Charset=utf8;";
        static MySqlConnection conn = new MySqlConnection(connstr);

        public static DataTable select_Decks(int userid)
        {
            // -- Operatia de interogare --
            // Cautam si aducem din baza de date DBvideoteca tabela domenii
            // toate inregistrarile (toate domeniile) ordonate alfabetic
            MySqlCommand comDecks = new MySqlCommand();
            comDecks.Connection = conn;
            comDecks.CommandText = "SELECT * FROM decks where userid = @paramUserid";
            comDecks.Parameters.AddWithValue("@paramUserid", userid);
            MySqlDataAdapter decksAdapt = new MySqlDataAdapter(comDecks);
            DataTable decksDT = new DataTable();
            try
            {
                conn.Open();
                decksAdapt.Fill(decksDT);
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
            return decksDT;
        }

        public static void Add_NewDeck(int userid, string name)
        {
            MySqlCommand cmdAddDeck = new MySqlCommand();
            cmdAddDeck.Connection = conn;
            cmdAddDeck.CommandText = "INSERT INTO decks(deckname, userid) VALUES(@paramDeckname, @paramUserid); ";
            try
            {
                conn.Open();
                cmdAddDeck.Parameters.AddWithValue("@paramUserid", userid);
                cmdAddDeck.Parameters.AddWithValue("@paramDeckname", name);
                cmdAddDeck.ExecuteNonQuery();
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
    }

    
}
