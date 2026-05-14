namespace CalculatorGUI
{
    partial class CalculatorForm
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
            this.nbr_1 = new System.Windows.Forms.Button();
            this.nbr_2 = new System.Windows.Forms.Button();
            this.nbr_3 = new System.Windows.Forms.Button();
            this.nbr_0 = new System.Windows.Forms.Button();
            this.nbr_6 = new System.Windows.Forms.Button();
            this.nbr_5 = new System.Windows.Forms.Button();
            this.nbr_4 = new System.Windows.Forms.Button();
            this.nbr_9 = new System.Windows.Forms.Button();
            this.nbr_8 = new System.Windows.Forms.Button();
            this.nbr_7 = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.expression_bar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nbr_1
            // 
            this.nbr_1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nbr_1.Location = new System.Drawing.Point(10, 246);
            this.nbr_1.Margin = new System.Windows.Forms.Padding(1);
            this.nbr_1.Name = "nbr_1";
            this.nbr_1.Size = new System.Drawing.Size(85, 60);
            this.nbr_1.TabIndex = 20;
            this.nbr_1.Text = "1";
            this.nbr_1.UseVisualStyleBackColor = true;
            this.nbr_1.Click += new System.EventHandler(this.digit_button_Click);
            // 
            // nbr_2
            // 
            this.nbr_2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nbr_2.Location = new System.Drawing.Point(95, 246);
            this.nbr_2.Margin = new System.Windows.Forms.Padding(1);
            this.nbr_2.Name = "nbr_2";
            this.nbr_2.Size = new System.Drawing.Size(85, 60);
            this.nbr_2.TabIndex = 1;
            this.nbr_2.Text = "2";
            this.nbr_2.UseVisualStyleBackColor = true;
            this.nbr_2.Click += new System.EventHandler(this.digit_button_Click);
            // 
            // nbr_3
            // 
            this.nbr_3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nbr_3.Location = new System.Drawing.Point(180, 246);
            this.nbr_3.Margin = new System.Windows.Forms.Padding(1);
            this.nbr_3.Name = "nbr_3";
            this.nbr_3.Size = new System.Drawing.Size(85, 60);
            this.nbr_3.TabIndex = 2;
            this.nbr_3.Text = "3";
            this.nbr_3.UseVisualStyleBackColor = true;
            this.nbr_3.Click += new System.EventHandler(this.digit_button_Click);
            // 
            // nbr_0
            // 
            this.nbr_0.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nbr_0.Location = new System.Drawing.Point(95, 306);
            this.nbr_0.Margin = new System.Windows.Forms.Padding(1);
            this.nbr_0.Name = "nbr_0";
            this.nbr_0.Size = new System.Drawing.Size(85, 60);
            this.nbr_0.TabIndex = 3;
            this.nbr_0.Text = "0";
            this.nbr_0.UseVisualStyleBackColor = true;
            this.nbr_0.Click += new System.EventHandler(this.digit_button_Click);
            // 
            // nbr_6
            // 
            this.nbr_6.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nbr_6.Location = new System.Drawing.Point(180, 186);
            this.nbr_6.Margin = new System.Windows.Forms.Padding(1);
            this.nbr_6.Name = "nbr_6";
            this.nbr_6.Size = new System.Drawing.Size(85, 60);
            this.nbr_6.TabIndex = 6;
            this.nbr_6.Text = "6";
            this.nbr_6.UseVisualStyleBackColor = true;
            this.nbr_6.Click += new System.EventHandler(this.digit_button_Click);
            // 
            // nbr_5
            // 
            this.nbr_5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nbr_5.Location = new System.Drawing.Point(95, 186);
            this.nbr_5.Margin = new System.Windows.Forms.Padding(1);
            this.nbr_5.Name = "nbr_5";
            this.nbr_5.Size = new System.Drawing.Size(85, 60);
            this.nbr_5.TabIndex = 5;
            this.nbr_5.Text = "5";
            this.nbr_5.UseVisualStyleBackColor = true;
            this.nbr_5.Click += new System.EventHandler(this.digit_button_Click);
            // 
            // nbr_4
            // 
            this.nbr_4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nbr_4.Location = new System.Drawing.Point(10, 186);
            this.nbr_4.Margin = new System.Windows.Forms.Padding(1);
            this.nbr_4.Name = "nbr_4";
            this.nbr_4.Size = new System.Drawing.Size(85, 60);
            this.nbr_4.TabIndex = 4;
            this.nbr_4.Text = "4";
            this.nbr_4.UseVisualStyleBackColor = true;
            this.nbr_4.Click += new System.EventHandler(this.digit_button_Click);
            // 
            // nbr_9
            // 
            this.nbr_9.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nbr_9.Location = new System.Drawing.Point(180, 126);
            this.nbr_9.Margin = new System.Windows.Forms.Padding(1);
            this.nbr_9.Name = "nbr_9";
            this.nbr_9.Size = new System.Drawing.Size(85, 60);
            this.nbr_9.TabIndex = 9;
            this.nbr_9.Text = "9";
            this.nbr_9.UseVisualStyleBackColor = true;
            this.nbr_9.Click += new System.EventHandler(this.digit_button_Click);
            // 
            // nbr_8
            // 
            this.nbr_8.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nbr_8.Location = new System.Drawing.Point(95, 126);
            this.nbr_8.Margin = new System.Windows.Forms.Padding(1);
            this.nbr_8.Name = "nbr_8";
            this.nbr_8.Size = new System.Drawing.Size(85, 60);
            this.nbr_8.TabIndex = 8;
            this.nbr_8.Text = "8";
            this.nbr_8.UseVisualStyleBackColor = true;
            this.nbr_8.Click += new System.EventHandler(this.digit_button_Click);
            // 
            // nbr_7
            // 
            this.nbr_7.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.nbr_7.Location = new System.Drawing.Point(10, 126);
            this.nbr_7.Margin = new System.Windows.Forms.Padding(1);
            this.nbr_7.Name = "nbr_7";
            this.nbr_7.Size = new System.Drawing.Size(85, 60);
            this.nbr_7.TabIndex = 7;
            this.nbr_7.Text = "7";
            this.nbr_7.UseVisualStyleBackColor = true;
            this.nbr_7.Click += new System.EventHandler(this.digit_button_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_equal.Location = new System.Drawing.Point(180, 306);
            this.btn_equal.Margin = new System.Windows.Forms.Padding(1);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(85, 60);
            this.btn_equal.TabIndex = 0;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(10, 306);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(1);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(85, 60);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_plus.Location = new System.Drawing.Point(265, 306);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(1);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(85, 60);
            this.btn_plus.TabIndex = 15;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.operator_button_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_divide.Location = new System.Drawing.Point(265, 126);
            this.btn_divide.Margin = new System.Windows.Forms.Padding(1);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(85, 60);
            this.btn_divide.TabIndex = 14;
            this.btn_divide.Text = "÷";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.operator_button_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_multiply.Location = new System.Drawing.Point(265, 186);
            this.btn_multiply.Margin = new System.Windows.Forms.Padding(1);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(85, 60);
            this.btn_multiply.TabIndex = 13;
            this.btn_multiply.Text = "×";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.operator_button_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_minus.Location = new System.Drawing.Point(265, 246);
            this.btn_minus.Margin = new System.Windows.Forms.Padding(1);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(85, 60);
            this.btn_minus.TabIndex = 12;
            this.btn_minus.Text = "−";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.operator_button_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.Control;
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(12, 68);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(338, 46);
            this.display.TabIndex = 21;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // expression_bar
            // 
            this.expression_bar.BackColor = System.Drawing.SystemColors.Control;
            this.expression_bar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expression_bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.expression_bar.Location = new System.Drawing.Point(12, 45);
            this.expression_bar.Name = "expression_bar";
            this.expression_bar.ReadOnly = true;
            this.expression_bar.Size = new System.Drawing.Size(338, 17);
            this.expression_bar.TabIndex = 22;
            this.expression_bar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            this.AcceptButton = this.btn_equal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 376);
            this.Controls.Add(this.expression_bar);
            this.Controls.Add(this.display);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.nbr_9);
            this.Controls.Add(this.nbr_8);
            this.Controls.Add(this.nbr_7);
            this.Controls.Add(this.nbr_6);
            this.Controls.Add(this.nbr_5);
            this.Controls.Add(this.nbr_4);
            this.Controls.Add(this.nbr_0);
            this.Controls.Add(this.nbr_3);
            this.Controls.Add(this.nbr_2);
            this.Controls.Add(this.nbr_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalculatorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nbr_1;
        private System.Windows.Forms.Button nbr_2;
        private System.Windows.Forms.Button nbr_3;
        private System.Windows.Forms.Button nbr_0;
        private System.Windows.Forms.Button nbr_6;
        private System.Windows.Forms.Button nbr_5;
        private System.Windows.Forms.Button nbr_4;
        private System.Windows.Forms.Button nbr_9;
        private System.Windows.Forms.Button nbr_8;
        private System.Windows.Forms.Button nbr_7;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.TextBox expression_bar;
    }
}

