using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int n;
            // Проверяем ввод пользователя из textBox1
            if (int.TryParse(textBox1.Text, out n) && n > 1)
            {
                // Находим простые числа и выводим в textBox2
                string primes = FindPrimeNumbers(n);
                textBox2.Text = primes;
            }
            else
            {
                MessageBox.Show("Ошибка: Пожалуйста, введите целое число больше 1.");
            }
        }

        private string FindPrimeNumbers(int n)
        {
            // Формируем строку с простыми числами
            string result = "Простые числа от 2 до " + n + ": ";

            for (int num = 2; num <= n; num++)
            {
                if (IsPrime(num))
                {
                    result += num + " ";
                }
            }

            return result.Trim(); // Возвращаем результат
        }

        // Метод для проверки простоты числа
        private bool IsPrime(int number)
        {
            if (number < 2) return false; // Числа меньше 2 не считаются простыми
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) // Если число делится на i без остатка, значит оно составное
                {
                    return false;
                }
            }
            return true; // Если не нашли делителей, число простое
        }


    }
}