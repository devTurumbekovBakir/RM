namespace RM.Model
{
    partial class frmPOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnDin = new Guna.UI.WinForms.GunaTileButton();
            this.btnTake = new Guna.UI.WinForms.GunaTileButton();
            this.btnDelivery = new Guna.UI.WinForms.GunaTileButton();
            this.btnKot = new Guna.UI.WinForms.GunaTileButton();
            this.btnBill = new Guna.UI.WinForms.GunaTileButton();
            this.btnHold = new Guna.UI.WinForms.GunaTileButton();
            this.btnNew = new Guna.UI.WinForms.GunaTileButton();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.btnCheckout = new Guna.UI.WinForms.GunaButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvproID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdel = new System.Windows.Forms.DataGridViewImageColumn();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(90)))));
            this.gunaPanel1.Controls.Add(this.btnDin);
            this.gunaPanel1.Controls.Add(this.btnTake);
            this.gunaPanel1.Controls.Add(this.btnDelivery);
            this.gunaPanel1.Controls.Add(this.btnKot);
            this.gunaPanel1.Controls.Add(this.btnBill);
            this.gunaPanel1.Controls.Add(this.btnHold);
            this.gunaPanel1.Controls.Add(this.btnNew);
            this.gunaPanel1.Controls.Add(this.lblWaiter);
            this.gunaPanel1.Controls.Add(this.lblTable);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Controls.Add(this.btnExit);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1352, 115);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btnDin
            // 
            this.btnDin.Animated = true;
            this.btnDin.AnimationHoverSpeed = 0.07F;
            this.btnDin.AnimationSpeed = 0.03F;
            this.btnDin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnDin.BorderColor = System.Drawing.Color.Black;
            this.btnDin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDin.FocusedColor = System.Drawing.Color.Empty;
            this.btnDin.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnDin.ForeColor = System.Drawing.Color.White;
            this.btnDin.Image = ((System.Drawing.Image)(resources.GetObject("btnDin.Image")));
            this.btnDin.ImageSize = new System.Drawing.Size(52, 52);
            this.btnDin.Location = new System.Drawing.Point(823, 21);
            this.btnDin.Name = "btnDin";
            this.btnDin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDin.OnHoverImage = null;
            this.btnDin.OnPressedColor = System.Drawing.Color.Black;
            this.btnDin.Size = new System.Drawing.Size(87, 79);
            this.btnDin.TabIndex = 2;
            this.btnDin.Text = "Онлайн";
            this.btnDin.Click += new System.EventHandler(this.btnDin_Click);
            // 
            // btnTake
            // 
            this.btnTake.Animated = true;
            this.btnTake.AnimationHoverSpeed = 0.07F;
            this.btnTake.AnimationSpeed = 0.03F;
            this.btnTake.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnTake.BorderColor = System.Drawing.Color.Black;
            this.btnTake.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTake.FocusedColor = System.Drawing.Color.Empty;
            this.btnTake.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnTake.ForeColor = System.Drawing.Color.White;
            this.btnTake.Image = global::RM.Properties.Resources.доставка_нов;
            this.btnTake.ImageSize = new System.Drawing.Size(52, 52);
            this.btnTake.Location = new System.Drawing.Point(730, 21);
            this.btnTake.Name = "btnTake";
            this.btnTake.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTake.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTake.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTake.OnHoverImage = null;
            this.btnTake.OnPressedColor = System.Drawing.Color.Black;
            this.btnTake.Size = new System.Drawing.Size(87, 79);
            this.btnTake.TabIndex = 2;
            this.btnTake.Text = "Вынос";
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Animated = true;
            this.btnDelivery.AnimationHoverSpeed = 0.07F;
            this.btnDelivery.AnimationSpeed = 0.03F;
            this.btnDelivery.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnDelivery.BorderColor = System.Drawing.Color.Black;
            this.btnDelivery.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelivery.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelivery.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Image = global::RM.Properties.Resources.доставка;
            this.btnDelivery.ImageSize = new System.Drawing.Size(52, 52);
            this.btnDelivery.Location = new System.Drawing.Point(637, 21);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelivery.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelivery.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelivery.OnHoverImage = null;
            this.btnDelivery.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelivery.Size = new System.Drawing.Size(87, 79);
            this.btnDelivery.TabIndex = 2;
            this.btnDelivery.Text = "Доставка";
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnKot
            // 
            this.btnKot.Animated = true;
            this.btnKot.AnimationHoverSpeed = 0.07F;
            this.btnKot.AnimationSpeed = 0.03F;
            this.btnKot.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnKot.BorderColor = System.Drawing.Color.Black;
            this.btnKot.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnKot.FocusedColor = System.Drawing.Color.Empty;
            this.btnKot.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnKot.ForeColor = System.Drawing.Color.White;
            this.btnKot.Image = global::RM.Properties.Resources.заказ;
            this.btnKot.ImageSize = new System.Drawing.Size(52, 52);
            this.btnKot.Location = new System.Drawing.Point(544, 21);
            this.btnKot.Name = "btnKot";
            this.btnKot.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnKot.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKot.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKot.OnHoverImage = null;
            this.btnKot.OnPressedColor = System.Drawing.Color.Black;
            this.btnKot.Size = new System.Drawing.Size(87, 79);
            this.btnKot.TabIndex = 2;
            this.btnKot.Text = "Заказ";
            this.btnKot.Click += new System.EventHandler(this.btnKot_Click);
            // 
            // btnBill
            // 
            this.btnBill.Animated = true;
            this.btnBill.AnimationHoverSpeed = 0.07F;
            this.btnBill.AnimationSpeed = 0.03F;
            this.btnBill.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnBill.BorderColor = System.Drawing.Color.Black;
            this.btnBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBill.FocusedColor = System.Drawing.Color.Empty;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = global::RM.Properties.Resources.счета;
            this.btnBill.ImageSize = new System.Drawing.Size(52, 52);
            this.btnBill.Location = new System.Drawing.Point(450, 21);
            this.btnBill.Name = "btnBill";
            this.btnBill.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBill.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBill.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBill.OnHoverImage = null;
            this.btnBill.OnPressedColor = System.Drawing.Color.Black;
            this.btnBill.Size = new System.Drawing.Size(87, 79);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "Счет";
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnHold
            // 
            this.btnHold.Animated = true;
            this.btnHold.AnimationHoverSpeed = 0.07F;
            this.btnHold.AnimationSpeed = 0.03F;
            this.btnHold.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnHold.BorderColor = System.Drawing.Color.Black;
            this.btnHold.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHold.FocusedColor = System.Drawing.Color.Empty;
            this.btnHold.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnHold.ForeColor = System.Drawing.Color.White;
            this.btnHold.Image = global::RM.Properties.Resources.рука_нов;
            this.btnHold.ImageSize = new System.Drawing.Size(52, 52);
            this.btnHold.Location = new System.Drawing.Point(358, 21);
            this.btnHold.Name = "btnHold";
            this.btnHold.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHold.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHold.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHold.OnHoverImage = null;
            this.btnHold.OnPressedColor = System.Drawing.Color.Black;
            this.btnHold.Size = new System.Drawing.Size(87, 79);
            this.btnHold.TabIndex = 2;
            this.btnHold.Text = "Задержать";
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnNew
            // 
            this.btnNew.Animated = true;
            this.btnNew.AnimationHoverSpeed = 0.07F;
            this.btnNew.AnimationSpeed = 0.03F;
            this.btnNew.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnNew.BorderColor = System.Drawing.Color.Black;
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNew.FocusedColor = System.Drawing.Color.Empty;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = global::RM.Properties.Resources.добавить_нов;
            this.btnNew.ImageSize = new System.Drawing.Size(52, 52);
            this.btnNew.Location = new System.Drawing.Point(265, 21);
            this.btnNew.Name = "btnNew";
            this.btnNew.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNew.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNew.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNew.OnHoverImage = null;
            this.btnNew.OnPressedColor = System.Drawing.Color.Black;
            this.btnNew.Size = new System.Drawing.Size(87, 79);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Новый";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblWaiter
            // 
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWaiter.ForeColor = System.Drawing.Color.White;
            this.lblWaiter.Location = new System.Drawing.Point(916, 65);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(133, 35);
            this.lblWaiter.TabIndex = 1;
            this.lblWaiter.Text = "Официант";
            this.lblWaiter.Visible = false;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTable.ForeColor = System.Drawing.Color.White;
            this.lblTable.Location = new System.Drawing.Point(916, 30);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(68, 35);
            this.lblTable.TabIndex = 1;
            this.lblTable.Text = "Стол";
            this.lblTable.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "POS";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BaseColor = System.Drawing.Color.White;
            this.btnExit.Image = global::RM.Properties.Resources.выкл;
            this.btnExit.Location = new System.Drawing.Point(1280, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 62);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::RM.Properties.Resources.менеджмент;
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 21);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(87, 79);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(90)))));
            this.gunaPanel2.Controls.Add(this.btnCheckout);
            this.gunaPanel2.Controls.Add(this.lblTotal);
            this.gunaPanel2.Controls.Add(this.label2);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 726);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1352, 93);
            this.gunaPanel2.TabIndex = 0;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.AnimationHoverSpeed = 0.07F;
            this.btnCheckout.AnimationSpeed = 0.03F;
            this.btnCheckout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(183)))), ((int)(((byte)(128)))));
            this.btnCheckout.BorderColor = System.Drawing.Color.Black;
            this.btnCheckout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCheckout.FocusedColor = System.Drawing.Color.Empty;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckout.Image")));
            this.btnCheckout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCheckout.Location = new System.Drawing.Point(922, 22);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCheckout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCheckout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCheckout.OnHoverImage = null;
            this.btnCheckout.OnPressedColor = System.Drawing.Color.Black;
            this.btnCheckout.Size = new System.Drawing.Size(139, 46);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "ОПЛАТИТЬ";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(1234, 33);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 35);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0.00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1086, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Общий счет";
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryPanel.Location = new System.Drawing.Point(12, 178);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(180, 542);
            this.CategoryPanel.TabIndex = 1;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPanel.AutoScroll = true;
            this.ProductPanel.Location = new System.Drawing.Point(198, 178);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(646, 542);
            this.ProductPanel.TabIndex = 1;
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToAddRows = false;
            this.gunaDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 40;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvproID,
            this.dgvName,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount,
            this.dgvdel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.White;
            this.gunaDataGridView1.Location = new System.Drawing.Point(850, 178);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(490, 542);
            this.gunaDataGridView1.TabIndex = 7;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = true;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
         
            this.gunaDataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gunaDataGridView1_CellFormatting);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSearch.Location = new System.Drawing.Point(23, 125);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(310, 41);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Tag = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "RMS";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog1.Text = null;
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDriverName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDriverName.Location = new System.Drawing.Point(522, 131);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(68, 35);
            this.lblDriverName.TabIndex = 1;
            this.lblDriverName.Text = "Стол";
            this.lblDriverName.Visible = false;
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 70;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "id";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgvproID
            // 
            this.dgvproID.HeaderText = "ProductID";
            this.dgvproID.MinimumWidth = 6;
            this.dgvproID.Name = "dgvproID";
            this.dgvproID.ReadOnly = true;
            this.dgvproID.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.HeaderText = "Имя";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvQty.FillWeight = 30F;
            this.dgvQty.HeaderText = "Кол-во";
            this.dgvQty.MinimumWidth = 30;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 65;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrice.FillWeight = 30F;
            this.dgvPrice.HeaderText = "Цена";
            this.dgvPrice.MinimumWidth = 30;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 63;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvAmount.FillWeight = 30F;
            this.dgvAmount.HeaderText = "Сумма";
            this.dgvAmount.MinimumWidth = 50;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            this.dgvAmount.Width = 60;
            // 
            // dgvdel
            // 
            this.dgvdel.FillWeight = 30F;
            this.dgvdel.HeaderText = "";
            this.dgvdel.Image = global::RM.Properties.Resources.карзина1;
            this.dgvdel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvdel.MinimumWidth = 30;
            this.dgvdel.Name = "dgvdel";
            this.dgvdel.ReadOnly = true;
            // 
            // frmPOS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1352, 819);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.lblDriverName);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmPOS";
            this.Text = "frmPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaTileButton btnNew;
        private Guna.UI.WinForms.GunaTileButton btnDin;
        private Guna.UI.WinForms.GunaTileButton btnTake;
        private Guna.UI.WinForms.GunaTileButton btnDelivery;
        private Guna.UI.WinForms.GunaTileButton btnKot;
        private Guna.UI.WinForms.GunaTileButton btnBill;
        private Guna.UI.WinForms.GunaTileButton btnHold;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.Label lblTable;
        private Guna.UI.WinForms.GunaPictureBox btnExit;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        public Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        public Guna.UI.WinForms.GunaButton btnCheckout;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvproID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private System.Windows.Forms.DataGridViewImageColumn dgvdel;
    }
}