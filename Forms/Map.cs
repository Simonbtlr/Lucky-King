using Lucky_King.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky_King.Forms
{
    public partial class Map : Form
    {
        Game game;
        Player player;
        Engine engine;

        int stage;

        public Map(Engine e, Game g, Player p, int s)
        {
            InitializeComponent();

            engine = e;
            game = g;
            player = p;
            stage = s;
        }

        private void Map_Load(object sender, EventArgs e)
        {

        }

        private void MarketButton_Click(object sender, EventArgs e)
        {
            engine.OpenMarketForm(game.PlotStep, this);
        }
    }
}
