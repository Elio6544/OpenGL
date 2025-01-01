﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpenGL_Lab_6
{
    public partial class RenderControl : OpenGL
    {
        private float size = 1.5f;
        private float AspectRatio { get => (float)Width / Height; }

        private float Xmin { get => (AspectRatio > 1) ? -size * AspectRatio : -size; }
        private float Xmax { get => (AspectRatio > 1) ? +size * AspectRatio : +size; }
        private float Ymin { get => (AspectRatio < 1) ? -size / AspectRatio : -size; }
        private float Ymax { get => (AspectRatio < 1) ? +size / AspectRatio : +size; }
        private float Zmin { get => -size; }
        private float Zmax { get => +size; }

        private float angleX;
        private float angleY;
        private float m;

        private float a = 0.3f;
        private float b = 0.5f;
        
        private float aw;

        private float theta
        {
            get { return 180f / MathF.PI * MathF.Acos((a * a + S * S - b * b) / (2 * a * S)); }
        }

        private float psi
        {
            get { return 180f / MathF.PI * MathF.Acos((a*a + b*b - S*S) / (2 * a * b)); }
        }

        private float phi;

        private float s = 0.2f;
        private float S
        {
            get { return s; }
            set { if ((value > (b - a)) && (value < (2 * a))) s = value; }
        }

        public RenderControl()
        {
            InitializeComponent();
            MouseWheel += OnMouseWheel;
        }

        private void OnStart(object sender, EventArgs e)
        {
            angleX = 0f;
            angleY = 0f;
            m = 1f;

            S = b;

            phi = 15.0f;
            aw = 0f;
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);

            glOrtho(Xmin, Xmax, Ymin, Ymax, Zmin, Zmax);

            glRotated(angleX, 1, 0, 0);
            glRotated(angleY, 0, 1, 0);
            glScaled(m, m, m);

            // Enable depth
            glEnable(GL_DEPTH_TEST);

            DrawAxis();

            DrawGridXY();
            DrawGridYZ();
            DrawGridZX();

            glRotated(aw, 0f, -1f, 0f);

            // first line
            glRotated(phi, 0f, 0f, -1f);
            Segment(2 * a, 0.05f, 1f, 0f, 0f);

            // second line
            glPushMatrix();
                glTranslated(0f, a, 0f);
                glRotated(-theta, 0f, 0f, -1f);
                Segment(2 * a, 0.04f, 0f, 1f, 0f);
            glPopMatrix();

            // third line
            glTranslated(0f, 2*a, 0f);
            glRotated(psi, 0f, 0f, -1f);
            Segment(-b, 0.05f, 0f, 0f, 1f);
            Segment(1.5f * b, 0.05f, 0f, 0f, 1f);
        }

        private void Segment(float height, float width, float r, float g, float b)
        {
            glColor3d(r, g, b);
            glLineWidth(5);

            glBegin(GL_LINES);
                glVertex3d(0f, 0f, -width);
                glVertex3d(0f, height, -width);

                glVertex3d(0f, 0f, width);
                glVertex3d(0f, height, width);

                glVertex3d(0f, 0f, -width);
                glVertex3d(0f, 0f, width);

                glVertex3d(0f, height, -width);
                glVertex3d(0f, height, width);
            glEnd();

            glLineWidth(1);
        }

        private float padding = 0.1f;
        private void DrawAxis()
        {
            glColor3d(238f / 255f, 223f / 255f, 122f / 255f);
            glLineWidth(1);

            glBegin(GL_LINES);
                glVertex3d(-padding, 0f, 0f);
                glVertex3d(1f, 0f, 0f);

                glVertex3d(0f, -padding, 0f);
                glVertex3d(0f, 1f, 0f);

                glVertex3d(0f, 0f, -padding);
                glVertex3d(0f, 0f, 1f);
            glEnd();

            DrawText("X", 1f, 0f, 0f);
            DrawText("Y", 0f, 1f, 0f);
            DrawText("Z", 0f, 0f, 1f);
        }

        private void DrawGridXY()
        {
            glColor3d(216f / 255f, 162f / 255f, 94f / 255f);
            glLineStipple(3, 21845);
            glEnable(GL_LINE_STIPPLE);
            glLineWidth(1);

            glBegin(GL_LINES);

            for (float value = 0; value <= 1f + padding; value += 0.1f)
            {
                glVertex3d(value, 0f, -padding);
                glVertex3d(value, 1f, -padding);

                glVertex3d(0f, value, -padding);
                glVertex3d(1f, value, -padding);
            }

            glEnd();
            glDisable(GL_LINE_STIPPLE);
        }

        private void DrawGridYZ()
        {
            glColor3d(216f / 255f, 162f / 255f, 94f / 255f);
            glLineStipple(3, 21845);
            glEnable(GL_LINE_STIPPLE);
            glLineWidth(1);

            glBegin(GL_LINES);

            for (float value = 0; value <= 1f + padding; value += 0.1f)
            {
                glVertex3d(-padding, value, 0f);
                glVertex3d(-padding, value, 1f);

                glVertex3d(-padding, 0f, value);
                glVertex3d(-padding, 1f, value);
            }

            glEnd();
            glDisable(GL_LINE_STIPPLE);
        }

        private void DrawGridZX()
        {
            glColor3d(216f / 255f, 162f / 255f, 94f / 255f);
            glLineStipple(3, 21845);
            glEnable(GL_LINE_STIPPLE);
            glLineWidth(1);

            glBegin(GL_LINES);

            for (float value = 0; value <= 1f + padding; value += 0.1f)
            {
                glVertex3d(value, -padding, 0f);
                glVertex3d(value, -padding, 1f);

                glVertex3d(0f, -padding, value);
                glVertex3d(1f, -padding, value);
            }

            glEnd();
            glDisable(GL_LINE_STIPPLE);
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    phi--;
                    break;

                case Keys.S:
                    phi++;
                    break;

                case Keys.E:
                    S += 0.01f;
                    break;

                case Keys.Q: 
                    S -= 0.01f; 
                    break;

                case Keys.A:
                    aw++;
                    break;

                case Keys.D:
                    aw--;
                    break;
            }

            Invalidate();
        }

        private bool mouseFlag = false;
        private Point mouseStart;

        private void OnMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            mouseFlag = e.Button == MouseButtons.Left;
            mouseStart = e.Location;
        }

        private void OnMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (mouseFlag)
                mouseFlag = !(e.Button == MouseButtons.Left);
        }

        private void OnMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
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

        private void OnMouseWheel(object sender, MouseEventArgs e)
        {
            m += e.Delta / 2000.0f;
            Invalidate();
        }
    }
}

