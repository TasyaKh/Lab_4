using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Phone : Technique
    {
        private byte numSim;                //Количество слотов для сим
        private int cameraMegapixels;       //Количество мегапикселей для камеры
        private int battery;                //Объем батареи мач
        public Phone()
        {
            numSim = (byte)(rnd.Next() % 1 + 1);
            cameraMegapixels = rnd.Next() % 50 + 1;
            battery = (rnd.Next() % (10000 - 1500)) + 1500;

            sizeOfDisplay(2, 7);
        }
        public override String getInfo()
        {
            var str = "Телефон";
            str += base.getInfo();
            str += String.Format("\nЧисло слотов для Sim: " + numSim);
            str += String.Format("\nКол-во мегапикселей у камеры: " + cameraMegapixels);
            str += String.Format("\nБатарея: " + battery + " мАч");

            return str;
        }
    }
}
