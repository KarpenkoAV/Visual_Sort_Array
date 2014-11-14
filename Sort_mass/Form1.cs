using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Sort_mass
{
    public partial class Form1 : Form
    { 
       // Indicator ind = new Indicator(57, 29, 450 ,100); 
        Indicator ind; // объявим индикатор
        Random rand;
        int delay;
        int[] ms;
        //  int[] ms = { 55, 67, 34, 55, 22, 54, 44, 33, 21, 65, 11, 14, 69, 8, 12, 32, 55, 57,6, 7,57,22,11,5,4, 47,31,3, 55, 4, 7,22,18,17,7,9,3,47,58, 67, 80,7,5,23,11 };
        //  int[] ms = { 44, 65, 44, 65 };
        
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            rand = new Random();
         //   this.Controls.Add(ind);
            ind = new Indicator(15, 20, groupBoxIndicator.Size.Width-30, groupBoxIndicator.Size.Height-30); //создаем объект индикатора с размерами groupBox 
            this.groupBoxIndicator.Controls.Add(ind); //добавляем объект индикатора к объекту groupBoxIndicator который в свою очередь принадлежит Form1
            textBoxDelay.Text = "300"; //задержка
            textBoxStart.Text = "1"; // задаем начальное значение элемента массива
            textBoxFinish.Text = "150"; //задаем кнечное значение элемента массива
            textBoxSize.Text = "50"; //задаем кол-во элементов в массиве
            comboBoxMetod.Text = comboBoxMetod.Items[0].ToString(); //Устанавливаем первый метод сортировки
        }



        private void button2_Click(object sender, EventArgs e)
        {
           
            switch (comboBoxMetod.Text)
            {
                case "Bubble":
                    {
                        Bubble(); 
                    }
                break;
                case "QuickSort":
                    {
                        QuickSort(0, ms.Count() - 1);
                    }
                break;
                case "InsertSort":
                {
                    InsertSort();
                }
                break;
            }
             
        }

        private void Bubble()
        {
             int count=0, count_r=0, tmp;

            while (count < ms.Count())
            {
                ind.ShowScale(ref ms, count, count_r);         
                Thread.Sleep(delay);
                for(int i=count+1;i<ms.Count();i++)
                    if (ms[count] > ms[i])
                    {
                        tmp = ms[count];
                        ms[count] = ms[i];
                        ms[i] = tmp;
                        count_r = i;
                    }
                count++;
            }
            ind.ShowScale(ref ms, -1, -1);      
        }

        private void QuickSort(int a, int b)
        {          
            int A = a;
            int B = b;
            double mid;
            if (b > a)
            {          
                mid = ms[(a + b) / 2];// Находим разделительный элемент в середине массива           
                while (A <= B)// Обходим массив
                {
                    Thread.Sleep(delay);

                    // Находим элемент, который больше или равен разделительному элементу от левого индекса.
                    while ((A < b) && (ms[A] < mid)) 
                        ++A;
                    // Находим элемент, который меньше или равен разделительному элементу от правого индекса.
                    while ((B > a) && (ms[B] > mid)) 
                        --B;
                    // Если индексы не пересекаются, меняем
                    if (A <= B)
                    {
                        int tmp;
                        tmp = ms[A];
                        ms[A] = ms[B];
                        ms[B] = tmp;
                        ++A;
                        --B;
                    }
                    ind.ShowScale(ref ms, A, B);
                }
                 // Если правый индекс не достиг левой границы массива, тогда необходимо повторить сортировку левой части.
                if (a < B) QuickSort(a, B);
                // Если левый индекс не достиг правой границы массива,  тогда необходимо повторить повторить сортировку правой части.
                if (A < b) QuickSort(A, b);
            }
               ind.ShowScale(ref ms, -1, -1);
        }

        void InsertSort() // сортировка вставками
        {
            int temp, // временная переменная для хранения значения элемента сортируемого массива
                item; // индекс предыдущего элемента
            for (int counter = 1; counter < ms.Count(); counter++)
            {
                
                Thread.Sleep(delay);
                temp = ms[counter]; // инициализируем временную переменную текущим значением элемента массива
                item = counter - 1; // запоминаем индекс предыдущего элемента массива
                while (item >= 0 && ms[item] > temp) // пока индекс не равен 0 и предыдущий элемент массива больше текущего
                {
                    ind.ShowScale(ref ms, counter, item);
                    ms[item + 1] = ms[item]; // перестановка элементов массива 
                    ms[item] = temp;
                    item--;
                }
            }
            ind.ShowScale(ref ms, -1, -1);    
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            int vStart = Convert.ToInt32(textBoxStart.Text);
            int vFinish = Convert.ToInt32(textBoxFinish.Text);
            int size = Convert.ToInt32(textBoxSize.Text);
            delay = Convert.ToInt32(textBoxDelay.Text);
            ms = new int[size];
            for (int i = 0; i < size; i++)
                ms[i] = rand.Next(vStart, vFinish);//Заполняем случайными числами диапозоном от vStart до vFinish
                ind.PrepareScale(ref ms); 
                ind.ShowScale(ref ms, -1, -1);       
        }

         
    }
}
