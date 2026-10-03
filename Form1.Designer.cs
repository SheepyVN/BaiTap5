namespace BaiTap7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStrip toolStrip;
        private RichTextBox richText;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel wordCountLabel;
        private ToolStripComboBox cmbFonts;
        private ToolStripComboBox cmbSizes;
        private ToolStripButton newButton;
        private ToolStripButton openButton;
        private ToolStripButton saveButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            systemMenu = new ToolStripMenuItem();
            newMenuItem = new ToolStripMenuItem();
            openMenuItem = new ToolStripMenuItem();
            saveMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            formatMenu = new ToolStripMenuItem();
            fontMenuItem = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            newButton = new ToolStripButton();
            openButton = new ToolStripButton();
            saveButton = new ToolStripButton();
            cmbFonts = new ToolStripComboBox();
            cmbSizes = new ToolStripComboBox();
            boldButton = new ToolStripButton();
            italicButton = new ToolStripButton();
            underlineButton = new ToolStripButton();
            richText = new RichTextBox();
            statusStrip = new StatusStrip();
            wordCountLabel = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { systemMenu, formatMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(850, 24);
            menuStrip.TabIndex = 2;
            // 
            // systemMenu
            // 
            systemMenu.DropDownItems.AddRange(new ToolStripItem[] { newMenuItem, openMenuItem, saveMenuItem, exitMenuItem });
            systemMenu.Name = "systemMenu";
            systemMenu.Size = new Size(69, 20);
            systemMenu.Text = "Hệ thống";
            systemMenu.Click += systemMenu_Click;
            // 
            // newMenuItem
            // 
            newMenuItem.Name = "newMenuItem";
            newMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newMenuItem.Size = new Size(248, 22);
            newMenuItem.Text = "📄  Tạo văn bản mới";
            newMenuItem.Click += newMenuItem_Click;
            // 
            // openMenuItem
            // 
            openMenuItem.Name = "openMenuItem";
            openMenuItem.Size = new Size(248, 22);
            openMenuItem.Text = "📂  Mở tập tin";
            openMenuItem.Click += openMenuItem_Click;
            // 
            // saveMenuItem
            // 
            saveMenuItem.Name = "saveMenuItem";
            saveMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveMenuItem.Size = new Size(248, 22);
            saveMenuItem.Text = "💾  Lưu nội dung văn bản";
            saveMenuItem.Click += saveMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(248, 22);
            exitMenuItem.Text = "Thoát";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // formatMenu
            // 
            formatMenu.DropDownItems.AddRange(new ToolStripItem[] { fontMenuItem });
            formatMenu.Name = "formatMenu";
            formatMenu.Size = new Size(74, 20);
            formatMenu.Text = "Định dạng";
            // 
            // fontMenuItem
            // 
            fontMenuItem.Name = "fontMenuItem";
            fontMenuItem.Size = new Size(107, 22);
            fontMenuItem.Text = "Font...";
            fontMenuItem.Click += fontMenuItem_Click;
            // 
            // toolStrip
            // 
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Items.AddRange(new ToolStripItem[] { newButton, openButton, saveButton, cmbFonts, cmbSizes, boldButton, italicButton, underlineButton });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(850, 25);
            toolStrip.TabIndex = 1;
            // 
            // newButton
            // 
            newButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            newButton.Font = new Font("Segoe UI Emoji", 9F);
            newButton.Name = "newButton";
            newButton.Size = new Size(27, 22);
            newButton.Text = "📄";
            newButton.ToolTipText = "Tạo văn bản mới";
            newButton.Click += newMenuItem_Click;
            // 
            // openButton
            // 
            openButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            openButton.Font = new Font("Segoe UI Emoji", 9F);
            openButton.Name = "openButton";
            openButton.Size = new Size(27, 22);
            openButton.Text = "📂";
            openButton.ToolTipText = "Mở tập tin";
            openButton.Click += openMenuItem_Click;
            // 
            // saveButton
            // 
            saveButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveButton.Font = new Font("Segoe UI Emoji", 9F);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(27, 22);
            saveButton.Text = "💾";
            saveButton.ToolTipText = "Lưu nội dung văn bản";
            saveButton.Click += saveMenuItem_Click;
            // 
            // cmbFonts
            // 
            cmbFonts.AutoSize = false;
            cmbFonts.Name = "cmbFonts";
            cmbFonts.Size = new Size(180, 23);
            cmbFonts.SelectedIndexChanged += cmbFonts_SelectedIndexChanged;
            // 
            // cmbSizes
            // 
            cmbSizes.AutoSize = false;
            cmbSizes.Name = "cmbSizes";
            cmbSizes.Size = new Size(65, 23);
            cmbSizes.SelectedIndexChanged += cmbSizes_SelectedIndexChanged;
            // 
            // boldButton
            // 
            boldButton.CheckOnClick = true;
            boldButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            boldButton.Name = "boldButton";
            boldButton.Size = new Size(23, 22);
            boldButton.Text = "B";
            boldButton.ToolTipText = "Đậm";
            boldButton.Click += boldButton_Click;
            // 
            // italicButton
            // 
            italicButton.CheckOnClick = true;
            italicButton.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            italicButton.Name = "italicButton";
            italicButton.Size = new Size(23, 22);
            italicButton.Text = "I";
            italicButton.ToolTipText = "Nghiêng";
            italicButton.Click += italicButton_Click;
            // 
            // underlineButton
            // 
            underlineButton.CheckOnClick = true;
            underlineButton.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            underlineButton.Name = "underlineButton";
            underlineButton.Size = new Size(23, 22);
            underlineButton.Text = "U";
            underlineButton.ToolTipText = "Gạch chân";
            underlineButton.Click += underlineButton_Click;
            // 
            // richText
            // 
            richText.AcceptsTab = true;
            richText.Dock = DockStyle.Fill;
            richText.Location = new Point(0, 49);
            richText.Name = "richText";
            richText.Size = new Size(850, 429);
            richText.TabIndex = 0;
            richText.Text = "";
            richText.SelectionChanged += richText_SelectionChanged;
            richText.TextChanged += richText_TextChanged;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { wordCountLabel });
            statusStrip.Location = new Point(0, 478);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(850, 22);
            statusStrip.TabIndex = 3;
            // 
            // wordCountLabel
            // 
            wordCountLabel.Name = "wordCountLabel";
            wordCountLabel.Size = new Size(46, 17);
            wordCountLabel.Text = "Số từ: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 500);
            Controls.Add(richText);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            Controls.Add(statusStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Soạn thảo văn bản";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ToolStripMenuItem systemMenu;
        private ToolStripMenuItem newMenuItem;
        private ToolStripMenuItem openMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem formatMenu;
        private ToolStripMenuItem fontMenuItem;
        private ToolStripButton boldButton;
        private ToolStripButton italicButton;
        private ToolStripButton underlineButton;
    }
}
