using static Lab_1.OpenGL;

namespace Lab_1
{
    internal class DrawGrid
    {
        private float Xmin, Xmax, Ymin, Ymax;

        public DrawGrid(float Xmin, float Xmax, float Ymin, float Ymax)
        {
            this.Xmin = Xmin;
            this.Xmax = Xmax;
            this.Ymin = Ymin;
            this.Ymax = Ymax;
        }

        public void Draw()
        {
            glColor3d(216f / 255f, 162f / 255f, 94f / 255f);

            DGrid();
            DAxis();

            glColor3d(0, 0, 0);
        }

        private void DGrid()
        {
            glLineStipple(1, 4369);
            glEnable(GL_LINE_STIPPLE);
            glLineWidth(2);
            glBegin(GL_LINES);

            // draw horizontal lines
            for (float i = Xmin; i <= Xmax; i += 1)
            {

                glVertex2d(i, Ymin - 1);
                glVertex2d(i, Ymax + 1);
            }

            // draw vertical lines
            for (float i = Ymin; i <= Ymax; i += 1)
            {
                glVertex2d(Xmin - 1, i);
                glVertex2d(Xmax + 1, i);

            }

            glEnd();
            glDisable(GL_LINE_STIPPLE);
            glLineWidth(1);
        }

        private void DAxis()
        {
            glLineWidth(4);
            glBegin(GL_LINES);

            // Y
            glVertex2d(Xmin - 1, Ymin - 0.2);
            glVertex2d(Xmin - 1, Ymax + 1);

            // arrow
            glVertex2d(Xmin - 1, Ymax + 1);
            glVertex2d(Xmin - 1 - 0.2, Ymax + 1 - 0.2);

            glVertex2d(Xmin - 1, Ymax + 1);
            glVertex2d(Xmin - 1 + 0.2, Ymax + 1 - 0.2);

            // strokes
            for (float i = Ymin; i <= Ymax; i++)
            {
                glVertex2d(Xmin - 1, i);
                glVertex2d(Xmin - 1 - 0.2, i);
            }

            // X
            glVertex2d(Xmin - 0.2, Ymin - 1);
            glVertex2d(Xmax + 1, Ymin - 1);

            // arrow
            glVertex2d(Xmax + 1, Ymin - 1);
            glVertex2d(Xmax + 1 - 0.2, Ymin - 1 - 0.2);

            glVertex2d(Xmax + 1, Ymin - 1);
            glVertex2d(Xmax + 1 - 0.2, Ymin - 1 + 0.2);

            // strokes
            for (float i = Xmin; i <= Xmax; i++)
            {
                glVertex2d(i, Ymin - 1);
                glVertex2d(i, Ymin - 1 - 0.2);
            }

            glEnd();
            glLineWidth(1);
        }
    }
}
