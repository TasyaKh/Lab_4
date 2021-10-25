using System;

namespace Lab_4
{
        public class Technique
        {
            public static Random rnd = new Random();
            private String sizeOfDispl = "0";
            protected void sizeOfDisplay(int minSize,int maxSize)
            {
                double result = (double)rnd.Next() % (maxSize - minSize) + minSize + 1;
                sizeOfDispl = String.Format("{0:f1}",result);
            }
            public virtual String getInfo()
            {
                var str = "\nРазмер экрана: " + sizeOfDispl;
                return str;
            }
            public virtual String deviceType()
            {
                return "Все устройства";
            }
        }  
}
