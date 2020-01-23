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
    public partial class CreateTest : Form
    {
        string Ans = "";
        public CreateTest()
        {
            InitializeComponent();       
        }
                                                                                                
        private void txtbCreateQuestion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblCreate_Click(object sender, EventArgs e)
        {

        }

        private void txtbQA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnA_CheckedChanged(object sender, EventArgs e)
        {
            Ans = "A";
            
        }

        private void txtbQB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnB_CheckedChanged(object sender, EventArgs e)
        {
            Ans = "B";
            
        }

        private void txtbQC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnC_CheckedChanged(object sender, EventArgs e)
        {
            Ans = "C";
            
        }

        private void txtbQD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnD_CheckedChanged(object sender, EventArgs e)
        {
            Ans = "D";
            
        }
        private void txtbNo_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //write to file
            try
            {
              
                File.AppendAllText("Test.txt", txtbNo.Text + "|" + txtbCreateQuestion.Text + "|" + txtbQA.Text + "|" + txtbQB.Text + "|" + txtbQC.Text + "|" + txtbQD.Text + "|" + Ans + Environment.NewLine);
                File.AppendAllText("TestAns.txt", Ans + Environment.NewLine);//for quick reference and quick mark check

            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            CreateTest CreateTestObj = new CreateTest();
            //open again
            this.Hide();
            CreateTestObj.ShowDialog();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            MultipleChoiceTest HomeObj = new MultipleChoiceTest();
            //open home page
            this.Hide();
            HomeObj.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
