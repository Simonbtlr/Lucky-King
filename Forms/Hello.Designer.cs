namespace Lucky_King.Forms
{
    partial class Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hello));
            this.NoButton = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Label();
            this.TextPlace = new System.Windows.Forms.Label();
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.formsEdits1 = new Lucky_King.Other.FormsEdits(this.components);
            this.VillageNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.Transparent;
            this.NoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoButton.Font = new System.Drawing.Font("Stanberry", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.NoButton.Image = global::Lucky_King.Properties.Resources.NoButton;
            this.NoButton.Location = new System.Drawing.Point(5, 195);
            this.NoButton.Name = "NoButton";
            this.NoButton.Padding = new System.Windows.Forms.Padding(5);
            this.NoButton.Size = new System.Drawing.Size(170, 40);
            this.NoButton.TabIndex = 16;
            this.NoButton.Text = "No Button";
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.Color.Transparent;
            this.YesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesButton.Font = new System.Drawing.Font("Stanberry", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.YesButton.Image = global::Lucky_King.Properties.Resources.YesButton;
            this.YesButton.Location = new System.Drawing.Point(180, 195);
            this.YesButton.Name = "YesButton";
            this.YesButton.Padding = new System.Windows.Forms.Padding(5);
            this.YesButton.Size = new System.Drawing.Size(170, 40);
            this.YesButton.TabIndex = 17;
            this.YesButton.Text = "Yes Button";
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // TextPlace
            // 
            this.TextPlace.BackColor = System.Drawing.Color.Transparent;
            this.TextPlace.Font = new System.Drawing.Font("Stanberry", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.TextPlace.Location = new System.Drawing.Point(10, 30);
            this.TextPlace.Name = "TextPlace";
            this.TextPlace.Size = new System.Drawing.Size(335, 150);
            this.TextPlace.TabIndex = 18;
            this.TextPlace.Text = "Меня зовут                          . И я родом из\r\n                             " +
    "                                                                !";
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.PlayerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerNameTextBox.Font = new System.Drawing.Font("Stanberry", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.PlayerNameTextBox.Location = new System.Drawing.Point(100, 30);
            this.PlayerNameTextBox.MaxLength = 15;
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new System.Drawing.Size(125, 27);
            this.PlayerNameTextBox.TabIndex = 19;
            // 
            // formsEdits1
            // 
            this.formsEdits1.form = this;
            this.formsEdits1.FormStyle = Lucky_King.Other.FormsEdits.fStyle.None;
            // 
            // VillageNameTextBox
            // 
            this.VillageNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.VillageNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VillageNameTextBox.Font = new System.Drawing.Font("Stanberry", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VillageNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.VillageNameTextBox.Location = new System.Drawing.Point(15, 65);
            this.VillageNameTextBox.MaxLength = 15;
            this.VillageNameTextBox.Name = "VillageNameTextBox";
            this.VillageNameTextBox.Size = new System.Drawing.Size(130, 27);
            this.VillageNameTextBox.TabIndex = 20;
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lucky_King.Properties.Resources.BackgroundMB;
            this.ClientSize = new System.Drawing.Size(355, 240);
            this.Controls.Add(this.VillageNameTextBox);
            this.Controls.Add(this.PlayerNameTextBox);
            this.Controls.Add(this.TextPlace);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.NoButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Hello";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Other.FormsEdits formsEdits1;
        private System.Windows.Forms.Label NoButton;
        private System.Windows.Forms.Label YesButton;
        private System.Windows.Forms.Label TextPlace;
        private System.Windows.Forms.TextBox PlayerNameTextBox;
        private System.Windows.Forms.TextBox VillageNameTextBox;
    }
}