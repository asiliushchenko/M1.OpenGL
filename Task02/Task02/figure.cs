using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task02
{
    public partial class RenderControl
    {
        public class figure 
        {
            readonly double cursorCenterX = -3;
            readonly double cursorCenterY = 0;

            public void DrawComplexFigure(double sidesize = 8.5, uint DrawMode = GL_FILL, double offsetX = 0, double offsetY = 0)
            {
                double height = Math.Sqrt(3) / 2 * sidesize; // Висота трикутника

                glPolygonMode(GL_FRONT_AND_BACK, DrawMode);

                // Лівий верхній жовтий чотирикутник (трапеція)
                glBegin(GL_QUAD_STRIP);
                glColor3d(1, 1, 0); // Жовтий колір
                glVertex2d(offsetX, offsetY + height); // Лівий верх
                glVertex2d(offsetX + sidesize, offsetY + height); // Правий верх
                glVertex2d(offsetX - 4.25, offsetY); // Правий низ
                glVertex2d(offsetX + sidesize + 4.25, offsetY); // Лівий низ
                glEnd();

                glBegin(GL_QUAD_STRIP);
                glColor3d(1, 0, 0); // Червоний колір
                glVertex2d(offsetX + sidesize, offsetY - height); // Лівий верх
                glVertex2d(offsetX, offsetY - height); // Правий верх
                glVertex2d(offsetX + sidesize + 4.25, offsetY); // Правий низ
                glVertex2d(offsetX - 4.25, offsetY); // Лівий низ
                glEnd();

                glBegin(GL_TRIANGLES);
                glColor3d(1, 1, 1); // Білий колір
                glVertex2d(offsetX + sidesize, offsetY + height); // Лівий кут
                glVertex2d(offsetX + sidesize * 2 , offsetY + height); // Правий кут
                glVertex2d(offsetX + sidesize + 4.25, offsetY); // Нижній кут
                glEnd();

                glBegin(GL_TRIANGLES);
                glColor3d(0.5, 0.5, 0.5); // Сірий колір
                glVertex2d(offsetX + sidesize + 4.25, offsetY); // Верхній кут
                glVertex2d(offsetX + sidesize, offsetY - height); // Лівий кут
                glVertex2d(offsetX + sidesize * 2, offsetY - height); // Правий кут
                glEnd();

                glBegin(GL_TRIANGLES);
                glColor3d(1, 0, 0);
                glVertex2d(offsetX + sidesize * 2, offsetY + height); // Правий кут
                glVertex2d(offsetX + sidesize + 4.25, offsetY); // Лівий кут
                glVertex2d(offsetX + sidesize * 2 + 4.25, offsetY); // Правий кут
                glEnd();

                glBegin(GL_TRIANGLES);
                glColor3d(1, 1, 0);
                glVertex2d(offsetX + sidesize + 4.25, offsetY); // Лівий кут
                glVertex2d(offsetX + sidesize * 2 + 4.25, offsetY); // Правий кут
                glVertex2d(offsetX + sidesize * 2, offsetY - height); // Нижній кут
                glEnd();
            }
        }
    }
}
