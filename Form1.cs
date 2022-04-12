using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isNumber(string oText)
        {
            try
            {
                int var1 = Convert.ToInt32(oText);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isNumber(txtNumber.Text.Trim()) == false)
            {
                MessageBox.Show("請輸入數字");
            }
            else
            {
                int number = int.Parse(txtNumber.Text);
                if (number % 2 == 0)
                {
                    lblResult.Text = $"輸入的數 {number}為 偶數";
                }
                else if (number % 2 != 0)
                {
                    lblResult.Text = $"輸入的數 {number}為 奇數";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = { 44, 66, 99 };
            lblResult.Text = $"三個數的最大值為 : {nums.Max().ToString()}";
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            if (isNumber(txtFrom.Text.Trim()) == false)
            {
                MessageBox.Show("請輸入數字");
            }
            else if (isNumber(txtTO.Text.Trim()) == false)
            {
                MessageBox.Show("請輸入數字");
            }
            else if (isNumber(txtStep.Text.Trim()) == false)
            {
                MessageBox.Show("請輸入數字");
            }

            else
            {
                lblResult.Text = "";
                int X = int.Parse(txtFrom.Text);
                int Y = int.Parse(txtTO.Text);
                int Z = int.Parse(txtStep.Text);
                int W = ((Y - X) / Z);
                int result = 0;
                int sum = 0;
                for (int i = 0; i <= W; i++)
                {
                    sum += X + (i * Z);
                    result = sum;
                }

                lblResult.Text = X + " 到 " + Y + " 相隔 " + (Z - 1) + "\n"
                    + "加總為  " + result.ToString();
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            if (isNumber(txtFrom.Text.Trim()) == false)
            {
                MessageBox.Show("請輸入數字");
            }
            else if (isNumber(txtTO.Text.Trim()) == false)
            {
                MessageBox.Show("請輸入數字");
            }
            else if (isNumber(txtStep.Text.Trim()) == false)
            {
                MessageBox.Show("請輸入數字");
            }
            else
            {
                int X = int.Parse(txtFrom.Text);
                int Y = int.Parse(txtTO.Text);
                int Z = int.Parse(txtStep.Text);
                int W = ((Y - X) / Z);
                int result = 0;
                int sum = 0;

                int i = 0;
                while (i <= W)
                {
                    sum += X + (i * Z);
                    result = sum;
                    i++;
                }
                lblResult.Text = X + " 到 " + Y + " 相隔 " + (Z - 1) + "\n"
                    + "加總為  " + result.ToString();
            }
        }

        private void btndo_Click(object sender, EventArgs e)
        {
            if (isNumber(txtFrom.Text.Trim()) == false)
            {
                MessageBox.Show("請輸入數字");
            }
            else if (isNumber(txtTO.Text.Trim()) == false)
            {
                MessageBox.Show("請輸入數字");
            }
            else if (isNumber(txtStep.Text.Trim()) == false)
            {
                MessageBox.Show("請輸入數字");
            }
            else
            {
                int X = int.Parse(txtFrom.Text);
                int Y = int.Parse(txtTO.Text);
                int Z = int.Parse(txtStep.Text);
                int W = ((Y - X) / Z);
                int result = 0;
                int sum = 0;

                int i = 0;
                do
                {
                    sum += X + (i * Z);
                    result = sum;
                    ++i;
                } while (i <= W);
                lblResult.Text = X + " 到 " + Y + " 相隔 " + (Z - 1) + "\n"
                    + "加總為  " + result.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lblResult.Text = "九九乘法表" + "\n";
            for (int j = 1; j <= 9; j++)
            {
                for (int i = 2; i <= 9; i++)
                {
                    lblResult.Text += "   " + (i + " x " + j + " = " + (i * j).ToString("00") + " |   ");
                }
                lblResult.Text += "\n";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string result = "";
            result = Convert.ToString(100, 2);
            lblResult.Text = result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int count = 0;
            int[] Numbers = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] % 2 != 0)
                {
                    count++;
                }
            }

            lblResult.Text = "int陣列arr0711[" + (Numbers[0].ToString()) + "," +
                (Numbers[1].ToString()) + "," +
                (Numbers[2].ToString()) + "," +
                (Numbers[3].ToString()) + "," +
                (Numbers[4].ToString()) + "," +
                (Numbers[5].ToString()) + "," +
                (Numbers[5].ToString()) + "," +
                (Numbers[6].ToString()) + "," +
                (Numbers[7].ToString()) + "," +
                (Numbers[8].ToString()) + "," +
                (Numbers[9].ToString()) + "," + "]" + "\n"
                + "奇數共  " + count + "\n"
                + "偶數共  " + (Numbers.Length - count);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string[] Names = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            String longest_string = Names.OrderBy(s => s.Length).LastOrDefault();


            string resultName = "";
            foreach (string B in Names)
            {
                resultName += B + ",";
            }

            resultName = resultName.Substring(0, resultName.Length - 1);


            lblResult.Text = "陣列string[  " + resultName + "]" + "\n"
          + "最長的名字為" + longest_string;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string[] Names = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };


            string resultName = "";
            foreach (string B in Names)
            {
                resultName += B + "  ";
            }

            string resultC = "";
            int count = 0;

            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i].Contains("c") || Names[i].Contains("C"))
                    count++;
                resultC += Names[i];

            }

            lblResult.Text = "String陣列:   " + resultName + "\n"
                + $"有C 或 c 的名字共有{count}個";
        }

        public void UseParams(params int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
                lblResult.Text = $" 最大值為: { max.ToString()}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] nums = new int[] { 44,99, 66, 100, 78 };
            UseParams(nums);
            
        }

        int max1;
        int min1;

        public ref int MaxScore(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    max1 = max;
                }
            }
            return ref max1;
        }

        public ref int MinScore(int[] array)
        {
            int min = array[1];
            for (int i = 0; i < array.Length; i++)
            {

                if (min > array[i])
                {
                    min = array[i];
                    min1 = min;
                }
            }
            return ref min1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] nums = { 44, 66, 99, 100, 78 };
            MaxScore(nums);
            MinScore(nums);
            lblResult.Text = $" 最大值為: { max1.ToString()} , 最小值為: { min1.ToString()}";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int[] randomBall = new int[6];
            Random rnd = new Random();
            string result2 = "";

            for (int i = 0; i < 6; i++)
            {
                //隨機產生1~49
                randomBall[i] = rnd.Next(1, 50);

                for (int j = 0; j < i; j++)
                {
                    while (randomBall[i] == randomBall[j])
                    {
                        j = 0;
                        randomBall[i] = rnd.Next(1, 50);
                    }
                }


                string result = "";
                result += randomBall[i].ToString() + "  ";
                result2 += result;

                lblResult.Text = "樂透號碼" + "\n" + "    " + result2;
            }

        }
    }
}
