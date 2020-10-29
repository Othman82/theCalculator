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

        //this boolean variable (set to true) signify the calc should reset he display if a number btn pressed
        bool clearDisplay = true; 

        //the first variable track the new calculation                         
        bool isFirstValue = true; 

       //the second variable track wether an operation is being requested immediatly after "=" pressed
        bool isAfterEqual = false; 

        //keep track the value of the calculation so far                         
        double currentAnswer; 
        
        //the value of the last number entered
        double lastValueEntered;

        //this Char variable keeps track of the last maths function requested 
        char lastOp;

        public Form1()
        {
            InitializeComponent();
        }
        //Modified this code so it responds to the clearDisplay variable instead
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
        //In similar fashion the Dp has been modified to handle the clearDisplay variable
        private void btnDP_Click(object sender, EventArgs e)
        {
            if (clearDisplay)
            {
                txtDisplay.Text = "0.";
                clearDisplay = false;
            }
            else
            {
                txtDisplay.AppendText(".");
            }          
        }
        //this method clears text dispaly box when clicked and displyas "0"
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = ("0");
           isFirstValue = true;
           isAfterEqual = false;
        }
        // When M+ is clicked the current contents of txtDisplay should be added to the storage space (i.e. variable). 
        private void btnMadd_Click(object sender, EventArgs e)
        {
            memoryValue += Convert.ToDouble(txtDisplay.Text);
        }
        // When M- is clicked the current contents of txtDisplay should be subtracted from the storage space. 
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isFirstValue)
            {
                //store display value 
                currentAnswer = Convert.ToDouble(txtDisplay.Text);
                //next number is no longer the first
                isFirstValue = false;
            }

            //process outstanding calculation
            else
            {
                lastValueEntered = Convert.ToDouble(txtDisplay.Text);

                switch (lastOp)
                {
                    case '+':
                        currentAnswer += lastValueEntered;
                        break;

                    case '-':
                        currentAnswer -= lastValueEntered;
                        break;

                    case '*':
                        currentAnswer *= lastValueEntered;
                        break;

                    case '/':
                        currentAnswer /= lastValueEntered;
                        break;

                }
            }

            lastOp = '+'; //update last math function to add
            isAfterEqual = false; // operation is not requested immidatly after "=" has been pressed
            clearDisplay = true; // reset display if number is pressed
            btnDP.Enabled = true; // re enable decimal point btn
            txtDisplay.Text = currentAnswer.ToString(); //show result of calculation

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (isAfterEqual == false)
            {
                lastValueEntered = Convert.ToDouble(txtDisplay.Text);
            }
            else
            {
                switch (lastOp)
                {
                    case '+':
                        currentAnswer += lastValueEntered;
                        break;
                    case '-':
                        currentAnswer -= lastValueEntered;
                        break;
                    case '*':
                        currentAnswer *= lastValueEntered;
                        break;
                    case '/':
                        currentAnswer /= lastValueEntered;
                        break;

                }



            }

            isAfterEqual = true;
            clearDisplay = true;
            isFirstValue = true;
            btnDP.Enabled = true;
            txtDisplay.Text = currentAnswer.ToString();
        }
    }
}
