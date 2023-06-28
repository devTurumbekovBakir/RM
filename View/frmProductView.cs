using RM.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.View
{
    public partial class frmProductView : SampleView
    {
        public frmProductView()
        {
            InitializeComponent();
        }

        private void frmProductView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string qry = "select pID,pName,pPrice,CategoryID,c.catName from products p inner join category c on c.catID = p.CategoryID where pName like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvcatID);
            lb.Items.Add(dgvcat);

            MainClass.LoadData(qry, gunaDataGridView1, lb);
        }


        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new Model.frmProductAdd());
            // frmCategoryAdd frm = new frmCategoryAdd();
            // frm.ShowDialog();
            GetData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                //это изменение, так как мы должны установить свойства текста перед открытием
                frmProductAdd frm = new frmProductAdd();
                frm.id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.cID = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvcatID"].Value);
                
                MainClass.BlurBackground(frm);
                GetData();

            }
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {

                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (guna2MessageDialog1.Show("Вы уверены, что хотите удалить?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from products where pID= " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);

                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    MessageBox.Show("Успешно удален");
                    GetData();
                }


            }
        }
    }
}
