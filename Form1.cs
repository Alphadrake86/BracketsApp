using BracketsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BracketsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TypeChange(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
            } else
            {
                radioButton1.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Text files (*.txt)|*.txt";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fdlg.FileName;
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please select a file", "Error", MessageBoxButtons.OK);
                return;
            }
            try
            {
                string[] players = File.ReadAllLines(textBox1.Text);

                bool isDouble = radioButton2.Checked;

                BracketsTourney tourney = new BracketsTourney(isDouble);
                tourney.AddPlayersFromFile(players);
                tourney.GenerateTournament();

                Form Results;
                if (isDouble)
                {
                    Results = new Form2(tourney);
                }
                else
                {
                    Results = new SinglesResults(tourney);
                    
                }
                
                Results.Show();
            }
            catch(Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK);
                return;
            }
            
        }
    }
}
