
namespace Lab_2
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
            tileCount_panel = new System.Windows.Forms.Panel();
            ver_numeric = new System.Windows.Forms.NumericUpDown();
            hor_numeric = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            drawMode_panel = new System.Windows.Forms.Panel();
            pointMode_rb = new System.Windows.Forms.RadioButton();
            lineMode_rb = new System.Windows.Forms.RadioButton();
            fillMode_rb = new System.Windows.Forms.RadioButton();
            label6 = new System.Windows.Forms.Label();
            shadeModel_panel = new System.Windows.Forms.Panel();
            flatModel_rb = new System.Windows.Forms.RadioButton();
            smoothModel_rb = new System.Windows.Forms.RadioButton();
            label4 = new System.Windows.Forms.Label();
            tileCount_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ver_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hor_numeric).BeginInit();
            drawMode_panel.SuspendLayout();
            shadeModel_panel.SuspendLayout();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(752, 621);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 65001;
            // 
            // tileCount_panel
            // 
            tileCount_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            tileCount_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            tileCount_panel.Controls.Add(ver_numeric);
            tileCount_panel.Controls.Add(hor_numeric);
            tileCount_panel.Controls.Add(label3);
            tileCount_panel.Controls.Add(label2);
            tileCount_panel.Controls.Add(label1);
            tileCount_panel.Location = new System.Drawing.Point(770, 12);
            tileCount_panel.Name = "tileCount_panel";
            tileCount_panel.Size = new System.Drawing.Size(323, 184);
            tileCount_panel.TabIndex = 1;
            // 
            // ver_numeric
            // 
            ver_numeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            ver_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            ver_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ver_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ver_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            ver_numeric.Location = new System.Drawing.Point(131, 121);
            ver_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ver_numeric.Name = "ver_numeric";
            ver_numeric.Size = new System.Drawing.Size(161, 26);
            ver_numeric.TabIndex = 5;
            ver_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ver_numeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            ver_numeric.ValueChanged += ver_numeric_ValueChanged;
            // 
            // hor_numeric
            // 
            hor_numeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            hor_numeric.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            hor_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            hor_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            hor_numeric.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            hor_numeric.Location = new System.Drawing.Point(131, 75);
            hor_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            hor_numeric.Name = "hor_numeric";
            hor_numeric.Size = new System.Drawing.Size(161, 26);
            hor_numeric.TabIndex = 4;
            hor_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            hor_numeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            hor_numeric.ValueChanged += hor_numeric_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label3.Location = new System.Drawing.Point(35, 121);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 22);
            label3.TabIndex = 3;
            label3.Text = "vertical";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label2.Location = new System.Drawing.Point(15, 75);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 22);
            label2.TabIndex = 2;
            label2.Text = "horizontal";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label1.Location = new System.Drawing.Point(72, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 32);
            label1.TabIndex = 2;
            label1.Text = "tile  count";
            // 
            // drawMode_panel
            // 
            drawMode_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            drawMode_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            drawMode_panel.Controls.Add(pointMode_rb);
            drawMode_panel.Controls.Add(lineMode_rb);
            drawMode_panel.Controls.Add(fillMode_rb);
            drawMode_panel.Controls.Add(label6);
            drawMode_panel.Location = new System.Drawing.Point(770, 202);
            drawMode_panel.Name = "drawMode_panel";
            drawMode_panel.Size = new System.Drawing.Size(323, 184);
            drawMode_panel.TabIndex = 6;
            // 
            // pointMode_rb
            // 
            pointMode_rb.Anchor = System.Windows.Forms.AnchorStyles.None;
            pointMode_rb.AutoSize = true;
            pointMode_rb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            pointMode_rb.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            pointMode_rb.Location = new System.Drawing.Point(35, 131);
            pointMode_rb.Name = "pointMode_rb";
            pointMode_rb.Size = new System.Drawing.Size(128, 26);
            pointMode_rb.TabIndex = 7;
            pointMode_rb.Text = "point mode";
            pointMode_rb.UseVisualStyleBackColor = true;
            pointMode_rb.CheckedChanged += pointMode_rb_CheckedChanged;
            // 
            // lineMode_rb
            // 
            lineMode_rb.Anchor = System.Windows.Forms.AnchorStyles.None;
            lineMode_rb.AutoSize = true;
            lineMode_rb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lineMode_rb.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            lineMode_rb.Location = new System.Drawing.Point(35, 99);
            lineMode_rb.Name = "lineMode_rb";
            lineMode_rb.Size = new System.Drawing.Size(118, 26);
            lineMode_rb.TabIndex = 6;
            lineMode_rb.Text = "line mode";
            lineMode_rb.UseVisualStyleBackColor = true;
            lineMode_rb.CheckedChanged += lineMode_rb_CheckedChanged;
            // 
            // fillMode_rb
            // 
            fillMode_rb.Anchor = System.Windows.Forms.AnchorStyles.None;
            fillMode_rb.AutoSize = true;
            fillMode_rb.Checked = true;
            fillMode_rb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            fillMode_rb.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            fillMode_rb.Location = new System.Drawing.Point(35, 67);
            fillMode_rb.Name = "fillMode_rb";
            fillMode_rb.Size = new System.Drawing.Size(118, 26);
            fillMode_rb.TabIndex = 5;
            fillMode_rb.TabStop = true;
            fillMode_rb.Text = "fill mode";
            fillMode_rb.UseVisualStyleBackColor = true;
            fillMode_rb.CheckedChanged += fillMode_rb_CheckedChanged;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label6.Location = new System.Drawing.Point(81, 13);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(149, 32);
            label6.TabIndex = 2;
            label6.Text = "draw mode";
            // 
            // shadeModel_panel
            // 
            shadeModel_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            shadeModel_panel.BackColor = System.Drawing.Color.FromArgb(57, 54, 54);
            shadeModel_panel.Controls.Add(flatModel_rb);
            shadeModel_panel.Controls.Add(smoothModel_rb);
            shadeModel_panel.Controls.Add(label4);
            shadeModel_panel.Location = new System.Drawing.Point(770, 392);
            shadeModel_panel.Name = "shadeModel_panel";
            shadeModel_panel.Size = new System.Drawing.Size(323, 147);
            shadeModel_panel.TabIndex = 8;
            // 
            // flatModel_rb
            // 
            flatModel_rb.Anchor = System.Windows.Forms.AnchorStyles.None;
            flatModel_rb.AutoSize = true;
            flatModel_rb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            flatModel_rb.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            flatModel_rb.Location = new System.Drawing.Point(35, 99);
            flatModel_rb.Name = "flatModel_rb";
            flatModel_rb.Size = new System.Drawing.Size(68, 26);
            flatModel_rb.TabIndex = 6;
            flatModel_rb.Text = "flat";
            flatModel_rb.UseVisualStyleBackColor = true;
            flatModel_rb.CheckedChanged += flatModel_rb_CheckedChanged;
            // 
            // smoothModel_rb
            // 
            smoothModel_rb.Anchor = System.Windows.Forms.AnchorStyles.None;
            smoothModel_rb.AutoSize = true;
            smoothModel_rb.Checked = true;
            smoothModel_rb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            smoothModel_rb.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            smoothModel_rb.Location = new System.Drawing.Point(35, 67);
            smoothModel_rb.Name = "smoothModel_rb";
            smoothModel_rb.Size = new System.Drawing.Size(88, 26);
            smoothModel_rb.TabIndex = 5;
            smoothModel_rb.TabStop = true;
            smoothModel_rb.Text = "smooth";
            smoothModel_rb.UseVisualStyleBackColor = true;
            smoothModel_rb.CheckedChanged += smoothModel_rb_CheckedChanged;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.FromArgb(238, 223, 122);
            label4.Location = new System.Drawing.Point(72, 11);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(179, 32);
            label4.TabIndex = 2;
            label4.Text = "shade model";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(52, 49, 49);
            ClientSize = new System.Drawing.Size(1105, 645);
            Controls.Add(shadeModel_panel);
            Controls.Add(drawMode_panel);
            Controls.Add(tileCount_panel);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Lab 2";
            tileCount_panel.ResumeLayout(false);
            tileCount_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ver_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)hor_numeric).EndInit();
            drawMode_panel.ResumeLayout(false);
            drawMode_panel.PerformLayout();
            shadeModel_panel.ResumeLayout(false);
            shadeModel_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.Panel tileCount_panel;
        private System.Windows.Forms.NumericUpDown ver_numeric;
        private System.Windows.Forms.NumericUpDown hor_numeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel drawMode_panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton pointMode_rb;
        private System.Windows.Forms.RadioButton lineMode_rb;
        private System.Windows.Forms.RadioButton fillMode_rb;
        private System.Windows.Forms.Panel shadeModel_panel;
        private System.Windows.Forms.RadioButton flatModel_rb;
        private System.Windows.Forms.RadioButton smoothModel_rb;
        private System.Windows.Forms.Label label4;
    }
}

