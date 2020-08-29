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
        Engine engine;
        Player player;
        Game game;

        public Training(Engine eng, Player p, Game g)
        {
            InitializeComponent();

            engine = eng;
            player = p;
            game = g;

            PlayerName.Text = player.Name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            engine.CloseGame(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            engine.OpenSettingsForm(this);
        }

        private void NoButton_Click(object sender, EventArgs e)
        {

        }

        private void Training_Load(object sender, EventArgs e)
        {
            if(game.PlotStep == 0)
            {
                YesButton.Text = "Начать обучение";
                NoButton.Visible = false;
            }
        }

        private async void YesButton_Click(object sender, EventArgs e)
        {
            YesButton.Enabled = false;

            if(game.PlotStep == 0)
            {
                YesButton.Text = "Далее";

                await Task.Run(() => engine.WriteMessage(this, Resources.StartMessage1, TextPlace));

                game.PlotStep++;
            }

            YesButton.Enabled = true;
        }
    }
}
