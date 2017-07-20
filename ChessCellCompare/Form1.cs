using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessCellCompare
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cell1 = textBox1.Text.ToString();
            string cell2 = textBox2.Text.ToString();
            bool result = CompareTwoCell(cell1, cell2);
            if (result)
                textBox3.Text = "Aynı Renk";
            else
                textBox3.Text = "Farklı Renk";
        }

        private bool CompareTwoCell(string cell1, string cell2)
        {
            int result1 = findSum(cell1);
            int result2 = findSum(cell2);
            if ((oddOrEven(result1) && oddOrEven(result2)) || (!oddOrEven(result1) && !oddOrEven(result2)))
                return true;
            else
                return false;
        }

        private bool oddOrEven(int number)
        {
            // number%2 == 0 color white else black
            if (number % 2 == 0)
                return true;
            else
                return false;
        }

        private int findSum(string cell)
        {
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            char letter = Convert.ToChar(cell.Substring(0, 1));
            int number = int.Parse(cell.Substring(1, 1));
            int index = Array.IndexOf(letters, letter);
            return number + index;
        }

        
    }
}
