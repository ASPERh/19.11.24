using System;
using System.Drawing;
using System.Windows.Forms;

namespace _19._11._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            int flagWidth = 600;
            int flagHeight = 400;

            int startX = 50;
            int startY = 25;

            g.FillRectangle(Brushes.Yellow, startX, startY, flagWidth, flagHeight);

            g.FillRectangle(Brushes.Blue, startX, startY, flagWidth, flagHeight/2);
        }

    }
}