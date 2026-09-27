namespace task2
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
            txtNumber1 = new MaskedTextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            txtNumber2 = new MaskedTextBox();
            cmbCommand = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            lblResult = new Label();
            btnResult = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.BackColor = Color.MidnightBlue;
            txtNumber1.BorderStyle = BorderStyle.None;
            txtNumber1.Font = new Font("Segoe UI", 11F);
            txtNumber1.ForeColor = Color.White;
            txtNumber1.Location = new Point(70, 75);
            txtNumber1.Mask = "00000000000";
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(360, 30);
            txtNumber1.TabIndex = 0;
            txtNumber1.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(70, 40);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 1;
            label1.Text = "Number One";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Location = new Point(70, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 1);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Location = new Point(70, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 1);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(70, 138);
            label2.Name = "label2";
            label2.Size = new Size(162, 32);
            label2.TabIndex = 4;
            label2.Text = "Number Two";
            // 
            // txtNumber2
            // 
            txtNumber2.BackColor = Color.MidnightBlue;
            txtNumber2.BorderStyle = BorderStyle.None;
            txtNumber2.Font = new Font("Segoe UI", 11F);
            txtNumber2.ForeColor = Color.White;
            txtNumber2.Location = new Point(70, 173);
            txtNumber2.Mask = "00000000000";
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(360, 30);
            txtNumber2.TabIndex = 3;
            txtNumber2.ValidatingType = typeof(int);
            // 
            // cmbCommand
            // 
            cmbCommand.BackColor = Color.Yellow;
            cmbCommand.Font = new Font("Segoe UI", 11F);
            cmbCommand.ForeColor = Color.MidnightBlue;
            cmbCommand.FormattingEnabled = true;
            cmbCommand.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbCommand.Location = new Point(71, 276);
            cmbCommand.Name = "cmbCommand";
            cmbCommand.Size = new Size(360, 38);
            cmbCommand.TabIndex = 6;
            cmbCommand.Text = "Select";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(71, 231);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 7;
            label3.Text = "Operator";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(71, 349);
            label4.Name = "label4";
            label4.Size = new Size(107, 32);
            label4.TabIndex = 8;
            label4.Text = "Answer:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblResult.ForeColor = Color.Yellow;
            lblResult.Location = new Point(245, 349);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(28, 32);
            lblResult.TabIndex = 9;
            lblResult.Text = "0";
            // 
            // btnResult
            // 
            btnResult.FlatAppearance.BorderSize = 0;
            btnResult.FlatStyle = FlatStyle.Flat;
            btnResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnResult.ForeColor = Color.Yellow;
            btnResult.Location = new Point(71, 437);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(145, 65);
            btnResult.TabIndex = 1;
            btnResult.Text = "Result";
            btnResult.Click += btnResult_Click;
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnClear.ForeColor = Color.Yellow;
            btnClear.Location = new Point(285, 437);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 65);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(478, 544);
            Controls.Add(btnClear);
            Controls.Add(btnResult);
            Controls.Add(lblResult);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbCommand);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(txtNumber2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(txtNumber1);
            Name = "Form1";
            Text = "weghrumi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtNumber1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private MaskedTextBox txtNumber2;
        private ComboBox cmbCommand;
        private Label label3;
        private Label label4;
        private Label lblResult;
        private Button btnResult;
        private Button btnClear;
    }
}
