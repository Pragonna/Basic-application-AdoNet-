namespace Quizzes
{
    partial class QuizAPage
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
            btn1opt = new Button();
            btn2opt = new Button();
            label1 = new Label();
            btn4opt = new Button();
            btn3opt = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelKey = new Label();
            SuspendLayout();
            // 
            // btn1opt
            // 
            btn1opt.Location = new Point(208, 161);
            btn1opt.Name = "btn1opt";
            btn1opt.Size = new Size(123, 56);
            btn1opt.TabIndex = 0;
            btn1opt.Text = "button1";
            btn1opt.UseVisualStyleBackColor = true;
            btn1opt.Click += btn1opt_Click;
            // 
            // btn2opt
            // 
            btn2opt.Location = new Point(412, 161);
            btn2opt.Name = "btn2opt";
            btn2opt.Size = new Size(123, 56);
            btn2opt.TabIndex = 1;
            btn2opt.Text = "button2";
            btn2opt.UseVisualStyleBackColor = true;
            btn2opt.Click += btn2opt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 68);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // btn4opt
            // 
            btn4opt.Location = new Point(412, 244);
            btn4opt.Name = "btn4opt";
            btn4opt.Size = new Size(123, 56);
            btn4opt.TabIndex = 3;
            btn4opt.Text = "btn4opt";
            btn4opt.UseVisualStyleBackColor = true;
            btn4opt.Click += btn4opt_Click;
            // 
            // btn3opt
            // 
            btn3opt.Location = new Point(208, 244);
            btn3opt.Name = "btn3opt";
            btn3opt.Size = new Size(123, 56);
            btn3opt.TabIndex = 4;
            btn3opt.Text = "button1";
            btn3opt.UseVisualStyleBackColor = true;
            btn3opt.Click += btn3opt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(176, 165);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 5;
            label2.Text = "A)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(388, 165);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 6;
            label3.Text = "B)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(175, 244);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 7;
            label4.Text = "C)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(387, 244);
            label5.Name = "label5";
            label5.Size = new Size(26, 20);
            label5.TabIndex = 8;
            label5.Text = "D)";
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelKey.Location = new Point(166, 68);
            labelKey.Name = "labelKey";
            labelKey.Size = new Size(40, 15);
            labelKey.TabIndex = 9;
            labelKey.Text = "label6";
            // 
            // QuizAPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 404);
            Controls.Add(labelKey);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn3opt);
            Controls.Add(btn4opt);
            Controls.Add(label1);
            Controls.Add(btn2opt);
            Controls.Add(btn1opt);
            Name = "QuizAPage";
            Text = "QuizAPage";
            Load += QuizAPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1opt;
        private Button btn2opt;
        private Label label1;
        private Button btn4opt;
        private Button btn3opt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelKey;
    }
}