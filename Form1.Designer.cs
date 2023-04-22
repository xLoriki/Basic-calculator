using System;
using System.ComponentModel;

namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelKalkulator = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonPow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button0 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox.ForeColor = System.Drawing.Color.Black;
            this.textBox.Location = new System.Drawing.Point(19, 230);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox.Size = new System.Drawing.Size(306, 70);
            this.textBox.TabIndex = 2;
            this.textBox.TabStop = false;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelKalkulator
            // 
            this.labelKalkulator.AutoSize = true;
            this.labelKalkulator.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelKalkulator.Font = new System.Drawing.Font("Cascadia Code", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKalkulator.ForeColor = System.Drawing.Color.Black;
            this.labelKalkulator.Location = new System.Drawing.Point(14, 9);
            this.labelKalkulator.Name = "labelKalkulator";
            this.labelKalkulator.Size = new System.Drawing.Size(307, 63);
            this.labelKalkulator.TabIndex = 3;
            this.labelKalkulator.Text = "CALCULATOR";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(59, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(111, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(167, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(59, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(111, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(167, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 30);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(59, 98);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 30);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gainsboro;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(111, 98);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 30);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gainsboro;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(167, 98);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 30);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonEqual.ForeColor = System.Drawing.Color.Black;
            this.buttonEqual.Location = new System.Drawing.Point(223, 98);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(90, 30);
            this.buttonEqual.TabIndex = 10;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonDivision.ForeColor = System.Drawing.Color.Black;
            this.buttonDivision.Location = new System.Drawing.Point(268, 69);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(45, 30);
            this.buttonDivision.TabIndex = 14;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonMultiplication.ForeColor = System.Drawing.Color.Black;
            this.buttonMultiplication.Location = new System.Drawing.Point(223, 69);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(47, 30);
            this.buttonMultiplication.TabIndex = 13;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonMinus.ForeColor = System.Drawing.Color.Black;
            this.buttonMinus.Location = new System.Drawing.Point(268, 43);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(45, 30);
            this.buttonMinus.TabIndex = 12;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPlus.ForeColor = System.Drawing.Color.Black;
            this.buttonPlus.Location = new System.Drawing.Point(223, 43);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(47, 30);
            this.buttonPlus.TabIndex = 11;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonC.ForeColor = System.Drawing.Color.Black;
            this.buttonC.Location = new System.Drawing.Point(263, 17);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(50, 30);
            this.buttonC.TabIndex = 17;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSqrt.ForeColor = System.Drawing.Color.Black;
            this.buttonSqrt.Location = new System.Drawing.Point(13, 43);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(50, 30);
            this.buttonSqrt.TabIndex = 15;
            this.buttonSqrt.Text = "sqrt";
            this.buttonSqrt.UseVisualStyleBackColor = false;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonPow
            // 
            this.buttonPow.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPow.ForeColor = System.Drawing.Color.Black;
            this.buttonPow.Location = new System.Drawing.Point(13, 69);
            this.buttonPow.Name = "buttonPow";
            this.buttonPow.Size = new System.Drawing.Size(50, 30);
            this.buttonPow.TabIndex = 16;
            this.buttonPow.Text = "^";
            this.buttonPow.UseVisualStyleBackColor = false;
            this.buttonPow.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.buttonPow);
            this.panel1.Controls.Add(this.buttonSqrt);
            this.panel1.Controls.Add(this.buttonC);
            this.panel1.Controls.Add(this.buttonPlus);
            this.panel1.Controls.Add(this.buttonMinus);
            this.panel1.Controls.Add(this.buttonMultiplication);
            this.panel1.Controls.Add(this.buttonDivision);
            this.panel1.Controls.Add(this.buttonEqual);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 130);
            this.panel1.TabIndex = 1;
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Gainsboro;
            this.button0.ForeColor = System.Drawing.Color.Black;
            this.button0.Location = new System.Drawing.Point(13, 98);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 30);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(340, 448);
            this.Controls.Add(this.labelKalkulator);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(356, 487);
            this.MinimumSize = new System.Drawing.Size(356, 487);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelKalkulator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonPow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button0;
    }
}

