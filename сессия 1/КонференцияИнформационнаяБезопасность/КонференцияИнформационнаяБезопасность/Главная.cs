using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КонференцияИнформационнаяБезопасность
{
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Главная_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "a4DataSet.Мероприятия". При необходимости она может быть перемещена или удалена.
            this.мероприятияTableAdapter.Fill(this.a4DataSet.Мероприятия);

        }
        // Код на переход на следующую форму
        private void button1_Click(object sender, EventArgs e)
          
        {
            Авторизация aa = new Авторизация();
            aa.Show();
            this.Hide();
        }

        // Код на поиск
        private void textBox1_TextChanged(object sender, EventArgs e)
            
        {
            SqlConnection con = new SqlConnection(@"Data Source=DC\WS2021;Initial Catalog=a4;Integrated Security=True");
            con.Open();
            string rt = "Select * From Мероприятия where Cобытие like '%" + textBox1.Text + "%'";
            SqlCommand cmd = new SqlCommand(rt, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
