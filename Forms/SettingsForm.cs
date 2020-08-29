using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lucky_King.Classes;
using Lucky_King.Other;
using Lucky_King.Properties;

namespace Lucky_King.Forms
{
    public partial class SettingsForm : Form
    {
        Engine engine;

        public SettingsForm(Engine e)
        {
            InitializeComponent();
            engine = e;
        }

        private void TextTypingEffectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(TextTypingEffectCheckBox.Checked == true)
            {
                Settings.Default.TextTypingEffect = true;
            }
            else
            {
                Settings.Default.TextTypingEffect = false;
            }
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            engine.ResetToDefault();
        }
    }
}
