using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using static Task03.RenderControl;

namespace Task03
{
    public partial class RenderControl : OpenGL
    {
        Class1 _l = new Class1();
        Functions _dF = new Functions();
        public double points = 1000;
        public bool showY { get; set; } = false;
        public double MinX { get; set; } = -2.0;
        public double MaxX { get; set; } = 2.0;
        public double MinY { get; set; } = -2.0;
        public double MaxY { get; set; } = 2.0;
        public int function { get; set; } = 0;
        public RenderControl()
        {
            InitializeComponent();
        }
        private void OnRender(object sender, EventArgs e)
        {
            glClearColor(1, 1, 1, 1);
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();
            glViewport(0, 0, Width, Height);

            if (!showY)
                (MinY, MaxY) = _dF.ShowY(MinX, MaxX, MinY, MaxY, points, function);
            MaxY = Math.Min(MaxY, 100);
            MinY = Math.Max(MinX, -100);
            gluOrtho2D(MinX, MaxX, MinY, MaxY);

            _l.DrawGrid(MinX, MaxX, MinY, MaxY);
            _l.DrawAxis(MinX, MaxX, MinY, MaxY);
            _dF.Function(MinX, MaxX, MinY, MaxY, points, function);
        }
    }
}

