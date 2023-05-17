namespace 平行四边形的图形绘制与面积
{
    partial class ParallelogramPage
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
            this.mainBoard = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // mainBoard
            // 
            this.mainBoard.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBoard.Location = new System.Drawing.Point(134, 41);
            this.mainBoard.Name = "mainBoard";
            this.mainBoard.Size = new System.Drawing.Size(772, 449);
            this.mainBoard.TabIndex = 0;
            this.mainBoard.TabStop = false;
            this.mainBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainBoard_MouseDown);
            this.mainBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainBoard_MouseMove);
            this.mainBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainBoard_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "面积为:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "点击三点绘制平行四边形，拖动平行四边形顶点调整面积";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(919, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainBoard);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox mainBoard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

