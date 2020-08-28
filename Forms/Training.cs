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

            engine.BuildForm(this);
        }
    }
}
