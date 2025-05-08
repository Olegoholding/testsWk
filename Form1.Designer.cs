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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTest = new System.Windows.Forms.ToolStripMenuItem();
            this.runTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.infLbl = new System.Windows.Forms.Label();
            this.cofirmBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayout1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.userEdit = new System.Windows.Forms.TextBox();
            this.allResult = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel = new System.Windows.Forms.Panel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTest,
            this.runTest,
            this.toolStripSeparator1,
            this.allResult,
            this.toolStripSeparator2,
            this.exitBtn});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // createTest
            // 
            this.createTest.Name = "createTest";
            this.createTest.Size = new System.Drawing.Size(294, 26);
            this.createTest.Text = "Создать тест";
            this.createTest.Click += new System.EventHandler(this.createTest_Click);
            // 
            // runTest
            // 
            this.runTest.Name = "runTest";
            this.runTest.Size = new System.Drawing.Size(294, 26);
            this.runTest.Text = "Пройти тест";
            this.runTest.Click += new System.EventHandler(this.runTest_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(291, 6);
            // 
            // exitBtn
            // 
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(294, 26);
            this.exitBtn.Text = "Выйти";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // help
            // 
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(118, 26);
            this.help.Text = "О программе";
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // mainPanel
            // 
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
            this.mainPanel.Location = new System.Drawing.Point(12, 33);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(920, 523);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Введите варианты ответов";
            // 
            // nazvaniyeEdit
            // 
            this.nazvaniyeEdit.Enabled = false;
            this.nazvaniyeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazvaniyeEdit.Location = new System.Drawing.Point(8, 133);
            this.nazvaniyeEdit.Name = "nazvaniyeEdit";
            this.nazvaniyeEdit.Size = new System.Drawing.Size(701, 34);
            this.nazvaniyeEdit.TabIndex = 11;
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.Location = new System.Drawing.Point(11, 199);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(695, 258);
            this.flowLayout.TabIndex = 10;
            // 
            // testCreate
            // 
            this.testCreate.Location = new System.Drawing.Point(715, 3);
            this.testCreate.Name = "testCreate";
            this.testCreate.Size = new System.Drawing.Size(202, 113);
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
            this.label2.Size = new System.Drawing.Size(241, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите название теста";
            // 
            // testNameEdit
            // 
            this.testNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testNameEdit.Location = new System.Drawing.Point(8, 55);
            this.testNameEdit.Name = "testNameEdit";
            this.testNameEdit.Size = new System.Drawing.Size(701, 34);
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
            this.trueEdit.Location = new System.Drawing.Point(8, 488);
            this.trueEdit.Name = "trueEdit";
            this.trueEdit.Size = new System.Drawing.Size(903, 34);
            this.trueEdit.TabIndex = 5;
            // 
            // vopros
            // 
            this.vopros.AutoSize = true;
            this.vopros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vopros.Location = new System.Drawing.Point(6, 105);
            this.vopros.Name = "vopros";
            this.vopros.Size = new System.Drawing.Size(260, 25);
            this.vopros.TabIndex = 3;
            this.vopros.Text = "Введите название вопроса";
            // 
            // addOtvet
            // 
            this.addOtvet.Enabled = false;
            this.addOtvet.Location = new System.Drawing.Point(712, 199);
            this.addOtvet.Name = "addOtvet";
            this.addOtvet.Size = new System.Drawing.Size(199, 258);
            this.addOtvet.TabIndex = 2;
            this.addOtvet.Text = "Добавить вариант ответа";
            this.addOtvet.UseVisualStyleBackColor = true;
            this.addOtvet.Click += new System.EventHandler(this.addOtvet_Click);
            // 
            // addVopros
            // 
            this.addVopros.Enabled = false;
            this.addVopros.Location = new System.Drawing.Point(715, 129);
            this.addVopros.Name = "addVopros";
            this.addVopros.Size = new System.Drawing.Size(202, 50);
            this.addVopros.TabIndex = 0;
            this.addVopros.Text = "Создать вопрос";
            this.addVopros.UseVisualStyleBackColor = true;
            this.addVopros.Click += new System.EventHandler(this.addVopros_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите что-то в меню для отображения";
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.infLbl);
            this.panelUser.Controls.Add(this.cofirmBtn);
            this.panelUser.Controls.Add(this.label6);
            this.panelUser.Controls.Add(this.flowLayout1);
            this.panelUser.Controls.Add(this.addUser);
            this.panelUser.Controls.Add(this.label5);
            this.panelUser.Controls.Add(this.userEdit);
            this.panelUser.Location = new System.Drawing.Point(12, 31);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(921, 534);
            this.panelUser.TabIndex = 3;
            this.panelUser.Visible = false;
            // 
            // infLbl
            // 
            this.infLbl.AutoSize = true;
            this.infLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infLbl.Location = new System.Drawing.Point(245, 434);
            this.infLbl.Name = "infLbl";
            this.infLbl.Size = new System.Drawing.Size(173, 25);
            this.infLbl.TabIndex = 6;
            this.infLbl.Text = "Выбранный тест:";
            // 
            // cofirmBtn
            // 
            this.cofirmBtn.Enabled = false;
            this.cofirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cofirmBtn.Location = new System.Drawing.Point(457, 462);
            this.cofirmBtn.Name = "cofirmBtn";
            this.cofirmBtn.Size = new System.Drawing.Size(454, 69);
            this.cofirmBtn.TabIndex = 5;
            this.cofirmBtn.Text = "Подтвердить выбор";
            this.cofirmBtn.UseVisualStyleBackColor = true;
            this.cofirmBtn.Click += new System.EventHandler(this.cofirmBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(452, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Выберите тест";
            // 
            // flowLayout1
            // 
            this.flowLayout1.AutoScroll = true;
            this.flowLayout1.Location = new System.Drawing.Point(457, 50);
            this.flowLayout1.Name = "flowLayout1";
            this.flowLayout1.Size = new System.Drawing.Size(454, 365);
            this.flowLayout1.TabIndex = 3;
            // 
            // addUser
            // 
            this.addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUser.Location = new System.Drawing.Point(11, 91);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(407, 78);
            this.addUser.TabIndex = 2;
            this.addUser.Text = "Внести имя";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ваша фамилия";
            // 
            // userEdit
            // 
            this.userEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userEdit.Location = new System.Drawing.Point(11, 50);
            this.userEdit.Name = "userEdit";
            this.userEdit.Size = new System.Drawing.Size(407, 34);
            this.userEdit.TabIndex = 0;
            // 
            // allResult
            // 
            this.allResult.Name = "allResult";
            this.allResult.Size = new System.Drawing.Size(294, 26);
            this.allResult.Text = "Просмотерть все результаты";
            this.allResult.Click += new System.EventHandler(this.allResult_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(291, 6);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dataGrid);
            this.panel.Location = new System.Drawing.Point(0, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(933, 534);
            this.panel.TabIndex = 4;
            this.panel.Visible = false;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(11, 6);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(910, 518);
            this.dataGrid.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 567);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Главная форма";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTest;
        private System.Windows.Forms.ToolStripMenuItem runTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitBtn;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayout1;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userEdit;
        private System.Windows.Forms.Button cofirmBtn;
        private System.Windows.Forms.Label infLbl;
        private System.Windows.Forms.ToolStripMenuItem allResult;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}

