using Lucky_King.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky_King.Other
{
    public partial class FormsEdits : Component
    {
        private bool mousePressed = false;
        
        private Point clickPosition;
        private Point moveStartPosition;
        
        public Form form {get; set;}

        private fStyle formStyle = fStyle.None;

        public enum fStyle
        {
            None
        }

        public fStyle FormStyle 
        {
            get => formStyle;
            set
            {
                formStyle = value;
                Sign();
            }
        }

        private void Sign()
        {
            if(form != null)
            {
                form.Load += Form_Load;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Apply();
        }

        private void Apply()
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.BackgroundImage = Resources.Background;

            form.MouseDown += Form_MouseDown;
            form.MouseUp += Form_MouseUp;
            form.MouseMove += Form_MouseMove;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePressed == true)
            {
                Size frmOffset = new Size(Point.Subtract(Cursor.Position, new Size(clickPosition)));
                form.Location = Point.Add(moveStartPosition, frmOffset);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Location.Y <= 25)
            {
                mousePressed = true;
                clickPosition = Cursor.Position;
                moveStartPosition = form.Location;
            }
        }

        public FormsEdits()
        {
            InitializeComponent();
        }

        public FormsEdits(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
