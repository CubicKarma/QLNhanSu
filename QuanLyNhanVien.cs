using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNhanSu
{
    public partial class QuanLyNhanVien : Form
    {
        //Ket noi SQL
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();

        //Datasourse (khac nhau)
        string dataSource = @"Data Source=DESKTOP-152SFQ3;Initial Catalog=Quanlynhasu_3F;Integrated Security=True";

        DataTable table = new DataTable();

        //demo datagridview trong form QuanLyNhanvien.cs
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NHANVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(dataSource);
            connection.Open();
            loadData();
        }

        private void lblTenNv_Click(object sender, EventArgs e)
        {

        }

        private void txtTenNv_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLuong_Click(object sender, EventArgs e)
        {

        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaNv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenNv.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDiachi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtLuong.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            cbxPhongban.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            cbxDuan.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }
    }
}
