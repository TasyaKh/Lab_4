using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        List<Technique> techList = new List<Technique>();   //Хранит утсройства(в порядке живой очереди)

        Image[] img = new Image[3] {                       //Хранит изображения устрйств
            new Bitmap(Lab_4.Properties.Resources.Laptop), //Изображение для ноутбуков
            new Bitmap(Lab_4.Properties.Resources.Tablet), //Изображение для планшетов
            new Bitmap(Lab_4.Properties.Resources.Phone)   //Изображение для телефонов
            };
        public Form1()
        {
            InitializeComponent();                        //Инициализировать компоненты
            showInfo();                                   //Показать начальную информацию об утсройствах
        }

        private void showPicture()            //Вывест и картинку об утсройстве на экран
        {         
            var tech = techList[0];                       //Получить первый элемент очереди
            if(tech is Laptop)                            //Просматриваем все элементы и в соответствии с найденным элементов выводим картинку
            { 
                pictureBox1.Image = img[0];
            }
            else if (tech is Tablet)
            {  
                pictureBox1.Image = img[1];
            }
            else if (tech is Phone)
            {
                pictureBox1.Image = img[2];
            }
        }
        private void showInfo()  //Показывает информацию о девайсе
        {
            String txt = "";     //Здесь хранится информация о поряждке взятия устройств с очереди
            int count = 0;       //Номер взятого элемента

            int laptopCount = 0; //Подсчитывает количество ноутбуков
            int tabletCount = 0; //Количество планшетов
            int phoneCount = 0;   //Количество телефонов

            foreach (var tech in this.techList) //Смотрим весь лист с устройствами
            {
                count++;              
                txt += count;                   //Номер присвоить

                if (tech is Laptop)             //Формируем информацию об устройствах 
                {
                    laptopCount++;
                    txt += ")Ноутбук\n";   

                       
                }
                else if (tech is Tablet)
                {
                    tabletCount++;
                    txt += ")Планшет\n";
                }
                else if (tech is Phone)
                {
                    phoneCount++;
                    txt += ")Телефон\n";
                }
            }
            txtInfo.Text = "Ноутбук   |Планшет|   Телефон";    //Выводим количество хранимых утсройств
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t   {1}\t      {2}", laptopCount, tabletCount, phoneCount); //Выводим их количество
            
            if (switchMode.Checked)   //Если мод на просмотр очереди включен, то показать ее элементы в отдельном боксе  seeElems
            {
                seeElems.Text = txt;
            }
            else                      //Если мод выключен, то запретить показ элементов
            {
                seeElems.Text = "";
            }
        }
   
        private void Refill_Click(object sender, EventArgs e) //Кнопка для перезаполнения списка
        {
            txtOut.Text = "Welcome!";
            techList.Clear();                                 //Очищаем массив с элементами

            var rnd = new Random();                           //Нужен для получения случайных чисел, чтобы заполнить автомат устройствами
            for (int i = 0; i < 10; i++)                      //Всего устройств будет 10 штук
            {
                switch (rnd.Next() % 3)                       //3ри устройства
                {
                    case 0:
                        this.techList.Add(new Laptop());
                        break;
                    case 1:
                        this.techList.Add(new Tablet());
                        break;
                    case 2:
                        this.techList.Add(new Phone());
                        break;
                }
            }
            showInfo();                              //Показать информацию о девайсе
            pictureBox1.Image = null;                       //Показать изображение для девайса
        }

        private void buttonGet_Click(object sender, EventArgs e) //Получтть элемент по нажатию кнопки "получить"
        {
            String info = "";                                    //Хранит полученную информацию

            if(techList.Count == 0)                              //Если девайсы закончились
            {
                txtOut.Text = "Денег нет!";
                pictureBox1.Image = null;                              //Показать изображение для девайса
                return;
            }
            Technique tech = this.techList[0];

            info = tech.getInfo();            //Получить информацию о девайсе
            txtOut.Text = info;               //Покрасить первую строку бокса, который выводит информацию о девайсе
            txtOut.SelectionStart = 0;        //Начало покраски строки
            txtOut.SelectionLength = info.IndexOf('\n');                                         //До конца первой строки
            txtOut.SelectionColor = Color.Blue;                                                  //Красим в синий цвет
            txtOut.SelectionFont = new Font(txtOut.Font.Name,10,System.Drawing.FontStyle.Bold);  //Делаем текст первой строки жирнее

          
           
            showPicture();                   //Показать изображение для девайса
            this.techList.RemoveAt(0);       //Удаляем вытащенный элемент
            showInfo();                      //Показываем измененную информацию о количестве девайсов


        }

        private void switchMode_CheckedChanged(object sender, EventArgs e) //Если мод на показ элементов очереди включен(мы можем узнать в каком порядке мы будем получать элементы с очереди)
        {

            if (switchMode.Checked == false)       //Если мод выключен, то запрещаем показ элементов очереди 
            {
                seeElems.Text = "";
            }
            else                                   //иначе, выводим состояние очереди и разрешаем показ элементов
            {
                showInfo();
            }
        }
    }
}
