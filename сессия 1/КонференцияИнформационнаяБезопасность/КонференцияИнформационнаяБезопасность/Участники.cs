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
    public partial class Участники : Form
    {
        public Участники()
        {
            InitializeComponent();
        }

        private void Участники_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "a4DataSet.Участники". При необходимости она может быть перемещена или удалена.
            this.участникиTableAdapter.Fill(this.a4DataSet.Участники);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Организатор aa = new Организатор();
            aa.Show();
            this.Hide();
        }
    }
}
