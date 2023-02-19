
namespace HiddenScreen
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.背景色BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.画像IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.最大化MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.元のサイズに戻すRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.最前面に表示TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.閉じるCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.変更CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.背景色BToolStripMenuItem,
            this.画像IToolStripMenuItem,
            this.toolStripSeparator1,
            this.最大化MToolStripMenuItem,
            this.元のサイズに戻すRToolStripMenuItem,
            this.toolStripSeparator2,
            this.最前面に表示TToolStripMenuItem,
            this.toolStripSeparator3,
            this.バージョン情報AToolStripMenuItem,
            this.閉じるCToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 198);
            // 
            // 背景色BToolStripMenuItem
            // 
            this.背景色BToolStripMenuItem.Name = "背景色BToolStripMenuItem";
            this.背景色BToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.背景色BToolStripMenuItem.Text = "背景色 (&B)";
            this.背景色BToolStripMenuItem.Click += new System.EventHandler(this.背景色BToolStripMenuItem_Click);
            // 
            // 画像IToolStripMenuItem
            // 
            this.画像IToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.変更CToolStripMenuItem,
            this.削除DToolStripMenuItem});
            this.画像IToolStripMenuItem.Name = "画像IToolStripMenuItem";
            this.画像IToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.画像IToolStripMenuItem.Text = "画像 (&I)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // 最大化MToolStripMenuItem
            // 
            this.最大化MToolStripMenuItem.Name = "最大化MToolStripMenuItem";
            this.最大化MToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.最大化MToolStripMenuItem.Text = "最大化 (&M)";
            this.最大化MToolStripMenuItem.Click += new System.EventHandler(this.最大化MToolStripMenuItem_Click);
            // 
            // 元のサイズに戻すRToolStripMenuItem
            // 
            this.元のサイズに戻すRToolStripMenuItem.Name = "元のサイズに戻すRToolStripMenuItem";
            this.元のサイズに戻すRToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.元のサイズに戻すRToolStripMenuItem.Text = "元のサイズに戻す (&R)";
            this.元のサイズに戻すRToolStripMenuItem.Click += new System.EventHandler(this.元のサイズに戻すRToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // 最前面に表示TToolStripMenuItem
            // 
            this.最前面に表示TToolStripMenuItem.Name = "最前面に表示TToolStripMenuItem";
            this.最前面に表示TToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.最前面に表示TToolStripMenuItem.Text = "最前面に表示 (&T)";
            this.最前面に表示TToolStripMenuItem.Click += new System.EventHandler(this.最前面に表示TToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // 閉じるCToolStripMenuItem
            // 
            this.閉じるCToolStripMenuItem.Name = "閉じるCToolStripMenuItem";
            this.閉じるCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.閉じるCToolStripMenuItem.Text = "閉じる (&C)";
            this.閉じるCToolStripMenuItem.Click += new System.EventHandler(this.閉じるCToolStripMenuItem_Click);
            // 
            // 変更CToolStripMenuItem
            // 
            this.変更CToolStripMenuItem.Name = "変更CToolStripMenuItem";
            this.変更CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.変更CToolStripMenuItem.Text = "変更(&C)...";
            this.変更CToolStripMenuItem.Click += new System.EventHandler(this.変更CToolStripMenuItem_Click);
            // 
            // 削除DToolStripMenuItem
            // 
            this.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem";
            this.削除DToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.削除DToolStripMenuItem.Text = "削除(&D)";
            this.削除DToolStripMenuItem.Click += new System.EventHandler(this.削除DToolStripMenuItem_Click);
            // 
            // バージョン情報AToolStripMenuItem
            // 
            this.バージョン情報AToolStripMenuItem.Name = "バージョン情報AToolStripMenuItem";
            this.バージョン情報AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.バージョン情報AToolStripMenuItem.Text = "バージョン情報(&A)";
            this.バージョン情報AToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報AToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 背景色BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 画像IToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 最大化MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 元のサイズに戻すRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 最前面に表示TToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 閉じるCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 変更CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 削除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報AToolStripMenuItem;
    }
}

