using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace POE
{
    public partial class Test : Form
    {
        public void CheckSave()
        {

            StreamReader srTest;
            StreamReader srTestTaken;
            StreamReader srTestAns;
            StreamReader srQuickAns;
            int i = 0, correct = 0, incorrect = 0, x = 1; ;
            try
            {
                String filepathTestTaken = "TestTaken.txt";
                srTestTaken = new StreamReader(filepathTestTaken);
                string taken;
                taken = srTestTaken.ReadToEnd();
                String[] tDetailsTaken = taken.Split('\n');//note an unawnswered quation will be blank on a new line
                i = tDetailsTaken.Length;

                String filepathTest = "Test.txt";
                srTest = new StreamReader(filepathTest);
                string t;
                t = srTest.ReadToEnd();
                String[] tDetails = t.Split('|');

                //string b ans value from end of test file
                String filepathTestAns = "Test.txt";
                srTestAns = new StreamReader(filepathTestAns);
                string ans;
                ans = srTestAns.ReadToEnd();
                String[] aDetails = t.Split('\n');

                String filepathTestQuickAns = "TestAns.txt";
                srQuickAns = new StreamReader(filepathTestQuickAns);
                string QuickAns;
                QuickAns = srQuickAns.ReadToEnd();
                String[] QuickDetails = QuickAns.Split('\n');

                while (x <= i-1)
                {

                    string a = tDetailsTaken[x - 1].Substring(0, 1);

                    string b = QuickDetails[x-1].Substring(0,1);

             
                    if (a.Equals(b))
                    {
                        File.AppendAllText("Marks.txt", tDetailsTaken[x - 1] + " is correct:\n Number " + aDetails[x-1] + Environment.NewLine);
                        //x + " Question: " + tDetails[1 * x] + "\n A: " + tDetails[2 * x] + "\n B: " + tDetails[3 * x] + "\n C: " + tDetails[4 * x] + "\n D: " + tDetails[5 * x] + Environment.NewLine);
                        correct++;
                    }
                    else if (!a.Equals(b) & !a.Equals(""))
                    {
                        File.AppendAllText("Marks.txt", tDetailsTaken[x - 1] + " is incorrect:\n Number " + aDetails[x - 1] + Environment.NewLine);
                        //x + " Question: " + tDetails[1 * x] + "\n A: " + tDetails[2 * x] + "\n B: " + tDetails[3 * x] + "\n C: " + tDetails[4 * x] + "\n D: " + tDetails[5 * x] + Environment.NewLine);
                        incorrect++;//de
                    }
                    x++;
                }
                File.AppendAllText("Marks.txt", correct + "/" + (i - 1) + Environment.NewLine);
                File.AppendAllText("TestMarks.txt", correct + Environment.NewLine);
                srTestAns.Close();
                srTestTaken.Close();
                srTest.Close();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        string ans;
        public void ReadTest ()
        {
            StreamReader srTest;
            StreamReader srTestTaken;
            StreamReader srTestCount;
            int qNum=0, i = 0, l=0;
            
            
            try
            {

                //get number of questions
                String filepathTestCount = "Test.txt";
                srTestCount = new StreamReader(filepathTestCount);
                string t;
                t = srTestCount.ReadToEnd();
                String[] tCount = t.Split('\n');
                qNum = tCount.Length;//how many answered questions
                srTestCount.Close();
                //


                String filepathTestTaken = "TestTaken.txt";
                srTestTaken = new StreamReader(filepathTestTaken);
                String filepathTest = "Test.txt";
                srTest = new StreamReader(filepathTest);
                String taken;
                String test;
                


                while (!srTestTaken.EndOfStream)
                {
                    taken = srTestTaken.ReadLine();
                    String[] tDetailsTaken = taken.Split('\n');//note an unawnswered quation will be blank on a new line
                    l++;//how many answers
                }
               
                while (!srTest.EndOfStream)
                {

                    test = srTest.ReadLine();
                    String[] tDetails = test.Split('|');
                    
                    if (l >= i)//note l will be empty with no answers while i would already have a question loaded
                    {
                        //question number
                        txtbNumber.Text = ("Question Numer: " + tDetails[0]);
                        //get question
                        txtbQuestion.Text = (tDetails[1]);
                        //get question 1 (A)
                        txtbA.Text = (tDetails[2]);
                        //get question 2 (B)
                        txtbB.Text = (tDetails[3]);
                        //get question 3 (C)
                        txtbC.Text = (tDetails[4]);
                        //get question 4 (D)
                        txtbD.Text = (tDetails[5]);
                    }
                    

                    i++;//count what line
                }
                
                if (l >= (qNum - 1))//Exit after last question. -1 Account for the \n in text file. Place results in main Mark file
                {
                    MessageBox.Show("The Test is Complete");
                   

                    CheckSave();
                    
                    srTestTaken.Close();
                    srTest.Close();
                    File.WriteAllText("TestTaken.txt", String.Empty);//clears the test taken text file that is being used as a temp file
                   
                    MultipleChoiceTest HomeObj = new MultipleChoiceTest();
                    //open home page
                    this.Hide();
                    HomeObj.ShowDialog();
                }


                srTest.Close();
                srTestTaken.Close();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
        public Test()
        {
            InitializeComponent();
            

        }
        private void txtbQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbD_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnAnsA_CheckedChanged(object sender, EventArgs e)
        {
            ans = "A";
        }

        private void rbtnAnsB_CheckedChanged(object sender, EventArgs e)
        {
            ans = "B";
        }

        private void rbtnAnsC_CheckedChanged(object sender, EventArgs e)
        {
            ans = "C";
        }

        private void rbtnAnsD_CheckedChanged(object sender, EventArgs e)
        {
            ans = "D";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //write answer to file
            try
            {
                
                File.AppendAllText("TestTaken.txt", ans + Environment.NewLine);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            Test TestObj = new Test();
            //open again
            this.Hide();
            TestObj.ShowDialog();
        }

        private void btnLoadTest_Click(object sender, EventArgs e)
        {
            ReadTest();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }
    }
}
