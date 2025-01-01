using Microsoft.Win32;
using System;
using System.Drawing;

namespace OpenGLLab7
{
    public partial class RenderControl : OpenGL
    {
        public RenderControl()
        {
            InitializeComponent();
        }

        float dy = 0.1f;
        float size = 30f;
        Color heartColor = Color.Crimson;

        private void OnContextCreated(object sender, EventArgs e)
        {
            // todo: 003 Загрузить настройки программы-заставки для основного режима работы
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\MyScreenSaver"))
            {
                if (key != null)
                {
                    if (key.GetValue("HeartColor") != null)
                        heartColor = Color.FromArgb((int)key.GetValue("HeartColor"));

                    if (key.GetValue("BackgroundColor") != null)
                        glClearColor(Color.FromArgb((int)key.GetValue("BackgroundColor")));

                    if (key.GetValue("Heartbeat") != null)
                        dy = (float)Convert.ToDecimal(key.GetValue("Heartbeat"));

                    if (key.GetValue("HeartSize") != null)
                        size = (float)Convert.ToDecimal(key.GetValue("HeartSize"));
                }
            }
        }

        float yleft = -1;
        private void OnRender(object sender, EventArgs e)
        {
            // todo: 004 Формирование изображения экранной заставки 
            // ...
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
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

            glOrtho(-1, 1, -1, 1, -1, 1);

            glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
            glColor3d(heartColor.R, heartColor.G, heartColor.B);
            glBegin(GL_POLYGON);
            
            float step = 0.01f;

            for (float t = 0; t < 2 * MathF.PI; t += step)
            {         
                float x1 = 16 * MathF.Pow(MathF.Sin(t), 3) / size;
                float y1 = (13 * MathF.Cos(t) - 5 * MathF.Cos(2 * t) - 2 * MathF.Cos(3 * t) - MathF.Cos(4 * t)) / size;

                float x2 = 16 * MathF.Pow(MathF.Sin(t + step), 3) / size;
                float y2 = (13 * MathF.Cos(t + step) - 5 * MathF.Cos(2 * (t + step)) - 2 * MathF.Cos(3 * (t + step)) - MathF.Cos(4 * (t + step))) / size;

                glVertex2d(x1, y1);
                glVertex2d(x2, y2);
            }

            glEnd();


            // todo: 005 Изменение параметра анимации/номера кадра 
            // ...
            if ((yleft >= 1) || (yleft <= -1)) dy = -dy;
            yleft -= dy;
            size += dy;
        }
    }
}

