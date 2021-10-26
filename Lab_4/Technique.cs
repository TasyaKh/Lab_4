using System;

namespace Lab_4
{
        public class Technique                        //Класс техники, наследуют все устройства
        {
            public static Random rnd = new Random();  //Нужен для получения случайных знаечний
            private String sizeOfDispl = "0";         //Размер экрана для всех устройств
            protected void sizeOfDisplay(int minSize,int maxSize) //Установить размер экрана максимальное значение и минимальное
            {
                double result = rnd.NextDouble() % (maxSize - minSize) + minSize + 1; //Вычислить значение от minSize до  maxSize
                sizeOfDispl = String.Format("{0:f1}",result);                         //Форматировать вычисленное значение размера экрана
            }
            public virtual String getInfo()                                            //Получить информацию об устройстве
            {
                var str = "\nРазмер экрана: " + sizeOfDispl + " дюйм";                 //Сформировтвать сообщение о размере экрана
                return str;                                                            //Вывести сформированное сообщение
            }
        public String getSizeOfDisplay()
        {
            return sizeOfDispl;
        }
    }  
}
