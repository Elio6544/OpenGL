using System;
using System.Windows.Forms;
using static Lab_3.OpenGL;

namespace Lab_3
{
    internal class DrawFuncOne : Draw
    {
        private int points;
        private bool isAutoY;

        private NumericUpDown Ymin_numeric;
        private NumericUpDown Ymax_numeric;

        public DrawFuncOne(WindowSize windowSize, DrawConfig drawConfig, int points, bool isAutoY, NumericUpDown Ymin_numeric, NumericUpDown Ymax_numeric) 
            : base(windowSize, drawConfig) 
        { 
            this.points = points;
            this.isAutoY = isAutoY; 

            this.Ymin_numeric = Ymin_numeric;
            this.Ymax_numeric = Ymax_numeric;
        }

        private float Func(float x) => 
            MathF.Sin(MathF.PI * x / 2) / (MathF.Cos(MathF.PI * x) - MathF.PI);

        public void DrawFunction()
        {
            float h = config.width / (points - 1);

            float x = 0;
            float y = 0;

            float _x = 0;
            float _y = 0;

            float _Ymin = float.MaxValue;
            float _Ymax = float.MinValue;

            glLineWidth(4);

            glBegin(GL_LINES);
            glColor3d(64f / 255f, 224f / 255f, 208f / 255f);

            for (int i = 0; i < points; i++)
            {
                x = windowSize.Xmin + i * h;
                y = Func(x);

                if (!isAutoY)
                {
                    if (y > windowSize.Ymax)
                    {
                        y = windowSize.Ymax;
                        continue;
                    }
                    else if (y < windowSize.Ymin)
                    {
                        y = windowSize.Ymin;
                        continue;
                    }
                }

                if (i > 0)
                {
                    glVertex2d(_x, _y);
                    glVertex2d(x, y);

                    if (_y * y <= 0)
                    {
                        DrawPoint((_x + x) / 2, (_y + y) / 2);
                    }
                }

                if (y < _Ymin && y < 0)
                {
                    _Ymin = y;
                }
                if (y > _Ymax && y > 0)
                {
                    _Ymax = y;
                }

                _x = x;
                _y = y;
            }

            glEnd();

            _Ymin = MathF.Round(_Ymin, 1);
            _Ymax = MathF.Round(_Ymax, 1);

            if (_Ymin < -100) _Ymin = -99.0f;
            if (_Ymax > 100) _Ymax = 99.0f;

            if (isAutoY)
            {
                Ymin_numeric.Value = (decimal)(_Ymin - config.step);
                Ymax_numeric.Value = (decimal)(_Ymax + config.step);
            }
        }

        private void DrawPoint(float x, float y)
        {
            // end draw function
            glEnd();

            // draw point
            glPointSize(10);

            glBegin(GL_POINTS);
            glColor3d(255f / 255f, 128f / 255f, 0f / 255f);

            glVertex2d(x, y);

            glEnd();

            // continue draw function
            glBegin(GL_LINES);
            glColor3d(64f / 255f, 224f / 255f, 208f / 255f);
        }
    }
}
