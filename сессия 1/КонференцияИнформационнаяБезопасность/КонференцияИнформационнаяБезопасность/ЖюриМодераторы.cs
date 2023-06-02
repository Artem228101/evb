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
    public partial class ЖюриМодераторы : Form
    {
        public ЖюриМодераторы()
        {
            InitializeComponent();
        }

        private void ЖюриМодераторы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "a4DataSet.Модераторы". При необходимости она может быть перемещена или удалена.
            this.модераторыTableAdapter.Fill(this.a4DataSet.Модераторы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "a4DataSet.Жюри". При необходимости она может быть перемещена или удалена.
            this.жюриTableAdapter.Fill(this.a4DataSet.Жюри);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Организатор aa = new Организатор();
            aa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ДобавлениеЖюриМодератора aa = new ДобавлениеЖюриМодератора();
            aa.Show();
            this.Hide();
        }
    }
}
