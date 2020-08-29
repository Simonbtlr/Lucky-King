namespace Lucky_King.Forms
{
    partial class SettingsForm
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
            this.formsEdits1 = new Lucky_King.Other.FormsEdits(this.components);
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.TTELabel = new System.Windows.Forms.Label();
            this.TextTypingEffectCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NoButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // formsEdits1
            // 
            this.formsEdits1.form = this;
            this.formsEdits1.FormStyle = Lucky_King.Other.FormsEdits.fStyle.None;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Image = global::Lucky_King.Properties.Resources.Settings;
            this.SettingsButton.Location = new System.Drawing.Point(105, 375);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(40, 40);
            this.SettingsButton.TabIndex = 7;
            this.SettingsButton.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.Image = global::Lucky_King.Properties.Resources.Save;
            this.SaveButton.Location = new System.Drawing.Point(60, 375);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(40, 40);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Image = global::Lucky_King.Properties.Resources.Exit;
            this.ExitButton.Location = new System.Drawing.Point(15, 375);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(40, 40);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.TabStop = false;
            // 
            // TTELabel
            // 
            this.TTELabel.AutoSize = true;
            this.TTELabel.BackColor = System.Drawing.Color.Transparent;
            this.TTELabel.Font = new System.Drawing.Font("Stanberry", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TTELabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.TTELabel.Location = new System.Drawing.Point(20, 155);
            this.TTELabel.Name = "TTELabel";
            this.TTELabel.Size = new System.Drawing.Size(194, 20);
            this.TTELabel.TabIndex = 8;
            this.TTELabel.Text = "Эфект печатной машинки";
            // 
            // TextTypingEffectCheckBox
            // 
            this.TextTypingEffectCheckBox.AutoSize = true;
            this.TextTypingEffectCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.TextTypingEffectCheckBox.Checked = true;
            this.TextTypingEffectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TextTypingEffectCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextTypingEffectCheckBox.Location = new System.Drawing.Point(220, 161);
            this.TextTypingEffectCheckBox.Name = "TextTypingEffectCheckBox";
            this.TextTypingEffectCheckBox.Size = new System.Drawing.Size(15, 14);
            this.TextTypingEffectCheckBox.TabIndex = 9;
            this.TextTypingEffectCheckBox.UseVisualStyleBackColor = false;
            this.TextTypingEffectCheckBox.CheckedChanged += new System.EventHandler(this.TextTypingEffectCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Image = global::Lucky_King.Properties.Resources.YesButton;
            this.label2.Location = new System.Drawing.Point(530, 270);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(170, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "Yes Button";
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.Transparent;
            this.NoButton.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.NoButton.Image = global::Lucky_King.Properties.Resources.NoButton;
            this.NoButton.Location = new System.Drawing.Point(530, 320);
            this.NoButton.Name = "NoButton";
            this.NoButton.Padding = new System.Windows.Forms.Padding(5);
            this.NoButton.Size = new System.Drawing.Size(170, 40);
            this.NoButton.TabIndex = 13;
            this.NoButton.Text = "No Button";
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lucky_King.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(710, 420);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextTypingEffectCheckBox);
            this.Controls.Add(this.TTELabel);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ExitButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Other.FormsEdits formsEdits1;
        private System.Windows.Forms.PictureBox SettingsButton;
        private System.Windows.Forms.PictureBox SaveButton;
        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.Label TTELabel;
        private System.Windows.Forms.CheckBox TextTypingEffectCheckBox;
        private System.Windows.Forms.Label NoButton;
        private System.Windows.Forms.Label label2;
    }
}