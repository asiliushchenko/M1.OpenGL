using System;
using System.Windows.Forms;
using static Task05.OpenGL;


namespace Task05
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void OnWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                renderControl1.Multi += 0.1;
            }
            else
            {
                if (renderControl1.Multi > 0.2)
                {
                    renderControl1.Multi -= 0.1;
                }
            }
            renderControl1.Invalidate();
        }
        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (renderControl1.NotRotating && e.Button == MouseButtons.Left)
            {
                renderControl1.NotRotating = false;
                renderControl1.LastLeftMouseX = e.X;
                renderControl1.LastLeftMouseY = e.Y;
            }
            if (renderControl1.NotPanning && e.Button == MouseButtons.Right)
            {
                renderControl1.NotPanning = false;
                renderControl1.LastRightMouseX = e.X;
                renderControl1.LastRightMouseY = e.Y;
            }
        }
        private void MouseMovement(object sender, MouseEventArgs e)
        {
            if (renderControl1.Mode)
            {
                if (!renderControl1.NotRotating)
                {
                    double deltaX = e.X - renderControl1.LastLeftMouseX;
                    double deltaY = e.Y - renderControl1.LastLeftMouseY;

                    renderControl1.CameraTheta += deltaX * 0.01;
                    renderControl1.CameraPhi -= deltaY * 0.01;

                    renderControl1.CameraPhi = Math.Clamp(renderControl1.CameraPhi, 0.1, Math.PI - 0.1);

                    renderControl1.LastLeftMouseX = e.X;
                    renderControl1.LastLeftMouseY = e.Y;

                    renderControl1.Invalidate();
                }
            }
            else
            {
                if (!renderControl1.NotRotating)
                {
                    double deltaX = e.X - renderControl1.LastLeftMouseX;
                    double deltaY = e.Y - renderControl1.LastLeftMouseY;

                    renderControl1.AngleX += deltaX * 0.2;
                    renderControl1.AngleY += deltaY * 0.2;

                    renderControl1.LastLeftMouseX = e.X;
                    renderControl1.LastLeftMouseY = e.Y;

                    renderControl1.Invalidate();
                }
            }
            if (!renderControl1.NotPanning)
            {
                double deltaX = e.X - renderControl1.LastRightMouseX;
                double deltaY = e.Y - renderControl1.LastRightMouseY;

                renderControl1.PanOffsetX += deltaX * 0.01;
                renderControl1.PanOffsetY -= deltaY * 0.01;
                renderControl1.LastRightMouseX = e.X;
                renderControl1.LastRightMouseY = e.Y;

                renderControl1.Invalidate();
            }
        }
        private void MouseClick(object sender, MouseEventArgs e)
        {
            if (!renderControl1.NotRotating && e.Button == MouseButtons.Left)
            {
                renderControl1.NotRotating = true;
            }
            if (!renderControl1.NotPanning && e.Button == MouseButtons.Right)
            {
                renderControl1.NotPanning = true;
            }
        }
        private void OrthogonalSystem(object sender, EventArgs e)
        {
            if (OrthogonalSys.Checked)
            {
                renderControl1.Mode = false;
                renderControl1.Invalidate();
            }
        }
        private void PerspectiveSystem(object sender, EventArgs e)
        {
            if (PerspectiveSys.Checked)
            {
                renderControl1.Mode = true;
                renderControl1.Invalidate();
            }
        }
        private void Light(object sender, EventArgs e)
        {
            renderControl1.LightOn = Lighting.Checked;
            renderControl1.Invalidate();
        }
    }
}
