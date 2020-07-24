using BracketsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BracketsApp
{
    public partial class SinglesResults : Form
    {
        private List<Bracket> brackets;
        public SinglesResults(BracketsTourney Bt)
        {
            brackets = Bt.GetBrackets();
            InitializeComponent();

            label1.Text = $"of {brackets.Count}";
            Page.Maximum = brackets.Count;
            SetPage(1);
        }

        private void Page_ValueChanged(object sender, EventArgs e)
        {
            SetPage((int)Page.Value);
        }

        private void SetPage(int page)
        {
            page = Math.Max(1, Math.Min(page, brackets.Count));
            Page.Value = page;
            SetBoxes(brackets[page - 1]);
        }

        private void SetBoxes(Bracket bracket)
        {
            List<BracketGame> r1 = bracket.GetRound(1);

            Round1Box1.Text = $"{r1[0].p1.name} ({r1[0].p1.games[0]})";
            Round1Box2.Text = $"{r1[0].p2.name} ({r1[0].p2.games[0]})";
            Round1Box3.Text = $"{r1[1].p1.name} ({r1[1].p1.games[0]})";
            Round1Box4.Text = $"{r1[1].p2.name} ({r1[1].p2.games[0]})";
            Round1Box5.Text = $"{r1[2].p1.name} ({r1[2].p1.games[0]})";
            Round1Box6.Text = $"{r1[2].p2.name} ({r1[2].p2.games[0]})";
            Round1Box7.Text = $"{r1[3].p1.name} ({r1[3].p1.games[0]})";
            Round1Box8.Text = $"{r1[3].p2.name} ({r1[3].p2.games[0]})";

            List<BracketGame> r2 = bracket.GetRound(2);

            Round2Box1.Text = $"{r2[0].p1.name} ({r2[0].p1.games[1]})";
            Round2Box2.Text = $"{r2[0].p2.name} ({r2[0].p2.games[1]})";
            Round2Box3.Text = $"{r2[1].p1.name} ({r2[1].p1.games[1]})";
            Round2Box4.Text = $"{r2[1].p2.name} ({r2[1].p2.games[1]})";


            BracketGame r3 = bracket.GetRound(3)[0];

            Round3Box1.Text = $"{r3.p1.name} ({r3.p1.games[2]})";
            Round3Box2.Text = $"{r3.p2.name} ({r3.p2.games[2]})";

            

            FirstPlace.Text = $"{r3.GetWinner(3).name} - $25";
            SecondPlace.Text = $"{r3.GetLoser(3).name} - $10";

        }

        private void back1_Click(object sender, EventArgs e)
        {
            SetPage((int)(Page.Value - 1));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetPage(1);
        }

        private void forward1_Click(object sender, EventArgs e)
        {
            SetPage((int)(Page.Value + 1));
        }

        private void forwardAll_Click(object sender, EventArgs e)
        {
            SetPage(brackets.Count);
        }
    }
}
