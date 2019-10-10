// Programmer: Alysia Maxwell
// Project: Assignment 2 - language order form 
// Due Date: 10/03/2018
// Description: Assignment #2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maxwell_2
{
    public partial class CourseOrderForm : Form
    {
            // Declare Class Level Constants To Prevent From Declaring Local Variables Inside Each Event 

               private const decimal inStatePrice = 49.00m;
               private const decimal outOfStatePrice = 99.00m;
               private decimal totalPrice;
               private int numberOfCourses;

        public CourseOrderForm()
        {
            InitializeComponent();
        }

        //  Event Handler To Control Fall and Spring Term Radio Button 

        private void fallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fallRadioButton.Checked)
            {
                fallRadioButton.Checked = true;
                springRadioButton.Checked = false;
            }
            else
            {
                springRadioButton.Checked = true;
                fallRadioButton.Checked = false; 
            }

        }

        // Shared Check Box Event Handler To Control What Happens When Boxes Selected And Deselected 

        private void beginningFrenchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
                numberOfCourses = 0; 
            
                // Increment Counter For Each Selected Course 

                if (beginningFrenchCheckBox.Checked)
                {
                    numberOfCourses += 1;
                }
                if (beginningGermanCheckBox.Checked)
                {
                    numberOfCourses += 1;
                }
                if (beginningItalianCheckBox.Checked)
                {
                    numberOfCourses += 1;
                }
                if (beginningSpanishCheckBox.Checked)
                {
                    numberOfCourses += 1;
                }
                if (beginningRussianCheckBox.Checked)
                {
                    numberOfCourses += 1;
                }


                
            
            // If Block To Determine In-State and Out-Of-State Price

            if (inStateRadioButton.Checked)
               {
                   totalPrice = inStatePrice * numberOfCourses;
               }
               else
               {
                   totalPrice = outOfStatePrice * numberOfCourses;
               }

            // Update Total Price Of Order

               totalLabel.Text = totalPrice.ToString("C");


            // Update Total Number Of Courses Selected 

               numberOfCoursesSelectedLabel.Text = numberOfCourses.ToString();
            
        }


        // Execute Assignments When Form Loads

        private void CourseOrderForm_Load(object sender, EventArgs e)
        {

            // Assign Class Level Constants to Labels On Form to initialize values 

            inStateChargeLabel.Text = inStatePrice.ToString("C");
            outOfStateChargeLabel.Text = outOfStatePrice.ToString("C");
            numberOfCoursesSelectedLabel.Text = numberOfCourses.ToString();
            totalLabel.Text = totalPrice.ToString("C");


        }

            // Save Button Event Handler to Display Order Summary 

        private void saveButton_Click(object sender, EventArgs e)
        {
           

            MessageBox.Show("Summary" + "   " +"   " + "\n" + MessageBoxButtons.OK + MessageBoxIcon.Question +
                           "Registration Term " + springRadioButton + "\n" +
                            "Registration Term " + termYearComboBox + "\n" +
                            "Student ID : " + studentIDMaskedTextBox + "\n" +
                            "Student Name : " + firstNameTextBox + lastNameTextBox + "\n" +
                            "student E-mail Address : " + emailTextBox + "\n" +
                            "Resident Status : " + inStateRadioButton + "\n" +
                            "Resident Status : " + outOfStateRadioButton + "\n" +
                            "Total Courses Purchased : " + numberOfCourses + "\n" +
                            "Price Per Course : " + inStateRadioButton + "\n" +
                            "Price Per Course : " + outOfStateRadioButton + "\n" +
                            "Total Order Price : " + totalPrice + "\n" +
                            "Credit Card Type : " + masterCardRadioButton +
                            "Credit Card Type : " + visaRadioButton + "\n" +
                            "Card Number : " + cardNumberTextBox + "\n" +
                            "Expiration Date : " + expirationLabel + "\n ");
                            
                           
        }
       
            // Clear Button Event Handler To Return Form To Original State 
                    
        private void clearButton_Click(object sender, EventArgs e)
        {
            // All Form Controls Reset To Default Position 

               numberOfCourses = 0; 
               fallRadioButton.Checked = true;
               termYearComboBox.SelectedIndex = -1;
               studentIDMaskedTextBox.Text = " ";
               firstNameTextBox.Text = " ";
               lastNameTextBox.Text = " ";
               emailTextBox.Text = " ";
               inStateRadioButton.Checked = true;
               beginningFrenchCheckBox.Checked = false;
               beginningGermanCheckBox.Checked = false;
               beginningItalianCheckBox.Checked = false;
               beginningRussianCheckBox.Checked = false;
               beginningSpanishCheckBox.Checked = false;
               masterCardRadioButton.Checked = true;
               cardNumberTextBox.Text = " ";
               expirationMaskedTextBox.Text = " ";

            // Send Focus Back To Term Selection 

               fallRadioButton.Focus(); 
        

        }
           
            // Terminate The Program 

        private void exitButton_Click(object sender, EventArgs e)
        {

            // Declare Variable To Hold User Selection To Terminate The Program 

               DialogResult selection;

            // Display Message To Confirm User Selection 

               selection = MessageBox.Show(" Are You Sure You Want To Quit?",
               "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
              
            // Determines What Happens After User Selection 
               
               if (selection == DialogResult.Yes)
               {
                  this.Close(); 
               }
               if (selection == DialogResult.No)
               {
                  fallRadioButton.Focus();
               }
        }
    }

   
   }
