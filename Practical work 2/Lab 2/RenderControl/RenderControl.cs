using System;

namespace Lab_2
{
    public partial class RenderControl : OpenGL
    {
        private WindowSize windowSize;
        private float sideWindow;

        public DrawFigures figures { get; set; }
        
        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnStart(object sender, EventArgs e)
        {
            sideWindow = 20f;
            windowSize = new WindowSize(-sideWindow, sideWindow, -sideWindow, sideWindow);

            figures = new DrawFigures(windowSize);
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            // Устанавливаем квадратную область просмотра, сохраняя пропорции
            if (Width > Height)
            {
                // Если ширина больше высоты, центрируем по горизонтали
                glViewport((Width - Height) / 2, 0, Height, Height);
            }
            else
            {
                // Если высота больше ширины, центрируем по вертикали
                glViewport(0, (Height - Width) / 2, Width, Width);
            }

            glOrtho(windowSize.Xmin, windowSize.Xmax, windowSize.Ymin, windowSize.Ymax, -1, 1);

            figures.Draw();
        }

        public void UpdateSideWindow()
        {
            float _hor = figures.horCount * figures.sideFigure * 2.5f;
            float _ver = figures.verCount * (figures.sideFigure * MathF.Sqrt(3));

            if (_hor > _ver)
            {
                sideWindow = _hor / 2 + 5;
            }
            else
            {
                sideWindow = _ver / 2 + 10 + (figures.sideFigure * MathF.Sqrt(3)) / 2;
            }

            windowSize = new WindowSize(-sideWindow, sideWindow, -sideWindow, sideWindow);
            figures.SetWindowSize(windowSize);

            Invalidate();
        }
    }
}

