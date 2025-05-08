using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static dimaWk.mainForm;

namespace dimaWk
{
    internal class testCall
    {
        public static List<string> nameTests = new List<string>();
        public static List<int> idTests = new List<int>();

        public static List<string> question = new List<string>();
        public static List<string> answers = new List<string>();
        public static List<string> trueAnswers = new List<string>();
        public static decimal allCount = 0;
        public void tryCallTestTable()
        {
            using (MySqlConnection conn = new MySqlConnection(testCreater.getConnStr()))
            {
                try
                {
                    conn.Open();
                    string query = $@"SELECT id, name FROM tests;";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nameTests.Add(reader["name"].ToString());
                            idTests.Add((int)(reader["id"]));
                            //MessageBox.Show($"Imya: {string.Concat(nameTests)}\nid: {string.Concat(idTests)}");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HResult.ToString());
                }
            }
        }
        public void tryCallQuestionTable()
        { 
            using (MySqlConnection conn = new MySqlConnection(testCreater.getConnStr()))
            {
                try
                {
                    conn.Open();
                    string query = $@"SELECT id, question, answers, trueAnswers FROM question WHERE id_tests = {confirmWorkspase.currentTest};";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idTests.Add((int)(reader["id"]));
                            question.Add(reader["question"].ToString());
                            answers.Add(reader["answers"].ToString());
                            trueAnswers.Add(reader["trueAnswers"].ToString());

                            allCount += 1;
                            question.Add(" | ");
                            answers.Add(" | ");
                            trueAnswers.Add(" | ");
                            //MessageBox.Show($"{allCount}");//($"Imya: {string.Concat(question)}\nid: {string.Concat(answers)}");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HResult.ToString());
                }
            }
        }
        public void tryInsertIntoResult()
        {
            string query = $@"INSERT INTO testPassing (id_tests, user, trueAnswers, mark) VALUES(@id_tests, @user, @trueAnswers, @mark)";
            using (MySqlConnection conn = new MySqlConnection(testCreater.getConnStr()))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_tests", confirmWorkspase.currentTest);
                    cmd.Parameters.AddWithValue("@user", confirmWorkspase.userName);
                    cmd.Parameters.AddWithValue("@trueAnswers", testForm.testForm.trueCount);
                    cmd.Parameters.AddWithValue("@mark", testForm.testForm.mark);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show($"{id}, {_id}");
                }
            }
        }
    }
}
