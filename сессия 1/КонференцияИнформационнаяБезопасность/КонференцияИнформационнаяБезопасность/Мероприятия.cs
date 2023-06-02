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
    public partial class Мероприятия : Form
    {
        public Мероприятия()
        {
            InitializeComponent();
        }

        private void Мероприятия_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "a4DataSet.Мероприятия". При необходимости она может быть перемещена или удалена.
            this.мероприятияTableAdapter.Fill(this.a4DataSet.Мероприятия);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Организатор aa = new Организатор();
            aa.Show();
            this.Hide();
        }
    }
}
