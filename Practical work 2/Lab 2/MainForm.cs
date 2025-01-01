using System.Windows.Forms;
using static Lab_2.OpenGL;


namespace Lab_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void hor_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.figures.horCount = (int)hor_numeric.Value;
            renderControl1.UpdateSideWindow();
        }

        private void ver_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.figures.verCount = (int)ver_numeric.Value;
            renderControl1.UpdateSideWindow();
        }

        private void fillMode_rb_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.figures.polygonMode = GL_FILL;
            renderControl1.Invalidate();
        }

        private void lineMode_rb_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.figures.polygonMode = GL_LINE;
            renderControl1.Invalidate();
        }

        private void pointMode_rb_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.figures.polygonMode = GL_POINT;
            renderControl1.Invalidate();
        }

        private void smoothModel_rb_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.figures.shadeModel = GL_SMOOTH;
            renderControl1.Invalidate();
        }

        private void flatModel_rb_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.figures.shadeModel = GL_FLAT;
            renderControl1.Invalidate();
        }
    }
}
