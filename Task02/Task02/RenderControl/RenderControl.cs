using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using static Task02.RenderControl;

namespace Task02
{
    public partial class RenderControl : OpenGL
    {
        public uint DrawMode { get; set; } = GL_FILL;
        public int TilesVertical { get; set; } = 1;
        public int TilesHorizontal { get; set; } = 1;
        figure _f = new figure();

        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnRender(object sender, EventArgs e)
        {
            int ortho = 10;

            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            if (Width > Height)
                glViewport((Width - Height) / 2, 0, Height, Height);
            else
                glViewport(0, (Height - Width) / 2, Width, Width);

            double max = Math.Max(TilesHorizontal, TilesVertical);
            glOrtho(-50, 50 * max, -50, 50 * max, -1, 1);

            double sideSize = 8.5;
            double height = Math.Sqrt(3) / 2 * sideSize;

            for (int row = 0; row < TilesVertical; row++)
            {
                for (int col = 0; col < TilesHorizontal; col++)
                {
                    double offsetX = col * 2.5 * sideSize;
                    double offsetY = row * 2 * height;

                    if (col % 2 != 0)
                        offsetY -= height;

                    _f.DrawComplexFigure(sideSize, DrawMode, offsetX, offsetY);
                }
            }

            glDisable(GL_LINES);
        }
    }
}