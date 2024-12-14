using System.Windows.Forms;
using System;
using System.Drawing;
using static Task02.OpenGL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Task02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(256, 300);
            renderControl1.DrawMode = GL_FILL;
        }

        private void rbFillMode_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.DrawMode = GL_FILL;
            renderControl1.Invalidate();
        }

        private void rbLineMode_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.DrawMode = GL_LINE;
            renderControl1.Invalidate();
        }

        private void rbPointMode_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.DrawMode = GL_POINT;
            renderControl1.Invalidate();
        }

        private void nUDVertical_ValueChanged(object sender, System.EventArgs e)
        {
            if (nUDVertical.Value <= 0)
            {
                nUDVertical.Value = 1;
            }
            else if (nUDVertical.Value >= 1)
            {
                renderControl1.TilesVertical = Convert.ToInt32(nUDVertical.Value);
                renderControl1.Invalidate();
            }
        }

        private void nUDHorizontal_ValueChanged(object sender, System.EventArgs e)
        {
            if (nUDHorizontal.Value <= 0)
            {
                nUDHorizontal.Value = 1;
            }
            else if (nUDHorizontal.Value >= 1)
            {
                renderControl1.TilesHorizontal = Convert.ToInt32(nUDHorizontal.Value);
                renderControl1.Invalidate();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}