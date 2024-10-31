using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class RenderControl : OpenGL
    {
        private Timer renderTimer;

        public RenderControl()
        {
            InitializeComponent();
        }

        private void RenderGL(object sender, EventArgs e)
        {

            glViewport(0, 0, Width, Height);
            glLoadIdentity();
            gluOrtho2D(-8, +12, -4, +8);
            glClear(GL_COLOR_BUFFER_BIT);

            Task task = new Task();
            task.DrawGrid();     // Зображення координатної сітки
            task.DrawFigure();    // Зображення фігури
            task.DrawPoints();   // Зображення точок
        }
    }
}
