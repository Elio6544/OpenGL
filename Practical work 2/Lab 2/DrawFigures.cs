using System;
using static Lab_2.OpenGL;

namespace Lab_2
{
    public class DrawFigures
    {
        private WindowSize windowSize;
        private Random random = new Random();

        public float sideFigure { get; }
        public int horCount { set; get; }
        public int verCount { set; get; }
        public uint polygonMode { set; get; }
        public uint shadeModel { set; get; }

        public DrawFigures(WindowSize windowSize)
        {
            this.windowSize = windowSize;

            sideFigure = 10f;

            horCount = 1;
            verCount = 1;

            polygonMode = GL_FILL;
            shadeModel = GL_SMOOTH;
        }

        public void Draw()
        {
            for(int ver = 0; ver < verCount; ver++)
            {
                for (int hor = 0; hor < horCount; hor++)
                {
                    DFigures(hor, ver);
                }
            }
        }

        public void SetWindowSize(WindowSize windowSize)
        {
            this.windowSize = windowSize;
        }

        private double RandomColor() => 
            random.NextDouble();

        private void DFigures(int hor, int ver)
        {
            float zero_x = (1.5f - (1.25f * (horCount - 1))) * sideFigure;
            float zero_y = (verCount - 1) * (sideFigure * MathF.Sqrt(3)) / 2;

            zero_y = hor % 2 != 0 ? zero_y - (sideFigure * MathF.Sqrt(3)) / 2 : zero_y;

            float coef_x = hor * (sideFigure * 2.5f);
            float coef_y = ver * (sideFigure * MathF.Sqrt(3));

            float pos_x = zero_x + coef_x;
            float pos_y = zero_y - coef_y;

            glPolygonMode(GL_FRONT_AND_BACK, polygonMode);
            glShadeModel(shadeModel);

            glPointSize(5);
            glLineWidth(5);

            // figure 1
            glBegin(GL_POLYGON);
                glColor3d(0, 1, 0);
                glVertex2d(pos_x - sideFigure, pos_y);
                glVertex2d(pos_x - (3 * sideFigure), pos_y);
                glVertex2d(pos_x - (2.5 * sideFigure), pos_y + ((sideFigure * Math.Sqrt(3)) / 2));
                glColor3d(1, 0, 0);
                glVertex2d(pos_x - (1.5 * sideFigure), pos_y + ((sideFigure * Math.Sqrt(3)) / 2));
            glEnd();

            // figure 2
            glBegin(GL_POLYGON);
                glColor3d(1, 0, 0);
                glVertex2d(pos_x - sideFigure, pos_y);
                glVertex2d(pos_x - (1.5 * sideFigure), pos_y + ((sideFigure * Math.Sqrt(3)) / 2));
                glColor3d(0, 1, 0);
                glVertex2d(pos_x - (0.5 * sideFigure), pos_y + ((sideFigure * Math.Sqrt(3)) / 2));
            glEnd();

            // figure 3
            glBegin(GL_POLYGON);
                glColor3d(0, 1, 0);
                glVertex2d(pos_x, pos_y);
                glVertex2d(pos_x - (0.5 * sideFigure), pos_y + ((sideFigure * Math.Sqrt(3)) / 2));
                glColor3d(1, 1, 0); 
                glVertex2d(pos_x - sideFigure, pos_y);
            glEnd();

            // figure 4
            glBegin(GL_POLYGON);
                glColor3d(1, 1, 0);
                glVertex2d(pos_x - sideFigure, pos_y);
                glVertex2d(pos_x - (3 * sideFigure), pos_y);
                glVertex2d(pos_x - (2.5 * sideFigure), pos_y - ((sideFigure * Math.Sqrt(3)) / 2));
                glColor3d(1, 0, 0);
                glVertex2d(pos_x - (1.5 * sideFigure), pos_y - ((sideFigure * Math.Sqrt(3)) / 2));
            glEnd();

            // figure 5
            glBegin(GL_POLYGON);
                glColor3d(1, 0, 0);
                glVertex2d(pos_x - sideFigure, pos_y);
                glVertex2d(pos_x - (1.5 * sideFigure), pos_y - ((sideFigure * Math.Sqrt(3)) / 2));
                glColor3d(1, 1, 0);
                glVertex2d(pos_x - (0.5 * sideFigure), pos_y - ((sideFigure * Math.Sqrt(3)) / 2));
            glEnd();

            // figure 6
            glBegin(GL_POLYGON);
                glColor3d(1, 1, 0);
                glVertex2d(pos_x, pos_y);
                glVertex2d(pos_x - (0.5 * sideFigure), pos_y - ((sideFigure * Math.Sqrt(3)) / 2));
                glColor3d(0, 1, 0);
                glVertex2d(pos_x - sideFigure, pos_y);
            glEnd();
        }
    }
}
