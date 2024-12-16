using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public partial class RenderControl
    {
        public class Functions
        {
            public void Function(double MinX, double MaxX, double MinY, double MaxY, double points, int function)
            {
                glLineWidth(2);
                glBegin(GL_LINE_STRIP);

                double previousY = double.NaN;
                double x = MinX;
                double step = (MaxX - MinX) / (points - 1);
                double y = CalculateFunction(x, function);
                glVertex2d(x, y);
                for (int i = 1; i < points; i++)
                {
                    previousY = y;
                    x = MinX + i * step;
                    y = CalculateFunction(x, function);

                    if (!double.IsNaN(previousY) && Math.Abs(y - previousY) > 1.0)
                    {
                        glEnd();
                        glBegin(GL_LINE_STRIP);
                        continue;
                    }
                    glVertex2d(x, y);

                    if ((previousY * y) <= 0 && previousY != 0)
                    {
                        glEnd();
                        DrawPointsOnX(previousY, x, step, y);
                        glBegin(GL_LINE_STRIP);
                        glColor3d(0, 0, 0);
                        glVertex2d(x, y);
                    }
                }
                glEnd();
            }

            public (double, double) ShowY(double MinX, double MaxX, double MinY, double MaxY, double points, int function)
            {
                double previousY = double.NaN;
                double x = MinX;
                double step = (MaxX - MinX) / (points - 1);
                double y = CalculateFunction(x, function);
                double min;
                double max;
                min = max = y;
                for (int i = 1; i < points; i++)
                {
                    previousY = y;
                    x = MinX + i * step;
                    y = CalculateFunction(x, function);

                    if (y > max)
                        max = y;
                    if (y < min)
                        min = y;
                }
                return (min, max);
            }

            public double CalculateFunction(double x, int function)
            {
                switch (function)
                {
                    case 0:
                        return Math.Cos(3 * x) / (Math.Cos(5 * x) + 1.1);
                    case 1:
                        return Math.Exp(2 * Math.Cos(Math.PI * x)) * Math.Tan((Math.PI * x) / 3);
                    default:
                        return 0;
                }
            }

            private void DrawPointsOnX(double previousY, double x, double step, double y)
            {
                glPointSize(5);
                glColor3d(1, 0, 0);
                glBegin(GL_POINTS);
                glVertex2d(x - step / 2, (previousY + y) / 2);
                glEnd();
            }
        }
    }

}
