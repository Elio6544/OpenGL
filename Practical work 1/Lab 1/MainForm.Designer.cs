
namespace Lab_1
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
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.FromArgb(160, 71, 71);
            renderControl1.ForeColor = System.Drawing.Color.Black;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(1121, 634);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 65001;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(52, 49, 49);
            ClientSize = new System.Drawing.Size(1145, 658);
            Controls.Add(renderControl1);
            Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            Name = "MainForm";
            Text = "Lab 1";
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
    }
}

