using DevExpress.XtraEditors;
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

namespace CHUNGKHOANG
{
    public partial class THONGTIN : DevExpress.XtraEditors.XtraForm
    {
        private bool isRequest = false;
        internal static readonly string _datasource = "LAPTOP";
        internal static readonly string _username = "sa";
        internal static readonly string _password = "sa";
        internal static readonly string _database = "CHUNGKHOAN";
        public string m_connect = "server =" + "LAPTOP" + "; uid= " + "sa" + "; pwd= " + "sa" + "; database = " + "CHUNGKHOAN";
        SqlConnection con = null;
        public delegate void NewHome();
        public event NewHome OnNewHome;
        public THONGTIN()
        {
            InitializeComponent();
            try
            {
                SqlClientPermission ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                ss.Demand();
            }
            catch (Exception)
            {

                throw;
            }
            SqlDependency.Start(m_connect);
            con = new SqlConnection(m_connect);
        }

        private void THONGTIN_Load(object sender, EventArgs e)
        {
            OnNewHome += Form1_OnNewHome;
            LoadData();
        }
        public void Form1_OnNewHome()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)//tab
            {
                NewHome dd = Form1_OnNewHome;
                i.BeginInvoke(dd, null);
                return;
            }
            LoadData();

        }

        void LoadData()
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT MACOPHIEU, GIAMUA3, KLMUA3, GIAMUA2, KLMUA2, GIAMUA1, KLMUA1, GIAKHOP, KL," +
                " GIABAN1, KLBAN1, GIABAN2, KLBAN2, GIABAN3, KLBAN3 FROM dbo.THONGTIN", con);
            cmd.Notification = null;

            SqlDependency de = new SqlDependency(cmd);
            de.OnChange += de_OnChange;

            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            dataGridView1.DataSource = dt;
        }
        public void de_OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency de = sender as SqlDependency;
            de.OnChange -= de_OnChange;
            OnNewHome?.Invoke();
        }

        private void THONGTIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlDependency.Stop(m_connect);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtNhanLenh.Enabled = true;
            }
            else
            {
                txtNhanLenh.Enabled = false;
            }
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
        {
            string macp, loaigd, lenh;
            float giadat;
            int soluong;

            macp = txtMaCK.Text;
            if (cbbMuaBan.Text.Equals("Mua"))
            {
                loaigd = "M";
            }
            else
            {
                loaigd = "B";
            }
            soluong = Convert.ToInt32(txtKhoiLuong.Text.Replace(",", ""));
            giadat = float.Parse(txtGia.Text.Replace(",", "").Replace("$", ""));
            lenh = cbbLenh.Text;

            int i = -1;
            string[] paras = new string[5] { "@MACOPHIEU", "@LOAIGD", "@LOAILENH", "@SOLUONG", "@GIADAT" };
            object[] values = new object[5] { macp, loaigd, lenh, soluong, giadat };
            i = Connection.RequestStatus("dbo.sp_DATLENH", CommandType.StoredProcedure, paras, values);
            if (i == 0)
            {
                MessageBox.Show("Đặt lệnh thành công!");
            }
            else
            {
                MessageBox.Show("Đặt lệnh thái bại!");
            }
        });
        }
    }
}