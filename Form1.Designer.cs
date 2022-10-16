namespace csharp_tutorial
{
    partial class lbl_a
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
            this.txt_a = new System.Windows.Forms.TextBox();
            this.lab_a = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(56, 15);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(100, 23);
            this.txt_a.TabIndex = 0;
            this.txt_a.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lab_a
            // 
            this.lab_a.AutoSize = true;
            this.lab_a.Location = new System.Drawing.Point(12, 18);
            this.lab_a.Name = "lab_a";
            this.lab_a.Size = new System.Drawing.Size(13, 15);
            this.lab_a.TabIndex = 1;
            this.lab_a.Text = "a";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(12, 60);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(14, 15);
            this.lbl_b.TabIndex = 2;
            this.lbl_b.Text = "b";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(56, 57);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 23);
            this.txt_b.TabIndex = 3;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(271, 18);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(13, 15);
            this.lbl_result.TabIndex = 4;
            this.lbl_result.Text = "0";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(56, 101);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(100, 23);
            this.btn_calculate.TabIndex = 5;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lab_a);
            this.Controls.Add(this.txt_a);
            this.Name = "lbl_a";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_a;
        private Label lab_a;
        private Label lbl_b;
        private TextBox txt_b;
        private Label lbl_result;
        private Button btn_calculate;
    }
}