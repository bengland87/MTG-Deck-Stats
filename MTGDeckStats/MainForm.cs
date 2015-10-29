using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTGDeckStats
{

    public partial class MainForm : Form
    {
        DB database;
        Dictionary<string, string> test = new Dictionary<string, string>();
        public MainForm(DB db)
        {
            database = db;
            InitializeComponent();
            refreshDecklists();
            
        }   

        public void refreshDecklists()
        {
            //load from DB and put into table
            string[,] collectionArray = database.read("select id, name from deck", "SELECT COUNT(*) from deck");
            
                //List<int> idList = new List<int>();
                //List<string> nameList = new List<string>();

                long x = collectionArray.GetLongLength(1); //rows
                test.Clear();
                for (int i = 0; i < x; i++)
                {
                    test.Add(collectionArray.GetValue(0, i).ToString(), collectionArray.GetValue(1, i).ToString());
                    //nameList.Add();

                    /*
                        comboBox1.Items.Insert(Int32.Parse(collectionArray.GetValue(0, i).ToString()), collectionArray.GetValue(1, i).ToString());
                    */

                    //collectionArray.GetValue(0,i).ToString()

                    //[j] = collectionArray.GetValue(j, i).ToString();
                }
                comboBox1.DataSource = new BindingSource(test, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";
                //dataCardTable
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NewDeck newDeck = new NewDeck(database);
            newDeck.ShowDialog();
            refreshDecklists();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshStats();
            
        }

        public void refreshStats()
        {
            string sqlString = "";
            string value = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Key;
            Console.WriteLine("INDEX VALUE = " + value);
            string[,] collectionArray = database.read("select id, matchesWon, matchesTied, matchesLost, gamesWon, gamesTied, gamesLost, mulligans from statistics WHERE deckid ='" + value + "'", "SELECT COUNT(*) from statistics WHERE deckid ='" + value + "'");
            if (collectionArray.GetValue(0, 0).ToString().Equals("No data"))
            {
                sqlString = "INSERT into statistics (deckid , matchesWon , matchesTied , matchesLost , gamesWon , gamesTied , gamesLost , mulligans ) VALUES ('" + value + "','0','0','0','0','0','0','0')";
                database.modify(sqlString);
                refreshStats();
                
            }
            else
            {
                float matchWin = Int32.Parse(collectionArray.GetValue(1,0).ToString());
                float matchTie = Int32.Parse(collectionArray.GetValue(2,0).ToString());
                float matchLose = Int32.Parse(collectionArray.GetValue(3,0).ToString());
                float matchPlay = matchWin + matchTie + matchLose;
                float gameWin = Int32.Parse(collectionArray.GetValue(4,0).ToString());
                float gameTie = Int32.Parse(collectionArray.GetValue(5,0).ToString());
                float gameLose = Int32.Parse(collectionArray.GetValue(6,0).ToString());
                float gamePlay = gameWin + gameTie + gameLose;
                float mulligan = Int32.Parse(collectionArray.GetValue(7,0).ToString());
                
                if (matchPlay==0)
                {
                    lblMatchWin.Text = "0.00";
                    lblMatchTie.Text = "0.00";
                    lblMatchLose.Text = "0.00";
                    lblMatchMull.Text = "0.00";
                }
                else
                {
                    lblMatchWin.Text = (matchWin / matchPlay).ToString("0.00");
                    lblMatchTie.Text = (matchTie / matchPlay).ToString("0.00");
                    lblMatchLose.Text = (matchLose / matchPlay).ToString("0.00");
                    lblMatchMull.Text = (mulligan / matchPlay).ToString("0.00");
                }
                if (gamePlay == 0)
                {
                    lblGameWin.Text = "0.00";
                    lblGameTie.Text = "0.00";
                    lblGameLose.Text = "0.00";
                    lblGameMull.Text = "0.00";
                }
                else
                {
                    lblGameWin.Text = (gameWin / gamePlay).ToString("0.00");
                    lblGameTie.Text = (gameTie / gamePlay).ToString("0.00");
                    lblGameLose.Text = (gameLose / gamePlay).ToString("0.00");
                    lblGameMull.Text = (mulligan / gamePlay).ToString("0.00");
                }
                lblMatches.Text = matchPlay.ToString();                
                lblGames.Text = gamePlay.ToString();
            }
        }
        private void btnDeleteDeck_Click(object sender, EventArgs e)
        {
            string sqlString = "";
            string value = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Value;
            string key = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Key;
            //Warning box to prompt "Are you sure?"
            DialogResult result = MessageBox.Show("Are you sure you want to delete "+value+"? This cannot be undone.",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);
            Console.WriteLine("Result is: "+result);
            if (result.Equals(DialogResult.Yes))
            {
                sqlString = "DELETE from deck WHERE id ='" + key + "'";
                database.modify(sqlString);
                sqlString = "DELETE from statistics WHERE deckid ='" + key + "'";
                database.modify(sqlString);
                refreshDecklists();
            }
            
        }

        private void button4_Click(object sender, EventArgs e) //Clear Stats
        {
            string sqlString = "";
            string key = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Key;
            string value = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Value;

            //warning box to prompt "Are you sure?"
            DialogResult result = MessageBox.Show("Are you sure you want to clear stats for " + value + "? This cannot be undone.",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);
            Console.WriteLine("Result is: " + result);
            if (result.Equals(DialogResult.Yes))
            {
                sqlString = "update statistics SET matchesWon = '0', matchesTied = '0', matchesLost = '0', gamesWon = '0', gamesTied = '0', gamesLost = '0', mulligans = '0' WHERE deckid ='" + key + "'";
                database.modify(sqlString);
                refreshDecklists();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlString = "";
            string value = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Key;
            int matchWin = 0;
            int matchTie = 0;
                int matchLose = 0;
                int gameWin = 0;
                int gameTie = 0;
                int gameLose = 0;
                int mulligan = 0;

            //get old data values
            string[,] collectionArray = database.read("select id, matchesWon, matchesTied, matchesLost, gamesWon, gamesTied, gamesLost, mulligans from statistics WHERE deckid ='" + value + "'", "SELECT COUNT(*) from statistics WHERE deckid ='" + value + "'");
            if (collectionArray.GetValue(0, 0).ToString().Equals("No data"))
            {
                sqlString = "INSERT into statistics (deckid , matchesWon , matchesTied , matchesLost , gamesWon , gamesTied , gamesLost , mulligans ) VALUES ('"+value+ "', '"+matchWin+"', '"+matchTie+"', '"+matchLose+"', '"+gameWin+"', '"+gameTie+"', '"+gameLose+"', '"+mulligan+"')";
                database.modify(sqlString);

            }
            else
            {
                 matchWin = Int32.Parse(collectionArray.GetValue(1,0).ToString());
                 matchTie = Int32.Parse(collectionArray.GetValue(2,0).ToString());
                 matchLose = Int32.Parse(collectionArray.GetValue(3,0).ToString());
                 gameWin = Int32.Parse(collectionArray.GetValue(4,0).ToString());
                 gameTie = Int32.Parse(collectionArray.GetValue(5,0).ToString());
                 gameLose = Int32.Parse(collectionArray.GetValue(6,0).ToString());
                 mulligan = Int32.Parse(collectionArray.GetValue(7,0).ToString());
            }
            //push new data into db
            matchWin += Int32.Parse(txtMWins.Text);
            matchTie += Int32.Parse(txtMTies.Text);
            matchLose += Int32.Parse(txtMLosses.Text);
            gameWin += Int32.Parse(txtGWins.Text);
            gameTie += Int32.Parse(txtGTies.Text);
            gameLose += Int32.Parse(txtGLosses.Text);
            mulligan += Int32.Parse(txtMulligans.Text);
            sqlString = "update statistics SET matchesWon = '"+matchWin+"', matchesTied = '"+matchTie+"', matchesLost = '"+matchLose+"', gamesWon = '"+gameWin+"', gamesTied = '"+gameTie+"', gamesLost = '"+gameLose+"', mulligans = '"+mulligan+"' WHERE deckid ='" + value + "'";
            Console.WriteLine(sqlString);
            database.modify(sqlString);

            //Display "OK" message
            //************
            refreshStats();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {
        }
    }
}
