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
    public partial class Market : Form
    {
        Engine engine;
        Game game;
        Player player;

        public Market(Engine e, Game g, Player p, int s)
        {
            InitializeComponent();

            engine = e;
            game = g;
            player = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            engine.OpenTrainingForm(this);
        }
    }
}
