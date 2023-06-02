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
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Главная aa = new Главная();
            aa.Show();
            this.Hide();
        }
        // Код на авторизацию Организатора
        private void button1_Click(object sender, EventArgs e) 
        {
            SqlConnection con = new SqlConnection("Data Source=DC\\WS2021;Initial Catalog=a4;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select ФИО FROM Организаторы where Код_организатора= '" + textBox1.Text + "'  and Пароль= '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли в систему!");
                this.Hide();
                Организатор аа = new Организатор(dt.Rows[0][0].ToString());
                аа.Show();
            }
            else
            {
                MessageBox.Show("Ошибка данных!\nВведите данные еще раз!");
            }
        }
    }
}


