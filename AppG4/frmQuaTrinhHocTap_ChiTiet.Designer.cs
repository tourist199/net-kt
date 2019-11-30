namespace AppG4.Data
{
    partial class frmQuaTrinhHocTap_ChiTiet
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numYearEnd = new System.Windows.Forms.NumericUpDown();
            this.numYearFrom = new System.Windows.Forms.NumericUpDown();
            this.txtNoiHoc = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numYearEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYearFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ năm:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(369, 355);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đến năm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Học tại:";
            // 
            // numYearEnd
            // 
            this.numYearEnd.Location = new System.Drawing.Point(158, 98);
            this.numYearEnd.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numYearEnd.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYearEnd.Name = "numYearEnd";
            this.numYearEnd.Size = new System.Drawing.Size(169, 22);
            this.numYearEnd.TabIndex = 2;
            this.numYearEnd.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numYearFrom
            // 
            this.numYearFrom.Location = new System.Drawing.Point(158, 65);
            this.numYearFrom.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numYearFrom.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYearFrom.Name = "numYearFrom";
            this.numYearFrom.Size = new System.Drawing.Size(169, 22);
            this.numYearFrom.TabIndex = 2;
            this.numYearFrom.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // txtNoiHoc
            // 
            this.txtNoiHoc.Location = new System.Drawing.Point(158, 150);
            this.txtNoiHoc.Multiline = true;
            this.txtNoiHoc.Name = "txtNoiHoc";
            this.txtNoiHoc.Size = new System.Drawing.Size(336, 144);
            this.txtNoiHoc.TabIndex = 3;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(241, 326);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(97, 37);
            this.btnDongY.TabIndex = 4;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(369, 326);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(97, 37);
            this.btnBoQua.TabIndex = 4;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            // 
            // frmQuaTrinhHocTap_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 393);
            this.ControlBox = false;
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtNoiHoc);
            this.Controls.Add(this.numYearFrom);
            this.Controls.Add(this.numYearEnd);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmQuaTrinhHocTap_ChiTiet";
            this.Text = "Thêm mới / Chỉnh sửa";
            ((System.ComponentModel.ISupportInitialize)(this.numYearEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYearFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numYearEnd;
        private System.Windows.Forms.NumericUpDown numYearFrom;
        private System.Windows.Forms.TextBox txtNoiHoc;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnBoQua;
    }
}