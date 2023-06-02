using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КонференцияИнформационнаяБезопасность
{
    public partial class Организатор : Form
    {
        public Организатор()
        {
            InitializeComponent();
        }
        public Организатор(string ФИО)
        {
            InitializeComponent();
            label3.Text = ФИО;

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Мероприятия aa = new Мероприятия();
            aa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Участники aa = new Участники();
            aa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ЖюриМодераторы aa = new ЖюриМодераторы();
            aa.Show();
            this.Hide();
        }

        private void Организатор_Load(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;

            if(h>=9 && h<=11)
            {
                label2.Text = "Доброе утро";

            }
            if (h >= 11 && h <= 18)
            {
                label2.Text = "Добрый день";

            }
            if (h >= 18 && h <= 24)
            {
                label2.Text = "Добрый вечер";

            }






        }

        private void label5_Click(object sender, EventArgs e)
        {
            Авторизация aa  = new Авторизация();
            aa.Show();
            this.Hide();
        }
    }
}
