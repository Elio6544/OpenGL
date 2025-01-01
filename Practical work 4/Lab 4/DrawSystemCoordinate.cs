using static Lab_4.OpenGL;

namespace Lab_4
{
    internal class DrawSystemCoordinate
    {
        private float Xmin, Xmax;
        private float Ymin, Ymax;

        private float _heigth;
        private float _width;

        private float step;

        public DrawSystemCoordinate(float Xmin, float Xmax, float Ymin, float Ymax, float _heigth, float _width, float step)
        {
            this.Xmin = Xmin;
            this.Xmax = Xmax;

            this.Ymin = Ymin;
            this.Ymax = Ymax;

            this._heigth = _heigth;
            this._width = _width;   

            this.step = step;
        }

        public void Draw()
        {
            DrawGrid();
            DrawAxis();
        }

        private void DrawGrid()
        {
            glLineWidth(1);

            glBegin(GL_LINES);
            glColor3d(216f / 255f, 162f / 255f, 94f / 255f);

            float _start = step * ((Ymax / step) % 1);

            // draw horizontal lines
            for (float row = _start; row < _heigth; row += step)
            {
                glVertex2d(Xmin, Ymax - row);
                glVertex2d(Xmax, Ymax - row);
            }

            _start = step * (((-Xmin) / step) % 1);

            // draw vertical lines
            for (float colum = _start; colum < _width; colum += step)
            {
                glVertex2d(Xmin + colum, Ymax);
                glVertex2d(Xmin + colum, Ymin);
            }

            // draw borders
            glVertex2d(Xmin, Ymax);
            glVertex2d(Xmax, Ymax);

            glVertex2d(Xmin, Ymin);
            glVertex2d(Xmax, Ymin);

            glVertex2d(Xmax, Ymax);
            glVertex2d(Xmax, Ymin);

            glVertex2d(Xmin, Ymax);
            glVertex2d(Xmin, Ymin);

            glEnd();
        }

        private void DrawAxis()
        {
            glLineWidth(2);

            glBegin(GL_LINES);
            glColor3d(238f / 255f, 223f / 255f, 122f / 255f);

            // X axis
            glVertex2d(Xmax, 0f);
            glVertex2d(Xmin, 0f);

            float _start = step * (((-Xmin) / step) % 1);

            // draw vertical lines
            for (float colum = _start; colum < _width + step; colum += step)
            {
                glVertex2d(Xmin + colum, 0);
                glVertex2d(Xmin + colum, -step / 3);
            }

            // Y axis
            glVertex2d(0f, Ymax);
            glVertex2d(0f, Ymin);

            _start = step * ((Ymax / step) % 1);

            // draw horizontal lines
            for (float row = _start; row < _heigth + step; row += step)
            {
                glVertex2d(-step / 3, Ymax - row);
                glVertex2d(0, Ymax - row);
            }

            glLineWidth(1);
            glEnd();
        }
    }
}
