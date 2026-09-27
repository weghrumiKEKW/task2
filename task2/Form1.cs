using System;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCommand.Items.Clear();
            cmbCommand.Items.Add("+");
            cmbCommand.Items.Add("-");
            cmbCommand.Items.Add("*");
            cmbCommand.Items.Add("/");
            cmbCommand.SelectedIndex = 0;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text, out double num1) &&
                double.TryParse(txtNumber2.Text, out double num2))
            {
                double result = 0;
                string selectedCommand = cmbCommand.SelectedItem?.ToString();

                switch (selectedCommand)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            MessageBox.Show("Bir sayı 0'a bölünemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Lütfen bir işlem seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli sayılar girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "0";
            txtNumber2.Text = "0";
            lblResult.Text = "0";
            if (cmbCommand.Items.Count > 0)
            {
                cmbCommand.SelectedIndex = 0;
            }
        }
    }
}