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
    public partial class ДобавлениеЖюриМодератора : Form
    {
        public ДобавлениеЖюриМодератора()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ЖюриМодераторы aa = new ЖюриМодераторы();
            aa.Show();
            this.Hide();
        }

        private void ДобавлениеЖюриМодератора_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "a4DataSet.Мероприятия". При необходимости она может быть перемещена или удалена.
            this.мероприятияTableAdapter.Fill(this.a4DataSet.Мероприятия);

        }
    }
}
