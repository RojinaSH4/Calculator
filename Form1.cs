using System;
using System.Diagnostics.Metrics;

namespace Rojina_Caculator
{
    public partial class Form1 : Form
    {
        double num1, num2, numAnsr;
        string strFunc;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        // This method processes the operation
        private void process(string strOpr)
        {
            // If there is a previous operator, perform calculation
            if (!string.IsNullOrEmpty(strFunc) && txtFunc.Text != "")
            {
                num2 = Convert.ToDouble(txtFunc.Text);
                calculate();
                num1 = numAnsr;
                txtFunc.Clear();
            }
            else
            {
                if (txtFunc.Text != "")
                {
                    num1 = Convert.ToDouble(txtFunc.Text);
                    txtFunc.Clear();
                }
            }

            // Display current operation in previous answer field
            strFunc = strOpr;
            txtPreviousAnsr.Text = num1 + " " + strOpr + " ";
        }

        // Perform calculation based on the selected operator
        private void calculate()
        {
            switch (strFunc)
            {
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Division by zero is not allowed!"); // Prevent division by zero
                        return;
                    }
                    numAnsr = num1 / num2;
                    break;
                case "*":
                    numAnsr = num1 * num2;
                    break;
                case "+":
                    numAnsr = num1 + num2;
                    break;
                case "-":
                    numAnsr = num1 - num2;
                    break;
            }
        }

        // Button click event for number buttons
        private void btn_Click(object sender, EventArgs e)
        {
            if (txtFunc.Text == "0")
                txtFunc.Clear();

            Button button = (Button)sender;
            txtFunc.Text = txtFunc.Text + button.Text;

            // Display the current operation (if any) along with the current input
            if (string.IsNullOrEmpty(strFunc))
            {
                txtPreviousAnsr.Text = txtFunc.Text;
            }
            else
            {
                txtPreviousAnsr.Text = num1 + " " + strFunc + " " + txtFunc.Text;
            }
        }

        // Reset calculator to initial state
        private void btnAC_Click(object sender, EventArgs e)
        {
            txtFunc.Clear();
            txtFunc.Text = "0";
            strFunc = null;

            txtPreviousAnsr.Clear();
        }


        // Handle calculate button click
        private void btnDivide_Click(object sender, EventArgs e)
        {
            process("/");
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            process("*");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            process("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            process("-");
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(txtFunc.Text);
            txtPreviousAnsr.Text = f + "!";

            // Check if the input is a positive integer
            if (f < 0 || f % 1 != 0)
            {
                MessageBox.Show("Factorial is only for positive integers");
                return;
            }

            double fact = 1;
            for (; f > 0; f--)
            {
                fact *= f;
            }

            txtFunc.Text = fact.ToString();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtFunc.Text = "3.141592653";
            txtPreviousAnsr.Text = txtFunc.Text;
        }

        private void btnUnderRoot_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(txtFunc.Text);
            txtPreviousAnsr.Text = "√" + n;
            n = Convert.ToDouble(System.Math.Sqrt(n));
            txtFunc.Text = n.ToString();

        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(txtFunc.Text);
            txtPreviousAnsr.Text = "Inv(" + i + ")";
            i = 1 / i;
            txtFunc.Text = i.ToString();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double s = Convert.ToDouble(txtFunc.Text);
            txtPreviousAnsr.Text = "Square(" + s + ")";
            s = s * s;
            txtFunc.Text = s.ToString();
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(txtFunc.Text);
            txtPreviousAnsr.Text = "Cube(" + c + ")";
            c = c * c * c;
            txtFunc.Text = c.ToString();
        }


        // Handle equals button click
        private void btnEql_Click(object sender, EventArgs e)
        {
            //If no input, set display to "0"
            if (string.IsNullOrEmpty(txtFunc.Text))
                txtFunc.Text = "0";
            num2 = Convert.ToDouble(txtFunc.Text);

            // Display the current operation
            txtPreviousAnsr.Text = num1 + " " + strFunc + " " + num2 + " =";

            switch (strFunc)
            {
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Division by zero is not allowed!"); // Prevent division by zero

                        return;
                    }
                    numAnsr = num1 / num2;
                    break;

                case "*":
                    numAnsr = num1 * num2;
                    break;

                case "+":
                    numAnsr = num1 + num2;
                    break;

                case "-":
                    numAnsr = num1 - num2;
                    break;
            }

