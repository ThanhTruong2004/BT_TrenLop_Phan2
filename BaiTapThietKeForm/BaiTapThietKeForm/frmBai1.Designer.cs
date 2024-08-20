namespace BaiTapThietKeForm
{
    partial class frmBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdXam = new System.Windows.Forms.RadioButton();
            this.rdDo = new System.Windows.Forms.RadioButton();
            this.rdXanh = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbISoTien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdXanh);
            this.groupBox1.Controls.Add(this.rdDo);
            this.groupBox1.Controls.Add(this.rdXam);
            this.groupBox1.Location = new System.Drawing.Point(355, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn màu xe";
            // 
            // rdXam
            // 
            this.rdXam.AutoSize = true;
            this.rdXam.Checked = true;
            this.rdXam.Location = new System.Drawing.Point(27, 19);
            this.rdXam.Name = "rdXam";
            this.rdXam.Size = new System.Drawing.Size(44, 17);
            this.rdXam.TabIndex = 0;
            this.rdXam.TabStop = true;
            this.rdXam.Text = "xám";
            this.rdXam.UseVisualStyleBackColor = true;
            this.rdXam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdDo
            // 
            this.rdDo.AutoSize = true;
            this.rdDo.Location = new System.Drawing.Point(27, 65);
            this.rdDo.Name = "rdDo";
            this.rdDo.Size = new System.Drawing.Size(38, 17);
            this.rdDo.TabIndex = 2;
            this.rdDo.Text = "đỏ";
            this.rdDo.UseVisualStyleBackColor = true;
            this.rdDo.CheckedChanged += new System.EventHandler(this.rdDo_CheckedChanged);
            // 
            // rdXanh
            // 
            this.rdXanh.AutoSize = true;
            this.rdXanh.Location = new System.Drawing.Point(27, 42);
            this.rdXanh.Name = "rdXanh";
            this.rdXanh.Size = new System.Drawing.Size(48, 17);
            this.rdXanh.TabIndex = 3;
            this.rdXanh.Text = "xanh";
            this.rdXanh.UseVisualStyleBackColor = true;
            this.rdXanh.CheckedChanged += new System.EventHandler(this.rdXanh_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(352, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(445, 190);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(100, 23);
            this.txtDonGia.TabIndex = 5;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(445, 249);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 23);
            this.txtSoLuong.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "$";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTinhTien.Location = new System.Drawing.Point(441, 301);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(130, 61);
            this.btnTinhTien.TabIndex = 9;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng tiền thanh toán:";
            // 
            // lbISoTien
            // 
            this.lbISoTien.AutoSize = true;
            this.lbISoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbISoTien.Location = new System.Drawing.Point(456, 389);
            this.lbISoTien.Name = "lbISoTien";
            this.lbISoTien.Size = new System.Drawing.Size(20, 24);
            this.lbISoTien.TabIndex = 11;
            this.lbISoTien.Text = "0";
            this.lbISoTien.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(551, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "$";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbISoTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmBai1";
            this.Text = "frmBai1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdXam;
        private System.Windows.Forms.RadioButton rdXanh;
        private System.Windows.Forms.RadioButton rdDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbISoTien;
        private System.Windows.Forms.Label label5;
    }
}