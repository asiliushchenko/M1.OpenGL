using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public partial class RenderControl
    {
        public class Class1
        {
            public void DrawGrid(double MinX, double MaxX, double MinY, double MaxY)
            {
                glLineWidth(0.5f);
                glColor3d(0.3, 0.3, 0.3);
                glBegin(GL_LINES);
                for (double i = MinX; i <= MaxX; i++)
                {
                    glVertex2d(i, MinY);
                    glVertex2d(i, MaxY);
                }
                for (double i = MinY; i <= MaxY; i++)
                {
                    glVertex2d(MinX, i);
                    glVertex2d(MaxX, i);
                }
                glEnd();
            }

            public void DrawAxis(double MinX, double MaxX, double MinY, double MaxY)
            {
                glLineWidth(2);
                glColor3d(0.1, 0.1, 0.1);
                glBegin(GL_LINES);
                glVertex2d(MinX, 0);
                glVertex2d(MaxX, 0);
                glVertex2d(0, MinY);
                glVertex2d(0, MaxY);
                glEnd();
            }
        }
    }
}
