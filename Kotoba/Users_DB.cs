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
    class Users_DB
    {
        static string connstr = "Data Source=localhost;UserId=root;database=Kotoba;Charset=utf8;";
        static MySqlConnection conn = new MySqlConnection(connstr);


        public static void Add_User(string email, string username, string password)
        {
            MySqlCommand cmdAddUser = new MySqlCommand();
            cmdAddUser.Connection = conn;
            cmdAddUser.CommandText = "INSERT INTO users(email, username, password) VALUES(@email, @username, @password); ";
            try
            {
                conn.Open();
                cmdAddUser.Parameters.AddWithValue("@email", email);
                cmdAddUser.Parameters.AddWithValue("@username", username);
                cmdAddUser.Parameters.AddWithValue("@password", password);
                cmdAddUser.ExecuteNonQuery();
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


        public static int find_User(string username, string password)
        {
            
            MySqlCommand comUser = new MySqlCommand();
            comUser.Connection = conn;
            comUser.CommandText = "SELECT userid FROM users where username = @paramUsername and password = @paramPassword";
            comUser.Parameters.AddWithValue("@paramUsername", username);
            comUser.Parameters.AddWithValue("@paramPassword", password);
            int userid = 0;
            try
            {
                conn.Open();
                MySqlDataReader readerUser = comUser.ExecuteReader();
                
            if (readerUser.Read())
                {
                    userid = Int32.Parse(readerUser["userid"].ToString());
                }
                // empty comUser parameters
                
                comUser.Parameters.Clear();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return userid;
        }

        public static string get_Username(int userid)
        {
            MySqlCommand comUser = new MySqlCommand();
            comUser.Connection = conn;
            comUser.CommandText = "SELECT username FROM users where userid = @paramUserid ";
            comUser.Parameters.AddWithValue("@paramUserid", userid);
            
            string username = "";
            try
            {
                conn.Open();
                MySqlDataReader readerUser = comUser.ExecuteReader();

                if (readerUser.Read())
                {
                    username = readerUser["username"].ToString();
                }
                
                comUser.Parameters.Clear();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return username;
        }
    }

}

