using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sort_mass
{
    class Indicator : System.Windows.Forms.Panel
    {
      private Color fonColor; //цвет фона диаграммы
      private Graphics g;    
      private Pen p;         // перо для рисования
      private Pen p_marker;  // перо для выделения
      private int width;     // ширина диаграммы
      private int height;    // высота диаграммы
      private int penThick;  // толщина пера (фактически толщина столбика диаграммы)
      private int otstup;    // отступ от края диаграммы 
      private float sc; // коэффициент масштабирования
      private int interval; //положение первого столбика

      public  Indicator()    // конструктор по умолчанию
      {
          width = 100; height = 67;           // высота и ширина по умолчанию
          fonColor = Color.SteelBlue;         // цвет фона диаграммы по умолчанию
          this.BackColor = fonColor;          // задать фон
          this.Location = new Point(0, 0);    // положение диаграммы 
          this.Name = "indicator";            // наименование диаграммы
          this.Size = new Size(width, height); // задать размер
          this.TabIndex = 0;
          g = this.CreateGraphics();          // создать Graphics объекта 
          penThick = 3;                       //толщина пера по умолчанию
      }
      public Indicator(int x, int y, int wid, int hei) // конструктор с параметрами
        {
            width = wid; height = hei;              //высота и ширина диаграммы
            fonColor = Color.SteelBlue;             //цвет фона диаграммы
            this.BackColor = fonColor;              //задать фон
            this.Location = new Point(x, y);        //положение диаграммы
            this.Name = "indicator";                // наименование диаграммы
            this.Size = new Size(width, height);    //задать размеры диаграммы
            this.TabIndex = 0;
            g = this.CreateGraphics();              // создать Graphics объекта 
            penThick = 3;                           //толщина пера
        }

      public void PrepareScale(ref int[] mas) //подготовить параметры диаграммы
      {

          var max = 1; //задаем максимальное стартовое значение
          int size = mas.Count();

          foreach (var ob in mas) //просматриваем массив и находим максимальное значение
          {
              if (ob >= max) { max = ob; }
          }
          sc = (float)(height - 1) / max; // вычисляем коэффициент масштабирования
         
          penThick = (width - size) / size; //вычисляем толщину пера исходя из кол-ва элементов в массиве
          otstup = (width - size) % size;   //вычисляем отступ исходя из кол-ва элементов в массиве
          p = new Pen(Color.YellowGreen, penThick);   // создаем перо для рисования столбика
          p_marker = new Pen(Color.PaleVioletRed, penThick); // создаем перо маркера
      }

      public void ShowScale(ref int[] mas, int i1, int i2) //отобразить диаграмму согласно данным массива 
      {
          int j;

          g.Clear(fonColor); // очистить Graphics цветом фона
          interval = otstup / 2 + penThick / 2; //задаем положение первого столбика
          
          for (j = 0; j < mas.Count(); j++) // строим столбики по массиву
          {

              if (j == i1 || j == i2) // проверяем на соответсвие индексов маркерам
              {
                  AddLine(p_marker, interval, height - 1, interval, height - (int)(mas[j] * sc));   //строим маркированную линию
                  interval += penThick + 1;                                                         //смещение для следующего столбика
              }
              else
              {
                  AddLine(p, interval, height - 1, interval, height - (int)(mas[j] * sc));           //строим обычную линию
                  interval += penThick + 1;                                                          //смещение для следующего столбика
              }
           
          }
          
      }
   
    
    protected void AddLine(Pen p_, int _x, int _y, int x_, int y_) // Рисование столбика
    {
          g.DrawLine(p_, new PointF(_x, _y), new PointF(x_,y_));     
    } 
  
  
    }
}