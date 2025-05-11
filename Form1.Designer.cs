namespace dimaWk
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nazvaniyeEdit = new System.Windows.Forms.TextBox();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.testCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.testNameEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trueEdit = new System.Windows.Forms.TextBox();
            this.vopros = new System.Windows.Forms.Label();
            this.addOtvet = new System.Windows.Forms.Button();
            this.addVopros = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.infLbl = new System.Windows.Forms.Label();
            this.cofirmBtn = new System.Windows.Forms.Button();
            this.flowLayout1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.userEdit = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.dltBtn = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.back1Btn = new System.Windows.Forms.Button();
            this.back2Btn = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.backBtn);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.nazvaniyeEdit);
            this.mainPanel.Controls.Add(this.flowLayout);
            this.mainPanel.Controls.Add(this.testCreate);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.testNameEdit);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.trueEdit);
            this.mainPanel.Controls.Add(this.vopros);
            this.mainPanel.Controls.Add(this.addOtvet);
            this.mainPanel.Controls.Add(this.addVopros);
            this.mainPanel.Location = new System.Drawing.Point(1, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(944, 541);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Варианты ответов";
            // 
            // nazvaniyeEdit
            // 
            this.nazvaniyeEdit.Enabled = false;
            this.nazvaniyeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazvaniyeEdit.Location = new System.Drawing.Point(8, 133);
            this.nazvaniyeEdit.Name = "nazvaniyeEdit";
            this.nazvaniyeEdit.Size = new System.Drawing.Size(384, 34);
            this.nazvaniyeEdit.TabIndex = 11;
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.Location = new System.Drawing.Point(11, 199);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(926, 258);
            this.flowLayout.TabIndex = 10;
            // 
            // testCreate
            // 
            this.testCreate.Location = new System.Drawing.Point(190, 18);
            this.testCreate.Name = "testCreate";
            this.testCreate.Size = new System.Drawing.Size(202, 34);
            this.testCreate.TabIndex = 9;
            this.testCreate.Text = "Создать тест";
            this.testCreate.UseVisualStyleBackColor = true;
            this.testCreate.Click += new System.EventHandler(this.testCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название теста";
            // 
            // testNameEdit
            // 
            this.testNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testNameEdit.Location = new System.Drawing.Point(8, 55);
            this.testNameEdit.Name = "testNameEdit";
            this.testNameEdit.Size = new System.Drawing.Size(384, 34);
            this.testNameEdit.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Правильный вариант ответа";
            // 
            // trueEdit
            // 
            this.trueEdit.Enabled = false;
            this.trueEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trueEdit.Location = new System.Drawing.Point(8, 486);
            this.trueEdit.Name = "trueEdit";
            this.trueEdit.Size = new System.Drawing.Size(698, 34);
            this.trueEdit.TabIndex = 5;
            // 
            // vopros
            // 
            this.vopros.AutoSize = true;
            this.vopros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vopros.Location = new System.Drawing.Point(6, 105);
            this.vopros.Name = "vopros";
            this.vopros.Size = new System.Drawing.Size(178, 25);
            this.vopros.TabIndex = 3;
            this.vopros.Text = "Название вопроса";
            // 
            // addOtvet
            // 
            this.addOtvet.Enabled = false;
            this.addOtvet.Location = new System.Drawing.Point(425, 18);
            this.addOtvet.Name = "addOtvet";
            this.addOtvet.Size = new System.Drawing.Size(281, 149);
            this.addOtvet.TabIndex = 2;
            this.addOtvet.Text = "Добавить вариант ответа";
            this.addOtvet.UseVisualStyleBackColor = true;
            this.addOtvet.Click += new System.EventHandler(this.addOtvet_Click);
            // 
            // addVopros
            // 
            this.addVopros.Enabled = false;
            this.addVopros.Location = new System.Drawing.Point(717, 485);
            this.addVopros.Name = "addVopros";
            this.addVopros.Size = new System.Drawing.Size(214, 38);
            this.addVopros.TabIndex = 0;
            this.addVopros.Text = "Создать вопрос";
            this.addVopros.UseVisualStyleBackColor = true;
            this.addVopros.Click += new System.EventHandler(this.addVopros_Click);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.back1Btn);
            this.panelUser.Controls.Add(this.infLbl);
            this.panelUser.Controls.Add(this.cofirmBtn);
            this.panelUser.Controls.Add(this.flowLayout1);
            this.panelUser.Controls.Add(this.addUser);
            this.panelUser.Controls.Add(this.label5);
            this.panelUser.Controls.Add(this.userEdit);
            this.panelUser.Location = new System.Drawing.Point(8, 20);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(921, 534);
            this.panelUser.TabIndex = 3;
            this.panelUser.Visible = false;
            // 
            // infLbl
            // 
            this.infLbl.AutoSize = true;
            this.infLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infLbl.Location = new System.Drawing.Point(14, 189);
            this.infLbl.Name = "infLbl";
            this.infLbl.Size = new System.Drawing.Size(173, 25);
            this.infLbl.TabIndex = 6;
            this.infLbl.Text = "Выбранный тест:";
            // 
            // cofirmBtn
            // 
            this.cofirmBtn.Enabled = false;
            this.cofirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cofirmBtn.Location = new System.Drawing.Point(17, 459);
            this.cofirmBtn.Name = "cofirmBtn";
            this.cofirmBtn.Size = new System.Drawing.Size(878, 69);
            this.cofirmBtn.TabIndex = 5;
            this.cofirmBtn.Text = "Подтвердить выбор";
            this.cofirmBtn.UseVisualStyleBackColor = true;
            this.cofirmBtn.Click += new System.EventHandler(this.cofirmBtn_Click);
            // 
            // flowLayout1
            // 
            this.flowLayout1.AutoScroll = true;
            this.flowLayout1.Location = new System.Drawing.Point(19, 217);
            this.flowLayout1.Name = "flowLayout1";
            this.flowLayout1.Size = new System.Drawing.Size(876, 239);
            this.flowLayout1.TabIndex = 3;
            // 
            // addUser
            // 
            this.addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUser.Location = new System.Drawing.Point(17, 105);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(878, 78);
            this.addUser.TabIndex = 2;
            this.addUser.Text = "Внести имя";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Фамилия проходящего";
            // 
            // userEdit
            // 
            this.userEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userEdit.Location = new System.Drawing.Point(19, 50);
            this.userEdit.Name = "userEdit";
            this.userEdit.Size = new System.Drawing.Size(876, 34);
            this.userEdit.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.back2Btn);
            this.panel.Controls.Add(this.dltBtn);
            this.panel.Controls.Add(this.dataGrid);
            this.panel.Location = new System.Drawing.Point(8, 21);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(925, 534);
            this.panel.TabIndex = 4;
            this.panel.Visible = false;
            // 
            // dltBtn
            // 
            this.dltBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dltBtn.Location = new System.Drawing.Point(13, 477);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(910, 51);
            this.dltBtn.TabIndex = 1;
            this.dltBtn.Text = "Удалить запись";
            this.dltBtn.UseVisualStyleBackColor = true;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(11, 50);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(910, 420);
            this.dataGrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(8, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(445, 95);
            this.button1.TabIndex = 5;
            this.button1.Text = "Создать тест";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createTest_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(465, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(468, 95);
            this.button2.TabIndex = 6;
            this.button2.Text = "Пройти тест";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.runTest_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(8, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 51);
            this.button3.TabIndex = 7;
            this.button3.Text = "Просмотерть результаты";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.allResult_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(301, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(335, 51);
            this.button4.TabIndex = 8;
            this.button4.Text = "Просмотерть вопросы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.voprosiCheck_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(642, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(287, 51);
            this.button5.TabIndex = 9;
            this.button5.Text = "Просмотерть тесты";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.lookTest_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(465, 224);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(468, 95);
            this.button6.TabIndex = 11;
            this.button6.Text = "Выход";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(8, 224);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(445, 95);
            this.button7.TabIndex = 10;
            this.button7.Text = "О программе";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.help_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(726, 22);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(202, 145);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "Вернуться назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // back1Btn
            // 
            this.back1Btn.Enabled = false;
            this.back1Btn.Location = new System.Drawing.Point(798, 3);
            this.back1Btn.Name = "back1Btn";
            this.back1Btn.Size = new System.Drawing.Size(108, 44);
            this.back1Btn.TabIndex = 14;
            this.back1Btn.Text = "Вернуться назад";
            this.back1Btn.UseVisualStyleBackColor = true;
            this.back1Btn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // back2Btn
            // 
            this.back2Btn.Enabled = false;
            this.back2Btn.Location = new System.Drawing.Point(11, 3);
            this.back2Btn.Name = "back2Btn";
            this.back2Btn.Size = new System.Drawing.Size(108, 44);
            this.back2Btn.TabIndex = 15;
            this.back2Btn.Text = "Вернуться назад";
            this.back2Btn.UseVisualStyleBackColor = true;
            this.back2Btn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 567);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "mainForm";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox trueEdit;
        private System.Windows.Forms.Label vopros;
        private System.Windows.Forms.Button addOtvet;
        private System.Windows.Forms.Button addVopros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox testNameEdit;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.TextBox nazvaniyeEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button testCreate;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayout1;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userEdit;
        private System.Windows.Forms.Button cofirmBtn;
        private System.Windows.Forms.Label infLbl;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button dltBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button back1Btn;
        private System.Windows.Forms.Button back2Btn;
    }
}

