using System;

namespace Lab_4
{
    public class Phone : Technique                 //Класс Телефонов, наследует класс техника
    {
        private byte numSim;                //Количество слотов для сим
        private int cameraMegapixels;       //Количество мегапикселей для камеры
        private int battery;                //Объем батареи мач
        public Phone()
        {
            numSim = (byte)(rnd.Next() % 2 + 1);            //1 - 2
            cameraMegapixels = rnd.Next() % 50 + 1;         //1-50
            battery = (rnd.Next() % (10000 - 1500)) + 1500; //1500-10000

            sizeOfDisplay(2, 7);
        }
        public override String getInfo()                   //Получить информацию оь утсройстве
        {
            var str = "Телефон";
            str += base.getInfo();                        //Получить информацию о размере экрана
            str += String.Format("\nЧисло слотов для Sim: " + numSim);
            str += String.Format("\nКол-во мегапикселей у камеры: " + cameraMegapixels);
            str += String.Format("\nБатарея: " + battery + " мАч");

            return str;
        }
        public byte getNumSim()
        {
            return numSim;
        }
        public int getCameraMegapixels()
        {
            return cameraMegapixels;
        }
        public int getBattery()
        {
            return battery;
        }
    }
}
