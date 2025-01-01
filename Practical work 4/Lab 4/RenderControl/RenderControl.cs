using System;

namespace Lab_4
{
    public partial class RenderControl : OpenGL
    {
        private float size;
        private float AspectRatio { get => (float)Width / Height; }

        private float Xmin { get => (AspectRatio > 1) ? -size * AspectRatio : -size; }
        private float Xmax { get => (AspectRatio > 1) ? +size * AspectRatio : +size; }
        private float Ymin { get => (AspectRatio < 1) ? -size / AspectRatio : -size; }
        private float Ymax { get => (AspectRatio < 1) ? +size / AspectRatio : +size; }

        private float margin;
        private float step;

        private float _heigth;
        private float _width;

        private Curve curve;

        private Line line;
        private Circle circle;
        private Hyperbole hyperbole;

        private DrawSystemCoordinate systemCoordinate;

        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnStart(object sender, EventArgs e)
        {
            size = 3.0f;

            margin = 0.2f;
            step = 0.5f;

            curve = Curve.circle;

            line = new Line(new PointLine(0f, 0f), 
                            new PointLine(0f, 0f));

            circle = new Circle(1f);
            hyperbole = new Hyperbole(1f, 1f);

            UpdateHeightWidth();
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);

            glOrtho(Xmin - margin, Xmax + margin, Ymin - margin, Ymax + margin, -1, 1);

            UpdateHeightWidth();

            systemCoordinate.Draw();
            DrawTextAxis();

            switch(curve)
            {
                case Curve.circle:
                    DrawCircle();
                    break;

                case Curve.hyperbole:
                    DrawHyperbole();
                    DrawLine();
                    break;
            }
        }

        public void SetDrawCurve(Curve curve)
        {
            this.curve = curve;

            Invalidate();
        }

        private void UpdateHeightWidth()
        {
            _heigth = (-Ymin) + Ymax;
            _width = (-Xmin) + Xmax;

            systemCoordinate = new DrawSystemCoordinate(Xmin, Xmax, Ymin, Ymax, _heigth, _width, step);
        }

        public void SetPointsLine(PointLine point_1, PointLine point_2)
        {
            line = new Line(point_1, point_2);

            Invalidate();
        }

        public void SetHyperbole(float b, float a)
        {
            hyperbole = new Hyperbole(b, a);

            Invalidate();
        }

        public void SetCircle(float r)
        {
            circle = new Circle(r);

            Invalidate();
        }

        private void DrawTextAxis()
        {
            glColor3d(238f / 255f, 223f / 255f, 122f / 255f);

            // X axis
            float _start = step * (((-Xmin) / step) % 1);
            for (float colum = _start; colum < _width + step; colum += step)
            {
                if (Xmin + colum >= 0.1f || Xmin + colum <= -0.1f)
                {
                    DrawText((Xmin + colum).ToString("F1"), Xmin + colum, -step / 2);
                }
            }


            // Y axis
            _start = step * ((Ymax / step) % 1);
            for (float row = _start; row < _heigth + step; row += step)
            {
                if (Ymax - row >= 0.1f || Ymax - row <= -0.1f)
                {
                    DrawText((Ymax - row).ToString("F1"), -step / 2, Ymax - row);
                }
            }

            // 0
            DrawText((0).ToString(), -step / 2.5f, -step / 2.5f);
        }

        private void DrawCircle()
        {
            float x = 0;
            float y = 0;

            float _x = 0;
            float _y = 0;

            float c = 0.001f;

            glLineWidth(3);

            glBegin(GL_LINES);
            glColor3d(64f / 255f, 224f / 255f, 208f / 255f);


            for (x = -circle.r; x < circle.r + c; x += c)
            {
                x = MathF.Round(x, 3);
                y = MathF.Sqrt((circle.r * circle.r) - (x * x));

                if (x > -circle.r)
                {
                    glVertex2d(_x, _y);
                    glVertex2d(x, y);

                    glVertex2d(_x, -_y);
                    glVertex2d(x, -y);
                }

                _y = y;
                _x = x;
            }

            glEnd();
        }

        private void DrawLine()
        {
            glLineWidth(3);

            glBegin(GL_LINES);
            glColor3d(0f / 255f, 255f / 255f, 0f / 255f);

            glVertex2d(line.point_1.x, line.point_1.y);
            glVertex2d(line.point_2.x, line.point_2.y);

            glEnd();
        }

        private void DrawPoint(PointLine el_point_1, PointLine el_point_2)
        {
            // circle
            float x1 = el_point_1.x;
            float y1 = el_point_1.y;
            float x2 = el_point_2.x;
            float y2 = el_point_2.y;

            // line
            float x3 = line.point_1.x;
            float y3 = line.point_1.y;
            float x4 = line.point_2.x;
            float y4 = line.point_2.y;

            // point
            float x0 = 0;
            float y0 = 0;

            float D = (x2 - x1) * (y4 - y3) - (y2 - y1) * (x4 - x3);

            float t1 = 0;
            float t2 = 0;

            if (D != 0)
            {
                t1 = ((x3 - x1) * (y4 - y3) - (y3 - y1) * (x4 - x3)) / D;
                t2 = ((x3 - x1) * (y2 - y1) - (y3 - y1) * (x2 - x1)) / D;

                if ((t1 >= 0 && t1 <= 1) && (t2 >= 0 && t2 <= 1))
                {
                    x0 = (x2 - x1) * t1 + x1;
                    y0 = (y2 - y1) * t1 + y1;

                    // end draw function
                    glEnd();

                    glPointSize(20);

                    glBegin(GL_POINTS);
                    glColor3d(255f / 255f, 255f / 255f, 0f / 255f);

                    glVertex2d(x0, y0);

                    glEnd();

                    // continue draw function
                    glBegin(GL_LINES);
                    glColor3d(64f / 255f, 224f / 255f, 208f / 255f);
                }
            }
        }

        private void DrawHyperbole()
        {
            float x = 0, y = 0;
            float _x = 0, _y = 0;

            float c = 0.001f;

            glLineWidth(3);

            glBegin(GL_LINES);
            glColor3d(64f / 255f, 224f / 255f, 208f / 255f);

            for (x = Xmin; x <= Xmax; x += c)
            {
                x = MathF.Round(x, 3);
                y = hyperbole.b * MathF.Sqrt((((x * x) / (hyperbole.a * hyperbole.a)) - 1));

                if (y > Ymax || y < Ymin)
                {
                    _x = x;
                    _y = y;

                    continue;
                }

                if (x > Xmin + c)
                {
                    glVertex2d(_x, _y);
                    glVertex2d(x, y);

                    glVertex2d(_x, -_y);
                    glVertex2d(x, -y);

                    DrawPoint(new PointLine(_x, _y), new PointLine(x, y));
                    DrawPoint(new PointLine(_x, -_y), new PointLine(x, -y));
                }

                _x = x;
                _y = y;
            }

            glEnd();
        }
    }
}

