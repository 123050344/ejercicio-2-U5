namespace ejercicio_2_U5
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
            btncalculate = new Button();
            txtnumber2 = new TextBox();
            txtnumber1 = new TextBox();
            txttotal = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btncalculate
            // 
            btncalculate.BackColor = Color.FromArgb(255, 255, 128);
            btncalculate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btncalculate.Location = new Point(472, 109);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(171, 75);
            btncalculate.TabIndex = 0;
            btncalculate.Text = "Calculate";
            btncalculate.UseVisualStyleBackColor = false;
            btncalculate.Click += btncalculate_Click;
            // 
            // txtnumber2
            // 
            txtnumber2.BackColor = Color.Yellow;
            txtnumber2.Location = new Point(195, 191);
            txtnumber2.Name = "txtnumber2";
            txtnumber2.Size = new Size(199, 23);
            txtnumber2.TabIndex = 1;
            // 
            // txtnumber1
            // 
            txtnumber1.BackColor = Color.Yellow;
            txtnumber1.Location = new Point(195, 109);
            txtnumber1.Name = "txtnumber1";
            txtnumber1.Size = new Size(199, 23);
            txtnumber1.TabIndex = 2;
            // 
            // txttotal
            // 
            txttotal.BackColor = Color.Yellow;
            txttotal.Location = new Point(195, 262);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(199, 23);
            txttotal.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(472, 215);
            button2.Name = "button2";
            button2.Size = new Size(129, 70);
            button2.TabIndex = 4;
            button2.Text = "Clean";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 109);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 5;
            label1.Text = "Number one";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 186);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 6;
            label2.Text = "Number two";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(64, 260);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 7;
            label3.Text = "Total";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(262, 9);
            label4.Name = "label4";
            label4.Size = new Size(292, 40);
            label4.TabIndex = 8;
            label4.Text = "Sum of two numbers";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(txttotal);
            Controls.Add(txtnumber1);
            Controls.Add(txtnumber2);
            Controls.Add(btncalculate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalculate;
        private TextBox txtnumber2;
        private TextBox txtnumber1;
        private TextBox txttotal;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}