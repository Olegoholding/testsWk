using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dimaWk
{
    public partial class mainForm : Form
    {

        public static class testWorkspase
        {
            public static string testName;
            public static string voprosName;
            public static string voprosAnsver;
            public static List<string> question = new List<string>();
        }
        public static class confirmWorkspase
        {
            public static string userName;
            public static List<string> nameTests = testCall.nameTests;
            public static List<int> idTests = testCall.idTests;
            public static int currentTest;

            public static string testName;
        }
        string table;
        public mainForm()
        {
            InitializeComponent();
        }
        private void createTest_Click(object sender, EventArgs e)
        {
            mainPanel.Show();
            panelUser.Hide();
            panel.Hide();
        }

        private void testCreate_Click(object sender, EventArgs e)
        {
            flowLayout.Enabled = true;
            addOtvet.Enabled = true;
            trueEdit.Enabled = true;
            nazvaniyeEdit.Enabled = true;

            testWorkspase.testName = testNameEdit.Text;

            testCreater transfer = new testCreater();
            transfer.testCreate();
        }

        private void addOtvet_Click(object sender, EventArgs e)
        {
            TextBox TextBox = new TextBox
            {
                Width = 500,
            };
            flowLayout.Controls.Add(TextBox);
            addVopros.Enabled = true;
        }

        private void addVopros_Click(object sender, EventArgs e)
        {
            testWorkspase.voprosAnsver = trueEdit.Text;
            testWorkspase.voprosName = nazvaniyeEdit.Text;
            MessageBox.Show(flowLayout.Controls.Count.ToString());
            foreach (Control edits in flowLayout.Controls)
            {
                if (edits is TextBox txtBox)
                {
                    testWorkspase.question.Add(txtBox.Text);
                }
            }
            testCreater transfer = new testCreater();
            transfer.voprosAdd();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            confirmWorkspase.userName = userEdit.Text;
            cofirmBtn.Enabled = true;
        }

        private void runTest_Click(object sender, EventArgs e)
        {
            panelUser.Show();
            mainPanel.Hide();
            panel.Hide();

            testCall transfer = new testCall();
            transfer.tryCallTestTable();

            flowPanelTestFill();
        }

        public void flowPanelTestFill()
        {
            for(int i = 0; i < confirmWorkspase.idTests.Count; i++ )
            {
                Label Label = new Label
                {
                    Font = new Font("Microsoft Sans Serif", 12),
                    Width = 500,
                    Text = confirmWorkspase.nameTests[i],
                    Cursor = Cursors.Hand,
                    Tag = confirmWorkspase.idTests[i]
                };
                Label.Click += Label_Click;

                flowLayout1.Controls.Add(Label); 
            }
            //MessageBox.Show($"{confirmWorkspase.nameTests}");
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label Label = sender as Label;
            if (Label != null)
            {
                confirmWorkspase.currentTest = (int)Label.Tag;
                infLbl.Text = $"Выбранный тест: {Label.Text}";
                confirmWorkspase.testName = infLbl.Text;
            }
        }
        private void cofirmBtn_Click(object sender, EventArgs e)
        {
            testCall transfer1 = new testCall();
            transfer1.tryCallQuestionTable();

            testForm.testForm transfer = new testForm.testForm();
            transfer.ShowDialog();
        }

        private void allResult_Click(object sender, EventArgs e)
        {
            panel.Show();
            dataGrid.Invalidate();
            table = "testPassing";
            dataLoad();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void help_Click(object sender, EventArgs e)
        {
            help.help transfer = new help.help();
            transfer.Show();
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells["id"].Value.ToString());
                using (MySqlConnection connection = new MySqlConnection(testCreater.getConnStr()))
                {
                    string query = $"DELETE FROM {table} WHERE id = {ID}";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        dataLoad();
                    }
                    catch (Exception ex)
                    {
                        dataLoad();
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private void dataLoad()
        {
        using (MySqlConnection conn = new MySqlConnection($"{testCreater.getConnStr()}"))
            {
                try
                {
                    string query = $"SELECT * FROM {table}";
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGrid.DataSource = dataTable;
                        dataGrid.AutoGenerateColumns = true;
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HResult.ToString());
                }
            }
        }
        private void lookTest_Click(object sender, EventArgs e)
        {
            table = "tests";
            dataGrid.Invalidate();
            panel.Show();
            dataLoad();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            back1Btn.Enabled = true;
            back2Btn.Enabled = true;
            button5.Enabled = true;
        }

        private void voprosiCheck_Click(object sender, EventArgs e)
        {
            table = "question";
            dataGrid.Invalidate();
            panel.Show();
            dataLoad();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            panel.Hide();
            panelUser.Hide();
            mainPanel.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            testForm.logPage transfer = new testForm.logPage(this.button1, this.button4);
            transfer.ShowDialog();
        }
    }
}
