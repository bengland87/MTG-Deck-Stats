using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace MTGDeckStats
{
    using System;

    public class DB
    {
        string startupPath;
        string sql;
        SQLiteCommand command;
        SQLiteConnection sqlite;


        public DB()
        {
            //Create or load database
            startupPath = Environment.CurrentDirectory; //get current program directory **WILL USE LATER
            if (!System.IO.File.Exists("MTGDeckStatsDB.sqlite"))
            {
                Console.WriteLine("Just entered to create Sync DB");
                SQLiteConnection.CreateFile("MTGDeckStatsDB.sqlite");
                sqlite = new SQLiteConnection("Data Source=MTGDeckStatsDB.sqlite;Version=3;");
                sqlite.Open();
                //Create Purchases Table - Speculations made by user
                sql = "create table deck (id integer, name varchar(20), colors varchar(20), format varchar(20), cards varchar(4), PRIMARY KEY(id ASC))";
                command = new SQLiteCommand(sql, sqlite);
                command.ExecuteNonQuery();
                //Create Statistics Table
                sql = "create table statistics (id integer, deckid integer, matchesWon integer, matchesTied integer, matchesLost integer, gamesWon integer, gamesTied integer, gamesLost integer, mulligans integer, PRIMARY KEY(id ASC), FOREIGN KEY(deckid) REFERENCES deck(id))";
                command = new SQLiteCommand(sql, sqlite);
                command.ExecuteNonQuery();

                sqlite.Close();
                
            }
            else
            {
                
                Console.WriteLine("DB exists - Connecting to DB");
                sqlite = new SQLiteConnection("Data Source=MTGDeckStatsDB.sqlite;Version=3;");
                //modify("insert into purchases (name, setName, date, price, condition) VALUES ('X', 'X', 'X','X', 'X')");
                

            }

        } 

        public void modify(string sql)
        {
            sqlite.Open();
            command = new SQLiteCommand(sql, sqlite);
            command.ExecuteNonQuery();
            sqlite.Close();
        }

        //*****this is going to need some work*****
        public string[,] read(string sql, string sqlRowCount)
        {
            string rows;
            sqlite.Open();
            command = new SQLiteCommand(sqlRowCount, sqlite);
            SQLiteDataReader reader1 = command.ExecuteReader();
            if (reader1.HasRows) {
                reader1.Read();
                rows = reader1.GetValue(0).ToString();
                reader1.Close();
                //Console.WriteLine("rows:" + rows); //
            }
            else {
                rows = "0";
            }
            command = new SQLiteCommand(sql, sqlite);
            SQLiteDataReader reader2 = command.ExecuteReader();
            string[,] a;
            int r = Convert.ToInt32(rows);
            if (r != 0)
            {
                a = new string[reader2.FieldCount, r];
                for (int i = 0; i < r; i++)
                {
                    reader2.Read(); //get a row
                    for (int j = 0; j < reader2.FieldCount; j++)
                    {
                        a[j, i] = (reader2.GetValue(j).ToString());
                    }
                }
            }
            else {
                a = new string[,] { { "No data" }, { "No data" } };
            }
            Console.Write("0,0: " + a[0, 0] + " // 1,0: " + a[1, 0]);

            reader2.Close();
            sqlite.Close();
            //Console.Write("Decks" + a[0, 0] + " " + a[1, 0]);
            return a;
        }

    }
}
