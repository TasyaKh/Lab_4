using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Laptop : Technique
    {
        private bool backlightKeyboard; //С подстветкой клавиатура или нет
        private byte numberCores;       //Число ядер
        private int spaceHardDrive;     //Объем памяти жесткого диска гб
        public Laptop()
        {
            backlightKeyboard = rnd.Next() % 2 == 1 ? true : false;
            numberCores = (byte)(rnd.Next() % 32 + 1);
            spaceHardDrive = (rnd.Next() % 1000 + 1);

            sizeOfDisplay(10, 18);
        }
        public override String getInfo()
        {
            var str = "Ноутбук";
            str += base.getInfo();
            str += String.Format("\nПодсветка на клавиатуре: " + backlightKeyboard);
            str += String.Format("\nЧисло ядер: " + numberCores);
            str += String.Format("\nОбъем жесткого диска: " + spaceHardDrive + " гб.");

            return str;
        }
    }
}
