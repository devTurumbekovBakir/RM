using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RM.Model
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {

            InitializeComponent();
        }

        public int MainID = 0;
        public string OrderType ="";
        public int driverID = 0;
        public string customerName = "";
        public string customerPhone = "";

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            gunaDataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();

            ProductPanel.Controls.Clear();
            LoadProducts();
        }

        private void AddCategory()
        {
            string qry = "Select * from Category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CategoryPanel.Controls.Clear();


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton
                    {
                        Font = new Font("Segoe UI", 10.2f),
                        BaseColor = Color.FromArgb(55, 33, 90),
                        Size = new Size(219, 42),
                        OnHoverBaseColor = Color.FromArgb(128, 128, 255),
                        Text = row["catName"].ToString()
                    };

                    //Событие для клика
                    b.Click += new EventHandler(b_Click);

                    CategoryPanel.Controls.Add(b);
                }


            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaButton b = (Guna.UI.WinForms.GunaButton)sender;
            if (b.Text == "All Categories")
            {
                txtSearch.Text = "1";
                txtSearch.Text = "";
                return;
            }


            foreach (var item in ProductPanel.Controls)
            {
                var pro = (usProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }


        private void AddItems(string id, String proID, string name, string cat, string price, Image pimage)
        {
            var w = new usProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(proID)
            };

            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (usProduct)ss;

                foreach (DataGridViewRow item in gunaDataGridView1.Rows)
                {
                    //это проверит, что продукт уже есть, а затем один для количества и обновления цены
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                           double.Parse(item.Cells["dgvPrice"].Value.ToString());

                        GetTotal(); // вызов GetTotal() здесь
                        return;
                    }


                }
                //эта строка добавить новый продукт
                // эта строка добавить новый продукт
                gunaDataGridView1.Rows.Add(new object[] { 0, 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });

                GetTotal();
            };


        }

        private void LoadProducts()
        {
            string qry = "Select * from products inner join category on catID = CategoryID ";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["pImage"];
                byte[] immagebytearray = imagearray;

                AddItems("0", item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(),
                    item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagearray)));

            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (usProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(txtSearch.Text.Trim().ToLower());

            }


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

        private void GetTotal()
        {
            double tot = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in gunaDataGridView1.Rows)
            {
                tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }

            lblTotal.Text = tot.ToString("N2");
        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            gunaDataGridView1.Rows.Clear();
            MainID = 0;
            lblTotal.Text = "00";
        }

        private bool isDeliveryChecked = false; // Инициализируем переменную

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            // Переключаем состояние кнопки
            isDeliveryChecked = !isDeliveryChecked;

            // Сбрасываем состояние других кнопок
            isTakeChecked = false;
            isDinChecked = false;

            // Ваши действия
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Доставка";

            // Здесь вы меняете цвет кнопок в зависимости от их состояния
            btnDelivery.BaseColor = isDeliveryChecked ? Color.FromArgb(128, 128, 255) : Color.FromArgb(83, 183, 128);
            btnTake.BaseColor = Color.FromArgb(83, 183, 128); // Возвращаем изначальный цвет
            btnDin.BaseColor = Color.FromArgb(83, 183, 128);  // Возвращаем изначальный цвет

            frmAddCustomer frm = new frmAddCustomer();
            frm.mainID = MainID;
            frm.orderType = OrderType;
            MainClass.BlurBackground(frm);

            if (frm.txtName.Text != "") // так как на вынос не было информации о водителе
            {
                driverID = frm.driverID;
                lblDriverName.Text = "Имя Клиента: " + frm.txtName.Text + "  Телефон: " + frm.txtPhone.Text + "  Водитель: " + frm.cbDriver.Text;
                lblDriverName.Visible = true;
                customerName = frm.txtName.Text;
                customerPhone = frm.txtPhone.Text;
            }
        }


        private bool isTakeChecked = false; // Добавляем новую переменную для отслеживания состояния кнопки btnTake

        private void btnTake_Click(object sender, EventArgs e)
        {
            // Делаем аналогичные действия для этой кнопки
            isTakeChecked = !isTakeChecked;

            isDeliveryChecked = false;
            isDinChecked = false;

            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Вынос";

            btnTake.BaseColor = isTakeChecked ? Color.FromArgb(128, 128, 255) : Color.FromArgb(83, 183, 128);
            btnDelivery.BaseColor = Color.FromArgb(83, 183, 128);
            btnDin.BaseColor = Color.FromArgb(83, 183, 128);

            frmAddCustomer frm = new frmAddCustomer();
            frm.mainID = MainID;
            frm.orderType = OrderType;
            MainClass.BlurBackground(frm);

            if (frm.txtName.Text != "") // так как на вынос не было информации о водителе
            {
                driverID = frm.driverID;
                lblDriverName.Text = "Имя Клиента: " + frm.txtName.Text + "Телефон: " + frm.txtPhone.Text;
                lblDriverName.Visible = true;
                customerName = frm.txtName.Text;
                customerPhone = frm.txtPhone.Text;
            }
        }


        private bool isDinChecked = false; // Добавляем новую переменную для отслеживания состояния кнопки btnDin

        private void btnDin_Click(object sender, EventArgs e)
        {
            // Делаем аналогичные действия для этой кнопки
            isDinChecked = !isDinChecked;

            isDeliveryChecked = false;
            isTakeChecked = false;

            OrderType = "Онлайн";
            lblDriverName.Visible = false;

            frmTableSelect frm = new frmTableSelect();
            MainClass.BlurBackground(frm);
            if (frm.TableName != "")
            {
                lblTable.Text = frm.TableName;
                lblTable.Visible = true;
            }
            else
            {
                lblTable.Text = "";
                lblTable.Visible = false;
            }

            frmWaiterSelect frm2 = new frmWaiterSelect();
            MainClass.BlurBackground(frm2);
            if (frm2.waiterName != "")
            {
                lblWaiter.Text = frm2.waiterName;
                lblWaiter.Visible = true;
            }
            else
            {
                lblWaiter.Text = "";
                lblWaiter.Visible = false;
            }

            btnDin.BaseColor = isDinChecked ? Color.FromArgb(128, 128, 255) : Color.FromArgb(83, 183, 128);
            btnDelivery.BaseColor = Color.FromArgb(83, 183, 128);
            btnTake.BaseColor = Color.FromArgb(83, 183, 128);
        }


        private void btnKot_Click(object sender, EventArgs e)
        {
            //сохранить данные в базе данных
            //создать столы
            //нужно добавить файл в таблицу для хранения дополнительной информации

            string qry1 = ""; // Main table
            string qry2 = ""; // Details table


            int detailID = 0;
            if (OrderType == "")
            {
                guna2MessageDialog1.Show("Пожалуйста, выберите тип заказа");
                return;
            }


            if (MainID == 0) // вставить
            {
                qry1 = @"Insert into tblMain Values (@aDate, @aTime, @TableName, @WaiterName,
                            @status, @OrderType, @total, @received, @change, @driverID, @CustName, @CustPhone);
                                Select SCOPE_IDENTITY()";
                //эта строка удалит отправленное значение редактирования
            }
            else //обновлять
            {
                qry1 = @"Update tblMain Set status = @status, total = @total, received = @received, change = @change where MainID = @ID ";
            }


            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "В ожидании");
            cmd.Parameters.AddWithValue("@OrderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text)); //поскольку мы сохраняем только данные о стоимости кухни, они будут обновляться при получении платежа.
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@CustName", customerName);
            cmd.Parameters.AddWithValue("@CustPhone", customerPhone);


            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

              

                if (detailID == 0)
                {
                    qry2 = @"Insert into tblDetails (MainID, proID, qty, price, amount) Values (@MainID, @proID, @qty, @price, @amount)";
                }
                else
                {
                    qry2 = @"Update tblDetails Set proID = @proID, qty = @qty, price = @price, amount = @amount where DetailID = @ID";
                }


                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

               


                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd2.ExecuteNonQuery();
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

               
            }
            guna2MessageDialog1.Show("Успешно сохранено");
            MainID = 0;
            detailID = 0;
            gunaDataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblTable.Visible = false;
            lblTotal.Text = "00";
            lblDriverName.Text = "";
        }
        public int id = 0;
        private void btnBill_Click(object sender, EventArgs e)
        {
            frmBillList frm = new frmBillList();
            MainClass.BlurBackground(frm);

            if (frm.MainID >0)
            {
                id = frm.MainID;
                MainID = frm.MainID;
                LoadEntries();
            }

        }
      
        private void LoadEntries()
        {
            string qry = @"Select * from tblMain m
                             inner join tblDetails d on m.MainID = d.MainID
                             inner join products p on p.pID = d.proID
                                Where m.MainID = @id";
            SqlCommand cmd2 = new SqlCommand(qry, MainClass.con);
            cmd2.Parameters.AddWithValue("@id", id);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            if (dt2.Rows[0]["OrderType"].ToString() == "Доставка")
            {
                btnDelivery.OnHoverBaseColor = Color.FromArgb(128, 128, 255);
                lblWaiter.Visible = false;
                lblTable.Visible = false;
            }
            else if (dt2.Rows[0]["OrderType"].ToString() == "Вынос")
            {
                btnTake.OnHoverBaseColor = Color.FromArgb(128, 128, 255);
                lblWaiter.Visible = false;
                lblTable.Visible = false;
            }
            else
            {
                btnDin.OnHoverBaseColor = Color.FromArgb(128, 128, 255);
                lblWaiter.Visible = true;
                lblTable.Visible = true;
            }

            gunaDataGridView1.Rows.Clear();

            foreach (DataRow item in dt2.Rows)
            {
                lblTable.Text = item["TableName"].ToString();
                lblWaiter.Text = item["WaiterName"].ToString();


                string detailid = item["DetailID"].ToString();
                string proName = item["pName"].ToString();
                string proid = item["proID"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();


                object[] obj = {0,detailid , proid,proName,qty,price,amount };
                gunaDataGridView1.Rows.Add(obj);
            }
            GetTotal();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            frmCheckout frm = new frmCheckout();
            frm.MainID = id;
            frm.amt = Convert.ToDouble(lblTotal.Text);
            MainClass.BlurBackground(frm);

            MainID = 0;
            gunaDataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblTable.Visible = false;
            lblTotal.Text = "00";
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            string qry1 = ""; // Main table
            string qry2 = ""; // Details table


            int detailID = 0;

            if (OrderType == "")
            {
                guna2MessageDialog1.Show("Пожалуйста, выберите тип заказа");
                return;
            }

            if (MainID == 0) // вставить
            {
                qry1 = @"Insert into tblMain Values (@aDate, @aTime, @TableName, @WaiterName,
                            @status, @OrderType, @total, @received, @change, @driverID, @CustName, @CustPhone);
                                Select SCOPE_IDENTITY()";
                //эта строка удалит отправленное значение редактирования
            }
            else //обновлять
            {
                qry1 = @"Update tblMain Set status = @status, total = @total, received = @received, change = @change where MainID = @ID ";
            }


            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Удержание");
            cmd.Parameters.AddWithValue("@OrderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text)); //поскольку мы сохраняем только данные о стоимости кухни, они будут обновляться при получении платежа.
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@CustName", customerName);
            cmd.Parameters.AddWithValue("@CustPhone", customerPhone);



            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);



                if (detailID == 0)
                {
                    qry2 = @"Insert into tblDetails (MainID, proID, qty, price, amount) Values (@MainID, @proID, @qty, @price, @amount)";
                }
                else
                {
                    qry2 = @"Update tblDetails Set proID = @proID, qty = @qty, price = @price, amount = @amount where DetailID = @ID";
                }


                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));




                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd2.ExecuteNonQuery();
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }


            }
            guna2MessageDialog1.Show("Успешно сохранено");
            MainID = 0;
            detailID = 0;
            gunaDataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblTable.Visible = false;
            lblTotal.Text = "00";
            lblDriverName.Text = "";
        }

    }
}