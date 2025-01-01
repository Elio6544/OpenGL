
namespace Lab_5
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
            accurasy_panel = new System.Windows.Forms.Panel();
            segments_numeric = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            drawingMode_panel = new System.Windows.Forms.Panel();
            lineMode_rb = new System.Windows.Forms.RadioButton();
            fillMode_rb = new System.Windows.Forms.RadioButton();
            label3 = new System.Windows.Forms.Label();
            renderMode_panel = new System.Windows.Forms.Panel();
            perspectiveMode_rb = new System.Windows.Forms.RadioButton();
            label4 = new System.Windows.Forms.Label();
            orthoMode_rb = new System.Windows.Forms.RadioButton();
            sphere_panel = new System.Windows.Forms.Panel();
            sphereRadius_numeric = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            cone_panel = new System.Windows.Forms.Panel();
            coneSlice_numeric = new System.Windows.Forms.NumericUpDown();
            label13 = new System.Windows.Forms.Label();
            coneHeight_numeric = new System.Windows.Forms.NumericUpDown();
            label9 = new System.Windows.Forms.Label();
            coneRadius_numeric = new System.Windows.Forms.NumericUpDown();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            disk_panel = new System.Windows.Forms.Panel();
            diskOuterRadius_numeric = new System.Windows.Forms.NumericUpDown();
            label10 = new System.Windows.Forms.Label();
            diskInnerRadius_numeric = new System.Windows.Forms.NumericUpDown();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            accurasy_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)segments_numeric).BeginInit();
            drawingMode_panel.SuspendLayout();
            renderMode_panel.SuspendLayout();
            sphere_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sphereRadius_numeric).BeginInit();
            cone_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coneSlice_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coneHeight_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coneRadius_numeric).BeginInit();
            disk_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)diskOuterRadius_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diskInnerRadius_numeric).BeginInit();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            renderControl1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(874, 752);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 65001;
            // 
            // accurasy_panel
            // 
            accurasy_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            accurasy_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            accurasy_panel.Controls.Add(segments_numeric);
            accurasy_panel.Controls.Add(label2);
            accurasy_panel.Controls.Add(label1);
            accurasy_panel.Location = new System.Drawing.Point(892, 12);
            accurasy_panel.Name = "accurasy_panel";
            accurasy_panel.Size = new System.Drawing.Size(320, 125);
            accurasy_panel.TabIndex = 1;
            // 
            // segments_numeric
            // 
            segments_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            segments_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            segments_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            segments_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            segments_numeric.Location = new System.Drawing.Point(157, 74);
            segments_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            segments_numeric.Name = "segments_numeric";
            segments_numeric.Size = new System.Drawing.Size(129, 26);
            segments_numeric.TabIndex = 2;
            segments_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            segments_numeric.Value = new decimal(new int[] { 15, 0, 0, 0 });
            segments_numeric.ValueChanged += segments_numeric_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label2.Location = new System.Drawing.Point(28, 74);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 22);
            label2.TabIndex = 2;
            label2.Text = "segments";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label1.Location = new System.Drawing.Point(3, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(314, 33);
            label1.TabIndex = 2;
            label1.Text = "accurasy";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // drawingMode_panel
            // 
            drawingMode_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            drawingMode_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            drawingMode_panel.Controls.Add(lineMode_rb);
            drawingMode_panel.Controls.Add(fillMode_rb);
            drawingMode_panel.Controls.Add(label3);
            drawingMode_panel.Location = new System.Drawing.Point(892, 143);
            drawingMode_panel.Name = "drawingMode_panel";
            drawingMode_panel.Size = new System.Drawing.Size(157, 125);
            drawingMode_panel.TabIndex = 3;
            // 
            // lineMode_rb
            // 
            lineMode_rb.AutoSize = true;
            lineMode_rb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lineMode_rb.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            lineMode_rb.Location = new System.Drawing.Point(28, 87);
            lineMode_rb.Name = "lineMode_rb";
            lineMode_rb.Size = new System.Drawing.Size(68, 26);
            lineMode_rb.TabIndex = 5;
            lineMode_rb.Text = "line";
            lineMode_rb.UseVisualStyleBackColor = true;
            lineMode_rb.CheckedChanged += lineMode_rb_CheckedChanged;
            // 
            // fillMode_rb
            // 
            fillMode_rb.AutoSize = true;
            fillMode_rb.Checked = true;
            fillMode_rb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            fillMode_rb.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            fillMode_rb.Location = new System.Drawing.Point(28, 55);
            fillMode_rb.Name = "fillMode_rb";
            fillMode_rb.Size = new System.Drawing.Size(68, 26);
            fillMode_rb.TabIndex = 4;
            fillMode_rb.TabStop = true;
            fillMode_rb.Text = "fill";
            fillMode_rb.UseVisualStyleBackColor = true;
            fillMode_rb.CheckedChanged += fillMode_rb_CheckedChanged;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label3.Location = new System.Drawing.Point(3, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(151, 32);
            label3.TabIndex = 3;
            label3.Text = "drawing";
            label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // renderMode_panel
            // 
            renderMode_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            renderMode_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            renderMode_panel.Controls.Add(perspectiveMode_rb);
            renderMode_panel.Controls.Add(label4);
            renderMode_panel.Controls.Add(orthoMode_rb);
            renderMode_panel.Location = new System.Drawing.Point(1055, 143);
            renderMode_panel.Name = "renderMode_panel";
            renderMode_panel.Size = new System.Drawing.Size(157, 125);
            renderMode_panel.TabIndex = 4;
            // 
            // perspectiveMode_rb
            // 
            perspectiveMode_rb.AutoSize = true;
            perspectiveMode_rb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            perspectiveMode_rb.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            perspectiveMode_rb.Location = new System.Drawing.Point(10, 87);
            perspectiveMode_rb.Name = "perspectiveMode_rb";
            perspectiveMode_rb.Size = new System.Drawing.Size(138, 26);
            perspectiveMode_rb.TabIndex = 7;
            perspectiveMode_rb.Text = "perspective";
            perspectiveMode_rb.UseVisualStyleBackColor = true;
            perspectiveMode_rb.CheckedChanged += perspectiveMode_rb_CheckedChanged;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label4.Location = new System.Drawing.Point(3, 10);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(151, 32);
            label4.TabIndex = 4;
            label4.Text = "render";
            label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // orthoMode_rb
            // 
            orthoMode_rb.AutoSize = true;
            orthoMode_rb.Checked = true;
            orthoMode_rb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            orthoMode_rb.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            orthoMode_rb.Location = new System.Drawing.Point(10, 55);
            orthoMode_rb.Name = "orthoMode_rb";
            orthoMode_rb.Size = new System.Drawing.Size(78, 26);
            orthoMode_rb.TabIndex = 6;
            orthoMode_rb.TabStop = true;
            orthoMode_rb.Text = "ortho";
            orthoMode_rb.UseVisualStyleBackColor = true;
            orthoMode_rb.CheckedChanged += orthoMode_rb_CheckedChanged;
            // 
            // sphere_panel
            // 
            sphere_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            sphere_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            sphere_panel.Controls.Add(sphereRadius_numeric);
            sphere_panel.Controls.Add(label5);
            sphere_panel.Controls.Add(label6);
            sphere_panel.Location = new System.Drawing.Point(892, 274);
            sphere_panel.Name = "sphere_panel";
            sphere_panel.Size = new System.Drawing.Size(320, 125);
            sphere_panel.TabIndex = 3;
            // 
            // sphereRadius_numeric
            // 
            sphereRadius_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            sphereRadius_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            sphereRadius_numeric.DecimalPlaces = 1;
            sphereRadius_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            sphereRadius_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            sphereRadius_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            sphereRadius_numeric.Location = new System.Drawing.Point(157, 74);
            sphereRadius_numeric.Name = "sphereRadius_numeric";
            sphereRadius_numeric.Size = new System.Drawing.Size(129, 26);
            sphereRadius_numeric.TabIndex = 2;
            sphereRadius_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            sphereRadius_numeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            sphereRadius_numeric.ValueChanged += sphereRadius_numeric_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label5.Location = new System.Drawing.Point(48, 73);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 22);
            label5.TabIndex = 2;
            label5.Text = "radius";
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label6.Location = new System.Drawing.Point(3, 10);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(314, 33);
            label6.TabIndex = 2;
            label6.Text = "sphere";
            label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cone_panel
            // 
            cone_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            cone_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            cone_panel.Controls.Add(coneSlice_numeric);
            cone_panel.Controls.Add(label13);
            cone_panel.Controls.Add(coneHeight_numeric);
            cone_panel.Controls.Add(label9);
            cone_panel.Controls.Add(coneRadius_numeric);
            cone_panel.Controls.Add(label7);
            cone_panel.Controls.Add(label8);
            cone_panel.Location = new System.Drawing.Point(892, 405);
            cone_panel.Name = "cone_panel";
            cone_panel.Size = new System.Drawing.Size(320, 196);
            cone_panel.TabIndex = 4;
            // 
            // coneSlice_numeric
            // 
            coneSlice_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            coneSlice_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            coneSlice_numeric.DecimalPlaces = 1;
            coneSlice_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            coneSlice_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            coneSlice_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            coneSlice_numeric.Location = new System.Drawing.Point(157, 138);
            coneSlice_numeric.Maximum = new decimal(new int[] { 14, 0, 0, 65536 });
            coneSlice_numeric.Name = "coneSlice_numeric";
            coneSlice_numeric.Size = new System.Drawing.Size(129, 26);
            coneSlice_numeric.TabIndex = 5;
            coneSlice_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            coneSlice_numeric.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            coneSlice_numeric.ValueChanged += coneSlice_numeric_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label13.Location = new System.Drawing.Point(48, 138);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(60, 22);
            label13.TabIndex = 6;
            label13.Text = "slice";
            // 
            // coneHeight_numeric
            // 
            coneHeight_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            coneHeight_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            coneHeight_numeric.DecimalPlaces = 1;
            coneHeight_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            coneHeight_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            coneHeight_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            coneHeight_numeric.Location = new System.Drawing.Point(157, 106);
            coneHeight_numeric.Name = "coneHeight_numeric";
            coneHeight_numeric.Size = new System.Drawing.Size(129, 26);
            coneHeight_numeric.TabIndex = 3;
            coneHeight_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            coneHeight_numeric.Value = new decimal(new int[] { 15, 0, 0, 65536 });
            coneHeight_numeric.ValueChanged += coneHeight_numeric_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label9.Location = new System.Drawing.Point(48, 106);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(70, 22);
            label9.TabIndex = 4;
            label9.Text = "height";
            // 
            // coneRadius_numeric
            // 
            coneRadius_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            coneRadius_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            coneRadius_numeric.DecimalPlaces = 1;
            coneRadius_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            coneRadius_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            coneRadius_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            coneRadius_numeric.Location = new System.Drawing.Point(157, 74);
            coneRadius_numeric.Name = "coneRadius_numeric";
            coneRadius_numeric.Size = new System.Drawing.Size(129, 26);
            coneRadius_numeric.TabIndex = 2;
            coneRadius_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            coneRadius_numeric.Value = new decimal(new int[] { 25, 0, 0, 65536 });
            coneRadius_numeric.ValueChanged += coneRadius_numeric_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label7.Location = new System.Drawing.Point(48, 74);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 22);
            label7.TabIndex = 2;
            label7.Text = "radius";
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label8.Location = new System.Drawing.Point(3, 10);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(314, 33);
            label8.TabIndex = 2;
            label8.Text = "cone";
            label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // disk_panel
            // 
            disk_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            disk_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            disk_panel.Controls.Add(diskOuterRadius_numeric);
            disk_panel.Controls.Add(label10);
            disk_panel.Controls.Add(diskInnerRadius_numeric);
            disk_panel.Controls.Add(label11);
            disk_panel.Controls.Add(label12);
            disk_panel.Location = new System.Drawing.Point(892, 607);
            disk_panel.Name = "disk_panel";
            disk_panel.Size = new System.Drawing.Size(320, 157);
            disk_panel.TabIndex = 5;
            // 
            // diskOuterRadius_numeric
            // 
            diskOuterRadius_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            diskOuterRadius_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            diskOuterRadius_numeric.DecimalPlaces = 1;
            diskOuterRadius_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            diskOuterRadius_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            diskOuterRadius_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            diskOuterRadius_numeric.Location = new System.Drawing.Point(157, 106);
            diskOuterRadius_numeric.Name = "diskOuterRadius_numeric";
            diskOuterRadius_numeric.Size = new System.Drawing.Size(129, 26);
            diskOuterRadius_numeric.TabIndex = 3;
            diskOuterRadius_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            diskOuterRadius_numeric.Value = new decimal(new int[] { 3, 0, 0, 0 });
            diskOuterRadius_numeric.ValueChanged += diskOuterRadius_numeric_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label10.Location = new System.Drawing.Point(15, 105);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(130, 22);
            label10.TabIndex = 4;
            label10.Text = "outer radius";
            // 
            // diskInnerRadius_numeric
            // 
            diskInnerRadius_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            diskInnerRadius_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            diskInnerRadius_numeric.DecimalPlaces = 1;
            diskInnerRadius_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            diskInnerRadius_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            diskInnerRadius_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            diskInnerRadius_numeric.Location = new System.Drawing.Point(157, 74);
            diskInnerRadius_numeric.Name = "diskInnerRadius_numeric";
            diskInnerRadius_numeric.Size = new System.Drawing.Size(129, 26);
            diskInnerRadius_numeric.TabIndex = 2;
            diskInnerRadius_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            diskInnerRadius_numeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            diskInnerRadius_numeric.ValueChanged += diskInnerRadius_numeric_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label11.Location = new System.Drawing.Point(15, 73);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(130, 22);
            label11.TabIndex = 2;
            label11.Text = "inner radius";
            // 
            // label12
            // 
            label12.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label12.Location = new System.Drawing.Point(3, 10);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(314, 33);
            label12.TabIndex = 2;
            label12.Text = "disk";
            label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(52, 49, 49);
            ClientSize = new System.Drawing.Size(1224, 776);
            Controls.Add(disk_panel);
            Controls.Add(cone_panel);
            Controls.Add(sphere_panel);
            Controls.Add(renderMode_panel);
            Controls.Add(drawingMode_panel);
            Controls.Add(accurasy_panel);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Lab 5";
            Load += MainForm_Load;
            accurasy_panel.ResumeLayout(false);
            accurasy_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)segments_numeric).EndInit();
            drawingMode_panel.ResumeLayout(false);
            drawingMode_panel.PerformLayout();
            renderMode_panel.ResumeLayout(false);
            renderMode_panel.PerformLayout();
            sphere_panel.ResumeLayout(false);
            sphere_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sphereRadius_numeric).EndInit();
            cone_panel.ResumeLayout(false);
            cone_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coneSlice_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)coneHeight_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)coneRadius_numeric).EndInit();
            disk_panel.ResumeLayout(false);
            disk_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)diskOuterRadius_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)diskInnerRadius_numeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.Panel accurasy_panel;
        private System.Windows.Forms.NumericUpDown segments_numeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel drawingMode_panel;
        private System.Windows.Forms.Panel renderMode_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton lineMode_rb;
        private System.Windows.Forms.RadioButton fillMode_rb;
        private System.Windows.Forms.RadioButton perspectiveMode_rb;
        private System.Windows.Forms.RadioButton orthoMode_rb;
        private System.Windows.Forms.Panel sphere_panel;
        private System.Windows.Forms.NumericUpDown sphereRadius_numeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel cone_panel;
        private System.Windows.Forms.NumericUpDown coneHeight_numeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown coneRadius_numeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel disk_panel;
        private System.Windows.Forms.NumericUpDown diskOuterRadius_numeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown diskInnerRadius_numeric;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown coneSlice_numeric;
        private System.Windows.Forms.Label label13;
    }
}

