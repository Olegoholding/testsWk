using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dimaWk.testForm
{
    public partial class regLogForm : Form
    {
        ToolStripMenuItem voprosiCheck;
        ToolStripMenuItem testCreate;
        ToolStripMenuItem truePrikol;
        public regLogForm(ToolStripMenuItem VoprosiCheck, ToolStripMenuItem TestCreate, ToolStripMenuItem добавитьПользователяToolStripMenuItem)
        {
            InitializeComponent();
            voprosiCheck = VoprosiCheck;
            testCreate = TestCreate;
            truePrikol = добавитьПользователяToolStripMenuItem;
        }

        static MySqlConnection conn;
        static MySqlCommand cmd;
        static MySqlDataReader reader;


        public bool getDataUser()
        {
            bool foundUser = false;
            using (conn = new MySqlConnection(testCreater.getConnStr()))
                try
                {
                    conn.Open();
                    string sqlGet = $"SELECT login, pass FROM user WHERE login = '{loginEdit.Text}' and pass = '{passEdit.Text}'";
                    using (cmd = new MySqlCommand(sqlGet, conn))
                    {
                        using (reader = cmd.ExecuteReader())
                        {
                            foundUser = reader.HasRows;
                            //MessageBox.Show(foundUser.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HResult.ToString());
                }
            return foundUser;
        }

        private void regLogForm_Load(object sender, EventArgs e)
        {

        }

        private void auBtn_Click_1(object sender, EventArgs e)
        {
            if (getDataUser())
            {
                MessageBox.Show("Авторизация прошла успешно");
                voprosiCheck.Enabled = true;
                testCreate.Enabled = true;
                truePrikol.Enabled = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("Авторизация прошла не успешно, зарегистрируйтесь у администратора");
            }
        }
    }
}
