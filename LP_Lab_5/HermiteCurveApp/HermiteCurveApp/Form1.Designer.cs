namespace HermiteCurveApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtVx1 = new System.Windows.Forms.TextBox();
            this.txtVy1 = new System.Windows.Forms.TextBox();
            this.txtVx2 = new System.Windows.Forms.TextBox();
            this.txtVy2 = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblY1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblY2 = new System.Windows.Forms.Label();
            this.lblVx1 = new System.Windows.Forms.Label();
            this.lblVy1 = new System.Windows.Forms.Label();
            this.lblVx2 = new System.Windows.Forms.Label();
            this.lblVy2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(70, 12);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(50, 20);
            this.txtX1.TabIndex = 0;
            this.txtX1.Text = "50";
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(70, 38);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(50, 20);
            this.txtY1.TabIndex = 1;
            this.txtY1.Text = "100";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(70, 64);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(50, 20);
            this.txtX2.TabIndex = 2;
            this.txtX2.Text = "200";
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(70, 90);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(50, 20);
            this.txtY2.TabIndex = 3;
            this.txtY2.Text = "150";
            // 
            // txtVx1
            // 
            this.txtVx1.Location = new System.Drawing.Point(70, 116);
            this.txtVx1.Name = "txtVx1";
            this.txtVx1.Size = new System.Drawing.Size(50, 20);
            this.txtVx1.TabIndex = 4;
            this.txtVx1.Text = "30";
            // 
            // txtVy1
            // 
            this.txtVy1.Location = new System.Drawing.Point(70, 142);
            this.txtVy1.Name = "txtVy1";
            this.txtVy1.Size = new System.Drawing.Size(50, 20);
            this.txtVy1.TabIndex = 5;
            this.txtVy1.Text = "10";
            // 
            // txtVx2
            // 
            this.txtVx2.Location = new System.Drawing.Point(70, 168);
            this.txtVx2.Name = "txtVx2";
            this.txtVx2.Size = new System.Drawing.Size(50, 20);
            this.txtVx2.TabIndex = 6;
            this.txtVx2.Text = "-20";
            // 
            // txtVy2
            // 
            this.txtVy2.Location = new System.Drawing.Point(70, 194);
            this.txtVy2.Name = "txtVy2";
            this.txtVy2.Size = new System.Drawing.Size(50, 20);
            this.txtVy2.TabIndex = 7;
            this.txtVy2.Text = "40";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(12, 220);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(108, 23);
            this.btnDraw.TabIndex = 8;
            this.btnDraw.Text = "Draw Hermite Curve";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // pnlDraw
            // 
            this.pnlDraw.Location = new System.Drawing.Point(130, 12);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(400, 400);
            this.pnlDraw.TabIndex = 9;
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(12, 15);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(52, 13);
            this.lblX1.TabIndex = 10;
            this.lblX1.Text = "Point 1 X:";
            // 
            // lblY1
            // 
            this.lblY1.AutoSize = true;
            this.lblY1.Location = new System.Drawing.Point(12, 41);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(52, 13);
            this.lblY1.TabIndex = 11;
            this.lblY1.Text = "Point 1 Y:";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(12, 67);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(52, 13);
            this.lblX2.TabIndex = 12;
            this.lblX2.Text = "Point 2 X:";
            // 
            // lblY2
            // 
            this.lblY2.AutoSize = true;
            this.lblY2.Location = new System.Drawing.Point(12, 93);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(52, 13);
            this.lblY2.TabIndex = 13;
            this.lblY2.Text = "Point 2 Y:";
            // 
            // lblVx1
            // 
            this.lblVx1.AutoSize = true;
            this.lblVx1.Location = new System.Drawing.Point(12, 119);
            this.lblVx1.Name = "lblVx1";
            this.lblVx1.Size = new System.Drawing.Size(38, 13);
            this.lblVx1.TabIndex = 14;
            this.lblVx1.Text = "V1 X:";
            // 
            // lblVy1
            // 
            this.lblVy1.AutoSize = true;
            this.lblVy1.Location = new System.Drawing.Point(12, 145);
            this.lblVy1.Name = "lblVy1";
            this.lblVy1.Size = new System.Drawing.Size(38, 13);
            this.lblVy1.TabIndex = 15;
            this.lblVy1.Text = "V1 Y:";
            // 
            // lblVx2
            // 
            this.lblVx2.AutoSize = true;
            this.lblVx2.Location = new System.Drawing.Point(12, 171);
            this.lblVx2.Name = "lblVx2";
            this.lblVx2.Size = new System.Drawing.Size(38, 13);
            this.lblVx2.TabIndex = 16;
            this.lblVx2.Text = "V2 X:";
            // 
            // lblVy2
            // 
            this.lblVy2.AutoSize = true;
            this.lblVy2.Location = new System.Drawing.Point(12, 197);
            this.lblVy2.Name = "lblVy2";
            this.lblVy2.Size = new System.Drawing.Size(38, 13);
            this.lblVy2.TabIndex = 17;
            this.lblVy2.Text = "V2 Y:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 424);
            this.Controls.Add(this.lblVy2);
            this.Controls.Add(this.lblVx2);
            this.Controls.Add(this.lblVy1);
            this.Controls.Add(this.lblVx1);
            this.Controls.Add(this.lblY2);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblY1);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.txtVy2);
            this.Controls.Add(this.txtVx2);
            this.Controls.Add(this.txtVy1);
            this.Controls.Add(this.txtVx1);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Name = "Form1";
            this.Text = "Hermite Curve App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtVx1;
        private System.Windows.Forms.TextBox txtVy1;
        private System.Windows.Forms.TextBox txtVx2;
        private System.Windows.Forms.TextBox txtVy2;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblY2;
        private System.Windows.Forms.Label lblVx1;
        private System.Windows.Forms.Label lblVy1;
        private System.Windows.Forms.Label lblVx2;
        private System.Windows.Forms.Label lblVy2;
    }
}
