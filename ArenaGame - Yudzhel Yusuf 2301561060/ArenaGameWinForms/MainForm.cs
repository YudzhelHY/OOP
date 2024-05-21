using ArenaGameEngine;
using Microsoft.VisualBasic.Logging;
using System.Reflection;

namespace ArenaGameWinForms
{
    public partial class MainForm : Form
    {
        private Hero winnerOne;
        private Hero winnerTwo;
        public MainForm()
        {
            InitializeComponent();
        }

        public void AddItemToListBoxKnight(string s)
        {
            ListBoxKnight.Items.Add(s);
        }

        public void AddItemToListBoxRogue(string s)
        {
            ListBoxRogue.Items.Add(s);
        }
        public void AddItemToListBoxSultan(string s)
        {
            ListBoxSultan.Items.Add(s);
        }
        public void AddItemToListBoxBrigand(string s)
        {
            ListBoxBrigand.Items.Add(s);
        }

        private void bNewGame_Click(object sender, EventArgs e)
        {
            bNewGame_Click(sender, e, true);
        }

        private void bNewGame_Click(object sender, EventArgs e, bool log)
        {
            ClearTextBoxBeforeFight(ListBoxRogue, ListBoxKnight);

            Knight knight = new Knight("Sir John");
            Rogue rogue = new Rogue("Slim Shady");
            Arena arena = new Arena(knight, rogue);
            arena.EventListener = new WinFormsGameEventListener(this);
            Hero winner = arena.Battle();

            if (log) MessageBox.Show($"Winner is {winner.Name}", "Battle ended.");
            else winnerOne = winner;
        }

        private void bSecondGame_Click(object sender, EventArgs e)
        {
            bSecondGame_Click(sender, e, true);
        }

        private void bSecondGame_Click(object sender, EventArgs e, bool log = true)
        {
            ClearTextBoxBeforeFight(ListBoxSultan, ListBoxBrigand);

            Sultan sultan = new Sultan("Sultan Syuleyman");
            Brigand brigand = new Brigand("Teke");
            Arena arena = new Arena(sultan, brigand);
            arena.EventListener = new WinFormsGameEventListener(this);
            Hero winner = arena.Battle();

            if (log) MessageBox.Show($"Winner is {winner.Name}", "Battle ended.");
            else winnerTwo = winner;
        }

        private void ClearTextBoxBeforeFight(ListBox first, ListBox second)
        {
            first.Items.Clear();
            second.Items.Clear();
        }

        private void MainFight_Click(object sender, EventArgs e)
        {
            bNewGame_Click(sender, e, false);
            bSecondGame_Click(sender, e, false);
            MessageBox.Show($"First Fight Winner is {winnerOne.Name}{Environment.NewLine}Second Fight Winner is {winnerTwo.Name}", "Battle ended.");
        }
    }
}
