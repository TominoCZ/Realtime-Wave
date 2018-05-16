namespace RealtimeWave
{
    partial class Form1
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
            this.tbarBoost = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tbarPoints = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbarSmoothing = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbarBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarPoints)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSmoothing)).BeginInit();
            this.SuspendLayout();
            // 
            // tbarBoost
            // 
            this.tbarBoost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tbarBoost.Location = new System.Drawing.Point(148, 11);
            this.tbarBoost.Minimum = 1;
            this.tbarBoost.Name = "tbarBoost";
            this.tbarBoost.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarBoost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbarBoost.Size = new System.Drawing.Size(45, 91);
            this.tbarBoost.TabIndex = 0;
            this.tbarBoost.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbarBoost.Value = 2;
            this.tbarBoost.Scroll += new System.EventHandler(this.tbarBoost_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "BOOST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbarPoints
            // 
            this.tbarPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tbarPoints.LargeChange = 1;
            this.tbarPoints.Location = new System.Drawing.Point(83, 11);
            this.tbarPoints.Minimum = 4;
            this.tbarPoints.Name = "tbarPoints";
            this.tbarPoints.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarPoints.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbarPoints.Size = new System.Drawing.Size(45, 91);
            this.tbarPoints.TabIndex = 0;
            this.tbarPoints.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbarPoints.Value = 9;
            this.tbarPoints.Scroll += new System.EventHandler(this.tbarPoints_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "POINTS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tbarSmoothing);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbarPoints);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbarBoost);
            this.panel2.Location = new System.Drawing.Point(586, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 131);
            this.panel2.TabIndex = 3;
            // 
            // tbarSmoothing
            // 
            this.tbarSmoothing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tbarSmoothing.LargeChange = 1;
            this.tbarSmoothing.Location = new System.Drawing.Point(12, 11);
            this.tbarSmoothing.Name = "tbarSmoothing";
            this.tbarSmoothing.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSmoothing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbarSmoothing.Size = new System.Drawing.Size(45, 91);
            this.tbarSmoothing.TabIndex = 2;
            this.tbarSmoothing.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbarSmoothing.Value = 5;
            this.tbarSmoothing.Scroll += new System.EventHandler(this.tbarSmoothing_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "TENSION";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Realtime Wave";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.tbarBoost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarPoints)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSmoothing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tbarBoost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbarPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar tbarSmoothing;
        private System.Windows.Forms.Label label3;
    }
}

