using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadFirstEstimator1
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        BirthdayParty birthdayParty;
        
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numberOfPeople.Value, healthyOptionCheckBox.Checked, fancyDecorationsCheckBox.Checked);
            DisplayDinnerCosts();

            birthdayParty = new BirthdayParty((int)numericUpDown1.Value, checkBox1.Checked, textBox1.Text);
            DisplayBirthdayCost();
            
        }

        private void NumberOfPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numberOfPeople.Value;           
            DisplayDinnerCosts();
            
        }

        private void DisplayDinnerCosts()
        {
            decimal Cost = dinnerParty.Cost;
            costLabel.Text = Cost.ToString("c");
                
        }

        private void DisplayBirthdayCost()
        {
            label4.Visible = birthdayParty.CakeWritingTooLong;
            decimal birthDayCost = birthdayParty.Cost;
            birthdayCostLabel.Text = birthDayCost.ToString("c");
            
        }

        private void fancyDecorationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecortations = fancyDecorationsCheckBox.Checked;
            DisplayDinnerCosts();
        }

        private void healthyOptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyOptionCheckBox.Checked;
            DisplayDinnerCosts();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayBirthdayCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = checkBox1.Checked;
            DisplayBirthdayCost();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = textBox1.Text;
            DisplayBirthdayCost();
        }

    
    }
}
