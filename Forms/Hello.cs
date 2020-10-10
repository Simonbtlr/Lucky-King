using Lucky_King.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky_King.Forms
{
    public partial class Hello : Form
    {
        Engine engine;
        Game game;
        Player player;

        public Hello(Engine e, Game g, Player p)
        {
            InitializeComponent();

            engine = e;
            game = g;
            player = p;

            YesButton.Text = "Подтвердить";
            NoButton.Text = "Сбросить";
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            if(PlayerNameTextBox.Text == "" || VillageNameTextBox.Text == "")
            {
                NoButton_Click(sender, e);
            }
            else
            {
                player.Name = PlayerNameTextBox.Text;
                game.VillageName = VillageNameTextBox.Text;

                engine.SaveGame();

                this.Close();
            }
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            PlayerNameTextBox.Text = "";
            VillageNameTextBox.Text = "";
        }
    }
}
