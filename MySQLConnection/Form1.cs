using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MySQLConnection
{
    public partial class Form1 : Form
    {

        private MySqlConnectionStringBuilder mysqlbuilder = new MySqlConnectionStringBuilder();
        private MySqlConnection mysqlconnection;

        public Form1()
        {
            InitializeComponent();
        }

        private void on_mysql_Click(object sender, EventArgs e)
        {
            //用户数据库账号、密码
            mysqlbuilder.UserID = "root";
            mysqlbuilder.Password = "123456";
            mysqlbuilder.Server = "localhost";
            mysqlbuilder.Database = "test2";
            mysqlconnection = new MySqlConnection(mysqlbuilder.ConnectionString);        
            try
            {
                mysqlconnection.Open();
                MessageBox.Show("数据库连接成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void create_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string sql = "insert into student values (" + "'" + Sno_textbox.Text + "','" + Sname_textbox.Text + "'" + ",'" + Ssex_textbox.Text + "'," + Sage_textbox.Text  + ",'" + Sdept_textbox.Text +"')";
            MySqlCommand cmd = new MySqlCommand(sql, mysqlconnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("数据添加成功！");
            mysqlconnection.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string sql = "delete from student where id=" + Sno_textbox.Text;
            MySqlCommand cmd = new MySqlCommand(sql, mysqlconnection);
            cmd.ExecuteNonQuery();
            if (cmd.ExecuteNonQuery() < 0)
            {
                mysqlconnection.Close();
                MessageBox.Show("删除失败");
                return;
            }
            mysqlconnection.Close();
            MessageBox.Show("数据删除成功！");
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "确实修改数据？";
                if (1 == (int)MessageBox.Show(msg, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
                {
                    string sql = "update student set Sno=" + "'" + Sno_textbox.Text + "',Sname=" + "'" + Sname_textbox.Text + "',Ssex=" + "'" + Ssex_textbox.Text + "',Sage=" + Sage_textbox.Text + ",Sdept = " + "'" + Sdept_textbox.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, mysqlconnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("数据更新成功！");
                    mysqlconnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "错误信息");
                mysqlconnection.Close();
            }
        }

        private void read_Click(object sender, EventArgs e)
        {
            string sql1 = "select * from student"; 
            MySqlCommand cmd1 = new MySqlCommand(sql1, mysqlconnection);
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            //string sql2 = "select * from course";
            //MySqlCommand cmd2 = new MySqlCommand(sql2, mysqlconnection);
            //MySqlDataReader reader2 = cmd2.ExecuteReader();

            //在dataGridView1中显示列属性
            dataGridView1.ColumnCount = 5;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.Columns[0].Name = "Sno";
            dataGridView1.Columns[1].Name = "Sname";
            dataGridView1.Columns[2].Name = "Ssex";
            dataGridView1.Columns[3].Name = "Sage";
            dataGridView1.Columns[4].Name = "Sdept";
            
            /*dataGridView2.ColumnCount = 3;
            dataGridView2.ColumnHeadersVisible = true;
            dataGridView2.Columns[0].Name = "Cno";
            dataGridView2.Columns[1].Name = "Cname";
            dataGridView2.Columns[2].Name = "Tname";*/

            //在DataGridView1中显示数据
            while (reader1.Read())
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = reader1.GetString("Sno");
                this.dataGridView1.Rows[index].Cells[1].Value = reader1.GetString("Sname");
                this.dataGridView1.Rows[index].Cells[2].Value = reader1.GetString("Ssex");
                this.dataGridView1.Rows[index].Cells[3].Value = reader1.GetInt32("Sage");
                this.dataGridView1.Rows[index].Cells[4].Value = reader1.GetString("Sdept");
            }
            /*while (reader2.Read())
            {
                int index = this.dataGridView2.Rows.Add();
                this.dataGridView2.Rows[index].Cells[0].Value = reader2.GetString("Cno");
                this.dataGridView2.Rows[index].Cells[1].Value = reader2.GetString("Cname");
                this.dataGridView2.Rows[index].Cells[2].Value = reader2.GetString("Tname");
            }*/
            MessageBox.Show("数据查取成功！");
            mysqlconnection.Close();
        }

        private void off_mysql_Click(object sender, EventArgs e)
        {
            mysqlconnection.Close();     //关闭连接
            MessageBox.Show("数据库已断开连接！");
        }
    }
}
