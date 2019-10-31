namespace 指挥控制终端.CustomControl
{
    partial class UserControlButton
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSubmit = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = global::指挥控制终端.Properties.Resources.anniu2;
            this.flowLayoutPanel1.Controls.Add(this.lbSubmit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(95, 39);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lbSubmit
            // 
            this.lbSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSubmit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSubmit.ForeColor = System.Drawing.Color.White;
            this.lbSubmit.Location = new System.Drawing.Point(3, 0);
            this.lbSubmit.Name = "lbSubmit";
            this.lbSubmit.Size = new System.Drawing.Size(92, 29);
            this.lbSubmit.TabIndex = 1;
            this.lbSubmit.Text = "text";
            this.lbSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSubmit.Click += new System.EventHandler(this.lbSubmit_Click);
            // 
            // UserControlButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UserControlButton";
            this.Size = new System.Drawing.Size(95, 39);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbSubmit;
    }
}
