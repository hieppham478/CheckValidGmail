namespace ChecklivedieFULL
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_status = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nhậpMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.từClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.từFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.từCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.từFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaListMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.soluongtoida = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tongproxy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tongloi = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tongdie = new System.Windows.Forms.Label();
            this.tientrinh2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tonglive = new System.Windows.Forms.Label();
            this.tongmailcheck = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chaytumailso = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tatbangdencheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loaiproxy = new System.Windows.Forms.ComboBox();
            this.dungproxycheck = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soluongtoida)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chaytumailso)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_status.ContextMenuStrip = this.contextMenuStrip1;
            this.txt_status.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.ForeColor = System.Drawing.Color.White;
            this.txt_status.Location = new System.Drawing.Point(7, 31);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(455, 274);
            this.txt_status.TabIndex = 330;
            this.txt_status.Text = "";
            this.txt_status.TextChanged += new System.EventHandler(this.txt_status_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpMailToolStripMenuItem,
            this.thêmProxyToolStripMenuItem,
            this.xóaListMailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 70);
            // 
            // nhậpMailToolStripMenuItem
            // 
            this.nhậpMailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.từClipboardToolStripMenuItem,
            this.từFileToolStripMenuItem});
            this.nhậpMailToolStripMenuItem.Image = global::ChecklivedieFULL.Properties.Resources.daulau;
            this.nhậpMailToolStripMenuItem.Name = "nhậpMailToolStripMenuItem";
            this.nhậpMailToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.nhậpMailToolStripMenuItem.Text = "Nhập mail";
            // 
            // từClipboardToolStripMenuItem
            // 
            this.từClipboardToolStripMenuItem.Image = global::ChecklivedieFULL.Properties.Resources.copy_paste_document_file_1557;
            this.từClipboardToolStripMenuItem.Name = "từClipboardToolStripMenuItem";
            this.từClipboardToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.từClipboardToolStripMenuItem.Text = "Từ Clipboard";
            this.từClipboardToolStripMenuItem.Click += new System.EventHandler(this.từClipboardToolStripMenuItem_Click);
            // 
            // từFileToolStripMenuItem
            // 
            this.từFileToolStripMenuItem.Image = global::ChecklivedieFULL.Properties.Resources._32officeicons_21_89726;
            this.từFileToolStripMenuItem.Name = "từFileToolStripMenuItem";
            this.từFileToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.từFileToolStripMenuItem.Text = "Từ File";
            this.từFileToolStripMenuItem.Click += new System.EventHandler(this.từFileToolStripMenuItem_Click);
            // 
            // thêmProxyToolStripMenuItem
            // 
            this.thêmProxyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.từCopyToolStripMenuItem,
            this.từFileToolStripMenuItem1});
            this.thêmProxyToolStripMenuItem.Image = global::ChecklivedieFULL.Properties.Resources.daulau;
            this.thêmProxyToolStripMenuItem.Name = "thêmProxyToolStripMenuItem";
            this.thêmProxyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.thêmProxyToolStripMenuItem.Text = "Thêm Proxy";
            // 
            // từCopyToolStripMenuItem
            // 
            this.từCopyToolStripMenuItem.Image = global::ChecklivedieFULL.Properties.Resources.copy_paste_document_file_1557;
            this.từCopyToolStripMenuItem.Name = "từCopyToolStripMenuItem";
            this.từCopyToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.từCopyToolStripMenuItem.Text = "Từ Copy";
            this.từCopyToolStripMenuItem.Click += new System.EventHandler(this.từCopyToolStripMenuItem_Click);
            // 
            // từFileToolStripMenuItem1
            // 
            this.từFileToolStripMenuItem1.Image = global::ChecklivedieFULL.Properties.Resources._32officeicons_21_89726;
            this.từFileToolStripMenuItem1.Name = "từFileToolStripMenuItem1";
            this.từFileToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.từFileToolStripMenuItem1.Text = "Từ File";
            this.từFileToolStripMenuItem1.Click += new System.EventHandler(this.từFileToolStripMenuItem1_Click);
            // 
            // xóaListMailToolStripMenuItem
            // 
            this.xóaListMailToolStripMenuItem.Image = global::ChecklivedieFULL.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.xóaListMailToolStripMenuItem.Name = "xóaListMailToolStripMenuItem";
            this.xóaListMailToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.xóaListMailToolStripMenuItem.Text = "Xóa list mail";
            this.xóaListMailToolStripMenuItem.Click += new System.EventHandler(this.xóaListMailToolStripMenuItem_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_start.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_start.Location = new System.Drawing.Point(246, 459);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(105, 29);
            this.btn_start.TabIndex = 331;
            this.btn_start.Text = "RUN";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_stop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_stop.Location = new System.Drawing.Point(351, 459);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(105, 29);
            this.btn_stop.TabIndex = 332;
            this.btn_stop.Text = " STOP";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 342;
            this.label2.Text = "Chạy từ mail số:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 340;
            this.label1.Text = "Số luồng:";
            // 
            // soluongtoida
            // 
            this.soluongtoida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluongtoida.Location = new System.Drawing.Point(123, 103);
            this.soluongtoida.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.soluongtoida.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.soluongtoida.Name = "soluongtoida";
            this.soluongtoida.Size = new System.Drawing.Size(73, 22);
            this.soluongtoida.TabIndex = 340;
            this.soluongtoida.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.tongproxy);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.tongloi);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.tongdie);
            this.groupBox5.Controls.Add(this.tientrinh2);
            this.groupBox5.Controls.Add(this.linkLabel2);
            this.groupBox5.Controls.Add(this.tonglive);
            this.groupBox5.Controls.Add(this.tongmailcheck);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(7, 311);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(227, 190);
            this.groupBox5.TabIndex = 336;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "STATUS";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // tongproxy
            // 
            this.tongproxy.AutoSize = true;
            this.tongproxy.Location = new System.Drawing.Point(95, 48);
            this.tongproxy.Name = "tongproxy";
            this.tongproxy.Size = new System.Drawing.Size(14, 16);
            this.tongproxy.TabIndex = 352;
            this.tongproxy.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 351;
            this.label7.Text = "Total Proxy:";
            // 
            // tongloi
            // 
            this.tongloi.AutoSize = true;
            this.tongloi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(86)))));
            this.tongloi.Location = new System.Drawing.Point(56, 135);
            this.tongloi.Name = "tongloi";
            this.tongloi.Size = new System.Drawing.Size(14, 16);
            this.tongloi.TabIndex = 11;
            this.tongloi.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(86)))));
            this.label25.Location = new System.Drawing.Point(11, 135);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 16);
            this.label25.TabIndex = 10;
            this.label25.Text = "Error:";
            // 
            // tongdie
            // 
            this.tongdie.AutoSize = true;
            this.tongdie.ForeColor = System.Drawing.Color.GreenYellow;
            this.tongdie.Location = new System.Drawing.Point(85, 75);
            this.tongdie.Name = "tongdie";
            this.tongdie.Size = new System.Drawing.Size(14, 16);
            this.tongdie.TabIndex = 7;
            this.tongdie.Text = "0";
            // 
            // tientrinh2
            // 
            this.tientrinh2.AutoSize = true;
            this.tientrinh2.Location = new System.Drawing.Point(75, 165);
            this.tientrinh2.Name = "tientrinh2";
            this.tientrinh2.Size = new System.Drawing.Size(14, 16);
            this.tientrinh2.TabIndex = 6;
            this.tientrinh2.Text = "0";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.LavenderBlush;
            this.linkLabel2.Location = new System.Drawing.Point(169, 167);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(52, 14);
            this.linkLabel2.TabIndex = 350;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Output";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // tonglive
            // 
            this.tonglive.AutoSize = true;
            this.tonglive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(46)))));
            this.tonglive.Location = new System.Drawing.Point(89, 105);
            this.tonglive.Name = "tonglive";
            this.tonglive.Size = new System.Drawing.Size(14, 16);
            this.tonglive.TabIndex = 5;
            this.tonglive.Text = "0";
            // 
            // tongmailcheck
            // 
            this.tongmailcheck.AutoSize = true;
            this.tongmailcheck.Location = new System.Drawing.Point(95, 22);
            this.tongmailcheck.Name = "tongmailcheck";
            this.tongmailcheck.Size = new System.Drawing.Size(14, 16);
            this.tongmailcheck.TabIndex = 4;
            this.tongmailcheck.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 165);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 16);
            this.label19.TabIndex = 3;
            this.label19.Text = "Đã chạy:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.GreenYellow;
            this.label18.Location = new System.Drawing.Point(11, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Gmail Die:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(46)))));
            this.label11.Location = new System.Drawing.Point(11, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Gmail Live:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Email:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(22)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(43, 517);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 341;
            // 
            // chaytumailso
            // 
            this.chaytumailso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaytumailso.Location = new System.Drawing.Point(123, 75);
            this.chaytumailso.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.chaytumailso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chaytumailso.Name = "chaytumailso";
            this.chaytumailso.Size = new System.Drawing.Size(73, 22);
            this.chaytumailso.TabIndex = 343;
            this.chaytumailso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 344;
            this.label3.Text = "Key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 345;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(237, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 346;
            this.label5.Text = "xxxxx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 347;
            this.label6.Text = "Author:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Turquoise;
            this.linkLabel1.Location = new System.Drawing.Point(390, 521);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 14);
            this.linkLabel1.TabIndex = 349;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hiep Pham";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tatbangdencheck
            // 
            this.tatbangdencheck.AutoSize = true;
            this.tatbangdencheck.Location = new System.Drawing.Point(12, 21);
            this.tatbangdencheck.Name = "tatbangdencheck";
            this.tatbangdencheck.Size = new System.Drawing.Size(128, 20);
            this.tatbangdencheck.TabIndex = 352;
            this.tatbangdencheck.Text = "Dừng bảng đen ?";
            this.tatbangdencheck.UseVisualStyleBackColor = true;
            this.tatbangdencheck.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loaiproxy);
            this.groupBox1.Controls.Add(this.dungproxycheck);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tatbangdencheck);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.soluongtoida);
            this.groupBox1.Controls.Add(this.chaytumailso);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(240, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(222, 142);
            this.groupBox1.TabIndex = 337;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SETTING";
            // 
            // loaiproxy
            // 
            this.loaiproxy.BackColor = System.Drawing.SystemColors.Control;
            this.loaiproxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loaiproxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaiproxy.FormattingEnabled = true;
            this.loaiproxy.Items.AddRange(new object[] {
            "Http",
            "Socks4",
            "Socks5"});
            this.loaiproxy.Location = new System.Drawing.Point(123, 44);
            this.loaiproxy.Name = "loaiproxy";
            this.loaiproxy.Size = new System.Drawing.Size(80, 24);
            this.loaiproxy.TabIndex = 380;
            // 
            // dungproxycheck
            // 
            this.dungproxycheck.AutoSize = true;
            this.dungproxycheck.Location = new System.Drawing.Point(12, 48);
            this.dungproxycheck.Name = "dungproxycheck";
            this.dungproxycheck.Size = new System.Drawing.Size(105, 20);
            this.dungproxycheck.TabIndex = 353;
            this.dungproxycheck.Text = "Dùng Proxy ?";
            this.dungproxycheck.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 29);
            this.panel1.TabIndex = 386;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChecklivedieFULL.Properties.Resources.gmail_new_logo_icon_159149;
            this.pictureBox2.Location = new System.Drawing.Point(7, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 29);
            this.pictureBox2.TabIndex = 387;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(414, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 386;
            this.button1.Text = "--";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Goldenrod;
            this.label15.Location = new System.Drawing.Point(44, 6);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(281, 16);
            this.label15.TabIndex = 385;
            this.label15.Text = "Check Email Valid Gmail v22.2.24 - HP Tools";
            this.label15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(443, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(172, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 29);
            this.button3.TabIndex = 387;
            this.button3.Text = "RUN";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(472, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txt_status);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HP Tools - Tool check live die Domain - FB: hieppham1812 - Tele: @hiepyoyo478";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soluongtoida)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chaytumailso)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhậpMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem từClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem từFileToolStripMenuItem;
        internal System.Windows.Forms.Button btn_start;
        internal System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label tongloi;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label tongdie;
        private System.Windows.Forms.Label tientrinh2;
        private System.Windows.Forms.Label tonglive;
        private System.Windows.Forms.Label tongmailcheck;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown soluongtoida;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown chaytumailso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripMenuItem xóaListMailToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox tatbangdencheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label tongproxy;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox loaiproxy;
        private System.Windows.Forms.CheckBox dungproxycheck;
        private System.Windows.Forms.ToolStripMenuItem thêmProxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem từCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem từFileToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.Button button3;
    }
}

