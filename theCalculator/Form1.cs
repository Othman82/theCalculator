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
        bool clearDisplay = true;
        public Form1()
        {
            InitializeComponent();
        }
        //all the numeric buttons now is using the same event handler (btn_click)
        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string digit = button.Text;
            if (clearDisplay)
            {
                txtDisplay.Text = digit;
                clearDisplay = false;
            }
            else
            {
                txtDisplay.AppendText(digit);
            }
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
