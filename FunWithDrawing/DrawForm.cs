using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FunWithDrawing
{
    class DrawForm : Form
    {
        //DATA MEMBER DECLARATION
        private Button btnErase;
        private Graphics g;
        private Point ptnStart, ptnEnd;

        //CONSTRUCTOR
        public DrawForm(string title = "")
        {
            Text = title;
            Size = new Size(800,600);

            InitForm();
        }

        public void InitForm()
        {
            this.BackColor = Color.BlanchedAlmond;
            //turn form into graphics
            g = this.CreateGraphics();

            // button
            btnErase = new Button();
            btnErase.Text = "Erase";
            btnErase.Location = new Point(10, 10);
            btnErase.Size = new Size(60,20);
            btnErase.BackColor = Color.LightBlue;
            btnErase.Click += BtnEraseClick;
            this.Controls.Add(btnErase);
            
            //The Mouse Events for drawing
            //this.MouseClick += DrawForm_MouseClick;
            //this.MouseDown += DrawForm_MouseDown;
            //this.MouseUp += DrawForm_MouseUp;
            //this.MouseMove += DrawForm_MouseMove;
        }

        private void DrawForm_MouseMove(object sender, MouseEventArgs e)
        {
            //Moving the mouse will draw whilst tracking the movement
            g.DrawLine(new Pen(Color.Black),new Point(e.X-1,e.Y-1), new Point(e.X,e.Y));
        }

        private void DrawForm_MouseDown(object sender, MouseEventArgs e)
        {
            ptnStart = new Point(e.X, e.Y);
        }
        private void DrawForm_MouseUp(object sender, MouseEventArgs e)
        {
            ptnEnd = new Point(e.X, e.Y);
            g.DrawLine(new Pen(Color.Black),ptnStart,ptnEnd);
        }
        

        private void DrawForm_MouseClick(object sender, MouseEventArgs e)
        {
            //this event draws a line from the center of the screen to the mouse locations
            g.DrawLine(new Pen(Color.Black), new Point(400,300), new Point(e.X, e.Y));
        }

        private void BtnEraseClick(object sender, EventArgs e)
        {
           g.Clear(Color.BlanchedAlmond);
        }
    }
}
