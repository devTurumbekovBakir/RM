using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.View
{
    public partial class frmKitchenView : Form
    {
        public frmKitchenView()
        {
            InitializeComponent();
        }

        private void frmKitchenView_Load(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void GetOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            string qry1 = @"Select * from tblMain where status = 'В ожидании' ";
            SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt1);

            FlowLayoutPanel p1;

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Width = 230;
                p1.Height = 350;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10, 10, 10, 10);

                FlowLayoutPanel p2 = new FlowLayoutPanel();

                p2 = new FlowLayoutPanel();
                p2.BackColor = Color.FromArgb(55, 33, 90);
                p2.AutoSize = true;
                p2.Width = 230;
                p2.Height = 125;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.BorderStyle = BorderStyle.FixedSingle;
                p2.Margin = new Padding(0, 0, 0, 0);


                Label lb1 = new Label();
                lb1.ForeColor = Color.White;
                lb1.Margin = new Padding(10, 10, 3, 0);
                lb1.AutoSize = true;


                Label lb2 = new Label();
                lb2.ForeColor = Color.White;
                lb2.Margin = new Padding(10, 5, 3, 0);
                lb2.AutoSize = true;

                Label lb3 = new Label();
                lb3.ForeColor = Color.White;
                lb3.Margin = new Padding(10, 5, 3, 0);
                lb3.AutoSize = true;

                Label lb4 = new Label();
                lb4.ForeColor = Color.White;
                lb4.Margin = new Padding(10, 5, 3, 10);
                lb4.AutoSize = true;


                lb1.Text = "Стол : " + dt1.Rows[i]["TableName"].ToString();
                lb2.Text = "Имя Официанта: " + dt1.Rows[i]["WaiterName"].ToString();
                lb3.Text = "Время заказа : " + dt1.Rows[i]["aTime"].ToString();
                lb4.Text = "Тип заказа : " + dt1.Rows[i]["OrderType"].ToString();

                p2.Controls.Add(lb1);
                p2.Controls.Add(lb2);
                p2.Controls.Add(lb3);
                p2.Controls.Add(lb4);


                p1.Controls.Add(p2);


                int mid = 0;
                mid = Convert.ToInt32(dt1.Rows[i]["MainID"].ToString());

                string qry2 = @"Select * from tblMain m
                             inner join tblDetails d on m.MainID = d.MainID
                             inner join products p on p.pID = d.proID
                                Where m.MainID = @mid";
                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@mid", mid);
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);



                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    FlowLayoutPanel productPanel = new FlowLayoutPanel();
                    productPanel.FlowDirection = FlowDirection.LeftToRight;
                    productPanel.AutoSize = true;
                    productPanel.Margin = new Padding(10, 5, 3, 0);

                    Label lb5 = new Label();
                    lb5.ForeColor = Color.Black;
                    lb5.AutoSize = true;

                    int no = j + 1;

                    lb5.Text = "" + no + " " + dt2.Rows[j]["pName"].ToString() + " " + dt2.Rows[j]["qty"].ToString();

                    productPanel.Controls.Add(lb5);
                    p1.Controls.Add(productPanel);
                }



                Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                b.BaseColor = Color.FromArgb(55, 33, 90);
                b.Size = new Size(130, 35);
                b.OnHoverBaseColor = Color.FromArgb(128, 128, 255);
                b.Margin = new Padding(20, 5, 3, 10);
                b.Text = " Завершить";
                b.Tag = dt1.Rows[i]["MainID"].ToString();

                b.Click += new EventHandler(b_Click);
                p1.Controls.Add(b);

                flowLayoutPanel1.Controls.Add(p1);
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Guna.UI.WinForms.GunaButton).Tag.ToString());

            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            if (guna2MessageDialog1.Show("Вы уверены, что хотите удалить?") == DialogResult.Yes)
            {
                string qry = @"Update tblMain set status = 'Завершенный' where MainID = @ID";
                Hashtable ht = new Hashtable();
                ht.Add("ID", id);

                if (MainClass.SQl(qry, ht) > 0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("Успешно сохранено");
                }
                GetOrders();
            }

        }
    }

}