using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data;
using System.Threading;

using Lucky_King.Properties;
using Lucky_King.Forms;

namespace Lucky_King.Classes
{
    public class Engine
    {
        string savesPath;
        string gameSave;
        string playerSave;
        string lastForm;
        
        XmlDocument xmlDoc = new XmlDocument();

        Game game = new Game();
        Player player = new Player();

        Training trainingForm;
        Map mapForm;
        Market marketForm;
        SettingsForm settingsForm;
        Hello helloForm;

        public Engine()
        {
            //From settings
            savesPath = Settings.Default.SavesPath;
            gameSave = savesPath + Settings.Default.GameSave;
            playerSave = savesPath + Settings.Default.PlayerSave;

            //Files
            if (!File.Exists(gameSave) || !File.Exists(playerSave))
            {
                ErrorMessage(0);
            }

            LoadGame();

            if(game.PlotStep == 0)
            {
                Training();
            }
            else
            {
                OpenLastForm();
            }
        }

        #region Private Metods

        private void ErrorMessage(int id)
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

        private void LoadGame()
        {
            xmlDoc.Load(gameSave);
            XmlElement xRoot = xmlDoc.DocumentElement;

            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0 && xNode.Name == "Kingdom")
                {
                    game.VillageName = xNode.Attributes.GetNamedItem("Name").Value;
                }
                if (xNode.Attributes.Count > 0 && xNode.Name == "Settings")
                {
                    lastForm = xNode.Attributes.GetNamedItem("LastUsedForm").Value;
                }
                foreach (XmlNode xChild in xNode.ChildNodes)
                {
                    if (xChild.Name == "Coins")
                    {
                        game.Coins = Convert.ToInt32(xChild.InnerText);
                    }
                    if (xChild.Name == "PlotStep")
                    {
                        game.PlotStep = Convert.ToInt32(xChild.InnerText);
                    }
                    if (xChild.Name == "TextTypeEffect")
                    {
                        Settings.Default.TextTypingEffect = Convert.ToBoolean(xChild.InnerText);
                    }
                }
            }

            LoadPlayer();
        }

        private void LoadPlayer()
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

        private void OpenLastForm()
        {
            if(lastForm == "Обучение")
            {
                trainingForm = new Training(this, player, game);
                trainingForm.Show();
            }
        }

        private void SavePlayer()
        {
            xmlDoc.Load(playerSave);

            XmlElement xRoot = xmlDoc.DocumentElement;

            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0 && xNode.Name == "Player")
                {
                    xNode.Attributes.GetNamedItem("Name").Value = player.Name;
                }
            }

            xmlDoc.Save(playerSave);
        }

        #endregion

        #region Public Metods

        public void CloseGame(Form f)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите выйти?", "Внимание!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                lastForm = f.Text;

                SaveGame();

                Environment.Exit(0);
            }
        }

        public void OpenHelloForm()
        {
            helloForm = new Hello(this, game, player);
            helloForm.ShowDialog();
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

        public void OpenSettingsForm(Form f)
        {
            f.Visible = false;

            settingsForm = new SettingsForm(this);
            settingsForm.ShowDialog();
        }

        public void OpenTrainingForm(Form f)
        {
            f.Close();

            trainingForm = new Training(this, player, game);
            trainingForm.Show();
        }

        public void ResetToDefault()
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите установить настройки по умолчанию?", "Сброс", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Settings.Default.TextTypingEffect = true;

                MessageBox.Show("Настройки успешно применены!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SaveGame()
        {
            xmlDoc.Load(gameSave);

            XmlElement xRoot = xmlDoc.DocumentElement;

            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0 && xNode.Name == "Kingdom")
                {
                    xNode.Attributes.GetNamedItem("Name").Value = game.VillageName;
                }
                
                if (xNode.Attributes.Count > 0 && xNode.Name == "Settings")
                {
                    xNode.Attributes.GetNamedItem("LastUsedForm").Value = lastForm;
                }

                foreach (XmlNode xChild in xNode.ChildNodes)
                {
                    if(xChild.Name == "Coins")
                    {
                        xChild.InnerText = Convert.ToString(game.Coins);
                    }

                    if(xChild.Name == "PlotStep")
                    {
                        xChild.InnerText = Convert.ToString(game.PlotStep);
                    }

                    if(xChild.Name == "TextTypingEffect")
                    {
                        xChild.InnerText = Convert.ToString(Settings.Default.TextTypingEffect);
                    }
                }
            }

            xmlDoc.Save(gameSave);

            SavePlayer();
        }

        public void Training()
        {
            trainingForm = new Training(this, player, game);
            trainingForm.Show();
        }

        public void WriteMessage(Form f, string message, Label lb)
        {
            lb.BeginInvoke((MethodInvoker)(() => lb.Text = ""));
            for (int i = 0; i < message.Length; i++)
            {
                if (Settings.Default.TextTypingEffect == true)
                {
                    lb.BeginInvoke((MethodInvoker)(() => lb.Text += message[i]));
                    Thread.Sleep(70);
                    f.BeginInvoke((MethodInvoker)(() => f.Update()));
                }
                else
                {
                    lb.BeginInvoke((MethodInvoker)(() => lb.Text = message));

                }
            }
        }

        #endregion
    }
}
