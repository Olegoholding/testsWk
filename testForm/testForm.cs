using Org.BouncyCastle.Utilities.Zlib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static dimaWk.mainForm;

namespace dimaWk.testForm
{
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
        }
        public static List<string> answers = testCall.answers.TakeWhile(a => a != " | ").ToList();
        public static List<string> answer = new List<string>();

        public static List<string> question = new List<string>();

        public static List<string> trueAnswers = testCall.trueAnswers.TakeWhile(a => a != " | ").ToList();
        public static List<string> trueAnswer = new List<string>();

        public static decimal mark;
        string result;

        int summaryCount = 0;
        public static decimal trueCount = 0;
        private void testForm_Load(object sender, EventArgs e)
        {
            confirmBtn.Enabled = true;
            nextBtn.Enabled = false;
            
            testLoad();
        }
        private bool testLoad()
        {
            //MessageBox.Show(string.Concat(question));
            answer = answers.First().Split(',').ToList();

            question = testCall.question.TakeWhile(a => a != " | ").ToList();

            int j = -1;
            questionLbl.Text = question[j+1];

            for (int i = 0; i < answer.Count; i++)
            {
                RadioButton radioButton = new RadioButton
                {
                    Font = new Font("Microsoft Sans Serif", 12),
                    Width = 500,
                    Text = answer[i],
                    Cursor = Cursors.Hand,
                    Tag = i
                };
                radioButton.Click += radioButton_Click;

                flowLayout.Controls.Add(radioButton);
            }

            return false;
        }
        public void radioButton_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            result = radioButton.Text;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            bool trueOrFalse = testCall.trueAnswers.Contains(result);

            nextBtn.Enabled = true;
            trueCount = trueOrFalse ? trueCount += 1 : trueCount;
            summaryCount += 1;
            bool checkNextQustion = (summaryCount == testCall.allCount);
            confirmBtn.Enabled = false;

            removeFromList();
        }
        public void removeFromList()
        {
            string separator = " | ";
            testCall.question.RemoveAll(x => question.Contains(x));
            testCall.answers.RemoveAll(x => answers.Contains(x));
            testCall.trueAnswers.RemoveAll(x => trueAnswer.Contains(x));

            answer.Clear();
            answers.Clear();
            trueAnswer.Clear();
            trueAnswers.Clear();

            question.Clear();

            testCall.question.Remove(separator);
            testCall.answers.Remove(separator);
            testCall.trueAnswers.Remove(separator);

            answers = testCall.answers.TakeWhile(a => a != " | ").ToList();
            trueAnswers = testCall.trueAnswers.TakeWhile(a => a != " | ").ToList();

            //MessageBox.Show($"{string.Concat(question)} SEPARATOR  {string.Concat(answer)} SEPARATOR {string.Concat(trueAnswer)} SEPARATOR ");
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (answers.Count != 0)
            {
            flowLayout.Controls.Clear();
            testLoad();
            confirmBtn.Enabled = true;
            nextBtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("Тест окончен");
                testName.Text = $"{confirmWorkspase.testName}";
                questionCount.Text = $"{testCall.allCount}";
                trueAnswersCount.Text = $"{trueCount}";
                userLbl.Text = $"{confirmWorkspase.userName}";

                mark = Math.Round(1 + 4 * (trueCount / testCall.allCount), 2);

                markLbl.Text = mark.ToString();
                panel.Show();

                testCall transfer = new testCall();
                transfer.tryInsertIntoResult();
            }
        }
    }
}
