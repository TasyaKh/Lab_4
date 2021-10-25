using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        List<Technique> techList = new List<Technique>();
        public Form1()
        {
            InitializeComponent();
            showInfo();
        }

        private void showInfo()
        {
            int laptopCount = 0;
            int tabletCount = 0;
            int phoneCount = 0;

            foreach (var tech in this.techList)
            {
                if(tech is Laptop)
                {
                    laptopCount++;
                }
                else if(tech is Tablet)
                {
                    tabletCount++;
                }
                else if(tech is Phone)
                {
                    phoneCount++;
                }
            }
            txtInfo.Text = "Ноутбук   Планшет   Телефон";
            txtInfo.Text +="\n";
            txtInfo.Text += String.Format("{0}\t  {1}\t     {2}", laptopCount, tabletCount, phoneCount);
        }

        private void Refill_Click(object sender, EventArgs e)
        {
           techList.Clear();

           var rnd = new Random();

            for(int i = 0; i < 10; i++)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        techList.Add(new Laptop());
                        break;
                    case 1:
                        techList.Add(new Tablet());
                        break;
                    case 2:
                        techList.Add(new Phone());
                        break;
                }
            }
            showInfo();
        }
    }
}
