namespace classes
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
            this.lblreduzir = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.btn_soma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_subtrac = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_form2 = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblreduzir
            // 
            this.lblreduzir.AutoSize = true;
            this.lblreduzir.Location = new System.Drawing.Point(44, 46);
            this.lblreduzir.Name = "lblreduzir";
            this.lblreduzir.Size = new System.Drawing.Size(40, 15);
            this.lblreduzir.TabIndex = 0;
            this.lblreduzir.Text = "Num1";
            this.lblreduzir.Click += new System.EventHandler(this.lblreduzir_Click);
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(108, 46);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(100, 23);
            this.txt_num1.TabIndex = 1;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(108, 89);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(100, 23);
            this.txt_num2.TabIndex = 2;
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(275, 38);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(75, 23);
            this.btn_soma.TabIndex = 3;
            this.btn_soma.Text = "Soma";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Num2";
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(275, 67);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 23);
            this.btn_div.TabIndex = 5;
            this.btn_div.Text = "Divisao";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_subtrac
            // 
            this.btn_subtrac.Location = new System.Drawing.Point(275, 96);
            this.btn_subtrac.Name = "btn_subtrac";
            this.btn_subtrac.Size = new System.Drawing.Size(75, 23);
            this.btn_subtrac.TabIndex = 6;
            this.btn_subtrac.Text = "Subtração";
            this.btn_subtrac.UseVisualStyleBackColor = true;
            this.btn_subtrac.Click += new System.EventHandler(this.btn_subtrac_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resultado:";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(108, 126);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 15);
            this.lbl_result.TabIndex = 8;
            // 
            // btn_form2
            // 
            this.btn_form2.Location = new System.Drawing.Point(275, 126);
            this.btn_form2.Name = "btn_form2";
            this.btn_form2.Size = new System.Drawing.Size(75, 23);
            this.btn_form2.TabIndex = 9;
            this.btn_form2.Text = "Estático";
            this.btn_form2.UseVisualStyleBackColor = true;
            this.btn_form2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Location = new System.Drawing.Point(275, 9);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(75, 23);
            this.btn_multi.TabIndex = 10;
            this.btn_multi.Text = "Multiplicação";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(368, 126);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Sair";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 173);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_form2);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_subtrac);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.lblreduzir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label lblreduzir;
        private TextBox txt_num1;
        private TextBox txt_num2;
        private Button btn_soma;
        private Label label1;
        private Button btn_div;
        private Button btn_subtrac;
        private Label label2;
        private Label lbl_result;
        private Button btn_form2;
        private Button btn_multi;
        private Button btn_exit;
    }
}