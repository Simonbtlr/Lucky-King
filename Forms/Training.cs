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

using Lucky_King.Classes;
using Lucky_King.Properties;

namespace Lucky_King.Forms
{
    public partial class Training : Form
    {
        int stage = 0;

        Engine engine;
        Player player;
        Game game;

        public Training(Engine eng, Player p, Game g, bool second)
        {
            InitializeComponent();

            engine = eng;
            player = p;
            game = g;

            if (second)
            {
                stage = 3;
            }
        }

        private void Training_Load(object sender, EventArgs e)
        { 
            PlayerGroupBox.Text = player.Name;
            CoinsValueLabel.Text = game.Coins + " монет";
            VillageNameLabel.Text = game.VillageName;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if(stage == 0)
            {
                button1.Enabled = false;
                button1.Text = "Далее";

                engine.WriteMessage(this, Resources.StartMessage1, textBox1);

                button1.Enabled = true;

                textBox2.Enabled = true;
                textBox3.Enabled = true;

                stage++;
            }
            else if(stage == 1)
            {
                if (textBox2.Text == "" || textBox3.Text == "")
                {
                    button1.Enabled = false;

                    engine.WriteMessage(this, Resources.StartMessageError1, textBox1);

                    button1.Enabled = true;
                }
                else
                {
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;

                    player.Name = textBox2.Text;
                    game.VillageName = textBox3.Text;

                    PlayerGroupBox.Text = player.Name;
                    VillageNameLabel.Text = game.VillageName;

                    button1.Enabled = false;


                    string message = player.Name + "? " + Resources.StartMessage2;

                    engine.WriteMessage(this, message, textBox1);

                    button1.Enabled = true;

                    stage++;
                }
            }
            else if (stage == 2)
            {
                button1.Enabled = false;

                engine.WriteMessage(this, Resources.StartMessage3, textBox1);

                game.Coins += 20;

                CoinsValueLabel.Text = game.Coins + " монет";

                MapButton.Visible = true;
            }
            else if (stage == 3)
            {
                button1.Text = "Далее";
                button1.Enabled = false;
            }
        }

        private void MapButton_Click(object sender, EventArgs e)
        {
            engine.OpenMapForm(game.PlotStep, this);
        }
    }
}
