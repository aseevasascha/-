using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_proect
{
    class Program
    {
        static void Main () 
        {
            int[] mas = new int[16];//Задаем массив на 16 элементов 
          

            for (int i = 0; i < mas.Length; i++)//Объявляем цикл для обработки массива
            {
                mas[i] = 0;//Заполняем массив 0
            }

                foreach (int i in mas)//Распечатываем значение элементов массива
                Console.WriteLine(i);
            Console.ReadKey();
        }
                
    }
}