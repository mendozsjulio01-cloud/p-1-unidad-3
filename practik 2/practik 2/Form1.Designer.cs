namespace practik_2
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
            button1 = new Button();
            calificacion = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(391, 276);
            button1.Name = "button1";
            button1.Size = new Size(312, 130);
            button1.TabIndex = 0;
            button1.Text = "desicion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // calificacion
            // 
            calificacion.AutoSize = true;
            calificacion.Location = new Point(92, 117);
            calificacion.Name = "calificacion";
            calificacion.Size = new Size(84, 20);
            calificacion.TabIndex = 1;
            calificacion.Text = "calificacion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(351, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(calificacion);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label calificacion;
        private TextBox textBox1;
    }
}
