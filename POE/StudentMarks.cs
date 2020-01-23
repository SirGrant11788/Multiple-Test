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
    public partial class StudentMarks : Form
    {

        public void display()
        {
            
            int i,x=0;
            
            try
            {
                string show = File.ReadAllText("MarksDisplay.txt");    
                String[] SMDetails = show.Split('\n');
                i = SMDetails.Length;
                
                while (x < i)
                {
                   
                    lbxDisplay.Items.Add(SMDetails[x]);
                    x++;
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public StudentMarks()
        {
            InitializeComponent();
        }

        private void txtboxStudentMarks_TextChanged(object sender, EventArgs e)
        {

            
        }
            private void btnStudentMarksHome_Click(object sender, EventArgs e)
        {
            //clears the temp file
            File.WriteAllText("MarksDisplay.txt", String.Empty);
            MultipleChoiceTest HomeObj = new MultipleChoiceTest();
            //open home page
            this.Hide();
            HomeObj.ShowDialog();
        }

        private void btnStudentMarksExit_Click(object sender, EventArgs e)
        {
            //clears the temp file
            File.WriteAllText("MarksDisplay.txt", String.Empty);
            System.Windows.Forms.Application.Exit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            display();
        }

        private void lbxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentMarks_Load(object sender, EventArgs e)
        {

        }
    }
}
