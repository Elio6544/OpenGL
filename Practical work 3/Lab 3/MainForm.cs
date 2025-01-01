using System.Windows.Forms;
using static Lab_3.OpenGL;


namespace Lab_3
{
    public partial class MainForm : Form
    {
        private decimal step = (decimal)0.1f;

        public MainForm()
        {
            InitializeComponent();

            Xmax_numeric.Minimum = Xmin_numeric.Value + step;
            Xmin_numeric.Maximum = Xmax_numeric.Value - step;

            Ymax_numeric.Minimum = Ymin_numeric.Value + step;
            Ymin_numeric.Maximum = Ymax_numeric.Value - step;

            renderControl1.Ymax_numeric = Ymax_numeric;
            renderControl1.Ymin_numeric = Ymin_numeric;
        }

        private void Xmin_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.UpdateWindowSize(new WindowSize(
                                            (float)Xmin_numeric.Value,
                                            (float)Xmax_numeric.Value,
                                            (float)Ymin_numeric.Value,
                                            (float)Ymax_numeric.Value));

            Xmax_numeric.Minimum = Xmin_numeric.Value + step;
        }

        private void Xmax_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.UpdateWindowSize(new WindowSize(
                                            (float)Xmin_numeric.Value,
                                            (float)Xmax_numeric.Value,
                                            (float)Ymin_numeric.Value,
                                            (float)Ymax_numeric.Value));

            Xmin_numeric.Maximum = Xmax_numeric.Value - step;
        }

        private void Ymin_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.UpdateWindowSize(new WindowSize(
                                            (float)Xmin_numeric.Value,
                                            (float)Xmax_numeric.Value,
                                            (float)Ymin_numeric.Value,
                                            (float)Ymax_numeric.Value));

            Ymax_numeric.Minimum = Ymin_numeric.Value + step;
        }

        private void Ymax_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.UpdateWindowSize(new WindowSize(
                                            (float)Xmin_numeric.Value,
                                            (float)Xmax_numeric.Value,
                                            (float)Ymin_numeric.Value,
                                            (float)Ymax_numeric.Value));

            Ymin_numeric.Maximum = Ymax_numeric.Value - step;
        }

        private void Yauto_cb_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.UpdateFunctions((int)points_numeric.Value,
                                            Yauto_cb.Checked);

            if (Yauto_cb.Checked)
            {
                Ymanual_panel.Enabled = false;
            }
            else
            {
                Ymanual_panel.Enabled = true;
            }
        }

        private void funcOne_rb_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.funcIndex = 1;
            renderControl1.Invalidate();
        }

        private void funcTwo_rb_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.funcIndex = 2;
            renderControl1.Invalidate();
        }

        private void points_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.UpdateFunctions((int)points_numeric.Value,
                                            Yauto_cb.Checked);
        }

        private void step_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.UpdateConfig((float)step_numeric.Value);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
