
namespace ModernClinic
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.tab_LeTan = new DevExpress.XtraTab.XtraTabControl();
            this.tabThuoc = new DevExpress.XtraTab.XtraTabPage();
            this.tab_BenhNhan = new DevExpress.XtraTab.XtraTabPage();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maBenhNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.namsinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrieuChung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bENHNHANBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.modernCareDataSet3 = new ModernClinic.ModernCareDataSet3();
            this.tabNhanVien = new DevExpress.XtraTab.XtraTabPage();
            this.tab_Benh = new DevExpress.XtraTab.XtraTabPage();
            this.bENHNHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modernCareDataSet = new ModernClinic.ModernCareDataSet();
            this.bENHNHANTableAdapter = new ModernClinic.ModernCareDataSetTableAdapters.BENHNHANTableAdapter();
            this.bENHNHANBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modernCareDataSet1 = new ModernClinic.ModernCareDataSet1();
            this.modernCareDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bENHNHANTableAdapter1 = new ModernClinic.ModernCareDataSet3TableAdapters.BENHNHANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tab_LeTan)).BeginInit();
            this.tab_LeTan.SuspendLayout();
            this.tab_BenhNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernCareDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernCareDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernCareDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_LeTan
            // 
            this.tab_LeTan.Appearance.Options.UseTextOptions = true;
            this.tab_LeTan.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.False;
            this.tab_LeTan.Location = new System.Drawing.Point(12, 12);
            this.tab_LeTan.Name = "tab_LeTan";
            this.tab_LeTan.SelectedTabPage = this.tabThuoc;
            this.tab_LeTan.Size = new System.Drawing.Size(1442, 836);
            this.tab_LeTan.TabIndex = 0;
            this.tab_LeTan.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tab_BenhNhan,
            this.tabNhanVien,
            this.tab_Benh,
            this.tabThuoc});
            // 
            // tabThuoc
            // 
            this.tabThuoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabThuoc.ImageOptions.SvgImage")));
            this.tabThuoc.Name = "tabThuoc";
            this.tabThuoc.Size = new System.Drawing.Size(1440, 774);
            this.tabThuoc.Text = "Thuốc";
            // 
            // tab_BenhNhan
            // 
            this.tab_BenhNhan.AutoScroll = true;
            this.tab_BenhNhan.Controls.Add(this.textEdit2);
            this.tab_BenhNhan.Controls.Add(this.dateEdit1);
            this.tab_BenhNhan.Controls.Add(this.comboBox1);
            this.tab_BenhNhan.Controls.Add(this.richTextBox1);
            this.tab_BenhNhan.Controls.Add(this.textEdit3);
            this.tab_BenhNhan.Controls.Add(this.textEdit1);
            this.tab_BenhNhan.Controls.Add(this.labelControl6);
            this.tab_BenhNhan.Controls.Add(this.labelControl5);
            this.tab_BenhNhan.Controls.Add(this.labelControl4);
            this.tab_BenhNhan.Controls.Add(this.labelControl3);
            this.tab_BenhNhan.Controls.Add(this.labelControl2);
            this.tab_BenhNhan.Controls.Add(this.labelControl1);
            this.tab_BenhNhan.Controls.Add(this.dataGridView1);
            this.tab_BenhNhan.ImageOptions.Image = global::ModernClinic.Properties.Resources.benhnhan_icon;
            this.tab_BenhNhan.Name = "tab_BenhNhan";
            this.tab_BenhNhan.Size = new System.Drawing.Size(1440, 774);
            this.tab_BenhNhan.Text = "Bệnh Nhân";
            this.tab_BenhNhan.TooltipIconType = DevExpress.Utils.ToolTipIconType.Application;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(824, 89);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(90, 30);
            this.textEdit2.TabIndex = 14;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(592, 92);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.ReadOnly = true;
            this.dateEdit1.Size = new System.Drawing.Size(94, 30);
            this.dateEdit1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 32);
            this.comboBox1.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(592, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 58);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(363, 89);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Size = new System.Drawing.Size(90, 30);
            this.textEdit3.TabIndex = 9;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(131, 19);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(322, 30);
            this.textEdit1.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(705, 95);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(97, 24);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Trạng Thái";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(483, 95);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(102, 24);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Ngày Khám";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(483, 25);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 24);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Địa chỉ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(244, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 24);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Năm Sinh";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(22, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Giới Tính";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Họ Tên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBenhNhanDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewCheckBoxColumn,
            this.namsinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.ngayKhamDataGridViewTextBoxColumn,
            this.TrieuChung,
            this.TrangThai});
            this.dataGridView1.DataSource = this.bENHNHANBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(22, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1399, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // maBenhNhanDataGridViewTextBoxColumn
            // 
            this.maBenhNhanDataGridViewTextBoxColumn.DataPropertyName = "MaBenhNhan";
            this.maBenhNhanDataGridViewTextBoxColumn.HeaderText = "MaBenhNhan";
            this.maBenhNhanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maBenhNhanDataGridViewTextBoxColumn.Name = "maBenhNhanDataGridViewTextBoxColumn";
            this.maBenhNhanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gioiTinhDataGridViewCheckBoxColumn
            // 
            this.gioiTinhDataGridViewCheckBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewCheckBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewCheckBoxColumn.Name = "gioiTinhDataGridViewCheckBoxColumn";
            this.gioiTinhDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // namsinhDataGridViewTextBoxColumn
            // 
            this.namsinhDataGridViewTextBoxColumn.DataPropertyName = "Namsinh";
            this.namsinhDataGridViewTextBoxColumn.HeaderText = "Namsinh";
            this.namsinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namsinhDataGridViewTextBoxColumn.Name = "namsinhDataGridViewTextBoxColumn";
            this.namsinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayKhamDataGridViewTextBoxColumn
            // 
            this.ngayKhamDataGridViewTextBoxColumn.DataPropertyName = "NgayKham";
            this.ngayKhamDataGridViewTextBoxColumn.HeaderText = "NgayKham";
            this.ngayKhamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayKhamDataGridViewTextBoxColumn.Name = "ngayKhamDataGridViewTextBoxColumn";
            this.ngayKhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TrieuChung
            // 
            this.TrieuChung.DataPropertyName = "TrieuChung";
            this.TrieuChung.HeaderText = "TrieuChung";
            this.TrieuChung.MinimumWidth = 6;
            this.TrieuChung.Name = "TrieuChung";
            this.TrieuChung.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // bENHNHANBindingSource2
            // 
            this.bENHNHANBindingSource2.DataMember = "BENHNHAN";
            this.bENHNHANBindingSource2.DataSource = this.modernCareDataSet3;
            // 
            // modernCareDataSet3
            // 
            this.modernCareDataSet3.DataSetName = "ModernCareDataSet3";
            this.modernCareDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.ImageOptions.Image = global::ModernClinic.Properties.Resources.letan_icon;
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Size = new System.Drawing.Size(1440, 774);
            this.tabNhanVien.Text = "Nhân Viên";
            // 
            // tab_Benh
            // 
            this.tab_Benh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tab_Benh.ImageOptions.SvgImage")));
            this.tab_Benh.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.tab_Benh.Name = "tab_Benh";
            this.tab_Benh.Size = new System.Drawing.Size(1440, 774);
            this.tab_Benh.Text = "Bệnh";
            // 
            // bENHNHANBindingSource
            // 
            this.bENHNHANBindingSource.DataMember = "BENHNHAN";
            this.bENHNHANBindingSource.DataSource = this.modernCareDataSet;
            // 
            // modernCareDataSet
            // 
            this.modernCareDataSet.DataSetName = "ModernCareDataSet";
            this.modernCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bENHNHANTableAdapter
            // 
            this.bENHNHANTableAdapter.ClearBeforeFill = true;
            // 
            // bENHNHANBindingSource1
            // 
            this.bENHNHANBindingSource1.DataMember = "BENHNHAN";
            this.bENHNHANBindingSource1.DataSource = this.modernCareDataSet;
            // 
            // modernCareDataSet1
            // 
            this.modernCareDataSet1.DataSetName = "ModernCareDataSet1";
            this.modernCareDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modernCareDataSet1BindingSource
            // 
            this.modernCareDataSet1BindingSource.DataSource = this.modernCareDataSet1;
            this.modernCareDataSet1BindingSource.Position = 0;
            // 
            // bENHNHANTableAdapter1
            // 
            this.bENHNHANTableAdapter1.ClearBeforeFill = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 877);
            this.Controls.Add(this.tab_LeTan);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tab_LeTan)).EndInit();
            this.tab_LeTan.ResumeLayout(false);
            this.tab_BenhNhan.ResumeLayout(false);
            this.tab_BenhNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernCareDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernCareDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernCareDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tab_LeTan;
        private DevExpress.XtraTab.XtraTabPage tab_BenhNhan;
        private DevExpress.XtraTab.XtraTabPage tabNhanVien;
        private DevExpress.XtraTab.XtraTabPage tab_Benh;
        private DevExpress.XtraTab.XtraTabPage tabThuoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ModernCareDataSet modernCareDataSet;
        private System.Windows.Forms.BindingSource bENHNHANBindingSource;
        private ModernCareDataSetTableAdapters.BENHNHANTableAdapter bENHNHANTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource modernCareDataSet1BindingSource;
        private ModernCareDataSet1 modernCareDataSet1;
        private System.Windows.Forms.BindingSource bENHNHANBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBenhNhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKhamDataGridViewTextBoxColumn;
        private ModernCareDataSet3 modernCareDataSet3;
        private System.Windows.Forms.BindingSource bENHNHANBindingSource2;
        private ModernCareDataSet3TableAdapters.BENHNHANTableAdapter bENHNHANTableAdapter1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrieuChung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}