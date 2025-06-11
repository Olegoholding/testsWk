using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace dimaWk.testForm
{
    public partial class logPage : Form
    {
        Button testCreate;
        Button checkAnsvers;
        public logPage(Button button1, Button button4)
        {
            InitializeComponent();
            testCreate = button1;
            checkAnsvers = button4;
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

        private void auBtn_Click_1(object sender, EventArgs e)
        {
            #region Лубимая валидация
            if (string.IsNullOrEmpty(passEdit.Text) || string.IsNullOrEmpty(loginEdit.Text))
            {
                MessageBox.Show("Заполните поля данными для продолжения");
                return;
            }

            if (!getDataUser())
            {
                MessageBox.Show("Аккаунт не найден, заругистрируйтесь у администратора");
                return;
            }
            #endregion

            MessageBox.Show("Авторизация прошла успешно");
            testCreate.Enabled = true;
            checkAnsvers.Enabled = true;
            this.Close();
        }
    }
}