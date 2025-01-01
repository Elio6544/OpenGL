using System;

namespace Lab_1
{
    public partial class RenderControl : OpenGL
    {
        private float Xmin, Xmax;
        private float Ymin, Ymax;

        private DrawGrid _grid;
        private DrawFigure _figure;
        
        public RenderControl()
        {
            InitializeComponent();
        }

        private void Start(object sender, EventArgs e)
        {
            Xmin = -8.5f;
            Xmax = 0.5f;
            Ymin = -3.5f;
            Ymax = 0.5f;

            _grid = new DrawGrid(Xmin, Xmax, Ymin, Ymax);
            _figure = new DrawFigure(Xmin, Xmax, Ymin, Ymax);
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);

            glOrtho(Xmin - 2, Xmax + 2, Ymin - 2, Ymax + 2, -1, 1);

            _grid.Draw();

            glColor3d(216f / 255f, 162f / 255f, 94f / 255f);
            DrawText("X1", Xmin, Ymin - 1.5);
            DrawText("X2", Xmax, Ymin - 1.5);

            DrawText("Y1", Xmin - 1.5, Ymin);
            DrawText("Y2", Xmin - 1.5, Ymax);
            glColor3d(0, 0, 0);

            _figure.Draw();
        }
    }
}

