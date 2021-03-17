
namespace ImpinjReaderExample
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ri_log = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.btn_conn = new System.Windows.Forms.Button();
            this.btn_inv = new System.Windows.Forms.Button();
            this.btn_cfg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ri_log
            // 
            this.ri_log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ri_log.Location = new System.Drawing.Point(0, 55);
            this.ri_log.Name = "ri_log";
            this.ri_log.Size = new System.Drawing.Size(881, 395);
            this.ri_log.TabIndex = 0;
            this.ri_log.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP地址";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(65, 12);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(403, 25);
            this.txt_ip.TabIndex = 2;
            // 
            // btn_conn
            // 
            this.btn_conn.Location = new System.Drawing.Point(492, 12);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(75, 23);
            this.btn_conn.TabIndex = 4;
            this.btn_conn.Text = "连接";
            this.btn_conn.UseVisualStyleBackColor = true;
            this.btn_conn.Click += new System.EventHandler(this.btn_conn_Click);
            // 
            // btn_inv
            // 
            this.btn_inv.Location = new System.Drawing.Point(587, 12);
            this.btn_inv.Name = "btn_inv";
            this.btn_inv.Size = new System.Drawing.Size(75, 23);
            this.btn_inv.TabIndex = 5;
            this.btn_inv.Text = "开启盘点";
            this.btn_inv.UseVisualStyleBackColor = true;
            this.btn_inv.Click += new System.EventHandler(this.btn_inv_Click);
            // 
            // btn_cfg
            // 
            this.btn_cfg.Location = new System.Drawing.Point(677, 12);
            this.btn_cfg.Name = "btn_cfg";
            this.btn_cfg.Size = new System.Drawing.Size(75, 23);
            this.btn_cfg.TabIndex = 6;
            this.btn_cfg.Text = "配置参数";
            this.btn_cfg.UseVisualStyleBackColor = true;
            this.btn_cfg.Click += new System.EventHandler(this.btn_cfg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.btn_cfg);
            this.Controls.Add(this.btn_inv);
            this.Controls.Add(this.btn_conn);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ri_log);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ri_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Button btn_conn;
        private System.Windows.Forms.Button btn_inv;
        private System.Windows.Forms.Button btn_cfg;
    }
}

