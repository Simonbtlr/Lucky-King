namespace Lucky_King.Forms
{
    partial class Training
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextPlace = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.PictureBox();
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            this.NoButton = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Label();
            this.formsEdits1 = new Lucky_King.Other.FormsEdits(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TextPlace
            // 
            this.TextPlace.BackColor = System.Drawing.Color.Transparent;
            this.TextPlace.Font = new System.Drawing.Font("Stanberry", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.TextPlace.Location = new System.Drawing.Point(20, 155);
            this.TextPlace.Name = "TextPlace";
            this.TextPlace.Size = new System.Drawing.Size(490, 195);
            this.TextPlace.TabIndex = 0;
            this.TextPlace.Text = "Sample Text";
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.BackColor = System.Drawing.Color.Transparent;
            this.PlayerName.Font = new System.Drawing.Font("Stanberry", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.PlayerName.Location = new System.Drawing.Point(535, 192);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(154, 20);
            this.PlayerName.TabIndex = 1;
            this.PlayerName.Text = "Sample Player Name";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Image = global::Lucky_King.Properties.Resources.Exit;
            this.ExitButton.Location = new System.Drawing.Point(15, 375);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(40, 40);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Image = global::Lucky_King.Properties.Resources.Save;
            this.SaveButton.Location = new System.Drawing.Point(60, 375);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(40, 40);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.TabStop = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Image = global::Lucky_King.Properties.Resources.Settings;
            this.SettingsButton.Location = new System.Drawing.Point(105, 375);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(40, 40);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.TabStop = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.Transparent;
            this.NoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoButton.Font = new System.Drawing.Font("Stanberry", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.NoButton.Image = global::Lucky_King.Properties.Resources.NoButton;
            this.NoButton.Location = new System.Drawing.Point(530, 320);
            this.NoButton.Name = "NoButton";
            this.NoButton.Padding = new System.Windows.Forms.Padding(5);
            this.NoButton.Size = new System.Drawing.Size(170, 40);
            this.NoButton.TabIndex = 15;
            this.NoButton.Text = "No Button";
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.Color.Transparent;
            this.YesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesButton.Font = new System.Drawing.Font("Stanberry", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.YesButton.Image = global::Lucky_King.Properties.Resources.YesButton;
            this.YesButton.Location = new System.Drawing.Point(530, 270);
            this.YesButton.Name = "YesButton";
            this.YesButton.Padding = new System.Windows.Forms.Padding(5);
            this.YesButton.Size = new System.Drawing.Size(170, 40);
            this.YesButton.TabIndex = 14;
            this.YesButton.Text = "Yes\r\nButton";
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // formsEdits1
            // 
            this.formsEdits1.form = this;
            this.formsEdits1.FormStyle = Lucky_King.Other.FormsEdits.fStyle.None;
            // 
            // Training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lucky_King.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(710, 420);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.TextPlace);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Training";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обучение";
            this.Load += new System.EventHandler(this.Training_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextPlace;
        private System.Windows.Forms.Label PlayerName;
        private Other.FormsEdits formsEdits1;
        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.PictureBox SaveButton;
        private System.Windows.Forms.PictureBox SettingsButton;
        private System.Windows.Forms.Label NoButton;
        private System.Windows.Forms.Label YesButton;
    }
}