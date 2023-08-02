namespace MathProject
{
    partial class Form1
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
            btnCalculate = new Button();
            txtPol = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnFindRoot = new Button();
            txtCalculate = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(714, 399);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(96, 27);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtPol
            // 
            txtPol.Location = new Point(250, 288);
            txtPol.Name = "txtPol";
            txtPol.Size = new Size(357, 23);
            txtPol.TabIndex = 1;
            txtPol.TextChanged += txtPol_TextChanged;
            txtPol.KeyPress += txtPol_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(250, 264);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 2;
            label1.Text = "Write your Pol here!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(219, 62);
            label2.Name = "label2";
            label2.Size = new Size(523, 62);
            label2.TabIndex = 3;
            label2.Text = "Math Bisections Project";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFindRoot
            // 
            btnFindRoot.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFindRoot.Location = new Point(836, 399);
            btnFindRoot.Name = "btnFindRoot";
            btnFindRoot.Size = new Size(119, 27);
            btnFindRoot.TabIndex = 4;
            btnFindRoot.Text = "Find Real Root";
            btnFindRoot.UseVisualStyleBackColor = true;
            btnFindRoot.Click += btnFindRoot_Click;
            // 
            // txtCalculate
            // 
            txtCalculate.Location = new Point(714, 432);
            txtCalculate.Name = "txtCalculate";
            txtCalculate.Size = new Size(96, 23);
            txtCalculate.TabIndex = 5;
            txtCalculate.TextChanged += txtCalculate_TextChanged;
            txtCalculate.KeyPress += txtCalculate_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 561);
            Controls.Add(txtCalculate);
            Controls.Add(btnFindRoot);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPol);
            Controls.Add(btnCalculate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "MathProject";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnCalculate;
        private TextBox txtPol;
        private Label label1;
        private Label label2;
        private Button btnFindRoot;
        private TextBox txtCalculate;
    }
}