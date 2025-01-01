using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class RenderControl : OpenGL
    {
        private float size;
        private float AspectRatio { get => (float)Width / Height; }

        private float Xmin { get => (AspectRatio > 1) ? -size * AspectRatio : -size; }
        private float Xmax { get => (AspectRatio > 1) ? +size * AspectRatio : +size; }
        private float Ymin { get => (AspectRatio < 1) ? -size / AspectRatio : -size; }
        private float Ymax { get => (AspectRatio < 1) ? +size / AspectRatio : +size; }
        private float Zmin { get => -size; }
        private float Zmax { get => +size; }

        private float angleX;
        private float angleY;

        private float gridStep;
        private float gridMerge;

        private float _heigth;
        private float _width;

        private float segment;

        private uint gluMode;

        private float sphereRadius;

        private float coneHeight;
        private float coneRadius;
        private float coneSlice;

        private float innerRadius;
        private float outerRadius;

        private bool isPerspective;

        private uint idAxis;
        private IntPtr qObj;

        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnStart(object sender, EventArgs e)
        {
            size = 10.5f;

            angleY = 20.0f;
            angleX = 10.0f;

            gridStep = 1f;
            gridMerge = 0.5f;

            _heigth = size * 2;
            _width = size * 2;

            segment = 15.0f;

            gluMode = GLU_FILL;

            sphereRadius = 1.0f;

            coneHeight = 1.5f;
            coneRadius = 2.5f;
            coneSlice = 1.0f;

            innerRadius = 1.0f;
            outerRadius = 3.0f;

            isPerspective = false;

            idAxis = glGenLists(3);
            glNewList(idAxis, GL_COMPILE);

            DrawGrid();
            DrawAxis();
            DrawTextAxis();

            glEndList();

            qObj = gluNewQuadric();
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);

            // Устанавливаем проекцию
            SetProjection();

            if (isPerspective)
            {
                // Для перспективной проекции добавляем отступ камеры назад
                glTranslatef(0, 0, -size * 3);
            }

            glRotated(angleX, 1, 0, 0);
            glRotated(angleY, 0, 1, 0);

            // Enable depth
            glEnable(GL_DEPTH_TEST);

            gluQuadricDrawStyle(qObj, gluMode);

            // Draw system coorditane
            glCallList(idAxis);

            glEnable(GL_COLOR_MATERIAL);
            glEnable(GL_LIGHTING);
            glEnable(GL_LIGHT0);
            glLightfv(GL_LIGHT0, GL_POSITION, new float[] { size, size, size, 0 });

            //Draw figures
            DrawSphere();
            DrawConus();
            DrawDisk();

            glDisable(GL_LIGHTING);
        }

        private void OnDestroy(object sender, EventArgs e)
        {
            gluDeleteQuadric(qObj);
        }

        private bool mouseFlag = false;
        private Point mouseStart;
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            mouseFlag = e.Button == MouseButtons.Left;
            mouseStart = e.Location;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (mouseFlag)
            {
                Point current = e.Location;
                angleX += (current.Y - mouseStart.Y) / 2.0f;
                angleY += (current.X - mouseStart.X) / 2.0f;
                mouseStart = current;
                Invalidate();
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (mouseFlag)
                mouseFlag = !(e.Button == MouseButtons.Left);
        }

        private void DrawAxis()
        {
            glLineWidth(2);

            glBegin(GL_LINES);
            glColor3d(238f / 255f, 223f / 255f, 122f / 255f);

            // X axis
            glVertex3d(-size + gridMerge, 0.0f, 0.0f);
            glVertex3d(size - gridMerge, 0.0f, 0.0f);

            float _start = gridStep * (((-size + gridMerge) / gridStep) % 1);

            // draw lines
            for (float colum = _start; colum < _width - gridMerge; colum += gridStep)
            {
                glVertex3d(-size + gridMerge + colum, 0f, 0f);
                glVertex3d(-size + gridMerge + colum, -gridStep / 3, 0f);
            }

            // Y axis
            glVertex3d(0.0f, -size + gridMerge, 0.0f);
            glVertex3d(0.0f, size - gridMerge, 0.0f);

            _start = gridStep * (((size - gridMerge) / gridStep) % 1);

            // draw lines
            for (float row = _start; row < _heigth - gridMerge; row += gridStep)
            {
                glVertex3d(-gridStep / 3, size - gridMerge - row, 0f);
                glVertex3d(0f, size - gridMerge - row, 0f);
            }

            // Z axis
            glVertex3d(0.0f, 0.0f, -size + gridMerge);
            glVertex3d(0.0f, 0.0f, size - gridMerge);

            _start = gridStep * (((size - gridMerge) / gridStep) % 1);

            // draw lines
            for (float row = _start; row < _heigth - gridMerge; row += gridStep)
            {
                glVertex3d(-gridStep / 3, 0f, size - gridMerge - row);
                glVertex3d(0f, 0f, size - gridMerge - row);
            }

            glEnd();
        }

        private void DrawTextAxis()
        {
            // draw text axis
            DrawText("+X", size, 0, 0);
            DrawText("+Y", 0, size, 0);
            DrawText("+Z", 0, 0, size);

            glColor3d(238f / 255f, 223f / 255f, 122f / 255f);

            // Z axis
            float _start = gridStep * (((-size) / gridStep) % 1);
            for (float colum = _start + gridStep; colum < _width; colum += gridStep)
            {
                if (-size + colum >= 0.1f || -size + colum <= -0.1f)
                {
                    DrawText((-size + colum).ToString("F1"), 0f, -gridStep / 2, -size + colum);
                }
            }

            // Y axis
            _start = gridStep * ((size / gridStep) % 1);
            for (float row = _start; row < _heigth; row += gridStep)
            {
                if (size - row >= 0.1f || size - row <= -0.1f)
                {
                    DrawText((size - row).ToString("F1"), -gridStep / 2, size - row, 0f);
                }
            }

            // X axis
            _start = gridStep * ((size / gridStep) % 1);
            for (float row = _start; row < _heigth; row += gridStep)
            {
                if (size - row >= 0.1f || size - row <= -0.1f)
                {
                    DrawText((size - row).ToString("F1"), size - row, -gridStep / 2, 0f);
                }
            }

            // 0
            DrawText((0).ToString(), -gridStep / 2.5f, -gridStep / 2.5f);

        }

        private void DrawGrid()
        {
            glLineWidth(1);

            glBegin(GL_LINES);
            glColor3d(216f / 255f, 162f / 255f, 94f / 255f);

            float _start = gridStep * ((size / gridStep) % 1) + gridMerge;

            // draw Y lines
            for (float row = _start; row < _heigth - gridMerge * 2; row += gridStep)
            {
                glVertex3d(0.0f, size - row - gridMerge, size - gridMerge);
                glVertex3d(0.0f, size - row - gridMerge, -size + gridMerge);
            }

            _start = gridStep * ((size / gridStep) % 1) + gridMerge;

            // draw Z lines
            for (float colum = _start; colum < _width - gridMerge * 2; colum += gridStep)
            {
                glVertex3d(0.0f, -size + gridMerge, size - colum - gridMerge);
                glVertex3d(0.0f, size - gridMerge, size - colum - gridMerge);
            }

            glEnd();
        }

        private void SetProjection()
        {
            // Переходим на матрицу проекции и сбрасываем её
            glMatrixMode(GL_PROJECTION);
            glLoadIdentity();

            if (isPerspective)
            {
                // Настройка перспективной проекции
                float fieldOfView = 45.0f;
                float nearClip = 0.1f;
                float farClip = 100.0f;
                gluPerspective(fieldOfView, AspectRatio, nearClip, farClip);
            }
            else
            {
                // Настройка ортогональной проекции
                glOrtho(Xmin, Xmax, Ymin, Ymax, Zmin, Zmax);
            }

            // Возвращаемся к матрице модели
            glMatrixMode(GL_MODELVIEW);
            glLoadIdentity();
        }

        private void DrawDisk()
        {
            glPushMatrix();

            float x0 = 4.5f;
            float y0 = 2.5f;
            float z0 = 2.5f;

            glTranslatef(x0, y0, z0);

            glColor3d(78f / 255f, 81f / 255f, 140f / 255f);
            gluDisk(qObj, innerRadius, outerRadius, (int)segment, (int)segment);

            glPopMatrix();
        }

        private void DrawConus()
        {
            glPushMatrix();

            float x0 = -3.5f;
            float y0 = 2.5f;
            float z0 = -2.0f;

            float slice = coneHeight - coneSlice;

            // slice
            glClipPlane(GL_CLIP_PLANE0, new double[] { 0, 0, -(z0 / z0), -(z0 / z0) * -(z0 + slice) });
            glEnable(GL_CLIP_PLANE0);

            glTranslatef(x0, y0, z0);
            glColor3d(255f / 255f, 237f / 255f, 0f / 255f);
            gluCylinder(qObj, coneRadius, 0.0f, coneHeight, (int)segment, (int)segment);

            glDisable(GL_CLIP_PLANE0);

            glPopMatrix();

        }

        private void DrawSphere()
        {
            glPushMatrix();

            float x0 = 2.0f;
            float y0 = 2.0f;
            float z0 = 3.5f;

            glTranslatef(x0, y0, z0);

            glColor3d(201f / 255f, 160f / 255f, 220f / 255f);
            gluSphere(qObj, sphereRadius, (int)segment, (int)segment);

            glPopMatrix();
        }

        public void SetSegments(int _segment)
        {
            segment = _segment;

            Invalidate();
        }

        public void SetDrawMode(uint _gluMode)
        {
            gluMode = _gluMode;

            Invalidate();
        }

        public void SetRenderMode(bool _isPerspective)
        {
            isPerspective = _isPerspective;

            Invalidate();
        }

        public void SetSphereRadius(float _radius)
        {
            sphereRadius = _radius;

            Invalidate();
        }

        public void SetConeRadius(float _radius)
        {
            coneRadius = _radius;

            Invalidate();
        }

        public void SetConeHeight(float _height)
        {
            coneHeight = _height;

            Invalidate();
        }

        public void SetConeSlice(float _slice)
        {
            coneSlice = _slice;

            Invalidate();
        }

        public void SetDiskInnerRadius(float _radius)
        {
            innerRadius = _radius;

            Invalidate();
        }

        public void SetDiskOuterRadius(float _radius)
        {
            outerRadius = _radius;

            Invalidate();
        }
    }
}

