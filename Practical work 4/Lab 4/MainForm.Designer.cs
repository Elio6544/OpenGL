
namespace Lab_4
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            renderControl1 = new RenderControl();
            curve_panel = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            curve_cb = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            circle_panel = new System.Windows.Forms.Panel();
            circle_radius_numeric = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            line_panel = new System.Windows.Forms.Panel();
            point2_y_numeric = new System.Windows.Forms.NumericUpDown();
            point1_x_numeric = new System.Windows.Forms.NumericUpDown();
            point1_y_numeric = new System.Windows.Forms.NumericUpDown();
            point2_x_numeric = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            hyperbole_panel = new System.Windows.Forms.Panel();
            hyp_b_numeric = new System.Windows.Forms.NumericUpDown();
            label9 = new System.Windows.Forms.Label();
            hyp_a_numeric = new System.Windows.Forms.NumericUpDown();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            curve_panel.SuspendLayout();
            circle_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circle_radius_numeric).BeginInit();
            line_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)point2_y_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)point1_x_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)point1_y_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)point2_x_numeric).BeginInit();
            hyperbole_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hyp_b_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hyp_a_numeric).BeginInit();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(698, 584);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 65001;
            // 
            // curve_panel
            // 
            curve_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            curve_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            curve_panel.Controls.Add(label2);
            curve_panel.Controls.Add(curve_cb);
            curve_panel.Controls.Add(label1);
            curve_panel.Location = new System.Drawing.Point(716, 12);
            curve_panel.Name = "curve_panel";
            curve_panel.Size = new System.Drawing.Size(277, 120);
            curve_panel.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label2.Location = new System.Drawing.Point(18, 75);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 22);
            label2.TabIndex = 4;
            label2.Text = "curve";
            // 
            // curve_cb
            // 
            curve_cb.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            curve_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            curve_cb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            curve_cb.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            curve_cb.FormattingEnabled = true;
            curve_cb.Items.AddRange(new object[] { "circle", "hyperbole" });
            curve_cb.Location = new System.Drawing.Point(95, 72);
            curve_cb.Name = "curve_cb";
            curve_cb.Size = new System.Drawing.Size(160, 30);
            curve_cb.TabIndex = 3;
            curve_cb.Text = "circle";
            curve_cb.SelectedIndexChanged += curve_cb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label1.Location = new System.Drawing.Point(51, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 32);
            label1.TabIndex = 2;
            label1.Text = "curve graph";
            // 
            // circle_panel
            // 
            circle_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            circle_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            circle_panel.Controls.Add(circle_radius_numeric);
            circle_panel.Controls.Add(label3);
            circle_panel.Controls.Add(label4);
            circle_panel.Location = new System.Drawing.Point(716, 138);
            circle_panel.Name = "circle_panel";
            circle_panel.Size = new System.Drawing.Size(277, 120);
            circle_panel.TabIndex = 5;
            // 
            // circle_radius_numeric
            // 
            circle_radius_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            circle_radius_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            circle_radius_numeric.DecimalPlaces = 1;
            circle_radius_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            circle_radius_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            circle_radius_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            circle_radius_numeric.Location = new System.Drawing.Point(95, 74);
            circle_radius_numeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            circle_radius_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            circle_radius_numeric.Name = "circle_radius_numeric";
            circle_radius_numeric.Size = new System.Drawing.Size(160, 26);
            circle_radius_numeric.TabIndex = 5;
            circle_radius_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            circle_radius_numeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            circle_radius_numeric.ValueChanged += el_a_numeric_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label3.Location = new System.Drawing.Point(19, 78);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 22);
            label3.TabIndex = 4;
            label3.Text = "radius";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label4.Location = new System.Drawing.Point(84, 15);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(104, 32);
            label4.TabIndex = 2;
            label4.Text = "circle";
            // 
            // line_panel
            // 
            line_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            line_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            line_panel.Controls.Add(point2_y_numeric);
            line_panel.Controls.Add(point1_x_numeric);
            line_panel.Controls.Add(point1_y_numeric);
            line_panel.Controls.Add(point2_x_numeric);
            line_panel.Controls.Add(label6);
            line_panel.Controls.Add(label7);
            line_panel.Controls.Add(label8);
            line_panel.Enabled = false;
            line_panel.Location = new System.Drawing.Point(716, 264);
            line_panel.Name = "line_panel";
            line_panel.Size = new System.Drawing.Size(277, 163);
            line_panel.TabIndex = 8;
            // 
            // point2_y_numeric
            // 
            point2_y_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            point2_y_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            point2_y_numeric.DecimalPlaces = 1;
            point2_y_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            point2_y_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            point2_y_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            point2_y_numeric.Location = new System.Drawing.Point(178, 114);
            point2_y_numeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            point2_y_numeric.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            point2_y_numeric.Name = "point2_y_numeric";
            point2_y_numeric.Size = new System.Drawing.Size(77, 26);
            point2_y_numeric.TabIndex = 10;
            point2_y_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            point2_y_numeric.ValueChanged += point2_y_numeric_ValueChanged;
            // 
            // point1_x_numeric
            // 
            point1_x_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            point1_x_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            point1_x_numeric.DecimalPlaces = 1;
            point1_x_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            point1_x_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            point1_x_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            point1_x_numeric.Location = new System.Drawing.Point(95, 71);
            point1_x_numeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            point1_x_numeric.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            point1_x_numeric.Name = "point1_x_numeric";
            point1_x_numeric.Size = new System.Drawing.Size(77, 26);
            point1_x_numeric.TabIndex = 9;
            point1_x_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            point1_x_numeric.ValueChanged += point1_x_numeric_ValueChanged;
            // 
            // point1_y_numeric
            // 
            point1_y_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            point1_y_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            point1_y_numeric.DecimalPlaces = 1;
            point1_y_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            point1_y_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            point1_y_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            point1_y_numeric.Location = new System.Drawing.Point(178, 71);
            point1_y_numeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            point1_y_numeric.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            point1_y_numeric.Name = "point1_y_numeric";
            point1_y_numeric.Size = new System.Drawing.Size(77, 26);
            point1_y_numeric.TabIndex = 8;
            point1_y_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            point1_y_numeric.ValueChanged += point1_y_numeric_ValueChanged;
            // 
            // point2_x_numeric
            // 
            point2_x_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            point2_x_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            point2_x_numeric.DecimalPlaces = 1;
            point2_x_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            point2_x_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            point2_x_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            point2_x_numeric.Location = new System.Drawing.Point(95, 114);
            point2_x_numeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            point2_x_numeric.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            point2_x_numeric.Name = "point2_x_numeric";
            point2_x_numeric.Size = new System.Drawing.Size(77, 26);
            point2_x_numeric.TabIndex = 7;
            point2_x_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            point2_x_numeric.ValueChanged += point2_x_numeric_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label6.Location = new System.Drawing.Point(9, 118);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(80, 22);
            label6.TabIndex = 6;
            label6.Text = "point 2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label7.Location = new System.Drawing.Point(9, 75);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(80, 22);
            label7.TabIndex = 4;
            label7.Text = "point 1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label8.Location = new System.Drawing.Point(108, 14);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(74, 32);
            label8.TabIndex = 2;
            label8.Text = "line";
            // 
            // hyperbole_panel
            // 
            hyperbole_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            hyperbole_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            hyperbole_panel.Controls.Add(hyp_b_numeric);
            hyperbole_panel.Controls.Add(label9);
            hyperbole_panel.Controls.Add(hyp_a_numeric);
            hyperbole_panel.Controls.Add(label10);
            hyperbole_panel.Controls.Add(label11);
            hyperbole_panel.Enabled = false;
            hyperbole_panel.Location = new System.Drawing.Point(716, 433);
            hyperbole_panel.Name = "hyperbole_panel";
            hyperbole_panel.Size = new System.Drawing.Size(277, 162);
            hyperbole_panel.TabIndex = 8;
            // 
            // hyp_b_numeric
            // 
            hyp_b_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            hyp_b_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            hyp_b_numeric.DecimalPlaces = 1;
            hyp_b_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            hyp_b_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            hyp_b_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            hyp_b_numeric.Location = new System.Drawing.Point(95, 115);
            hyp_b_numeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            hyp_b_numeric.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            hyp_b_numeric.Name = "hyp_b_numeric";
            hyp_b_numeric.Size = new System.Drawing.Size(160, 26);
            hyp_b_numeric.TabIndex = 7;
            hyp_b_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            hyp_b_numeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            hyp_b_numeric.ValueChanged += par_k_numeric_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label9.Location = new System.Drawing.Point(41, 119);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(20, 22);
            label9.TabIndex = 6;
            label9.Text = "b";
            // 
            // hyp_a_numeric
            // 
            hyp_a_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            hyp_a_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            hyp_a_numeric.DecimalPlaces = 1;
            hyp_a_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            hyp_a_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            hyp_a_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            hyp_a_numeric.Location = new System.Drawing.Point(95, 72);
            hyp_a_numeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            hyp_a_numeric.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            hyp_a_numeric.Name = "hyp_a_numeric";
            hyp_a_numeric.Size = new System.Drawing.Size(160, 26);
            hyp_a_numeric.TabIndex = 5;
            hyp_a_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            hyp_a_numeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            hyp_a_numeric.ValueChanged += par_h_numeric_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label10.Location = new System.Drawing.Point(41, 76);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(20, 22);
            label10.TabIndex = 4;
            label10.Text = "a";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label11.Location = new System.Drawing.Point(69, 17);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(149, 32);
            label11.TabIndex = 2;
            label11.Text = "hyperbole";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(52, 49, 49);
            ClientSize = new System.Drawing.Size(1005, 608);
            Controls.Add(hyperbole_panel);
            Controls.Add(line_panel);
            Controls.Add(circle_panel);
            Controls.Add(curve_panel);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Lab 4";
            Load += MainForm_Load;
            curve_panel.ResumeLayout(false);
            curve_panel.PerformLayout();
            circle_panel.ResumeLayout(false);
            circle_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)circle_radius_numeric).EndInit();
            line_panel.ResumeLayout(false);
            line_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)point2_y_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)point1_x_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)point1_y_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)point2_x_numeric).EndInit();
            hyperbole_panel.ResumeLayout(false);
            hyperbole_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hyp_b_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)hyp_a_numeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.Panel curve_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox curve_cb;
        private System.Windows.Forms.Panel circle_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown circle_radius_numeric;
        private System.Windows.Forms.Panel line_panel;
        private System.Windows.Forms.NumericUpDown point2_x_numeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown point1_y_numeric;
        private System.Windows.Forms.NumericUpDown point2_y_numeric;
        private System.Windows.Forms.NumericUpDown point1_x_numeric;
        private System.Windows.Forms.Panel hyperbole_panel;
        private System.Windows.Forms.NumericUpDown hyp_b_numeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown hyp_a_numeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

