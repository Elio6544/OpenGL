
namespace Lab_3
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
            XInterval_panel = new System.Windows.Forms.Panel();
            Xmax_numeric = new System.Windows.Forms.NumericUpDown();
            Xmin_numeric = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            YInterval_panel = new System.Windows.Forms.Panel();
            Ymanual_panel = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            Ymax_numeric = new System.Windows.Forms.NumericUpDown();
            Ymin_numeric = new System.Windows.Forms.NumericUpDown();
            Yauto_cb = new System.Windows.Forms.CheckBox();
            label6 = new System.Windows.Forms.Label();
            function_panel = new System.Windows.Forms.Panel();
            points_numeric = new System.Windows.Forms.NumericUpDown();
            funcTwo_rb = new System.Windows.Forms.RadioButton();
            label7 = new System.Windows.Forms.Label();
            funcOne_rb = new System.Windows.Forms.RadioButton();
            label9 = new System.Windows.Forms.Label();
            grid_panel = new System.Windows.Forms.Panel();
            step_numeric = new System.Windows.Forms.NumericUpDown();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            XInterval_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Xmax_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Xmin_numeric).BeginInit();
            YInterval_panel.SuspendLayout();
            Ymanual_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Ymax_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ymin_numeric).BeginInit();
            function_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)points_numeric).BeginInit();
            grid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)step_numeric).BeginInit();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.autoSizeY = false;
            renderControl1.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            renderControl1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            renderControl1.ForeColor = System.Drawing.Color.Black;
            renderControl1.funcIndex = 1;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.Name = "renderControl1";
            renderControl1.points = 1000;
            renderControl1.Size = new System.Drawing.Size(750, 668);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 65001;
            renderControl1.Ymax_numeric = null;
            renderControl1.Ymin_numeric = null;
            // 
            // XInterval_panel
            // 
            XInterval_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            XInterval_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            XInterval_panel.Controls.Add(Xmax_numeric);
            XInterval_panel.Controls.Add(Xmin_numeric);
            XInterval_panel.Controls.Add(label2);
            XInterval_panel.Controls.Add(label3);
            XInterval_panel.Controls.Add(label1);
            XInterval_panel.Location = new System.Drawing.Point(768, 12);
            XInterval_panel.Name = "XInterval_panel";
            XInterval_panel.Size = new System.Drawing.Size(316, 160);
            XInterval_panel.TabIndex = 1;
            // 
            // Xmax_numeric
            // 
            Xmax_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            Xmax_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Xmax_numeric.DecimalPlaces = 1;
            Xmax_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Xmax_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            Xmax_numeric.Location = new System.Drawing.Point(104, 105);
            Xmax_numeric.Name = "Xmax_numeric";
            Xmax_numeric.Size = new System.Drawing.Size(164, 26);
            Xmax_numeric.TabIndex = 4;
            Xmax_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Xmax_numeric.Value = new decimal(new int[] { 3, 0, 0, 0 });
            Xmax_numeric.ValueChanged += Xmax_numeric_ValueChanged;
            // 
            // Xmin_numeric
            // 
            Xmin_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            Xmin_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Xmin_numeric.DecimalPlaces = 1;
            Xmin_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Xmin_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            Xmin_numeric.Location = new System.Drawing.Point(104, 64);
            Xmin_numeric.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            Xmin_numeric.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            Xmin_numeric.Name = "Xmin_numeric";
            Xmin_numeric.Size = new System.Drawing.Size(164, 26);
            Xmin_numeric.TabIndex = 2;
            Xmin_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Xmin_numeric.Value = new decimal(new int[] { 3, 0, 0, int.MinValue });
            Xmin_numeric.ValueChanged += Xmin_numeric_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label2.Location = new System.Drawing.Point(38, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 22);
            label2.TabIndex = 2;
            label2.Text = "X min";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label3.Location = new System.Drawing.Point(38, 104);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 22);
            label3.TabIndex = 3;
            label3.Text = "X max";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label1.Location = new System.Drawing.Point(68, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(164, 32);
            label1.TabIndex = 2;
            label1.Text = "X interval";
            // 
            // YInterval_panel
            // 
            YInterval_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            YInterval_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            YInterval_panel.Controls.Add(Ymanual_panel);
            YInterval_panel.Controls.Add(Yauto_cb);
            YInterval_panel.Controls.Add(label6);
            YInterval_panel.Location = new System.Drawing.Point(768, 178);
            YInterval_panel.Name = "YInterval_panel";
            YInterval_panel.Size = new System.Drawing.Size(316, 182);
            YInterval_panel.TabIndex = 5;
            // 
            // Ymanual_panel
            // 
            Ymanual_panel.BackColor = System.Drawing.Color.Transparent;
            Ymanual_panel.Controls.Add(label4);
            Ymanual_panel.Controls.Add(label5);
            Ymanual_panel.Controls.Add(Ymax_numeric);
            Ymanual_panel.Controls.Add(Ymin_numeric);
            Ymanual_panel.Location = new System.Drawing.Point(38, 50);
            Ymanual_panel.Name = "Ymanual_panel";
            Ymanual_panel.Size = new System.Drawing.Size(240, 84);
            Ymanual_panel.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label4.Location = new System.Drawing.Point(3, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 22);
            label4.TabIndex = 2;
            label4.Text = "Y min";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label5.Location = new System.Drawing.Point(3, 49);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 22);
            label5.TabIndex = 3;
            label5.Text = "Y max";
            // 
            // Ymax_numeric
            // 
            Ymax_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            Ymax_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Ymax_numeric.DecimalPlaces = 1;
            Ymax_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Ymax_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            Ymax_numeric.Location = new System.Drawing.Point(69, 50);
            Ymax_numeric.Name = "Ymax_numeric";
            Ymax_numeric.Size = new System.Drawing.Size(164, 26);
            Ymax_numeric.TabIndex = 4;
            Ymax_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Ymax_numeric.Value = new decimal(new int[] { 3, 0, 0, 0 });
            Ymax_numeric.ValueChanged += Ymax_numeric_ValueChanged;
            // 
            // Ymin_numeric
            // 
            Ymin_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            Ymin_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Ymin_numeric.DecimalPlaces = 1;
            Ymin_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Ymin_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            Ymin_numeric.Location = new System.Drawing.Point(69, 9);
            Ymin_numeric.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            Ymin_numeric.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            Ymin_numeric.Name = "Ymin_numeric";
            Ymin_numeric.Size = new System.Drawing.Size(164, 26);
            Ymin_numeric.TabIndex = 2;
            Ymin_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Ymin_numeric.Value = new decimal(new int[] { 3, 0, 0, int.MinValue });
            Ymin_numeric.ValueChanged += Ymin_numeric_ValueChanged;
            // 
            // Yauto_cb
            // 
            Yauto_cb.AutoSize = true;
            Yauto_cb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Yauto_cb.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            Yauto_cb.Location = new System.Drawing.Point(113, 140);
            Yauto_cb.Name = "Yauto_cb";
            Yauto_cb.Size = new System.Drawing.Size(119, 26);
            Yauto_cb.TabIndex = 5;
            Yauto_cb.Text = "auto size";
            Yauto_cb.UseVisualStyleBackColor = true;
            Yauto_cb.CheckedChanged += Yauto_cb_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label6.Location = new System.Drawing.Point(68, 15);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(164, 32);
            label6.TabIndex = 2;
            label6.Text = "Y interval";
            // 
            // function_panel
            // 
            function_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            function_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            function_panel.Controls.Add(points_numeric);
            function_panel.Controls.Add(funcTwo_rb);
            function_panel.Controls.Add(label7);
            function_panel.Controls.Add(funcOne_rb);
            function_panel.Controls.Add(label9);
            function_panel.Location = new System.Drawing.Point(768, 366);
            function_panel.Name = "function_panel";
            function_panel.Size = new System.Drawing.Size(316, 151);
            function_panel.TabIndex = 6;
            // 
            // points_numeric
            // 
            points_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            points_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            points_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            points_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            points_numeric.Location = new System.Drawing.Point(104, 104);
            points_numeric.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            points_numeric.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            points_numeric.Name = "points_numeric";
            points_numeric.Size = new System.Drawing.Size(164, 26);
            points_numeric.TabIndex = 6;
            points_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            points_numeric.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            points_numeric.ValueChanged += points_numeric_ValueChanged;
            // 
            // funcTwo_rb
            // 
            funcTwo_rb.AutoSize = true;
            funcTwo_rb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            funcTwo_rb.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            funcTwo_rb.Location = new System.Drawing.Point(180, 58);
            funcTwo_rb.Name = "funcTwo_rb";
            funcTwo_rb.Size = new System.Drawing.Size(88, 26);
            funcTwo_rb.TabIndex = 4;
            funcTwo_rb.Text = "F(x) 2";
            funcTwo_rb.UseVisualStyleBackColor = true;
            funcTwo_rb.CheckedChanged += funcTwo_rb_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label7.Location = new System.Drawing.Point(28, 104);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 22);
            label7.TabIndex = 7;
            label7.Text = "points";
            // 
            // funcOne_rb
            // 
            funcOne_rb.AutoSize = true;
            funcOne_rb.Checked = true;
            funcOne_rb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            funcOne_rb.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            funcOne_rb.Location = new System.Drawing.Point(28, 58);
            funcOne_rb.Name = "funcOne_rb";
            funcOne_rb.Size = new System.Drawing.Size(88, 26);
            funcOne_rb.TabIndex = 3;
            funcOne_rb.TabStop = true;
            funcOne_rb.Text = "F(x) 1";
            funcOne_rb.UseVisualStyleBackColor = true;
            funcOne_rb.CheckedChanged += funcOne_rb_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label9.Location = new System.Drawing.Point(87, 12);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(134, 32);
            label9.TabIndex = 2;
            label9.Text = "function";
            // 
            // grid_panel
            // 
            grid_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            grid_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            grid_panel.Controls.Add(step_numeric);
            grid_panel.Controls.Add(label8);
            grid_panel.Controls.Add(label10);
            grid_panel.Location = new System.Drawing.Point(768, 523);
            grid_panel.Name = "grid_panel";
            grid_panel.Size = new System.Drawing.Size(316, 123);
            grid_panel.TabIndex = 8;
            // 
            // step_numeric
            // 
            step_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            step_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            step_numeric.DecimalPlaces = 1;
            step_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            step_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            step_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            step_numeric.Location = new System.Drawing.Point(104, 68);
            step_numeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            step_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            step_numeric.Name = "step_numeric";
            step_numeric.Size = new System.Drawing.Size(164, 26);
            step_numeric.TabIndex = 6;
            step_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            step_numeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            step_numeric.ValueChanged += step_numeric_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label8.Location = new System.Drawing.Point(48, 72);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(50, 22);
            label8.TabIndex = 7;
            label8.Text = "step";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label10.Location = new System.Drawing.Point(113, 14);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(74, 32);
            label10.TabIndex = 2;
            label10.Text = "grid";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(52, 49, 49);
            ClientSize = new System.Drawing.Size(1096, 692);
            Controls.Add(grid_panel);
            Controls.Add(function_panel);
            Controls.Add(YInterval_panel);
            Controls.Add(XInterval_panel);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Lab 3";
            Load += MainForm_Load;
            XInterval_panel.ResumeLayout(false);
            XInterval_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Xmax_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)Xmin_numeric).EndInit();
            YInterval_panel.ResumeLayout(false);
            YInterval_panel.PerformLayout();
            Ymanual_panel.ResumeLayout(false);
            Ymanual_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Ymax_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ymin_numeric).EndInit();
            function_panel.ResumeLayout(false);
            function_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)points_numeric).EndInit();
            grid_panel.ResumeLayout(false);
            grid_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)step_numeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.Panel XInterval_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Xmax_numeric;
        private System.Windows.Forms.NumericUpDown Xmin_numeric;
        private System.Windows.Forms.Panel YInterval_panel;
        private System.Windows.Forms.NumericUpDown Ymax_numeric;
        private System.Windows.Forms.NumericUpDown Ymin_numeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Yauto_cb;
        private System.Windows.Forms.Panel function_panel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton funcOne_rb;
        private System.Windows.Forms.RadioButton funcTwo_rb;
        private System.Windows.Forms.NumericUpDown points_numeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel grid_panel;
        private System.Windows.Forms.NumericUpDown step_numeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel Ymanual_panel;
    }
}

