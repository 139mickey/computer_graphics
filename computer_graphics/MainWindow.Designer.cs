
using 道格拉斯算法;
using System.Windows.Forms;
using System;

namespace Graphical_presentation
{
    partial class MainWindow
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
            int TabIndex = 0;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl1.Font = new System.Drawing.Font("宋体", 13, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            //this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();

            // 
            // tabControl1 add pages
            // 
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 705);
            this.tabControl1.TabIndex = 0;
            // 
            // 点与线段位置关系RelationOfPointLinePage
            // 
            this.tabPageRelationOfPointLine = new 点与线段位置关系.RelationOfPointLinePage();
            this.tabPageRelationOfPointLine.Location = new System.Drawing.Point(4, 22);
            this.tabPageRelationOfPointLine.Name = "tabPageRelationOfPointLine";
            this.tabPageRelationOfPointLine.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRelationOfPointLine.Size = new System.Drawing.Size(949, 679);
            this.tabPageRelationOfPointLine.TabIndex = TabIndex++;
            this.tabPageRelationOfPointLine.Text = "点与线段位置关系";
            this.tabPageRelationOfPointLine.UseVisualStyleBackColor = true;
            this.tabControl1.Controls.Add(this.tabPageRelationOfPointLine);

            // 
            // 两线段位置关系判断.RelationshipOfTwoLinePage
            // 
            this.tabPageRelationshipOfTwoLine = new 两线段位置关系判断.RelationshipOfTwoLinePage();
            this.tabPageRelationshipOfTwoLine.Location = new System.Drawing.Point(4, 22);
            this.tabPageRelationshipOfTwoLine.Name = "tabPageRelationshipOfTwoLine";
            this.tabPageRelationshipOfTwoLine.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRelationshipOfTwoLine.Size = new System.Drawing.Size(949, 679);
            this.tabPageRelationshipOfTwoLine.TabIndex = TabIndex++;
            this.tabPageRelationshipOfTwoLine.Text = "两线段位置关系";
            this.tabPageRelationshipOfTwoLine.UseVisualStyleBackColor = true;
            this.tabControl1.Controls.Add(this.tabPageRelationshipOfTwoLine);

            // 
            // 点与简单多边形_三角形_位置关系页面
            // 
            this.tabPagePosition = new 点与简单多边形_三角形_位置关系.PositionPage();
            this.tabPagePosition.Location = new System.Drawing.Point(4, 22);
            this.tabPagePosition.Name = "tabPagePosition";
            this.tabPagePosition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePosition.Size = new System.Drawing.Size(949, 679);
            this.tabPagePosition.TabIndex = TabIndex++;
            this.tabPagePosition.Text = "点与三角形位置关系";
            this.tabPagePosition.UseVisualStyleBackColor = true;
            this.tabControl1.Controls.Add(this.tabPagePosition);

            // 
            // 任意多边形面积PolygonAreaPage
            // 
            this.tabPagePolygonArea = new 任意多边形面积.PolygonAreaPage();
            this.tabPagePolygonArea.Location = new System.Drawing.Point(4, 22);
            this.tabPagePolygonArea.Name = "tabPagePolygonArea";
            this.tabPagePolygonArea.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePolygonArea.Size = new System.Drawing.Size(949, 679);
            this.tabPagePolygonArea.TabIndex = TabIndex++;
            this.tabPagePolygonArea.Text = "任意多边形面积";
            this.tabPagePolygonArea.UseVisualStyleBackColor = true;
            this.tabControl1.Controls.Add(this.tabPagePolygonArea);

            // 
            // 平行四边演示页面
            // 
            this.tabPageParallelogram = new 平行四边形的图形绘制与面积.ParallelogramPage();
            this.tabPageParallelogram.Name = "tabPageParallelogram";
            this.tabPageParallelogram.Text = "平行四边面积";
            this.tabPageParallelogram.Location = new System.Drawing.Point(4, 22);
            this.tabPageParallelogram.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageParallelogram.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParallelogram.Size = new System.Drawing.Size(949, 679);
            this.tabPageParallelogram.TabIndex = TabIndex++;
            this.tabControl1.Controls.Add(this.tabPageParallelogram);

            // 
            // 道格拉斯线段压缩页面
            // 
            this.tabPageDouglass = new 道格拉斯算法.DouglassFormDemo();
            this.tabPageDouglass.Name = "tabPageDouglass";
            this.tabPageDouglass.Text = "线段压缩";
            this.tabPageDouglass.Location = new System.Drawing.Point(4, 22);
            this.tabPageDouglass.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDouglass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDouglass.Size = new System.Drawing.Size(949, 679);
            this.tabPageDouglass.TabIndex = TabIndex++;
            this.tabControl1.Controls.Add(this.tabPageDouglass);

            this.tabControl1.SelectedIndex = TabIndex-1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 729);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "图形演示";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;

        private System.Windows.Forms.TabPage tabPageRelationOfPointLine;
        private System.Windows.Forms.TabPage tabPagePosition;
        private System.Windows.Forms.TabPage tabPagePolygonArea;
        private System.Windows.Forms.TabPage tabPageRelationshipOfTwoLine;
        private System.Windows.Forms.TabPage tabPageParallelogram;
        private System.Windows.Forms.TabPage tabPageDouglass;
    }
}

