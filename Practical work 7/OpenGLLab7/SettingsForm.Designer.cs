namespace OpenGLLab7
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            colorHeart_button = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            heartbeat_numeric = new System.Windows.Forms.NumericUpDown();
            sizeHeart_numeric = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            bgColor_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)heartbeat_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sizeHeart_numeric).BeginInit();
            SuspendLayout();
            // 
            // colorHeart_button
            // 
            colorHeart_button.BackColor = System.Drawing.Color.Crimson;
            colorHeart_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            colorHeart_button.Location = new System.Drawing.Point(138, 32);
            colorHeart_button.Name = "colorHeart_button";
            colorHeart_button.Size = new System.Drawing.Size(75, 23);
            colorHeart_button.TabIndex = 0;
            colorHeart_button.UseVisualStyleBackColor = false;
            colorHeart_button.Click += colorHeart_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(12, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 22);
            label1.TabIndex = 1;
            label1.Text = "heart color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(12, 81);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 22);
            label2.TabIndex = 2;
            label2.Text = "heartbeat";
            // 
            // heartbeat_numeric
            // 
            heartbeat_numeric.DecimalPlaces = 2;
            heartbeat_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            heartbeat_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            heartbeat_numeric.Location = new System.Drawing.Point(138, 79);
            heartbeat_numeric.Name = "heartbeat_numeric";
            heartbeat_numeric.Size = new System.Drawing.Size(75, 30);
            heartbeat_numeric.TabIndex = 3;
            heartbeat_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            heartbeat_numeric.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // sizeHeart_numeric
            // 
            sizeHeart_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            sizeHeart_numeric.Location = new System.Drawing.Point(138, 129);
            sizeHeart_numeric.Name = "sizeHeart_numeric";
            sizeHeart_numeric.Size = new System.Drawing.Size(75, 30);
            sizeHeart_numeric.TabIndex = 5;
            sizeHeart_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            sizeHeart_numeric.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(12, 131);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 22);
            label3.TabIndex = 4;
            label3.Text = "heart size";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(12, 189);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(110, 22);
            label4.TabIndex = 7;
            label4.Text = "background";
            // 
            // bgColor_button
            // 
            bgColor_button.BackColor = System.Drawing.Color.Black;
            bgColor_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bgColor_button.Location = new System.Drawing.Point(138, 190);
            bgColor_button.Name = "bgColor_button";
            bgColor_button.Size = new System.Drawing.Size(75, 23);
            bgColor_button.TabIndex = 6;
            bgColor_button.UseVisualStyleBackColor = false;
            bgColor_button.Click += bgColor_button_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(241, 231);
            Controls.Add(label4);
            Controls.Add(bgColor_button);
            Controls.Add(sizeHeart_numeric);
            Controls.Add(label3);
            Controls.Add(heartbeat_numeric);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(colorHeart_button);
            Name = "SettingsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Settings";
            FormClosed += SettingsFormClosed;
            Load += SettingsFormLoad;
            ((System.ComponentModel.ISupportInitialize)heartbeat_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)sizeHeart_numeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button colorHeart_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown heartbeat_numeric;
        private System.Windows.Forms.NumericUpDown sizeHeart_numeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bgColor_button;
    }
}