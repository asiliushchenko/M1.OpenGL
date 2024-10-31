using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public partial class RenderControl
    {
        public class Task
        {
            public void DrawGrid()
            {
                glColor3f(0.8f, 0.8f, 0.8f);
                glLineWidth(1.0f);          // Товщина ліній сітки
                glEnable(GL_LINE_STIPPLE);  // Включення режиму ліній
                glLineStipple(1, 0x00FF);
                glBegin(GL_LINES);
                for (double i = -8; i <= 12; i+=0.5)
                {
                    glVertex2d(i, -4);
                    glVertex2d(i, 8);
                }
                for (double j = -4; j <= 8; j+=0.5)
                {
                    glVertex2d(-8, j);
                    glVertex2d(12, j);
                }
                glEnd();
                glDisable(GL_LINE_STIPPLE);  // Відключення пунктирних ліній
            }

            // Метод зображення фігури
            public void DrawFigure()
            {
                glColor3f(0.0f, 0.0f, 0.0f);  // Колір контуру
                glLineWidth(3.0f);            // Товщина ліній фігури
                glBegin(GL_LINE_STRIP);
                Figure(-3);
                glEnd();
            }
            public void Figure(double offsetX = 0)
            {
                glVertex2d(-0.5 + offsetX, -1);  // Нижня ліва точка
                glVertex2d(-0.5 + offsetX, 0);   // Верхня ліва точка
                glVertex2d(0 + offsetX, 0.5);   // Верхня центральна точка
                glVertex2d(1 + offsetX, 1);   // Верхня права точка
                glVertex2d(1 + offsetX, -0.5);   // Права точка
                glVertex2d(0.5 + offsetX, -1);   // Нижня права точка
                glVertex2d(-0.5 + offsetX, -1);  // Нижня ліва точка
            }

            // Метод зображення точок
            public void DrawPoints()
            {
                glEnable(GL_POINT_SMOOTH);
                glColor3f(0.0f, 0.0f, 0.0f);
                glPointSize(10.0f);
                glBegin(GL_POINTS);
                Figure(0);
                glEnd();
                glDisable(GL_POINT_SMOOTH);
            }
        }
    }
}