            txtFunc.Text = numAnsr.ToString();
            strFunc = null; //Reset operator after calculation
        }


        // Color changing logic for UI transition effects
        bool slide = true;

        int r1 = 92, g1 = 95, b1 = 102;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (r1 <= 32)
            {
                timer1.Stop();
            }
            else
            {
                r1 -= 3;
                this.BackColor = Color.FromArgb(r1, g1, b1);
                txtPreviousAnsr.BackColor = Color.FromArgb(r1, g1, b1);
                txtPreviousAnsr.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.BackColor = Color.FromArgb(81, 99, 143);
                    }

                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (g1 <= 40)
            {
                timer2.Stop();
            }
            else
            {
                g1 -= 3;
                this.BackColor = Color.FromArgb(r1, g1, b1);
                txtPreviousAnsr.BackColor = Color.FromArgb(r1, g1, b1);
                txtPreviousAnsr.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.BackColor = Color.FromArgb(81, 99, 143);
                    }

                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (b1 <= 66)
            {
                timer3.Stop();
            }
            else
            {
                b1 -= 3;
                this.BackColor = Color.FromArgb(r1, g1, b1);
                txtPreviousAnsr.BackColor = Color.FromArgb(r1, g1, b1);
                txtPreviousAnsr.ForeColor = Color.FromArgb(255, 255, 255);
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.BackColor = Color.FromArgb(81, 99, 143);
                    }

                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (r1 >= 235)
            {
                timer4.Stop();
            }
            else
            {
                r1 += 3;
                this.BackColor = Color.FromArgb(r1, g1, b1);
                txtPreviousAnsr.BackColor = Color.FromArgb(r1, g1, b1);
                txtPreviousAnsr.ForeColor = Color.FromArgb(48, 48, 48);
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.BackColor = Color.FromArgb(255, 255, 255);
                    }

                }
            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (g1 >= 240)
            {
                timer5.Stop();
            }
            else
            {
                g1 += 3;
                this.BackColor = Color.FromArgb(r1, g1, b1);
                txtPreviousAnsr.BackColor = Color.FromArgb(r1, g1, b1);
                txtPreviousAnsr.ForeColor = Color.FromArgb(48, 48, 48);
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.BackColor = Color.FromArgb(255, 255, 255);
                    }

                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (b1 >= 255)
            {
                timer6.Stop();
            }
            else
            {
                b1 += 3;
                this.BackColor = Color.FromArgb(r1, g1, b1);
                txtPreviousAnsr.BackColor = Color.FromArgb(r1, g1, b1);
                txtPreviousAnsr.ForeColor = Color.FromArgb(48, 48, 48);
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.BackColor = Color.FromArgb(255, 255, 255);
                    }

                }
            }
        }


        // Handle panel sliding effect on mouse down event
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            timer7.Start();
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }


        // Panel sliding effect with color transition
        private void timer7_Tick(object sender, EventArgs e)
        {
            if (slide == true)
            {
                panel2.Left += 3;
                if (panel2.Left >= 24)
                {
                    timer7.Stop();
                    slide = false;
                    panel1.BackColor = Color.FromArgb(64, 64, 64);
                    panel2.BackColor = Color.FromArgb(255, 255, 255);
                }
            }
            else
            {
                panel2.Left -= 3;
                if (panel2.Left <= 3)
                {
                    timer4.Start();
                    timer5.Start();
                    timer6.Start();
                    timer7.Stop();
                    slide = true;
                    panel2.BackColor = Color.FromArgb(64, 64, 64);
                    panel1.BackColor = Color.FromArgb(255, 255, 255);
                }
            }

        }
    }
}