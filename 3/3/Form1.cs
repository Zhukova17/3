using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numbersList = new List<int>();
        List<float> numberList = new List<float>();

        private void button1_Click(object sender, EventArgs e)
        {
            numbersList.Clear();
            numberList.Clear();
            string input = textBox.Text;
            string[] elements = input.Split(' ');

            foreach (string element in elements)
            {
                if (int.TryParse(element, out int number)&&number<0)
                {
                    numbersList.Add(number); // Добавляем в numbersList
                }

                else if (float.TryParse(element, out float Number)&&Number < 0)
                {
                    numberList.Add(Number); // Добавляем в numberList
                }
            }

            textBox2.Text = null;
            foreach (int element in numbersList)
            {
                textBox2.Text += $" {element}";            
            }

            textBox2.Text = null;
            foreach (float element in numberList)
            {
                textBox2.Text += $" {element}";
            }
        }

        /// <summary>
        /// Шаблонная функция 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lists"></param>
        /// <returns></returns>
        public static T Sum<T>(List<T> lists)
        {
            dynamic list = lists;
            dynamic sum = default(T);
            foreach (var element in list)
            {
                sum += (dynamic)element;
            }
            return sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Отображаем результат
            label1.Text = $"Сумма отрицательных элементов: {Sum(numbersList)}";
            label1.Text = $"Сумма отрицательных элементов: {Sum(numberList)}";
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    } 
}
