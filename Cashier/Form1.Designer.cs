namespace Cashier
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
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Num = new System.Windows.Forms.TextBox();
            this.cb_Result = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.lb_Summer = new System.Windows.Forms.Label();
            this.cbx_Type = new System.Windows.Forms.ComboBox();
            this.bt_count = new System.Windows.Forms.Button();
            this.lbx_List = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(157, 77);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(100, 21);
            this.tb_Price.TabIndex = 0;
            // 
            // tb_Num
            // 
            this.tb_Num.Location = new System.Drawing.Point(483, 77);
            this.tb_Num.Name = "tb_Num";
            this.tb_Num.Size = new System.Drawing.Size(100, 21);
            this.tb_Num.TabIndex = 1;
            // 
            // cb_Result
            // 
            this.cb_Result.Location = new System.Drawing.Point(157, 341);
            this.cb_Result.Name = "cb_Result";
            this.cb_Result.Size = new System.Drawing.Size(100, 21);
            this.cb_Result.TabIndex = 2;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(29, 80);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(29, 12);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "单价";
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(361, 80);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(29, 12);
            this.lbNum.TabIndex = 4;
            this.lbNum.Text = "数量";
            // 
            // lb_Summer
            // 
            this.lb_Summer.AutoSize = true;
            this.lb_Summer.Location = new System.Drawing.Point(29, 350);
            this.lb_Summer.Name = "lb_Summer";
            this.lb_Summer.Size = new System.Drawing.Size(29, 12);
            this.lb_Summer.TabIndex = 5;
            this.lb_Summer.Text = "总价";
            // 
            // cbx_Type
            // 
            this.cbx_Type.FormattingEnabled = true;
            this.cbx_Type.Items.AddRange(new object[] {
            "正常收费",
            "满300返100",
            "打8折"});
            this.cbx_Type.Location = new System.Drawing.Point(113, 144);
            this.cbx_Type.Name = "cbx_Type";
            this.cbx_Type.Size = new System.Drawing.Size(121, 20);
            this.cbx_Type.TabIndex = 6;
            // 
            // bt_count
            // 
            this.bt_count.Location = new System.Drawing.Point(351, 144);
            this.bt_count.Name = "bt_count";
            this.bt_count.Size = new System.Drawing.Size(75, 23);
            this.bt_count.TabIndex = 7;
            this.bt_count.Text = "确认";
            this.bt_count.UseVisualStyleBackColor = true;
            this.bt_count.Click += new System.EventHandler(this.bt_count_Click);
            // 
            // lbx_List
            // 
            this.lbx_List.FormattingEnabled = true;
            this.lbx_List.ItemHeight = 12;
            this.lbx_List.Location = new System.Drawing.Point(113, 205);
            this.lbx_List.Name = "lbx_List";
            this.lbx_List.Size = new System.Drawing.Size(576, 88);
            this.lbx_List.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbx_List);
            this.Controls.Add(this.bt_count);
            this.Controls.Add(this.cbx_Type);
            this.Controls.Add(this.lb_Summer);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.cb_Result);
            this.Controls.Add(this.tb_Num);
            this.Controls.Add(this.tb_Price);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Num;
        private System.Windows.Forms.TextBox cb_Result;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lb_Summer;
        private System.Windows.Forms.ComboBox cbx_Type;
        private System.Windows.Forms.Button bt_count;
        private System.Windows.Forms.ListBox lbx_List;
    }
}

