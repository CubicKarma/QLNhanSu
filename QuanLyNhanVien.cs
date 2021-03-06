﻿using System;
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
        //Help ref
        Form helpf;
        //Ket noi SQL
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader sqlReader;
        SqlDataAdapter adapter = new SqlDataAdapter();

        //Datasourse (khac nhau)

        DataTable table = new DataTable();

        //demo datagridview trong form QuanLyNhanvien.cs
        void loadData()
        {
            //Thiet lap input listener
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);

            command = connection.CreateCommand();
            command.CommandText = "select * from NHANVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            //Thêm phòng ban vào cbx
            UpdatePB();

            //Thêm dự án vào cbx
            UpdateDA();
        }

        private void UpdateDA()
        {
            cbxDuan.Items.Clear();
            command.CommandText = "SELECT * FROM DUAN";
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                cbxDuan.Items.Add(sqlReader["id_Da"].ToString());
            }
            sqlReader.Close();
        }

        private void UpdatePB()
        {
            cbxPhongban.Items.Clear();
            command.CommandText = "SELECT * FROM PHONGBAN";
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                cbxPhongban.Items.Add(sqlReader["id_Pb"].ToString());
            }
            sqlReader.Close();
        }

        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Helper.Define.dataSource);
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
       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from NHANVIEN where id_Nv='" + txtMaNv.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }
        //gọi sự kiện đóng form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Chuyển về form đăng nhập rồi mới tắt form để app đc terminate
            Helper.Utilities.GetMainForm().Show();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            
            string id = txtMaNv.Text;
            connection.Open();

            string sql = "select * from NHANVIEN where id_Nv = '" + txtMaNv.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, connection);

            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {

                MessageBox.Show(" Trùng Mã Nhân Viên! Mời Nhập lại");
            }
            else
            {
                dta.Close();
                command = connection.CreateCommand();
                command.CommandText = "Insert into NHANVIEN values('" + txtMaNv.Text + "', N'" + txtTenNv.Text + "','" + dtpNgaySinh.Text + "', N'" + txtDiachi.Text + "' , '" + txtLuong.Text + "' , '" + cbxPhongban.Text + "' , '" + cbxDuan.Text + "')";
                command.ExecuteNonQuery();
                loadData();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtMaNv.Text = "";
            txtTenNv.Text = "";
            dtpNgaySinh.Text = "1/1/1900";
            txtDiachi.Text = "";
            txtLuong.Text = "";
            cbxPhongban.Text = "";
            cbxDuan.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //txtMaNv.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = "update NHANVIEN set name_Nv = N'" + txtTenNv.Text + "', ngaysinh_Nv = '" + dtpNgaySinh.Text + "', diachi_Nv = N'" + txtDiachi.Text + "' , luong_Nv = '" + txtLuong.Text + "', id_Pb = '" + cbxPhongban.Text + "' , id_Da= '" + cbxDuan.Text + "' where id_Nv = '" + txtMaNv.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            connection.Open();
            string maNhanVien = txtSearch.Text;
            string sql = "select id_NV from NHANVIEN where id_NV = '" + txtSearch.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader dta = cmd.ExecuteReader();

            if (dta.Read() == true)
            {
                dta.Close();
                command = connection.CreateCommand();
                command.CommandText = "select * from NHANVIEN where id_Nv='" + txtSearch.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else
            {
                MessageBox.Show("Không có mã nhân viên cần tìm!");
            }
        }

        //input listener
        void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                CreateHelpForm();
            }
        }

        private void CreateHelpForm()
        {
            if (helpf == null)
            {
                Helper.Helper helper = new Helper.Helper();
                helper.ShowDialog();
                helpf = helper;
            }
        }

        private void helpBTN_Click(object sender, EventArgs e)
        {
            CreateHelpForm();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NHANVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}