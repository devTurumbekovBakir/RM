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

namespace RM.Model
{
    public partial class frmWaiterSelect : Form
    {
        public frmWaiterSelect()
        {
            InitializeComponent();
        }

        public string waiterName;

        private void frmWaiterSelect_Load(object sender, EventArgs e)
        {
            string qry = "Select * from staff where sRole Like 'Официант'";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                b.Text = row["sName"].ToString();
                b.Width = 150;
                b.Height = 50;
                b.BaseColor = Color.FromArgb(83, 183, 128);
                b.OnHoverBaseColor = Color.FromArgb(128, 128, 255);

                //Событие для клика
                b.Click += new EventHandler(b_Click);

                flowLayoutPanel1.Controls.Add(b);

            }
        }
        private void b_Click(object sender, EventArgs e)
        {
            waiterName = (sender as Guna.UI.WinForms.GunaButton).Text.ToString();
            this.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
