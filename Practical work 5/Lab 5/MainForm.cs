using System.Windows.Forms;
using static Lab_5.OpenGL;


namespace Lab_5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void segments_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetSegments((int)segments_numeric.Value);
        }

        private void fillMode_rb_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetDrawMode(GLU_FILL);
        }

        private void lineMode_rb_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetDrawMode(GLU_LINE);
        }

        private void orthoMode_rb_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetRenderMode(false);
        }

        private void perspectiveMode_rb_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetRenderMode(true);
        }

        private void sphereRadius_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetSphereRadius((float)sphereRadius_numeric.Value);
        }

        private void coneRadius_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetConeRadius((float)coneRadius_numeric.Value);
        }

        private void coneHeight_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetConeHeight((float)coneHeight_numeric.Value);

            coneSlice_numeric.Maximum = coneHeight_numeric.Value - coneSlice_numeric.Increment;
        }

        private void diskInnerRadius_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetDiskInnerRadius((float)diskInnerRadius_numeric.Value);

            diskOuterRadius_numeric.Minimum = diskInnerRadius_numeric.Value + (decimal)0.1f;
        }

        private void diskOuterRadius_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetDiskOuterRadius((float)diskOuterRadius_numeric.Value);

            diskInnerRadius_numeric.Maximum = diskOuterRadius_numeric.Value - (decimal)0.1f;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        private void coneSlice_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetConeSlice((float)coneSlice_numeric.Value);
        }
    }
}
