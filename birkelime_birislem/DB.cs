using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace CountDownGame
{
    class DB
    {
        private OleDbConnection con;
        private OleDbCommand cmd;
        private OleDbDataReader rd;
        public List<string> Kelimeler = new List<string>();
        public bool Connect()
        {
            string query = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kelimeler.accdb;Persist Security Info=False;";
            this.con = new OleDbConnection(query);
           try
            {
                this.con.Open();
                return true;
            }

         catch (Exception e)
            {
              
                return false;
            }
        }

        public int SetQuery(string query)
        {
            this.Connect();
            cmd = new OleDbCommand();
            cmd.Connection = con;
            try
            {
                cmd.CommandText = query;
                int a = cmd.ExecuteNonQuery();
                this.Close();
                return a;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                this.Close();
                return 0;
            }

        }

        public OleDbDataReader GetQuery(string query)
        {
            try
            {
                cmd = new OleDbCommand();
                cmd.CommandText = query;
                cmd.Connection = con;
                rd = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return rd;
        }


        public bool KelimeleriCek()
        {
                OleDbDataReader dr;
               this.Connect();
                
                string query = String.Format("SELECT * FROM tblKelimeler");
                dr = this.GetQuery(query);
                while(dr.Read())
                {
                    Kelimeler.Add(dr["kelime"].ToString());
                }

                this.Close();
            return true;
        }

        public void Close()
        {
            con.Close();
        }
    }

}

