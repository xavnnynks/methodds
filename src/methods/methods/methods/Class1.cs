using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace methods
{
    public class Class1
    {
        // Составить функцию, которая при данных a и b возвращает максимум трех выражений:
        public string maximum(double a, double b)
        {

            // x=cos(a+b)^2
            //double plus = a + b;
            //double x = Math.Pow(Math.Sin(plus), 2);
            
            string res1 = "0";

            // y=sin(a+b)
            //x = Math.Sin(plus);

            string res2 = "0";

            // z = a/b (дробь)
            // 

            string res3 = "0";
            return $"{res1}, {res2}, {res3}";
        }

        // С помощью функции надо определить, сколько раз данное число повторяется в массиве.
        public int massiv(int[] x, int n)
        {
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (n == x[i])
                { count++; }
            }
            return count;
        }

        /*7.10.Программа вводит символ, а затем с помощью функции определяет,
        сколько раз указанный символ встречается в произвольной
        последовательности символов.*/
        public int symbol(char x, string y)
        {
            int count = 0;
            for (int i = 0; y.Length > 0; i++)
            {
                if (y[i] == x)
                { count++; }
            }
            return count;
        }

        /*7.11.Программа с помощью функции определяет максимальный элемент
        одномерного массива, а затем подсчитывает количество максимумов.*/
        public int max(int[] x, int y)
        {
            int max = x[0];
            for (int i = 0; i < x.Length; i++) 
            {
                if (max < x[i])
                { 
                    max = x[i]; 
                }
            }
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == max)
                { count++; }
            }
            return count;
        }

        public void matrix(int[,] x)
        {//7.16. Написать функцию замены элементов диагонали матрицы на нули.

            int count = 0;

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    if (i == count && j == count)
                    {
                        x[count, count] = 0;
                    }

                }
                count++;
            }
        }

        public void matrixminus(int[,] x)
        {//7.17. Написать функцию замены всех отрицательных чисел матрицы на единицы.

            for (int i = 0; i < x.GetLength(0); i++)
            { 
                // итерация, если итерация не больше количества столбцов, итерация плюс
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    // нужно найти минимальный элемент в текущей строке
                    if (x[i, j] < 0)
                    {
                        x[i, j] = 1;
                    }
                }
            }
        }

        public int matrixSum(int[,] x)
        {//7.18. Написать функцию нахождения суммы минимальных элементов матрицы по строкам.
            int summ = 0;

            // итерация, если итераций не больше количества строк, итерация плюс
            for (int i = 0; i < x.GetLength(0); i++)
            {
                //мы пробегаемся по столбцам, затем по строкам
                int min = x[i, 0];

                // итерация, если итерация не больше количества столбцов, итерация плюс
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    // нужно найти минимальный элемент в текущей строке
                    if (x[i, j] < min)
                    {
                        min = x[i, j];
                    }
                }
                summ += min;
            }
            return summ;
        }

        public string reverse(string s)
        {//7.21.Дана строка. Получить с помощью функции новую строку путем прочтения ее, начиная с конца.
            string r = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                r += s[i];
            }
            return r;
        }


        public string stroka(string x)
        {//Добавить к ней с помощью функции в начале строки четыре символа «+» и пять символов «-».
            return $"++++{x}-----";
        }

        public string ss(char x, int k)
        {// 7.23.Дан символ.С помощью функции составить программу, формирующую строку, состоящую из k данных символов.
            string z = "";
            for (int i = 0; i < k; i++) 
            {
                z += x;
            }
            return z;
        }

        public int massSum(int[] x, int n)
        {//7.24. С помощью функции составить программу суммирования первых n элементов одномерного массива.
            if (x.Length < n)
                throw new Exception("n не может быть больше длины массива");
            int summ = 0;
            for (int i = 0; i < n; i++)
            {
                summ += x[i];
            }
            return summ;
        }
    }
}
