using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lucky_King.Other;
using Lucky_King.Properties;

namespace Lucky_King.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
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
    }
}
