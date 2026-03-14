using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5___BT_1___Nhom_7
{
    public partial class Form1 : Form
    {
        public List<string> listDSSo = new List<string>();
        List<string> dsUocSo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool checkSo(string Text)
        {
            if (Text == "")
                return false;
            foreach(string item in listDSSo)
            {
                if(string.Compare(item, Text, true) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(checkSo(txtSo.Text))
            {
                listDSSo.Add(txtSo.Text);
                cboDSSo.Items.Add(txtSo.Text);
                txtSo.Text = "";
                txtSo.Focus();
                cboDSSo.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Số vừa nhập đã tồn tại! hoặc chưa nhập dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDSSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboDSSo.Text)) return;
            dsUocSo = new List<string>();
            int so = int.Parse(cboDSSo.Text);
            for(int i = 1; i <= so; i++)
            {
                if(so % i == 0)
                {
                    dsUocSo.Add(i.ToString());
                }
            }
            lstUocSo.DataSource = dsUocSo;
            lstUocSo.SelectedIndex = 0;
        }

        private void btnTongUoc_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach(string item in dsUocSo)
            {
                sum += int.Parse(item);
            }
            MessageBox.Show("Tổng các ước số là: " + sum, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSoLuongUocChan_Click(object sender, EventArgs e)
        {
            int soLuongUocChan = 0;
            foreach(string item in dsUocSo)
            {
                if(int.Parse(item) % 2 == 0)
                {
                    soLuongUocChan++;
                }
            }
            MessageBox.Show("Số lượng các ước số chẵn là: " + soLuongUocChan, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool LaSoNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnSoLuongUocNT_Click(object sender, EventArgs e)
        {
            if (dsUocSo == null)
            {
                return;
            }
            int soLuongUocNguyenTo = 0;
            foreach(string item in dsUocSo)
            {
                if(LaSoNguyenTo(int.Parse(item)))
                {
                    soLuongUocNguyenTo++;
                }
            }
            MessageBox.Show("Số lượng ước nguyên tố là: " + soLuongUocNguyenTo, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
