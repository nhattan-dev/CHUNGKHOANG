
namespace CHUNGKHOANG
{
    partial class THONGTIN
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnMua = new DevExpress.XtraEditors.SimpleButton();
            this.cbbLenh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMuaBan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbLoaiLenh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaCK = new DevExpress.XtraEditors.TextEdit();
            this.txtKhoiLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtGia = new DevExpress.XtraEditors.TextEdit();
            this.txtSLMax = new DevExpress.XtraEditors.TextEdit();
            this.txtNhanLenh = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLenh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMuaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiLenh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoiLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanLenh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1442, 395);
            this.dataGridView1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(572, 639);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "Trạng thái tiểu khoản: Bình Thường";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(1020, 558);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(715, 593);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(94, 30);
            this.btnLamMoi.TabIndex = 20;
            this.btnLamMoi.TabStop = false;
            this.btnLamMoi.Text = "Làm lại";
            // 
            // btnMua
            // 
            this.btnMua.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnMua.Appearance.Options.UseForeColor = true;
            this.btnMua.AppearanceHovered.BackColor = System.Drawing.Color.Yellow;
            this.btnMua.AppearanceHovered.Options.UseBackColor = true;
            this.btnMua.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            this.btnMua.AppearancePressed.Options.UseBackColor = true;
            this.btnMua.Location = new System.Drawing.Point(567, 593);
            this.btnMua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMua.Name = "btnMua";
            this.btnMua.Size = new System.Drawing.Size(94, 30);
            this.btnMua.TabIndex = 29;
            this.btnMua.Text = "Mua";
            this.btnMua.Click += new System.EventHandler(this.btnMua_Click);
            // 
            // cbbLenh
            // 
            this.cbbLenh.EditValue = "LO";
            this.cbbLenh.Location = new System.Drawing.Point(842, 463);
            this.cbbLenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLenh.Name = "cbbLenh";
            this.cbbLenh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLenh.Properties.Appearance.Options.UseFont = true;
            this.cbbLenh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbLenh.Properties.Items.AddRange(new object[] {
            "LO",
            "ATO",
            "ATC"});
            this.cbbLenh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbLenh.Size = new System.Drawing.Size(195, 28);
            this.cbbLenh.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(743, 554);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nhân lệnh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(743, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lệnh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã CK:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(743, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "SL max:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Khối lượng:";
            // 
            // cbbMuaBan
            // 
            this.cbbMuaBan.EditValue = "Mua";
            this.cbbMuaBan.Location = new System.Drawing.Point(842, 422);
            this.cbbMuaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMuaBan.Name = "cbbMuaBan";
            this.cbbMuaBan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMuaBan.Properties.Appearance.Options.UseFont = true;
            this.cbbMuaBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMuaBan.Properties.Items.AddRange(new object[] {
            "Mua",
            "Bán"});
            this.cbbMuaBan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbMuaBan.Size = new System.Drawing.Size(195, 28);
            this.cbbMuaBan.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(743, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mua/bán:";
            // 
            // cbbLoaiLenh
            // 
            this.cbbLoaiLenh.EditValue = "Lệnh Thông Thường";
            this.cbbLoaiLenh.Location = new System.Drawing.Point(447, 421);
            this.cbbLoaiLenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLoaiLenh.Name = "cbbLoaiLenh";
            this.cbbLoaiLenh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiLenh.Properties.Appearance.Options.UseFont = true;
            this.cbbLoaiLenh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbLoaiLenh.Properties.Items.AddRange(new object[] {
            "Lệnh Thông Thường"});
            this.cbbLoaiLenh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbLoaiLenh.Size = new System.Drawing.Size(195, 28);
            this.cbbLoaiLenh.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Loại lệnh:";
            // 
            // txtMaCK
            // 
            this.txtMaCK.Location = new System.Drawing.Point(447, 462);
            this.txtMaCK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaCK.Name = "txtMaCK";
            this.txtMaCK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCK.Properties.Appearance.Options.UseFont = true;
            this.txtMaCK.Size = new System.Drawing.Size(174, 28);
            this.txtMaCK.TabIndex = 22;
            // 
            // txtKhoiLuong
            // 
            this.txtKhoiLuong.EditValue = "1000";
            this.txtKhoiLuong.Location = new System.Drawing.Point(447, 506);
            this.txtKhoiLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKhoiLuong.Name = "txtKhoiLuong";
            this.txtKhoiLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoiLuong.Properties.Appearance.Options.UseFont = true;
            this.txtKhoiLuong.Properties.Mask.EditMask = "n0";
            this.txtKhoiLuong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKhoiLuong.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtKhoiLuong.Size = new System.Drawing.Size(174, 28);
            this.txtKhoiLuong.TabIndex = 24;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(447, 549);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Properties.Appearance.Options.UseFont = true;
            this.txtGia.Properties.Mask.EditMask = "c0";
            this.txtGia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGia.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtGia.Size = new System.Drawing.Size(174, 28);
            this.txtGia.TabIndex = 25;
            // 
            // txtSLMax
            // 
            this.txtSLMax.Enabled = false;
            this.txtSLMax.Location = new System.Drawing.Point(842, 507);
            this.txtSLMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSLMax.Name = "txtSLMax";
            this.txtSLMax.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLMax.Properties.Appearance.Options.UseFont = true;
            this.txtSLMax.Properties.Mask.EditMask = "n0";
            this.txtSLMax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSLMax.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSLMax.Size = new System.Drawing.Size(170, 28);
            this.txtSLMax.TabIndex = 28;
            // 
            // txtNhanLenh
            // 
            this.txtNhanLenh.EditValue = "1";
            this.txtNhanLenh.Enabled = false;
            this.txtNhanLenh.Location = new System.Drawing.Point(842, 550);
            this.txtNhanLenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhanLenh.Name = "txtNhanLenh";
            this.txtNhanLenh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanLenh.Properties.Appearance.Options.UseFont = true;
            this.txtNhanLenh.Properties.Mask.EditMask = "n0";
            this.txtNhanLenh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNhanLenh.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNhanLenh.Size = new System.Drawing.Size(170, 28);
            this.txtNhanLenh.TabIndex = 27;
            // 
            // THONGTIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 667);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnMua);
            this.Controls.Add(this.cbbLenh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbMuaBan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbLoaiLenh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaCK);
            this.Controls.Add(this.txtKhoiLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSLMax);
            this.Controls.Add(this.txtNhanLenh);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "THONGTIN";
            this.Text = "THONGTIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.THONGTIN_FormClosing);
            this.Load += new System.EventHandler(this.THONGTIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLenh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMuaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiLenh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoiLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanLenh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnMua;
        private DevExpress.XtraEditors.ComboBoxEdit cbbLenh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ComboBoxEdit cbbMuaBan;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ComboBoxEdit cbbLoaiLenh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMaCK;
        private DevExpress.XtraEditors.TextEdit txtKhoiLuong;
        private DevExpress.XtraEditors.TextEdit txtGia;
        private DevExpress.XtraEditors.TextEdit txtSLMax;
        private DevExpress.XtraEditors.TextEdit txtNhanLenh;
    }
}