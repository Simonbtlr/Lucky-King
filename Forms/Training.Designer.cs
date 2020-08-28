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
            this.formsEdits1 = new Lucky_King.Other.FormsEdits(this.components);
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
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.TextPlace);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Training";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обучение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextPlace;
        private System.Windows.Forms.Label PlayerName;
        private Other.FormsEdits formsEdits1;
    }
}