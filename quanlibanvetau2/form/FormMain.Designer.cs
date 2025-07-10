namespace quanlibanvetau2.form
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip1 = new MenuStrip();
            quảnLíToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            hànhKháchToolStripMenuItem = new ToolStripMenuItem();
            véTàuToolStripMenuItem = new ToolStripMenuItem();
            chuyếnTàuToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLíToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1540, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLíToolStripMenuItem
            // 
            quảnLíToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nhânViênToolStripMenuItem, tàiKhoảnToolStripMenuItem, hànhKháchToolStripMenuItem, véTàuToolStripMenuItem, chuyếnTàuToolStripMenuItem, thốngKêToolStripMenuItem });
            quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            quảnLíToolStripMenuItem.Size = new Size(116, 36);
            quảnLíToolStripMenuItem.Text = "Quản Lí";
            quảnLíToolStripMenuItem.Click += quảnLíToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(359, 44);
            nhânViênToolStripMenuItem.Text = "Nhân Viên ";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(359, 44);
            tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            tàiKhoảnToolStripMenuItem.Click += tàiKhoảnToolStripMenuItem_Click;
            // 
            // hànhKháchToolStripMenuItem
            // 
            hànhKháchToolStripMenuItem.Name = "hànhKháchToolStripMenuItem";
            hànhKháchToolStripMenuItem.Size = new Size(359, 44);
            hànhKháchToolStripMenuItem.Text = "Hành Khách";
            hànhKháchToolStripMenuItem.Click += hànhKháchToolStripMenuItem_Click;
            // 
            // véTàuToolStripMenuItem
            // 
            véTàuToolStripMenuItem.Name = "véTàuToolStripMenuItem";
            véTàuToolStripMenuItem.Size = new Size(359, 44);
            véTàuToolStripMenuItem.Text = "Vé Tàu";
            véTàuToolStripMenuItem.Click += véTàuToolStripMenuItem_Click;
            // 
            // chuyếnTàuToolStripMenuItem
            // 
            chuyếnTàuToolStripMenuItem.Name = "chuyếnTàuToolStripMenuItem";
            chuyếnTàuToolStripMenuItem.Size = new Size(359, 44);
            chuyếnTàuToolStripMenuItem.Text = "Chuyến Tàu";
            chuyếnTàuToolStripMenuItem.Click += chuyếnTàuToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(359, 44);
            thốngKêToolStripMenuItem.Text = "Thống Kê";
            thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(140, 36);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            hệThốngToolStripMenuItem.Click += hệThốngToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(259, 44);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(259, 44);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1540, 825);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "FormMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLíToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem hànhKháchToolStripMenuItem;
        private ToolStripMenuItem véTàuToolStripMenuItem;
        private ToolStripMenuItem chuyếnTàuToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
    }
}