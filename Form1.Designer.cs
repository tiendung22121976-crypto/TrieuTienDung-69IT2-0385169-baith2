namespace WindowsFormsApp4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtThreads = new System.Windows.Forms.TextBox();
            this.btnCham = new System.Windows.Forms.Button();
            this.btnNhanh = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbKetqua = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số Thread cần chạy:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtThreads
            // 
            this.txtThreads.Location = new System.Drawing.Point(163, 15);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.Size = new System.Drawing.Size(68, 20);
            this.txtThreads.TabIndex = 1;
            this.txtThreads.TextChanged += new System.EventHandler(this.txtThreads_TextChanged);
            // 
            // btnCham
            // 
            this.btnCham.Location = new System.Drawing.Point(280, 11);
            this.btnCham.Name = "btnCham";
            this.btnCham.Size = new System.Drawing.Size(111, 27);
            this.btnCham.TabIndex = 2;
            this.btnCham.Text = "Ưu tiên thấp";
            this.btnCham.UseVisualStyleBackColor = true;
            this.btnCham.Click += new System.EventHandler(this.btnCham_Click);
            // 
            // btnNhanh
            // 
            this.btnNhanh.Location = new System.Drawing.Point(452, 11);
            this.btnNhanh.Name = "btnNhanh";
            this.btnNhanh.Size = new System.Drawing.Size(111, 27);
            this.btnNhanh.TabIndex = 3;
            this.btnNhanh.Text = "Ưu tiên cao";
            this.btnNhanh.UseVisualStyleBackColor = true;
            this.btnNhanh.Click += new System.EventHandler(this.btnNhanh_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(613, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 27);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Tính tích 2 ma trận";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbKetqua
            // 
            this.lbKetqua.FormattingEnabled = true;
            this.lbKetqua.Location = new System.Drawing.Point(12, 45);
            this.lbKetqua.Name = "lbKetqua";
            this.lbKetqua.Size = new System.Drawing.Size(1076, 576);
            this.lbKetqua.TabIndex = 5;
            this.lbKetqua.SelectedIndexChanged += new System.EventHandler(this.lbKetqua_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 645);
            this.Controls.Add(this.lbKetqua);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnNhanh);
            this.Controls.Add(this.btnCham);
            this.Controls.Add(this.txtThreads);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThreads;
        private System.Windows.Forms.Button btnCham;
        private System.Windows.Forms.Button btnNhanh;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lbKetqua;
    }
}

