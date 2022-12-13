namespace proje1
{
    partial class frmstokcs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgıdatutar = new System.Windows.Forms.TextBox();
            this.txtiçecektut = new System.Windows.Forms.TextBox();
            this.txtatıştı = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnkaydet2 = new System.Windows.Forms.Button();
            this.txtint = new System.Windows.Forms.TextBox();
            this.txtsu = new System.Windows.Forms.TextBox();
            this.txtelektrik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Elektrik = new System.Windows.Forms.ColumnHeader();
            this.Su = new System.Windows.Forms.ColumnHeader();
            this.İnternet = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gıda Tutarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "İçecek Tutarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Unispace", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Atıştırmalıklar:";
            // 
            // txtgıdatutar
            // 
            this.txtgıdatutar.Location = new System.Drawing.Point(204, 90);
            this.txtgıdatutar.Name = "txtgıdatutar";
            this.txtgıdatutar.Size = new System.Drawing.Size(125, 27);
            this.txtgıdatutar.TabIndex = 3;
            // 
            // txtiçecektut
            // 
            this.txtiçecektut.Location = new System.Drawing.Point(204, 129);
            this.txtiçecektut.Name = "txtiçecektut";
            this.txtiçecektut.Size = new System.Drawing.Size(125, 27);
            this.txtiçecektut.TabIndex = 4;
            // 
            // txtatıştı
            // 
            this.txtatıştı.Location = new System.Drawing.Point(204, 172);
            this.txtatıştı.Name = "txtatıştı";
            this.txtatıştı.Size = new System.Drawing.Size(125, 27);
            this.txtatıştı.TabIndex = 5;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Unispace", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnkaydet.Location = new System.Drawing.Point(162, 241);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(94, 29);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(0, 332);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(421, 121);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gıdalar";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçecekler";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Atıştırmalıklar";
            this.columnHeader3.Width = 120;
            // 
            // btnkaydet2
            // 
            this.btnkaydet2.Font = new System.Drawing.Font("Unispace", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnkaydet2.Location = new System.Drawing.Point(612, 241);
            this.btnkaydet2.Name = "btnkaydet2";
            this.btnkaydet2.Size = new System.Drawing.Size(94, 29);
            this.btnkaydet2.TabIndex = 14;
            this.btnkaydet2.Text = "Kaydet";
            this.btnkaydet2.UseVisualStyleBackColor = true;
            this.btnkaydet2.Click += new System.EventHandler(this.btnkaydet2_Click);
            // 
            // txtint
            // 
            this.txtint.Location = new System.Drawing.Point(602, 167);
            this.txtint.Name = "txtint";
            this.txtint.Size = new System.Drawing.Size(125, 27);
            this.txtint.TabIndex = 13;
            // 
            // txtsu
            // 
            this.txtsu.Location = new System.Drawing.Point(602, 124);
            this.txtsu.Name = "txtsu";
            this.txtsu.Size = new System.Drawing.Size(125, 27);
            this.txtsu.TabIndex = 12;
            // 
            // txtelektrik
            // 
            this.txtelektrik.Location = new System.Drawing.Point(602, 85);
            this.txtelektrik.Name = "txtelektrik";
            this.txtelektrik.Size = new System.Drawing.Size(125, 27);
            this.txtelektrik.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Unispace", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(507, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "İnternet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Unispace", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(560, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Su:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Unispace", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(507, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Elektrik:";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Elektrik,
            this.Su,
            this.İnternet});
            this.listView2.Location = new System.Drawing.Point(427, 332);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(442, 121);
            this.listView2.TabIndex = 15;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // Elektrik
            // 
            this.Elektrik.Text = "Elektrik";
            this.Elektrik.Width = 100;
            // 
            // Su
            // 
            this.Su.Text = "Su";
            this.Su.Width = 90;
            // 
            // İnternet
            // 
            this.İnternet.Text = "İnternet";
            this.İnternet.Width = 100;
            // 
            // frmstokcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proje1.Properties.Resources.hostel_graphics_handwriting_wallpaper;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnkaydet2);
            this.Controls.Add(this.txtint);
            this.Controls.Add(this.txtsu);
            this.Controls.Add(this.txtelektrik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtatıştı);
            this.Controls.Add(this.txtiçecektut);
            this.Controls.Add(this.txtgıdatutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmstokcs";
            this.Text = "Stoklar&Faturalar";
            this.Load += new System.EventHandler(this.frmstokcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtgıdatutar;
        private TextBox txtiçecektut;
        private TextBox txtatıştı;
        private Button btnkaydet;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnkaydet2;
        private TextBox txtint;
        private TextBox txtsu;
        private TextBox txtelektrik;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListView listView2;
        private ColumnHeader Elektrik;
        private ColumnHeader Su;
        private ColumnHeader İnternet;
    }
}