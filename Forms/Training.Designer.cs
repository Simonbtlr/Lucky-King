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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.CoinsValueLabel = new System.Windows.Forms.Label();
            this.VillageNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.MapButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PlayerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lucky_King.Properties.Resources.Filling_100x100_square;
            this.pictureBox1.Location = new System.Drawing.Point(582, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PlayerGroupBox
            // 
            this.PlayerGroupBox.Controls.Add(this.CoinsValueLabel);
            this.PlayerGroupBox.Controls.Add(this.VillageNameLabel);
            this.PlayerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.PlayerGroupBox.Name = "PlayerGroupBox";
            this.PlayerGroupBox.Size = new System.Drawing.Size(564, 100);
            this.PlayerGroupBox.TabIndex = 1;
            this.PlayerGroupBox.TabStop = false;
            this.PlayerGroupBox.Text = "PlayerName";
            // 
            // CoinsValueLabel
            // 
            this.CoinsValueLabel.AutoSize = true;
            this.CoinsValueLabel.Location = new System.Drawing.Point(7, 46);
            this.CoinsValueLabel.Name = "CoinsValueLabel";
            this.CoinsValueLabel.Size = new System.Drawing.Size(94, 20);
            this.CoinsValueLabel.TabIndex = 1;
            this.CoinsValueLabel.Text = "CoinsValue";
            // 
            // VillageNameLabel
            // 
            this.VillageNameLabel.AutoSize = true;
            this.VillageNameLabel.Location = new System.Drawing.Point(7, 22);
            this.VillageNameLabel.Name = "VillageNameLabel";
            this.VillageNameLabel.Size = new System.Drawing.Size(103, 20);
            this.VillageNameLabel.TabIndex = 0;
            this.VillageNameLabel.Text = "VillageName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 118);
            this.textBox1.MaxLength = 50000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(495, 251);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Начать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(517, 144);
            this.textBox2.MaxLength = 16;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 26);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ваше Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Название Имения";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(517, 196);
            this.textBox3.MaxLength = 16;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 26);
            this.textBox3.TabIndex = 6;
            // 
            // MapButton
            // 
            this.MapButton.Location = new System.Drawing.Point(632, 273);
            this.MapButton.Name = "MapButton";
            this.MapButton.Size = new System.Drawing.Size(50, 50);
            this.MapButton.TabIndex = 8;
            this.MapButton.Text = "Карта";
            this.MapButton.UseVisualStyleBackColor = true;
            this.MapButton.Visible = false;
            this.MapButton.Click += new System.EventHandler(this.MapButton_Click);
            // 
            // Training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 381);
            this.Controls.Add(this.MapButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PlayerGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Training";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обучение";
            this.Load += new System.EventHandler(this.Training_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PlayerGroupBox.ResumeLayout(false);
            this.PlayerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox PlayerGroupBox;
        private System.Windows.Forms.Label CoinsValueLabel;
        private System.Windows.Forms.Label VillageNameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button MapButton;
    }
}