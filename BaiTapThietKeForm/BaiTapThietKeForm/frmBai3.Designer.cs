﻿namespace BaiTapThietKeForm
{
    partial class frmBai3
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
            this.txtTuMoi = new System.Windows.Forms.TextBox();
            this.txtNghia = new System.Windows.Forms.TextBox();
            this.btnThemTuMoi = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHienThiNghia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nghĩa của từ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTuMoi
            // 
            this.txtTuMoi.Location = new System.Drawing.Point(176, 40);
            this.txtTuMoi.Name = "txtTuMoi";
            this.txtTuMoi.Size = new System.Drawing.Size(182, 20);
            this.txtTuMoi.TabIndex = 0;
            // 
            // txtNghia
            // 
            this.txtNghia.Location = new System.Drawing.Point(176, 80);
            this.txtNghia.Name = "txtNghia";
            this.txtNghia.Size = new System.Drawing.Size(182, 20);
            this.txtNghia.TabIndex = 1;
            // 
            // btnThemTuMoi
            // 
            this.btnThemTuMoi.Location = new System.Drawing.Point(221, 120);
            this.btnThemTuMoi.Name = "btnThemTuMoi";
            this.btnThemTuMoi.Size = new System.Drawing.Size(112, 23);
            this.btnThemTuMoi.TabIndex = 2;
            this.btnThemTuMoi.Text = "Thêm từ mới";
            this.btnThemTuMoi.UseVisualStyleBackColor = true;
            this.btnThemTuMoi.Click += new System.EventHandler(this.btnThemTuMoi_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(62, 188);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 186);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DANH SÁCH TỪ MỚI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "NGHĨA CỦA TỪ";
            // 
            // txtHienThiNghia
            // 
            this.txtHienThiNghia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHienThiNghia.Location = new System.Drawing.Point(393, 188);
            this.txtHienThiNghia.Multiline = true;
            this.txtHienThiNghia.Name = "txtHienThiNghia";
            this.txtHienThiNghia.Size = new System.Drawing.Size(198, 186);
            this.txtHienThiNghia.TabIndex = 10;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHienThiNghia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnThemTuMoi);
            this.Controls.Add(this.txtNghia);
            this.Controls.Add(this.txtTuMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTuMoi;
        private System.Windows.Forms.TextBox txtNghia;
        private System.Windows.Forms.Button btnThemTuMoi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHienThiNghia;
    }
}