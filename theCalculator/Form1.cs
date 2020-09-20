using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theCalculator
{
    public partial class Form1 : Form
    {//A variable to hold the value stored in the calculator’s memory
        double memoryValue = 0.0;
        public Form1()
        {
            InitializeComponent();
        }
        //this method displays "1" on the claculator textbox when clicked btn1
        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("1");
        }
        //this method displays "2" on the claculator textbox when clicked btn2
        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("2");
        }
        //this method displays "3" on the claculator textbox when clicked btn3
        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("3");
        }
        //this method displays "4" on the claculator textbox when clicked btn4
        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("4");
        }
        //this method displays "5" on the claculator textbox when clicked btn5
        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("5");
        }
        //this method displays "6" on the claculator textbox when clicked btn6
        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("6");
        }
        //this method displays "7" on the claculator textbox when clicked btn7
        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("7");
        }
        //this method displays "8" on the claculator textbox when clicked btn8
        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("8");
        }
        //this method displays "9" on the claculator textbox when clicked btn9
        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("9");
        }
        //this method displays "0" on the claculator textbox when clicked btn0
        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("0");
        }
        //this method displays "." 
        private void btnDP_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(".");
        }
        //this method clears text dispaly box when clicked and displyas "0"
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = ("0");  
        }
        // When M+ is clicked the current contents of txtDisplay should be added to the storage space (i.e. variable). 
        private void btnMadd_Click(object sender, EventArgs e)
        {
            memoryValue += Convert.ToDouble(txtDisplay.Text);
        }
        // When M+ is clicked the current contents of txtDisplay should be subtracted from the storage space. 
        private void btnMsub_Click(object sender, EventArgs e)
        {
            memoryValue -= Convert.ToDouble(txtDisplay.Text);
        }
        //another assignment statement to reset the variable so it stores the value zero
        private void btnMclr_Click(object sender, EventArgs e)
        {
            memoryValue = 0.0;
        }
        //button MR should take whatever value is currently stored in variable memoryValue and show it via the Text property of txtDisplay
        private void btnMrec_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memoryValue.ToString();
        }


    }
}
