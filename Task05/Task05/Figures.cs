using System;
using System.Runtime.InteropServices;

namespace Task05
{
    public partial class RenderControl
    {
        public class Figures
        {
            public delegate void outText(string s, double x, double y, double z);
            public outText Print;

            // Координатна сітка
            public void Grid(double size, double step = 1.0)
            {
                glDisable(GL_LIGHTING);
                glLineWidth(0.5f);
                glColor3ub(200, 200, 200);

                glBegin(GL_LINES);
                for (double i = -size; i <= size; i += step)
                {
                    // Лінії параллельно осі Z
                    glVertex3d(i, 0, -size);
                    glVertex3d(i, 0, size);

                    // Лінії параллельно осі X
                    glVertex3d(-size, 0, i);
                    glVertex3d(size, 0, i);
                }
                glEnd();

                glEnable(GL_LIGHTING);
            }

            // Зображення координат
            public void CoordinateLines(double x, double y, double z)
            {
                glDisable(GL_LIGHTING);
                glLineWidth(2.5f);
                glBegin(GL_LINES);
                glColor3ub(0, 0, 200); // Координата X
                glVertex3d(x, y, z);
                glVertex3d(x + 2, y, z);

                glColor3ub(0, 200, 0); // Координата Y
                glVertex3d(x, y, z);
                glVertex3d(x, y + 2, z);

                glColor3ub(200, 0, 0); // Координата Z
                glVertex3d(x, y, z);
                glVertex3d(x, y, z + 2);
                glEnd();

                Print?.Invoke("X", x + 2, y, z);
                Print?.Invoke("Y", x, y + 2, z);
                Print?.Invoke("Z", x, y, z + 2);
            }

            // Сфера
            public void Sphere(double x0, double y0, double z0, double radius, int slices = 20, int stacks = 20)
            {
                glPushMatrix();
                glTranslated(x0, y0, z0);

                for (int i = 0; i < stacks; i++)
                {
                    double phi1 = Math.PI * i / stacks;
                    double phi2 = Math.PI * (i + 1) / stacks;

                    glBegin(GL_QUAD_STRIP);
                    for (int j = 0; j <= slices; j++)
                    {
                        double theta = 2.0 * Math.PI * j / slices;

                        double x1 = radius * Math.Sin(phi1) * Math.Cos(theta);
                        double y1 = radius * Math.Cos(phi1);
                        double z1 = radius * Math.Sin(phi1) * Math.Sin(theta);

                        double x2 = radius * Math.Sin(phi2) * Math.Cos(theta);
                        double y2 = radius * Math.Cos(phi2);
                        double z2 = radius * Math.Sin(phi2) * Math.Sin(theta);

                        glColor3ub(150, 100, 255);
                        glVertex3d(x1, y1, z1);
                        glVertex3d(x2, y2, z2);
                    }
                    glEnd();
                }

                glPopMatrix();
            }

            // Усіченний конус
            public void TruncatedCone(double x0, double y0, double z0, double radius1, double radius2, double height, int slices = 20)
            {
                glPushMatrix();
                glTranslated(x0, y0, z0);

                glBegin(GL_QUAD_STRIP);
                for (int i = 0; i <= slices; i++)
                {
                    double theta = 2.0 * Math.PI * i / slices;

                    double x1 = radius1 * Math.Cos(theta);
                    double z1 = radius1 * Math.Sin(theta);
                    double x2 = radius2 * Math.Cos(theta);
                    double z2 = radius2 * Math.Sin(theta);

                    glColor3ub(200, 200, 100);
                    glVertex3d(x1, 0, z1);
                    glVertex3d(x2, height, z2);
                }
                glEnd();

                glPopMatrix();
            }

            // Частинний диск
            public void PartialDisc(double x0, double y0, double z0, double radiusInner, double radiusOuter, double startAngle, double sweepAngle, int slices = 40)
            {
                glPushMatrix();
                glTranslated(x0, y0, z0);

                glBegin(GL_TRIANGLE_STRIP);
                for (int i = 0; i <= slices; i++)
                {
                    double angle = startAngle + sweepAngle * i / slices;
                    angle = angle * Math.PI / 180.0;

                    double x1 = radiusInner * Math.Cos(angle);
                    double z1 = radiusInner * Math.Sin(angle);
                    double x2 = radiusOuter * Math.Cos(angle);
                    double z2 = radiusOuter * Math.Sin(angle);

                    glColor3ub(250, 255, 250);
                    glVertex3d(x1, 0, z1);
                    glVertex3d(x2, 0, z2);
                }
                glEnd();

                glPopMatrix();
            }
        }
    }
}