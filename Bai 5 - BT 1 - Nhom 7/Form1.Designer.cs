namespace Bai_5___BT_1___Nhom_7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDSSo = new System.Windows.Forms.ComboBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lstUocSo = new System.Windows.Forms.ListBox();
            this.btnTongUoc = new System.Windows.Forms.Button();
            this.btnSoLuongUocChan = new System.Windows.Forms.Button();
            this.btnSoLuongUocNT = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDSSo);
            this.groupBox1.Controls.Add(this.txtSo);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Nhập số";
            // 
            // cboDSSo
            // 
            this.cboDSSo.FormattingEnabled = true;
            this.cboDSSo.Location = new System.Drawing.Point(28, 122);
            this.cboDSSo.Name = "cboDSSo";
            this.cboDSSo.Size = new System.Drawing.Size(341, 28);
            this.cboDSSo.TabIndex = 2;
            this.cboDSSo.SelectedIndexChanged += new System.EventHandler(this.cboDSSo_SelectedIndexChanged);
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(28, 52);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(195, 26);
            this.txtSo.TabIndex = 1;
            this.txtSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSo_KeyPress);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(254, 50);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(115, 28);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lstUocSo
            // 
            this.lstUocSo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lstUocSo.FormattingEnabled = true;
            this.lstUocSo.ItemHeight = 15;
            this.lstUocSo.Location = new System.Drawing.Point(17, 27);
            this.lstUocSo.Name = "lstUocSo";
            this.lstUocSo.Size = new System.Drawing.Size(234, 169);
            this.lstUocSo.TabIndex = 1;
            // 
            // btnTongUoc
            // 
            this.btnTongUoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTongUoc.Location = new System.Drawing.Point(525, 295);
            this.btnTongUoc.Name = "btnTongUoc";
            this.btnTongUoc.Size = new System.Drawing.Size(210, 37);
            this.btnTongUoc.TabIndex = 2;
            this.btnTongUoc.Text = "Tổng các ước số";
            this.btnTongUoc.UseVisualStyleBackColor = true;
            this.btnTongUoc.Click += new System.EventHandler(this.btnTongUoc_Click);
            // 
            // btnSoLuongUocChan
            // 
            this.btnSoLuongUocChan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSoLuongUocChan.Location = new System.Drawing.Point(525, 362);
            this.btnSoLuongUocChan.Name = "btnSoLuongUocChan";
            this.btnSoLuongUocChan.Size = new System.Drawing.Size(210, 37);
            this.btnSoLuongUocChan.TabIndex = 3;
            this.btnSoLuongUocChan.Text = "Số lượng các ước số chẵn";
            this.btnSoLuongUocChan.UseVisualStyleBackColor = true;
            this.btnSoLuongUocChan.Click += new System.EventHandler(this.btnSoLuongUocChan_Click);
            // 
            // btnSoLuongUocNT
            // 
            this.btnSoLuongUocNT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSoLuongUocNT.Location = new System.Drawing.Point(525, 421);
            this.btnSoLuongUocNT.Name = "btnSoLuongUocNT";
            this.btnSoLuongUocNT.Size = new System.Drawing.Size(210, 40);
            this.btnSoLuongUocNT.TabIndex = 4;
            this.btnSoLuongUocNT.Text = "Số lượng các ước nguyên tố";
            this.btnSoLuongUocNT.UseVisualStyleBackColor = true;
            this.btnSoLuongUocNT.Click += new System.EventHandler(this.btnSoLuongUocNT_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(127, 362);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 37);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstUocSo);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(488, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 222);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSoLuongUocNT);
            this.Controls.Add(this.btnSoLuongUocChan);
            this.Controls.Add(this.btnTongUoc);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cboDSSo;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.ListBox lstUocSo;
        private System.Windows.Forms.Button btnTongUoc;
        private System.Windows.Forms.Button btnSoLuongUocChan;
        private System.Windows.Forms.Button btnSoLuongUocNT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

