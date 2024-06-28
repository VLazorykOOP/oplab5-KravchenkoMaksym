using System.Windows.Forms;

namespace KochFractal
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtX1;
        private TextBox txtY1;
        private TextBox txtX2;
        private TextBox txtY2;
        private TextBox txtX3;
        private TextBox txtY3;
        private TextBox txtOrder;
        private Button btnDraw;
        private PictureBox pictureBox;

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
            this.txtX3 = new System.Windows.Forms.TextBox();
            this.txtY3 = new System.Windows.Forms.TextBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(12, 12);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(50, 20);
            this.txtX1.TabIndex = 0;
            this.txtX1.Text = "X1";
            this.txtX1.TextChanged += new System.EventHandler(this.txtX1_TextChanged);
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(68, 12);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(50, 20);
            this.txtY1.TabIndex = 1;
            this.txtY1.Text = "Y1";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(12, 40);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(50, 20);
            this.txtX2.TabIndex = 2;
            this.txtX2.Text = "X2";
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(68, 40);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(50, 20);
            this.txtY2.TabIndex = 3;
            this.txtY2.Text = "Y2";
            // 
            // txtX3
            // 
            this.txtX3.Location = new System.Drawing.Point(12, 68);
            this.txtX3.Name = "txtX3";
            this.txtX3.Size = new System.Drawing.Size(50, 20);
            this.txtX3.TabIndex = 4;
            this.txtX3.Text = "X3";
            // 
            // txtY3
            // 
            this.txtY3.Location = new System.Drawing.Point(68, 68);
            this.txtY3.Name = "txtY3";
            this.txtY3.Size = new System.Drawing.Size(50, 20);
            this.txtY3.TabIndex = 5;
            this.txtY3.Text = "Y3";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(12, 96);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(106, 20);
            this.txtOrder.TabIndex = 6;
            this.txtOrder.Text = "Order";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(12, 124);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(106, 23);
            this.btnDraw.TabIndex = 7;
            this.btnDraw.Text = "Побудувати";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 153);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(776, 285);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.txtY3);
            this.Controls.Add(this.txtX3);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Name = "Form1";
            this.Text = "Фрактал Коха";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
