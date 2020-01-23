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
    public partial class LecturerMarks : Form
    {
        public void display()
        {
            StreamReader srMarks;
            StreamReader srLecturerMarks;
            StreamReader srTestCount;
            string display="";

            try
            {
                //get number of questions
                String filepathTestCount = "Test.txt";
                srTestCount = new StreamReader(filepathTestCount);
                string t;
                t = srTestCount.ReadToEnd();
                String[] tCount = t.Split('\n');
                int qNum = tCount.Length;//how many answered questions
                srTestCount.Close();
                //

                String filepathMarks = "TestMarks.txt";
                srMarks = new StreamReader(filepathMarks);
                string Marks;
                Marks = srMarks.ReadToEnd();
                String[] AllMarks = Marks.Split('\n');
                int l = AllMarks.Length-1;//\n in text file
                int i = 0,x=0, total =0,n=1, high=0,low=10000;
                string highStd = "", lowStd = "";


                while (l >= i)
                {

                    if (n<=l) {
                        Int32.TryParse(AllMarks[(n)], out x);
                        total = total + x;

                        if (x > high)
                        {
                            high = x;
                            highStd = AllMarks[n-1];
                        }
                        if (low > x)
                        {
                            low = x;
                            lowStd = AllMarks[n-1];
                        }

                    }
                    display = display+"\n" + AllMarks[i];
                    n=n+2;
                    i++;
                }
                //save to file
                display = display + "\n Average: " + (total/((l-1)/2))+"\n Highest Mark: "+high+" by "+highStd+"\n Lowest Mark: "+low+" by "+lowStd+"\n The test was out of "+qNum+" marks";//avg note -1 for \n
                File.WriteAllText("LecturerMarks.txt", display + Environment.NewLine);

                //read from file
                
                String filepathLecturerMarks = "LecturerMarks.txt";
                srLecturerMarks = new StreamReader(filepathLecturerMarks);
                string LMarks;
                LMarks = srLecturerMarks.ReadToEnd();
                String[] LecturerMarks = LMarks.Split('\n');
                int lm = LecturerMarks.Length-1;///
                int y=0;
                while (y <= lm)
                {
                    lbxDisplay.Items.Add(LecturerMarks[y]);
                    y++;
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public LecturerMarks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLectureMarksHome_Click(object sender, EventArgs e)
        {
            MultipleChoiceTest HomeObj = new MultipleChoiceTest();
            //open home page
            this.Hide();
            HomeObj.ShowDialog();
        }

    

        private void lbxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            display();
        }

        private void btnLecturerMarksExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LecturerMarks_Load(object sender, EventArgs e)
        {

        }
    }
}
