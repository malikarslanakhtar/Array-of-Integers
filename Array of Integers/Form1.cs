using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_of_Integers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = { 8, 9, 5, 6, 2, 8, 4 };
            int total;
            for (int i=0;i<nums.Length;i++)
            
            {
                lblOutput.Text = "The first element is " + nums [0];
                lblOutput.Text += "\r\n" + "The second element is " + nums[4];
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Fruit = { "Banana", "Apple", "Pear", "Orange", "Kiwi fruit" };
            Fruit[1] = "Stwarberry";
            int numoffruits;
            numoffruits = Fruit.Length;
            {
                lblOutput2.Text = Fruit[1] + " is the second element";
                lblOutput2.Text += "\r\n" + "Total Fruit is " + numoffruits;
            }
        }
    }
}
