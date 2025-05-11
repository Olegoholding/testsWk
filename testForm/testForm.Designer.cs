namespace dimaWk.testForm
{
    partial class testForm
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
            this.questionLbl = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.userLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.markLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trueAnswersCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.questionCount = new System.Windows.Forms.Label();
            this.testName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLbl.Location = new System.Drawing.Point(13, 50);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(267, 25);
            this.questionLbl.TabIndex = 2;
            this.questionLbl.Text = "Описания вопроса пока нет";
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nextBtn.Location = new System.Drawing.Point(714, 497);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(224, 83);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Следующий вопрос";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirmBtn.Location = new System.Drawing.Point(18, 497);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(224, 83);
            this.confirmBtn.TabIndex = 6;
            this.confirmBtn.Text = "Подтвердить выбор";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.userLbl);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.markLbl);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.trueAnswersCount);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.questionCount);
            this.panel.Controls.Add(this.testName);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(943, 567);
            this.panel.TabIndex = 7;
            this.panel.Visible = false;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLbl.Location = new System.Drawing.Point(687, 220);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(95, 32);
            this.userLbl.TabIndex = 8;
            this.userLbl.Text = "Число";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(470, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Кто проходил?";
            // 
            // markLbl
            // 
            this.markLbl.AutoSize = true;
            this.markLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markLbl.Location = new System.Drawing.Point(829, 279);
            this.markLbl.Name = "markLbl";
            this.markLbl.Size = new System.Drawing.Size(49, 54);
            this.markLbl.TabIndex = 6;
            this.markLbl.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(470, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Оценка за прохождение:";
            // 
            // trueAnswersCount
            // 
            this.trueAnswersCount.AutoSize = true;
            this.trueAnswersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trueAnswersCount.Location = new System.Drawing.Point(348, 297);
            this.trueAnswersCount.Name = "trueAnswersCount";
            this.trueAnswersCount.Size = new System.Drawing.Size(95, 32);
            this.trueAnswersCount.TabIndex = 4;
            this.trueAnswersCount.Text = "Число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Правильных ответов:";
            // 
            // questionCount
            // 
            this.questionCount.AutoSize = true;
            this.questionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionCount.Location = new System.Drawing.Point(292, 220);
            this.questionCount.Name = "questionCount";
            this.questionCount.Size = new System.Drawing.Size(95, 32);
            this.questionCount.TabIndex = 2;
            this.questionCount.Text = "Число";
            // 
            // testName
            // 
            this.testName.AutoSize = true;
            this.testName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testName.Location = new System.Drawing.Point(27, 30);
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(25, 32);
            this.testName.TabIndex = 1;
            this.testName.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Всего вопросов:";
            // 
            // flowLayout
            // 
            this.flowLayout.Location = new System.Drawing.Point(18, 79);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(872, 412);
            this.flowLayout.TabIndex = 8;
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 582);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.questionLbl);
            this.Name = "testForm";
            this.Text = "Прохождение теста";
            this.Load += new System.EventHandler(this.testForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label markLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label trueAnswersCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label questionCount;
        private System.Windows.Forms.Label testName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
    }
}