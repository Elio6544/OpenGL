using System;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class RenderControl : OpenGL
    {
        public WindowSize windowSize;
        public DrawConfig drawConfig;

        private float _width;
        private float _height;

        public int points { set; get; }
        public int funcIndex { set; get; }
        public bool autoSizeY { set; get; }

        public NumericUpDown Ymin_numeric { set; get; }
        public NumericUpDown Ymax_numeric { set; get; }

        private DrawFuncOne funcOne;
        private DrawFuncTwo funcTwo;

        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnStart(object sender, EventArgs e)
        {
            windowSize = new WindowSize(-3f, 3f, -3f, 3f);

            _width = -windowSize.Xmin + windowSize.Xmax;    
            _height = -windowSize.Ymin + windowSize.Ymax;

            drawConfig = new DrawConfig(_width, _height, 0.2f, 1f);

            funcIndex = 1;
            autoSizeY = false;

            points = 1000;

            funcOne = new DrawFuncOne(windowSize, drawConfig, points, autoSizeY, Ymin_numeric, Ymax_numeric);
            funcTwo = new DrawFuncTwo(windowSize, drawConfig, points, autoSizeY, Ymin_numeric, Ymax_numeric);
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);

            glOrtho(windowSize.Xmin - drawConfig.margin, windowSize.Xmax + drawConfig.margin, 
                    windowSize.Ymin - drawConfig.margin, windowSize.Ymax + drawConfig.margin, 
                    -1, 1);

            switch(funcIndex)
            {
                case 1:
                    funcOne.DrawCoordinateSystem();
                    funcOne.DrawFunction();
                    break;

                case 2:
                    funcTwo.DrawCoordinateSystem();
                    funcTwo.DrawFunction();
                    break;
            }

            DrawTextAxis();
        }

        private void DrawTextAxis()
        {
            glColor3d(238f / 255f, 223f / 255f, 122f / 255f);

            // X axis
            float _start = drawConfig.step * (((-windowSize.Xmin) / drawConfig.step) % 1);
            for (float colum = _start; colum < _width + drawConfig.step; colum += drawConfig.step)
            {
                if ((windowSize.Xmin + colum != 0) && (windowSize.Xmin + colum >= windowSize.Xmin && windowSize.Xmin + colum <= windowSize.Xmax))
                {
                    DrawText((windowSize.Xmin + colum).ToString("F1"), windowSize.Xmin + colum, -drawConfig.step / 3);
                }
            }

            // Y axis
            _start = drawConfig.step * ((windowSize.Ymax / drawConfig.step) % 1);
            for (float row = _start; row < drawConfig.height + drawConfig.step; row += drawConfig.step)
            {
                if ((windowSize.Ymax - row != 0) && (windowSize.Ymax - row <= windowSize.Ymax && windowSize.Ymax - row >= windowSize.Ymin))
                {
                    DrawText((windowSize.Ymax - row).ToString("F1"), -drawConfig.step / 3, windowSize.Ymax - row);
                }
            }

            // 0
            DrawText((0).ToString("F1"), -drawConfig.step / 3, -drawConfig.step / 3);
        }

        public void UpdateWindowSize(WindowSize windowSize)
        {
            this.windowSize = windowSize;

            _width = -windowSize.Xmin + windowSize.Xmax;
            _height = -windowSize.Ymin + windowSize.Ymax;

            UpdateConfig(drawConfig.step);            
        }

        public void UpdateConfig(float step)
        {
            drawConfig = new DrawConfig(_width, _height, 0.2f, step);

            UpdateFunctions(points, autoSizeY);
        }

        public void UpdateFunctions(int points, bool autoSizeY)
        {
            this.points = points;
            this.autoSizeY = autoSizeY;
            
            funcOne = new DrawFuncOne(windowSize, drawConfig, points, autoSizeY, Ymin_numeric, Ymax_numeric);
            funcTwo = new DrawFuncTwo(windowSize, drawConfig, points, autoSizeY, Ymin_numeric, Ymax_numeric);

            Invalidate();
        }
    }
}

