namespace A04_01
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
            this.lbl1Side = new System.Windows.Forms.Label();
            this.lbl2Side = new System.Windows.Forms.Label();
            this.txt1Side = new System.Windows.Forms.TextBox();
            this.txt2Side = new System.Windows.Forms.TextBox();
            this.lbl3Side = new System.Windows.Forms.Label();
            this.txt3Side = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1Side
            // 
            this.lbl1Side.AutoSize = true;
            this.lbl1Side.Location = new System.Drawing.Point(246, 127);
            this.lbl1Side.Name = "lbl1Side";
            this.lbl1Side.Size = new System.Drawing.Size(85, 25);
            this.lbl1Side.TabIndex = 0;
            this.lbl1Side.Text = "Side 1 :";
            // 
            // lbl2Side
            // 
            this.lbl2Side.AutoSize = true;
            this.lbl2Side.Location = new System.Drawing.Point(246, 205);
            this.lbl2Side.Name = "lbl2Side";
            this.lbl2Side.Size = new System.Drawing.Size(85, 25);
            this.lbl2Side.TabIndex = 1;
            this.lbl2Side.Text = "Side 2 :";
            // 
            // txt1Side
            // 
            this.txt1Side.Location = new System.Drawing.Point(354, 121);
            this.txt1Side.Name = "txt1Side";
            this.txt1Side.Size = new System.Drawing.Size(160, 31);
            this.txt1Side.TabIndex = 0;
            this.txt1Side.Click += new System.EventHandler(this.txt1Side_Enter);
            this.txt1Side.Enter += new System.EventHandler(this.txt1Side_Enter);
            // 
            // txt2Side
            // 
            this.txt2Side.Location = new System.Drawing.Point(354, 199);
            this.txt2Side.Name = "txt2Side";
            this.txt2Side.Size = new System.Drawing.Size(160, 31);
            this.txt2Side.TabIndex = 1;
            this.txt2Side.Click += new System.EventHandler(this.txt2Side_Enter);
            this.txt2Side.Enter += new System.EventHandler(this.txt2Side_Enter);
            // 
            // lbl3Side
            // 
            this.lbl3Side.AutoSize = true;
            this.lbl3Side.Location = new System.Drawing.Point(192, 290);
            this.lbl3Side.Name = "lbl3Side";
            this.lbl3Side.Size = new System.Drawing.Size(139, 25);
            this.lbl3Side.TabIndex = 4;
            this.lbl3Side.Text = "Hypotenuse :";
            // 
            // txt3Side
            // 
            this.txt3Side.Location = new System.Drawing.Point(354, 284);
            this.txt3Side.Name = "txt3Side";
            this.txt3Side.ReadOnly = true;
            this.txt3Side.Size = new System.Drawing.Size(160, 31);
            this.txt3Side.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(354, 361);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(159, 46);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter the two known sides of a right triangle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txt3Side);
            this.Controls.Add(this.lbl3Side);
            this.Controls.Add(this.txt2Side);
            this.Controls.Add(this.txt1Side);
            this.Controls.Add(this.lbl2Side);
            this.Controls.Add(this.lbl1Side);
            this.Name = "Form1";
            this.Text = "Hypotenuse Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1Side;
        private System.Windows.Forms.Label lbl2Side;
        private System.Windows.Forms.TextBox txt1Side;
        private System.Windows.Forms.TextBox txt2Side;
        private System.Windows.Forms.Label lbl3Side;
        private System.Windows.Forms.TextBox txt3Side;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
    }
}

