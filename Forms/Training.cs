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
            TextPlace.Text = "Начни приключение :)";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            engine.CloseGame(this);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            engine.OpenSettingsForm(this);
        }

        private async void NoButton_Click(object sender, EventArgs e)
        {
            YesButton.Enabled = false;
            YesButton.Text = "";

            NoButton.Enabled = false;
            NoButton.Text = "";

            if (game.PlotStep == 2)
            {
                await Task.Run(() => engine.WriteMessage(this, Resources.StartMessage3_2, TextPlace));
            }

            game.PlotStep++;

            NoButton.Enabled = true;
            YesButton.Enabled = true;
        }

        private void Training_Load(object sender, EventArgs e)
        {
            if(game.PlotStep == 0)
            {
                YesButton.Text = "Начать\nприключение";
                NoButton.Visible = false;
            }
        }

        private async void YesButton_Click(object sender, EventArgs e)
        {
            YesButton.Enabled = false;
            YesButton.Text = "";

            NoButton.Enabled = false;
            NoButton.Text = "";

            if (game.PlotStep == 0)
            {
                await Task.Run(() => engine.WriteMessage(this, Resources.StartMessage1, TextPlace));

                YesButton.Text = "Предствиться";
            }
            else if (game.PlotStep == 1)
            {
                engine.OpenHelloForm();

                PlayerName.Text = player.Name;

                await Task.Run(() => engine.WriteMessage(this, Resources.StartMessage2, TextPlace));

                YesButton.Text = "Попросить проводить";
                
                NoButton.Visible = true;
                NoButton.Text = "Пообещать вернуть";
            }
            else if (game.PlotStep == 2)
            {
                await Task.Run(() => engine.WriteMessage(this, Resources.StartMessage3_1, TextPlace));
            }

            game.PlotStep++;

            YesButton.Enabled = true;
            NoButton.Enabled = true;
        }
    }
}
