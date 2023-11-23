namespace Quizzes.Quizzes
{
    partial class QuizBPage
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
            btn1optl = new Button();
            btn4optl = new Button();
            btn2optl = new Button();
            btn3optl = new Button();
            labelQuest = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelKey = new Label();
            SuspendLayout();
            // 
            // btn1optl
            // 
            btn1optl.Location = new Point(178, 158);
            btn1optl.Name = "btn1optl";
            btn1optl.Size = new Size(110, 49);
            btn1optl.TabIndex = 0;
            btn1optl.Text = "button1";
            btn1optl.UseVisualStyleBackColor = true;
            btn1optl.Click += btn1optl_Click;
            // 
            // btn4optl
            // 
            btn4optl.Location = new Point(356, 229);
            btn4optl.Name = "btn4optl";
            btn4optl.Size = new Size(110, 49);
            btn4optl.TabIndex = 1;
            btn4optl.Text = "button2";
            btn4optl.UseVisualStyleBackColor = true;
            btn4optl.Click += btn4optl_Click;
            // 
            // btn2optl
            // 
            btn2optl.Location = new Point(356, 158);
            btn2optl.Name = "btn2optl";
            btn2optl.Size = new Size(110, 49);
            btn2optl.TabIndex = 2;
            btn2optl.Text = "button3";
            btn2optl.UseVisualStyleBackColor = true;
            btn2optl.Click += btn2optl_Click;
            // 
            // btn3optl
            // 
            btn3optl.Location = new Point(178, 229);
            btn3optl.Name = "btn3optl";
            btn3optl.Size = new Size(110, 49);
            btn3optl.TabIndex = 3;
            btn3optl.Text = "button4";
            btn3optl.UseVisualStyleBackColor = true;
            btn3optl.Click += btn3optl_Click;
            // 
            // labelQuest
            // 
            labelQuest.AutoSize = true;
            labelQuest.Location = new Point(86, 105);
            labelQuest.Name = "labelQuest";
            labelQuest.Size = new Size(38, 15);
            labelQuest.TabIndex = 4;
            labelQuest.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(153, 162);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 5;
            label1.Text = "A)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(332, 162);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 6;
            label2.Text = "B)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(331, 246);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 7;
            label3.Text = "D)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(153, 246);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 8;
            label4.Text = "C)";
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelKey.Location = new Point(27, 105);
            labelKey.Name = "labelKey";
            labelKey.Size = new Size(53, 15);
            labelKey.TabIndex = 9;
            labelKey.Text = "labelKEy";
            // 
            // QuizBPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 393);
            Controls.Add(labelKey);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelQuest);
            Controls.Add(btn3optl);
            Controls.Add(btn2optl);
            Controls.Add(btn4optl);
            Controls.Add(btn1optl);
            Name = "QuizBPage";
            Text = "QuizBPage";
            Load += QuizBPage_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1optl;
        private Button btn4optl;
        private Button btn2optl;
        private Button btn3optl;
        private Label labelQuest;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelKey;
    }
}