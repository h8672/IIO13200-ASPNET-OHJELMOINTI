//Demo DBLogiikkaa oppilastietojen hakemiseen
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace JAMK.ICT.Data
{
    public static class DBPlacebo
    {
        public static DataTable Get3TestStudents()
        {
            //create
            DataTable dt = new DataTable();
            //columns
            dt.Columns.Add("asioid", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("FirstName", typeof(string));
            //rows
            dt.Rows.Add("A3581", "Waltari", "Mika");
            dt.Rows.Add("B3553", "King", "Stephen");
            dt.Rows.Add("D9876", "Oksanen", "Sofi");
            return dt;
        }
        public static DataTable GetAllStudentsFromSQLServer(string connectionStr, string taulu, out string viesti)
        {
            // basic principle: connect - execute query - disconnect
            try
            {
                SqlConnection myConn = new SqlConnection(connectionStr);
                myConn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM " + taulu, myConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, taulu);
                viesti = "Tiedot haettu onnistuneesti tietokannasta " + myConn.DataSource;
                return ds.Tables[taulu];
            }
            catch (Exception ex)
            {
                viesti = ex.Message;
                throw;
            }
        }

        public static DataTable GetCitysFromMySQL(string cs)
        {
            try
            {
                //yhteys labranetin myslille ja palautetaan taulu City DataTablena
                string sql = "SELECT name, countrycode, population FROM City WHERE population > 99999 ORDER BY population DESC";
                using(MySqlConnection conn = new MySqlConnection(cs))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

/*
 CREATE TABLE City (
id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
name VARCHAR(30) NOT NULL,
countrycode VARCHAR(12) NOT NULL,
population INT(20) NOT NULL
);

INSERT INTO City (name, countrycode, population)
VALUES ('USA', 'USA', 875498679); 
INSERT INTO City (name, countrycode, population)
VALUES ('Baltio', 'BAL', 68995643); 
INSERT INTO City (name, countrycode, population)
VALUES ('Goo', 'GOO', 3429965); 
 */
