using RM.Reports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Model
{
    public partial class frmBillList : SampleAdd
    {
        public frmBillList()
        {
            InitializeComponent();
        }
        public int MainID = 0;
        private void frmBillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
       

        private void LoadData()
        {
            string qry = @"select MainID, TableName, WaiterName, OrderType, status, total from tblMain
                            where status <> 'В ожидании' ";

            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);


            MainClass.LoadData(qry, gunaDataGridView1, lb);
        }

        private void gunaDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.CurrentCell != null && gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                //это изменение, так как мы должны установить свойства текста перед открытием

                MainID = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                this.Close();
                

            }

            if (gunaDataGridView1.CurrentCell != null && gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                // распечатать счет
                MainID = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = @"Select * from tblMain m inner join 
                                 tblDetails d on d.MainID = m.MainID 
                                   inner join products p on p.PID = d.ProID
                                    where m.MainID = @MainID ";

                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                cmd.Parameters.AddWithValue("@Mainid", MainID);
                MainClass.con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                MainClass.con.Close();
                frmPrint frm = new frmPrint();
                rptBill cr = new rptBill();

                cr.SetDataSource(dt);
                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.Refresh();
                frm.Show();

            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
