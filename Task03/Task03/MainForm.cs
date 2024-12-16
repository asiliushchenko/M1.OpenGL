using System.Windows.Forms;
using static Task03.OpenGL;
using System.Drawing;


namespace Task03
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(766, 435);
            renderControl1.MinX = (double)MinXvalue.Value;
            renderControl1.MaxX = (double)MaxXvalue.Value;
            renderControl1.MinY = (double)MinYvalue.Value;
            renderControl1.MaxY = (double)MaxYvalue.Value;
            renderControl1.showY = false;
        }

        private void NumberOfPoints_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.points = (double)NumberOfPoints.Value;
            renderControl1.Invalidate();
        }

        private void MinXvalue_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.MinX = (double)MinXvalue.Value;
            renderControl1.Invalidate();
        }

        private void MaxXvalue_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.MaxX = (double)MaxXvalue.Value;
            renderControl1.Invalidate();
        }

        private void buttonShowY_Click(object sender, System.EventArgs e)
        {
            if (!renderControl1.showY)
            {
                MenuY.Visible = true;
                renderControl1.MinY = (double)MinYvalue.Value;
                renderControl1.MaxY = (double)MaxYvalue.Value;
            }
            else
            {
                MenuY.Visible = false;
                renderControl1.MinY = -2.0;
                renderControl1.MaxY = 2.0;
            }
            renderControl1.showY = !renderControl1.showY;
            renderControl1.Invalidate();
        }

        private void MinYvalue_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.MinY = (double)MinYvalue.Value;
            renderControl1.Invalidate();
        }

        private void MaxYvalue_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.MaxY = (double)MaxYvalue.Value;
            renderControl1.Invalidate();
        }

        private void Function1_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.function = 0;
            renderControl1.Invalidate();
        }

        private void Function2_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.function = 1;
            renderControl1.Invalidate();
        }
    }
}
