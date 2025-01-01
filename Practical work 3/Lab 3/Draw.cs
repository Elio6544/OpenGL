using static Lab_3.OpenGL;

namespace Lab_3
{
    internal class Draw
    {
        protected WindowSize windowSize;
        protected DrawConfig config;

        public Draw(WindowSize windowSize,DrawConfig config)
        {
            this.windowSize = windowSize;
            this.config = config;
        }

        public void DrawCoordinateSystem()
        {
            DrawGrid();
            DrawAxis();
        }

        private void DrawGrid()
        {
            glLineWidth(1);

            glBegin(GL_LINES);
            glColor3d(216f / 255f, 162f / 255f, 94f / 255f);

            float _start = config.step * ((windowSize.Ymax / config.step) % 1);

            // draw horizontal lines
            for (float row = _start; row < config.height; row += config.step)
            {
                glVertex2d(windowSize.Xmin, windowSize.Ymax - row);
                glVertex2d(windowSize.Xmax, windowSize.Ymax - row);
            }

            _start = config.step * (((-windowSize.Xmin) / config.step) % 1);

            // draw vertical lines
            for (float colum = _start; colum < config.width; colum += config.step)
            {
                glVertex2d(windowSize.Xmin + colum, windowSize.Ymax);
                glVertex2d(windowSize.Xmin + colum, windowSize.Ymin);
            }

            // draw borders
            glVertex2d(windowSize.Xmin, windowSize.Ymax);
            glVertex2d(windowSize.Xmax, windowSize.Ymax);

            glVertex2d(windowSize.Xmin, windowSize.Ymin);
            glVertex2d(windowSize.Xmax, windowSize.Ymin);

            glVertex2d(windowSize.Xmax, windowSize.Ymax);
            glVertex2d(windowSize.Xmax, windowSize.Ymin);

            glVertex2d(windowSize.Xmin, windowSize.Ymax);
            glVertex2d(windowSize.Xmin, windowSize.Ymin);

            glEnd();
        }

        private void DrawAxis()
        {
            glLineWidth(2);

            glBegin(GL_LINES);
            glColor3d(238f / 255f, 223f / 255f, 122f / 255f);

            // X axis
            glVertex2d(windowSize.Xmax, 0f);
            glVertex2d(windowSize.Xmin, 0f);

            float _start = config.step * (((-windowSize.Xmin) / config.step) % 1);

            // draw vertical lines
            for (float colum = _start; colum < config.width + config.step; colum += config.step)
            {
                if (windowSize.Xmin + colum >= windowSize.Xmin && windowSize.Xmin + colum <= windowSize.Xmax)
                {
                    glVertex2d(windowSize.Xmin + colum, 0);
                    glVertex2d(windowSize.Xmin + colum, -config.step / 5);
                }
            }

            // Y axis
            glVertex2d(0f, windowSize.Ymax);
            glVertex2d(0f, windowSize.Ymin);

            _start = config.step * ((windowSize.Ymax / config.step) % 1);

            // draw horizontal lines
            for (float row = _start; row < config.height + config.step; row += config.step)
            {
                if (windowSize.Ymax - row <= windowSize.Ymax && windowSize.Ymax - row >= windowSize.Ymin)
                {
                    glVertex2d(-config.step / 5, windowSize.Ymax - row);
                    glVertex2d(0, windowSize.Ymax - row);
                }

            }

            glLineWidth(1);
            glEnd();
        }
    }
}
