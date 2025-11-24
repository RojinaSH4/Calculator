namespace Rojina_Caculator
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtFunc = new TextBox();
            btnUnderRoot = new Button();
            btnPi = new Button();
            btnFact = new Button();
            btnAC = new Button();
            btnDivide = new Button();
            btnSquare = new Button();
            btnCube = new Button();
            btnMulti = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnPlus = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnEql = new Button();
            btnInverse = new Button();
            btnZero = new Button();
            btnDot = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnMinus = new Button();
            txtPreviousAnsr = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            timer6 = new System.Windows.Forms.Timer(components);
            timer7 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFunc
            // 
            txtFunc.Font = new Font("Segoe UI Emoji", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtFunc.Location = new Point(12, 40);
            txtFunc.Name = "txtFunc";
            txtFunc.Size = new Size(269, 46);
            txtFunc.TabIndex = 0;
            txtFunc.Text = "0";
            txtFunc.TextAlign = HorizontalAlignment.Right;
            // 
            // btnUnderRoot
            // 
            btnUnderRoot.AutoSize = true;
            btnUnderRoot.BackColor = Color.White;
            btnUnderRoot.FlatStyle = FlatStyle.Flat;
            btnUnderRoot.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnderRoot.ForeColor = Color.FromArgb(255, 128, 0);
            btnUnderRoot.Location = new Point(15, 92);
            btnUnderRoot.Name = "btnUnderRoot";
            btnUnderRoot.Size = new Size(62, 42);
            btnUnderRoot.TabIndex = 1;
            btnUnderRoot.Text = " √";
            btnUnderRoot.UseVisualStyleBackColor = false;
            btnUnderRoot.Click += btnUnderRoot_Click;
            // 
            // btnPi
            // 
            btnPi.AutoSize = true;
            btnPi.BackColor = Color.White;
            btnPi.FlatStyle = FlatStyle.Flat;
            btnPi.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPi.ForeColor = Color.FromArgb(255, 128, 0);
            btnPi.Location = new Point(83, 92);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(62, 42);
            btnPi.TabIndex = 2;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = false;
            btnPi.Click += btnPi_Click;
            // 
            // btnFact
            // 
            btnFact.AutoSize = true;
            btnFact.BackColor = Color.White;
            btnFact.FlatStyle = FlatStyle.Flat;
            btnFact.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFact.ForeColor = Color.FromArgb(255, 128, 0);
            btnFact.Location = new Point(151, 92);
            btnFact.Name = "btnFact";
            btnFact.Size = new Size(62, 40);
            btnFact.TabIndex = 3;
            btnFact.Text = "n!";
            btnFact.UseVisualStyleBackColor = false;
            btnFact.Click += btnFact_Click;
            // 
            // btnAC
            // 
            btnAC.AutoSize = true;
            btnAC.BackColor = Color.White;
            btnAC.FlatStyle = FlatStyle.Flat;
            btnAC.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAC.ForeColor = Color.FromArgb(192, 0, 0);
            btnAC.Location = new Point(219, 92);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(62, 40);
            btnAC.TabIndex = 4;
            btnAC.Text = "AC";
            btnAC.UseVisualStyleBackColor = false;
            btnAC.Click += btnAC_Click;
            // 
            // btnDivide
            // 
            btnDivide.AutoSize = true;
            btnDivide.BackColor = Color.White;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.ForeColor = Color.FromArgb(255, 128, 0);
            btnDivide.Location = new Point(219, 137);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(62, 40);
            btnDivide.TabIndex = 8;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnSquare
            // 
            btnSquare.AutoSize = true;
            btnSquare.BackColor = Color.White;
            btnSquare.FlatStyle = FlatStyle.Flat;
            btnSquare.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSquare.ForeColor = Color.FromArgb(255, 128, 0);
            btnSquare.Location = new Point(151, 137);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(62, 40);
            btnSquare.TabIndex = 7;
            btnSquare.Text = "x²";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnCube
            // 
            btnCube.AutoSize = true;
            btnCube.BackColor = Color.White;
            btnCube.FlatStyle = FlatStyle.Flat;
            btnCube.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCube.ForeColor = Color.FromArgb(255, 128, 0);
            btnCube.Location = new Point(83, 137);
            btnCube.Name = "btnCube";
            btnCube.Size = new Size(62, 40);
            btnCube.TabIndex = 6;
            btnCube.Text = "x³";
            btnCube.UseVisualStyleBackColor = false;
            btnCube.Click += btnCube_Click;
            // 
            // btnMulti
            // 
            btnMulti.AutoSize = true;
            btnMulti.BackColor = Color.White;
            btnMulti.FlatStyle = FlatStyle.Flat;
            btnMulti.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMulti.ForeColor = Color.FromArgb(255, 128, 0);
            btnMulti.Location = new Point(219, 182);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(62, 40);
            btnMulti.TabIndex = 12;
            btnMulti.Text = "×";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnNine
            // 
            btnNine.AutoSize = true;
            btnNine.BackColor = Color.White;
            btnNine.FlatStyle = FlatStyle.Flat;
            btnNine.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNine.ForeColor = Color.Fuchsia;
            btnNine.Location = new Point(151, 182);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(62, 40);
            btnNine.TabIndex = 11;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btn_Click;
            // 
            // btnEight
            // 
            btnEight.AutoSize = true;
            btnEight.BackColor = Color.White;
            btnEight.FlatStyle = FlatStyle.Flat;
            btnEight.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEight.ForeColor = Color.Fuchsia;
            btnEight.Location = new Point(83, 182);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(62, 40);
            btnEight.TabIndex = 10;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += btn_Click;
            // 
            // btnSeven
            // 
            btnSeven.AutoSize = true;
            btnSeven.BackColor = Color.White;
            btnSeven.FlatStyle = FlatStyle.Flat;
            btnSeven.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeven.ForeColor = Color.Fuchsia;
            btnSeven.Location = new Point(15, 182);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(62, 40);
            btnSeven.TabIndex = 9;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += btn_Click;
            // 
            // btnPlus
            // 
            btnPlus.AutoSize = true;
            btnPlus.BackColor = Color.White;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.ForeColor = Color.FromArgb(255, 128, 0);
            btnPlus.Location = new Point(219, 227);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(62, 40);
            btnPlus.TabIndex = 16;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnSix
            // 
            btnSix.AutoSize = true;
            btnSix.BackColor = Color.White;
            btnSix.FlatStyle = FlatStyle.Flat;
            btnSix.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSix.ForeColor = Color.Fuchsia;
            btnSix.Location = new Point(151, 227);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(62, 40);
            btnSix.TabIndex = 15;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btn_Click;
            // 
            // btnFive
            // 
            btnFive.AutoSize = true;
            btnFive.BackColor = Color.White;
            btnFive.FlatStyle = FlatStyle.Flat;
            btnFive.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFive.ForeColor = Color.Fuchsia;
            btnFive.Location = new Point(83, 227);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(62, 40);
            btnFive.TabIndex = 14;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btn_Click;
            // 
            // btnFour
            // 
            btnFour.AutoSize = true;
            btnFour.BackColor = Color.White;
            btnFour.FlatStyle = FlatStyle.Flat;
            btnFour.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFour.ForeColor = Color.Fuchsia;
            btnFour.Location = new Point(15, 227);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(62, 40);
            btnFour.TabIndex = 13;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btn_Click;
            // 
            // btnEql
            // 
            btnEql.AutoSize = true;
            btnEql.BackColor = Color.White;
            btnEql.FlatStyle = FlatStyle.Flat;
            btnEql.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEql.ForeColor = Color.FromArgb(0, 192, 0);
            btnEql.Location = new Point(151, 317);
            btnEql.Name = "btnEql";
            btnEql.Size = new Size(130, 40);
            btnEql.TabIndex = 20;
            btnEql.Text = "=";
            btnEql.UseVisualStyleBackColor = false;
            btnEql.Click += btnEql_Click;
            // 
            // btnInverse
            // 
            btnInverse.AutoSize = true;
            btnInverse.BackColor = Color.White;
            btnInverse.FlatStyle = FlatStyle.Flat;
            btnInverse.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnInverse.ForeColor = Color.FromArgb(255, 128, 0);
            btnInverse.Location = new Point(15, 137);
            btnInverse.Name = "btnInverse";
            btnInverse.Size = new Size(62, 40);
            btnInverse.TabIndex = 19;
            btnInverse.Text = "1/x";
            btnInverse.UseVisualStyleBackColor = false;
            btnInverse.Click += btnInverse_Click;
            // 
            // btnZero
            // 
            btnZero.AutoSize = true;
            btnZero.BackColor = Color.White;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnZero.ForeColor = Color.Fuchsia;
            btnZero.Location = new Point(83, 317);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(62, 40);
            btnZero.TabIndex = 18;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btn_Click;
            // 
            // btnDot
            // 
            btnDot.AutoSize = true;
            btnDot.BackColor = Color.White;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDot.ForeColor = Color.FromArgb(255, 128, 0);
            btnDot.Location = new Point(15, 317);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(62, 40);
            btnDot.TabIndex = 24;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            // 
            // btnThree
            // 
            btnThree.AutoSize = true;
            btnThree.BackColor = Color.White;
            btnThree.FlatStyle = FlatStyle.Flat;
            btnThree.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThree.ForeColor = Color.Fuchsia;
            btnThree.Location = new Point(151, 272);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(62, 40);
            btnThree.TabIndex = 23;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btn_Click;
            // 
            // btnTwo
            // 
            btnTwo.AutoSize = true;
            btnTwo.BackColor = Color.White;
            btnTwo.FlatStyle = FlatStyle.Flat;
            btnTwo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTwo.ForeColor = Color.Fuchsia;
            btnTwo.Location = new Point(83, 272);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(62, 40);
            btnTwo.TabIndex = 22;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btn_Click;
            // 
            // btnOne
            // 
            btnOne.AutoSize = true;
            btnOne.BackColor = Color.White;
            btnOne.FlatStyle = FlatStyle.Flat;
            btnOne.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOne.ForeColor = Color.Fuchsia;
            btnOne.Location = new Point(15, 272);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(62, 40);
            btnOne.TabIndex = 21;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btn_Click;
            // 
            // btnMinus
            // 
            btnMinus.AutoSize = true;
            btnMinus.BackColor = Color.White;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.ForeColor = Color.FromArgb(255, 128, 0);
            btnMinus.Location = new Point(219, 272);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(62, 40);
            btnMinus.TabIndex = 26;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // txtPreviousAnsr
            // 
            txtPreviousAnsr.BackColor = Color.FromArgb(235, 240, 255);
            txtPreviousAnsr.BorderStyle = BorderStyle.None;
            txtPreviousAnsr.Font = new Font("Segoe UI Historic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPreviousAnsr.ForeColor = Color.FromArgb(64, 64, 64);
            txtPreviousAnsr.Location = new Point(12, 12);
            txtPreviousAnsr.Name = "txtPreviousAnsr";
            txtPreviousAnsr.ReadOnly = true;
            txtPreviousAnsr.RightToLeft = RightToLeft.No;
            txtPreviousAnsr.Size = new Size(219, 15);
            txtPreviousAnsr.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(237, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(44, 22);
            panel1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(16, 16);
            panel2.TabIndex = 29;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 10;
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Interval = 10;
            timer4.Tick += timer4_Tick;
            // 
            // timer5
            // 
            timer5.Interval = 10;
            timer5.Tick += timer5_Tick;
            // 
            // timer6
            // 
            timer6.Interval = 10;
            timer6.Tick += timer6_Tick;
            // 
            // timer7
            // 
            timer7.Interval = 10;
            timer7.Tick += timer7_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 240, 255);
            ClientSize = new Size(293, 369);
            Controls.Add(panel1);
            Controls.Add(txtPreviousAnsr);
            Controls.Add(btnMinus);
            Controls.Add(btnDot);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnEql);
            Controls.Add(btnInverse);
            Controls.Add(btnZero);
            Controls.Add(btnPlus);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnMulti);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnDivide);
            Controls.Add(btnSquare);
            Controls.Add(btnCube);
            Controls.Add(btnAC);
            Controls.Add(btnFact);
            Controls.Add(btnPi);
            Controls.Add(btnUnderRoot);
            Controls.Add(txtFunc);
            Cursor = Cursors.PanNW;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculatior";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFunc;
        private Button btnUnderRoot;
        private Button btnPi;
        private Button btnFact;
        private Button btnAC;
        private Button btnDivide;
        private Button btnSquare;
        private Button btnCube;
        private Button btnMulti;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnPlus;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnEql;
        private Button btnInverse;
        private Button btnZero;
        private Button btnDot;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnMinus;
        private TextBox txtPreviousAnsr;
        private Panel panel1;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
    }
}