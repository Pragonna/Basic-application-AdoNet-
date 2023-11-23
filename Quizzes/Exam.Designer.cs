namespace Quizzes
{
    partial class Exam
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            btnResult = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(15, 30);
            button1.Name = "button1";
            button1.Size = new Size(149, 127);
            button1.TabIndex = 0;
            button1.Text = "Quiz A";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(193, 30);
            button2.Name = "button2";
            button2.Size = new Size(149, 127);
            button2.TabIndex = 1;
            button2.Text = "Quiz B";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Yi Baiti", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(45, 12);
            label1.TabIndex = 2;
            label1.Text = "InMemory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Yi Baiti", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(193, 30);
            label2.Name = "label2";
            label2.Size = new Size(69, 12);
            label2.TabIndex = 3;
            label2.Text = "From Database";
            // 
            // btnResult
            // 
            btnResult.Location = new Point(125, 176);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(105, 34);
            btnResult.TabIndex = 4;
            btnResult.Text = "Result";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // Exam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 222);
            Controls.Add(btnResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Exam";
            Text = "Exam";
            Load += Exam_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button btnResult;
    }
}