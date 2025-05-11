using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dimaWk
{
    internal class testCreater
    {
        public static string getConnStr()
        {
            return $"Server = 95.183.12.18; Port = 3306; Database=ervinDB; user=dima; password=123;";
        }
        private string testName = mainForm.testWorkspase.testName;
        private string voprosName = mainForm.testWorkspase.voprosName;
        private List<string> question = mainForm.testWorkspase.question;
        private string voprosAnswer = mainForm.testWorkspase.voprosAnsver;


        private static long idTest;
        public void testCreate()
        {
            try
            {
                string query = $@"INSERT INTO tests (name) VALUES(@name)";
                using (MySqlConnection conn = new MySqlConnection(getConnStr()))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", testName);
                        cmd.ExecuteNonQuery();
                        idTest = cmd.LastInsertedId;
                        //MessageBox.Show(idTest.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.HResult.ToString());
            }
        }
        public void voprosAdd()
        {
            int _idTest = (int)idTest;
            if (_idTest != 0)
            {
                try
                {
                    string query = $@"INSERT INTO question (id_tests, question, answers, trueAnswers) 
                                            VALUES(@id_tests, @question, @answers, @trueAnswers)";
                    using (MySqlConnection conn = new MySqlConnection(getConnStr()))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id_tests", idTest);
                            cmd.Parameters.AddWithValue("@question", voprosName);
                            cmd.Parameters.AddWithValue("@answers", string.Join(",", question));
                            cmd.Parameters.AddWithValue("@trueAnswers", voprosAnswer);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    mainForm.testWorkspase.question.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HResult.ToString());
                }
            }
            else
            {
                //MessageBox.Show($"{idTest.ToString()}");
            }
        }   
    }
}
