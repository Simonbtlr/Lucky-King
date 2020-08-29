using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

using Lucky_King.Properties;
using Lucky_King.Forms;
using System.Xml.Linq;
using System.Data;
using System.Threading;

namespace Lucky_King.Classes
{
    public class Engine
    {
        bool textTypingEffect;

        string savesPath;
        string picturesPath;
        string gameSave;
        string playerSave;

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        
        XmlDocument xmlDoc = new XmlDocument();

        Game game = new Game();
        Player player = new Player();

        Training trainingForm;
        Map mapForm;
        Market marketForm;
        SettingsForm settingsForm;

        public Engine()
        {
            //From settings
            savesPath = Settings.Default.SavesPath;
            picturesPath = Settings.Default.PicturesPath;
            gameSave = savesPath + Settings.Default.GameSave;
            playerSave = savesPath + Settings.Default.PlayerSave;
            textTypingEffect = Settings.Default.TextTypingEffect;

            //Files
            if (!File.Exists(gameSave) || !File.Exists(playerSave))
            {
                ErrorMessage(0);
            }

            //Icons/Pictures
            if (!Directory.Exists(picturesPath))
            {
                ErrorMessage(1);
            }

            LoadGame();
            LoadPlayer();

            if(game.PlotStep == 0)
            {
                Training();
            }
        }

        public void Training()
        {
            trainingForm = new Training(this, player, game, false);
            trainingForm.Show();
        }

        public void LoadPlayer()
        {
            xmlDoc.Load(playerSave);
            XmlElement xRoot = xmlDoc.DocumentElement;

            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0)
                {
                    player.Name = xNode.Attributes.GetNamedItem("Name").Value;
                }
            }
        }

        public void OpenSettingsForm(Form f)
        {
            f.Visible = false;

            settingsForm = new SettingsForm();
            DialogResult dr = settingsForm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                ApplySettings(settingsForm);
            }
        }

        private void ApplySettings(Form f)
        {

        }

        public void CloseGame()
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите выйти?", "Внимание!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dr == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }

        public void LoadGame()
        {
            xmlDoc.Load(gameSave);
            XmlElement xRoot = xmlDoc.DocumentElement;
       
            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0)
                {
                    game.VillageName = xNode.Attributes.GetNamedItem("Name").Value;
                }
                foreach (XmlNode xChild in xNode.ChildNodes)
                {
                    if(xChild.Name == "Coins")
                    {
                        game.Coins = Convert.ToInt32(xChild.InnerText);
                    }
                    if(xChild.Name == "PlotStep")
                    {
                        game.PlotStep = Convert.ToInt32(xChild.InnerText);
                    }
                }
            }
        }

        public void ErrorMessage(int id)
        {
            string error = "Ошибка";

            if (id == 0)
            {
                error = "Отсутвуют файлы сохранений.";
            }
            else if (id == 1)
            {
                error = "Отсутвует папка с изображениями.";
            }

            MessageBox.Show(error, "Внимане", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }

        public void OpenTrainingForm(Form f)
        {
            f.Close();
            
            trainingForm = new Training(this, player, game, true);
            trainingForm.Show();
        }

        public void OpenMapForm(int step, Form f)
        {
            f.Close();

            mapForm = new Map(this, game, player, step);
            mapForm.Show();
        }

        public void OpenMarketForm(int step, Form f)
        {
            f.Close();

            marketForm = new Market(this, game, player, step);
            marketForm.Show();
        }

        public void WriteMessage(Form f, string message, TextBox tb)
        {
            for (int i = 0; i < message.Length; i++)
            {
                tb.Text += message[i];
                if (textTypingEffect == true)
                {
                    Thread.Sleep(70);
                    f.Update();
                }
            }
        }
    }
}
