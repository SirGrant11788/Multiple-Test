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
    public partial class MultipleChoiceTest : Form
    {
        Boolean sCheck = false, lCheck = false;//booleans for confirming student or lecturer
        StudentMarks StudentMarksObj = new StudentMarks();
        LecturerMarks LecturerMarksObj = new LecturerMarks();
        Test TestObj = new Test();
        CreateTest CreateTestObj = new CreateTest();
        

        public MultipleChoiceTest()
        {
            InitializeComponent();
        }

        public void CheckStudent()
        {
            StreamReader srStudents;

            try
            {
                String filepathStudents = "Students.txt";

                srStudents = new StreamReader(filepathStudents);


                string s;


                while (!srStudents.EndOfStream)
                {
                    s = srStudents.ReadLine();
                    String[] sDetails = s.Split('\n');

                    if (sDetails[0].Equals(txtbName.Text))
                        sCheck = true;


                }

            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//Student check method looking at the Student text file
        public void CheckLecturers()
        {

            StreamReader srLecturers;
            try
            {

                String filepathLecturers = "Lecturers.txt";

                srLecturers = new StreamReader(filepathLecturers);

                string l;

                while (!srLecturers.EndOfStream)
                {
                    l = srLecturers.ReadLine();
                    String[] lDetails = l.Split('\n');

                    if (lDetails[0].Equals(txtbName.Text))
                        lCheck = true;

                }

            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//Lecturer check method looking at the Lecturer text file

        public void TempMarks()
        {
            try
            {
                int i = 0, qNum=0,x=0,c=0;
                StreamReader srTestCount;
                StreamReader srM;
                String filepathM = "Marks.txt";
                srM = new StreamReader(filepathM);
                string m;
                m = srM.ReadToEnd();
                String[] Marks = m.Split('\n');
                c = Marks.Length;//how many answered questions

                //get number of questions
                String filepathTestCount = "Test.txt";
                srTestCount = new StreamReader(filepathTestCount);
                string t;
                t = srTestCount.ReadToEnd();
                String[] tCount = t.Split('\n');
                qNum = tCount.Length;//how many answered questions
                srTestCount.Close();
                //
                //compensate for the \n in the text file and create ease of manipluation for txtbName
                string name = txtbName.Text;
                string MarkName="";
                int LMarks = 0;
                while (i < c)//loops for checks through text file
                {

                    LMarks = Marks[i].Length;//compensate for the \n in the text file
                    MarkName=Marks[i].Remove((LMarks-1));//compensate for the \n in the text file
                    
                   
                    if (name.Equals(MarkName))
                    {
                        
                        while (x<=7)
                        {
                            
                            File.AppendAllText("MarksDisplay.txt", Marks[(i + x)] + Environment.NewLine);
                            x++;
                        }
                        i = c + 1;//end while loop now

                    }

                    i++;
                }




                srM.Close();
            
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultipleChoiceTest_Load(object sender, EventArgs e)
        {

        }


        private void btnViewMarks_Click(object sender, EventArgs e)
        {
            CheckStudent();
            CheckLecturers();
            if(sCheck == true)
            {
                

                //create the temp Marks display file for specific student

                TempMarks();
                
                //open StudentMarks
                this.Hide();
                StudentMarksObj.ShowDialog();
            }
            if(lCheck == true)
            {
                
                //open LecturerMarks
                this.Hide();
                LecturerMarksObj.ShowDialog();
            }
            if(sCheck == false && lCheck == false)
            {
                MessageBox.Show("Incorrect Details");//incorrect name or surname
            }
        }

        private void btnBeginTest_Click(object sender, EventArgs e)
        {
            CheckStudent();
            CheckLecturers();
            if (sCheck == true)
            {
                //add user name to mark file
                File.AppendAllText("Marks.txt", txtbName.Text + Environment.NewLine);
                //add user name to test mark file for quick marking
                File.AppendAllText("TestMarks.txt", txtbName.Text + Environment.NewLine);
                //open Test
                this.Hide();
                TestObj.ShowDialog();
            }
            if (lCheck == true)
            {
                MessageBox.Show("Only a student can take the test");
            }
            if (sCheck == false && lCheck == false)
            {
                MessageBox.Show("Incorrect Details");//incorrect name or surname
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CheckStudent();
            CheckLecturers();
            if (sCheck == true)
            {
                MessageBox.Show("Only a lecturer can create a test");
            }
            if (lCheck == true)
            {
                
                this.Hide();
                CreateTestObj.ShowDialog();
            }
            if (sCheck == false && lCheck == false)
            {
                MessageBox.Show("Incorrect Details");//incorrect name or surname
            }
        }
    }
}
