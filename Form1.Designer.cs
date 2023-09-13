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
            comboBox1 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(1020, 665);
            btnCalculate.Margin = new Padding(4, 5, 4, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(137, 45);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtPol
            // 
            txtPol.Location = new Point(357, 480);
            txtPol.Margin = new Padding(4, 5, 4, 5);
            txtPol.Name = "txtPol";
            txtPol.Size = new Size(508, 31);
            txtPol.TabIndex = 1;
            txtPol.TextChanged += txtPol_TextChanged;
            txtPol.KeyPress += txtPol_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(357, 440);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 2;
            label1.Text = "Write your Pol here!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(313, 103);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(766, 93);
            label2.TabIndex = 3;
            label2.Text = "Math Bisections Project";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFindRoot
            // 
            btnFindRoot.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFindRoot.Location = new Point(1194, 665);
            btnFindRoot.Margin = new Padding(4, 5, 4, 5);
            btnFindRoot.Name = "btnFindRoot";
            btnFindRoot.Size = new Size(170, 45);
            btnFindRoot.TabIndex = 4;
            btnFindRoot.Text = "Find Real Root";
            btnFindRoot.UseVisualStyleBackColor = true;
            btnFindRoot.Click += btnFindRoot_Click;
            // 
            // txtCalculate
            // 
            txtCalculate.Location = new Point(1020, 720);
            txtCalculate.Margin = new Padding(4, 5, 4, 5);
            txtCalculate.Name = "txtCalculate";
            txtCalculate.Size = new Size(135, 31);
            txtCalculate.TabIndex = 5;
            txtCalculate.TextChanged += txtCalculate_TextChanged;
            txtCalculate.KeyPress += txtCalculate_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(369, 720);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(91, 33);
            comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(250, 720);
            label3.Name = "label3";
            label3.Size = new Size(113, 26);
            label3.TabIndex = 7;
            label3.Text = "Tolerance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 935);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(txtCalculate);
            Controls.Add(btnFindRoot);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPol);
            Controls.Add(btnCalculate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
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
        private ComboBox comboBox1;
        private Label label3;

    }
}