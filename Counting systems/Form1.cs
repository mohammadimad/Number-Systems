using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counting_systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ReStrat()
        {
            txtNumber.ReadOnly = true;
            txtNumber.Text = "";
            
            FromComboBox.SelectedIndex = 0;
            ToComboBox.SelectedIndex = 1;
            txtResult.Text = "";

        }
        private void CheckNumericInput(int num,int count1,int x, int y,string word = "binary")
        {
            while (count1 != 0)
            {
                int z = count1 % 10;
                count1 /= 10;
                if (!(z >= x && z <= y))
                {
                    MessageBox.Show("Please enter a valid "+ word +" number.");
                    ReStrat();
                    
                    break;
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string result = "";
            
            switch (FromComboBox.Text)
            {
                case "Decimal":
                    int num = int.Parse(txtNumber.Text);
                    switch (ToComboBox.Text) {
                        case "Binary":
                            result = Convert.ToString(num, 2);
                            break;
                        case "Octal":
                            result = Convert.ToString(num, 8);
                            break;
                        case "Hexadecimal":
                            result = Convert.ToString(num, 16);
                            break;
                    }
                    break;
                case "Binary":
                  
                    int num1 = int.Parse(txtNumber.Text);
                    int count1 = num1;
                    CheckNumericInput(num1, count1, 0, 1);
                    
                    switch (ToComboBox.Text)
                    {
                        case "Decimal":
                            num1 = Convert.ToInt32(txtNumber.Text, 2);
                            result = num1.ToString();
                            break;
                        case "Octal":
                            result = Convert.ToString(num1, 8);
                            break;
                        case "Hexadecimal":
                            result = Convert.ToString(num1, 16);
                            break;
                    }
                    break;
                    
                case "Octal":
                    int num2= int.Parse(txtNumber.Text);
                    int count2 = num2;
                    CheckNumericInput(num2, count2, 0, 7,"octal");
                   
                        switch (ToComboBox.Text)
                        {
                            case "Decimal":
                                num2 = Convert.ToInt32(txtNumber.Text, 8);
                                result = num2.ToString(); ;
                                break;
                            case "Binary":
                                result = Convert.ToString(num2, 2);
                                break;
                            case "Hexadecimal":
                                result = Convert.ToString(num2, 16);
                                break;
                        }
                       break;
                case "Hexadecimal":
                    
                    int num3 = int.Parse(txtNumber.Text);
                     switch (ToComboBox.Text)
                        {
                            case "Decimal":
                                num3 = Convert.ToInt32(txtNumber.Text, 16);
                                result = num3.ToString();
                                break;
                            case "Binary":
                                result = Convert.ToString(num3, 2);
                                break;
                            case "Octal":
                                result = Convert.ToString(num3, 8);
                                break;
                        }
                                     break;
            }
            
            txtResult.Text = result;
        }
       
            
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumber.ReadOnly = false;
            if (FromComboBox.SelectedIndex == 1)
                ToComboBox.SelectedIndex = 0;
            else
                ToComboBox.SelectedIndex = 1;

          
            lblFrom.Text = FromComboBox.SelectedItem.ToString();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTo.Text = ToComboBox.SelectedItem.ToString();

        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string temp = FromComboBox.Text;
            FromComboBox.Text = ToComboBox.Text;
            ToComboBox.Text = temp;
        }

       

        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtNumber.ReadOnly = true;
            txtResult.Text = "";
            FromComboBox.SelectedIndex = 0;
            ToComboBox.SelectedIndex = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FromComboBox.SelectedIndex = 0;
            ToComboBox.SelectedIndex = 1;
        }
    }
}
