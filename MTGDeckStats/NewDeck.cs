using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MTGDeckStats
{
    public partial class NewDeck : Form
    {
        DB database;
        string deckName;
        string deckColors;
        string deckFormat;
        string deckSize;
        //id integer, name varchar(20), colors varchar(20), format varchar(20), cards int, PRIMARY KEY(id ASC))
        public NewDeck(DB db)
        {
            database = db;
            InitializeComponent();
        }

        private void NewDeck_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String errCode = "";
            deckName = txtName.Text;
            deckColors = txtColors.Text;
            deckFormat = comboFormat.Text;
            deckSize = txtSize.Text;
            
            deckName = deckName.Replace("'", "''");
            deckColors = deckColors.Replace("'", "''");
            deckFormat = deckFormat.Replace("'", "''");
            deckSize = deckSize.Replace("'", "''");
            if (deckName.Equals("", StringComparison.Ordinal)) { errCode += "Please enter the name of your deck.\n"; }
            if (deckColors.Equals("", StringComparison.Ordinal)) { errCode += "Please enter the colors of your deck (Shorthand is best. Example: BUG).\n"; }
            if (deckFormat.Equals("", StringComparison.Ordinal)) { errCode += "Please select the format of your deck.\n"; }
            if (deckSize.Equals("", StringComparison.Ordinal)) { errCode += "Please enter the size of your deck (number of cards in the deck).\n"; }
            if (errCode.Equals("", StringComparison.Ordinal))
            {
                string sqlString = "insert into deck (name, colors, format, cards) VALUES ('" + deckName + "','" + deckColors + "','" + deckFormat + "','" + deckSize + "')";
                database.modify(sqlString);
                
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show(errCode,
        "Missing Entries",
        MessageBoxButtons.OK);
            }
        }
    }
}
