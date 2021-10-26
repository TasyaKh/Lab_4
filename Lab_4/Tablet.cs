using System;

namespace Lab_4
{
    public class Tablet : Technique        //Класс для планшетов, наследует класс техника
    {
        private bool camera;        //Наличие камеры
        private int dpiScreen;      //dpi экрана

        public Tablet()
        {
            camera = rnd.Next() % 2 == 1 ? true : false; //0-1
            dpiScreen = rnd.Next() % 300 + 1;            //1-300

            sizeOfDisplay(7, 11);
        }
        public override String getInfo()                         //Получаем информацию об устройстве
        {
            var str = "Планшет";                                 //Говорим о том, что это планшет
            str += base.getInfo();                               //Получить размер экрана(общее свойство для всех устройств) с суперкласса
            str += String.Format("\nНаличие камеры: " + camera); //Вывести наличие камеры, есть она или нет
            str += String.Format("\nDPI экрана: " + dpiScreen);  //Получить dpi экрана

            return str;                                          //Вывести полученные данные об устройстве
        }
         public int getDpiScreen()
        {
            return dpiScreen;
        }
    }
}
