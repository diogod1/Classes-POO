namespace classes
{
    partial class Form2
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
            this.btn_multi2 = new System.Windows.Forms.Button();
            this.btn_soma2 = new System.Windows.Forms.Button();
            this.btn_div2 = new System.Windows.Forms.Button();
            this.btn_sub2 = new System.Windows.Forms.Button();
            this.lbl_num_1 = new System.Windows.Forms.Label();
            this.lbl_num_2 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_classes = new System.Windows.Forms.Button();
            this.lbl_resultado_2 = new System.Windows.Forms.Label();
            this.txt_num_1 = new System.Windows.Forms.TextBox();
            this.txt_num_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_multi2
            // 
            this.btn_multi2.Location = new System.Drawing.Point(303, 31);
            this.btn_multi2.Name = "btn_multi2";
            this.btn_multi2.Size = new System.Drawing.Size(75, 23);
            this.btn_multi2.TabIndex = 0;
            this.btn_multi2.Text = "Multiplicação";
            this.btn_multi2.UseVisualStyleBackColor = true;
            this.btn_multi2.Click += new System.EventHandler(this.btn_multi2_Click);
            // 
            // btn_soma2
            // 
            this.btn_soma2.Location = new System.Drawing.Point(303, 60);
            this.btn_soma2.Name = "btn_soma2";
            this.btn_soma2.Size = new System.Drawing.Size(75, 23);
            this.btn_soma2.TabIndex = 1;
            this.btn_soma2.Text = "Soma";
            this.btn_soma2.UseVisualStyleBackColor = true;
            this.btn_soma2.Click += new System.EventHandler(this.btn_soma2_Click);
            // 
            // btn_div2
            // 
            this.btn_div2.Location = new System.Drawing.Point(303, 89);
            this.btn_div2.Name = "btn_div2";
            this.btn_div2.Size = new System.Drawing.Size(75, 23);
            this.btn_div2.TabIndex = 2;
            this.btn_div2.Text = "Divisao";
            this.btn_div2.UseVisualStyleBackColor = true;
            this.btn_div2.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_sub2
            // 
            this.btn_sub2.Location = new System.Drawing.Point(303, 118);
            this.btn_sub2.Name = "btn_sub2";
            this.btn_sub2.Size = new System.Drawing.Size(75, 23);
            this.btn_sub2.TabIndex = 3;
            this.btn_sub2.Text = "Subtração";
            this.btn_sub2.UseVisualStyleBackColor = true;
            this.btn_sub2.Click += new System.EventHandler(this.btn_sub2_Click);
            // 
            // lbl_num_1
            // 
            this.lbl_num_1.AutoSize = true;
            this.lbl_num_1.Location = new System.Drawing.Point(42, 39);
            this.lbl_num_1.Name = "lbl_num_1";
            this.lbl_num_1.Size = new System.Drawing.Size(40, 15);
            this.lbl_num_1.TabIndex = 4;
            this.lbl_num_1.Text = "Num1";
            // 
            // lbl_num_2
            // 
            this.lbl_num_2.AutoSize = true;
            this.lbl_num_2.Location = new System.Drawing.Point(42, 68);
            this.lbl_num_2.Name = "lbl_num_2";
            this.lbl_num_2.Size = new System.Drawing.Size(40, 15);
            this.lbl_num_2.TabIndex = 5;
            this.lbl_num_2.Text = "Num2";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(33, 142);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(59, 15);
            this.lbl_resultado.TabIndex = 6;
            this.lbl_resultado.Text = "Resultado";
            // 
            // btn_classes
            // 
            this.btn_classes.Location = new System.Drawing.Point(303, 147);
            this.btn_classes.Name = "btn_classes";
            this.btn_classes.Size = new System.Drawing.Size(75, 23);
            this.btn_classes.TabIndex = 7;
            this.btn_classes.Text = "Classes";
            this.btn_classes.UseVisualStyleBackColor = true;
            this.btn_classes.Click += new System.EventHandler(this.btn_classes_Click);
            // 
            // lbl_resultado_2
            // 
            this.lbl_resultado_2.AutoSize = true;
            this.lbl_resultado_2.Location = new System.Drawing.Point(107, 142);
            this.lbl_resultado_2.Name = "lbl_resultado_2";
            this.lbl_resultado_2.Size = new System.Drawing.Size(0, 15);
            this.lbl_resultado_2.TabIndex = 8;
            // 
            // txt_num_1
            // 
            this.txt_num_1.Location = new System.Drawing.Point(107, 36);
            this.txt_num_1.Name = "txt_num_1";
            this.txt_num_1.Size = new System.Drawing.Size(100, 23);
            this.txt_num_1.TabIndex = 9;
            // 
            // txt_num_2
            // 
            this.txt_num_2.Location = new System.Drawing.Point(107, 68);
            this.txt_num_2.Name = "txt_num_2";
            this.txt_num_2.Size = new System.Drawing.Size(100, 23);
            this.txt_num_2.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 194);
            this.Controls.Add(this.txt_num_2);
            this.Controls.Add(this.txt_num_1);
            this.Controls.Add(this.lbl_resultado_2);
            this.Controls.Add(this.btn_classes);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_num_2);
            this.Controls.Add(this.lbl_num_1);
            this.Controls.Add(this.btn_sub2);
            this.Controls.Add(this.btn_div2);
            this.Controls.Add(this.btn_soma2);
            this.Controls.Add(this.btn_multi2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_multi2;
        private Button btn_soma2;
        private Button btn_div2;
        private Button btn_sub2;
        private Label lbl_num_1;
        private Label lbl_num_2;
        private Label lbl_resultado;
        private Button btn_classes;
        private Label lbl_resultado_2;
        private TextBox txt_num_1;
        private TextBox txt_num_2;
    }
}