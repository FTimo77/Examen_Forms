namespace Examen
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
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(102, 112);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 0;
            button1.Text = "Añadir Alumno";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(212, 112);
            button2.Name = "button2";
            button2.Size = new Size(109, 23);
            button2.TabIndex = 1;
            button2.Text = "Eliminar Alumno";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(327, 112);
            button3.Name = "button3";
            button3.Size = new Size(122, 23);
            button3.TabIndex = 2;
            button3.Text = "Modificar Alumno";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(203, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(360, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 165);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 4;
            label1.Text = "Mostrar Alumnos";
            // 
            // button4
            // 
            button4.Location = new Point(455, 112);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "Aprobados";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(536, 112);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "Suspensos";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private Label label1;
        private Button button4;
        private Button button5;
    }
}
