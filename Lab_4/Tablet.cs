using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Tablet : Technique
    {
        private bool camera;        //Наличие камеры
        private int dpiScreen;      //dpi экрана

        public Tablet()
        {
            camera = rnd.Next() % 2 == 1 ? true : false;
            dpiScreen = rnd.Next() % 300 + 1;

            sizeOfDisplay(7, 11);
        }
        public override String getInfo()
        {
            var str = "Планшет";
            str += base.getInfo();
            str += String.Format("\nНаличие камеры: " + camera);
            str += String.Format("\nDPI экрана: " + dpiScreen);

            return str;
        }
    }
}
