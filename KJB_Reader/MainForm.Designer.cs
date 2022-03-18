namespace KJB_Reader
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.cbBook = new System.Windows.Forms.ToolStripComboBox();
            this.cbChapter = new System.Windows.Forms.ToolStripComboBox();
            this.cmdPreviousChapter = new System.Windows.Forms.ToolStripButton();
            this.cmdNextChapter = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.menu.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(401, 25);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedSearchToolStripMenuItem});
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // advancedSearchToolStripMenuItem
            // 
            this.advancedSearchToolStripMenuItem.Name = "advancedSearchToolStripMenuItem";
            this.advancedSearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.advancedSearchToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.advancedSearchToolStripMenuItem.Text = "Advanced &Search";
            this.advancedSearchToolStripMenuItem.Click += new System.EventHandler(this.advancedSearchToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // richText
            // 
            this.richText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richText.Location = new System.Drawing.Point(0, 59);
            this.richText.Name = "richText";
            this.richText.ReadOnly = true;
            this.richText.Size = new System.Drawing.Size(401, 550);
            this.richText.TabIndex = 1;
            this.richText.Text = "";
            this.richText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richText_KeyDown);
            this.richText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richText_KeyPress);
            // 
            // toolBar
            // 
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbBook,
            this.cbChapter,
            this.cmdPreviousChapter,
            this.cmdNextChapter,
            this.txtSearch});
            this.toolBar.Location = new System.Drawing.Point(0, 25);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(401, 25);
            this.toolBar.TabIndex = 2;
            this.toolBar.Text = "toolStrip1";
            // 
            // cbBook
            // 
            this.cbBook.AutoSize = false;
            this.cbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBook.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBook.MaxDropDownItems = 30;
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(130, 25);
            this.cbBook.SelectedIndexChanged += new System.EventHandler(this.cbBook_SelectedIndexChanged);
            // 
            // cbChapter
            // 
            this.cbChapter.AutoSize = false;
            this.cbChapter.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbChapter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbChapter.MaxDropDownItems = 30;
            this.cbChapter.Name = "cbChapter";
            this.cbChapter.Size = new System.Drawing.Size(45, 25);
            this.cbChapter.SelectedIndexChanged += new System.EventHandler(this.cbChapter_SelectedIndexChanged);
            this.cbChapter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbChapter_KeyPress);
            // 
            // cmdPreviousChapter
            // 
            this.cmdPreviousChapter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdPreviousChapter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdPreviousChapter.Image = ((System.Drawing.Image)(resources.GetObject("cmdPreviousChapter.Image")));
            this.cmdPreviousChapter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPreviousChapter.Name = "cmdPreviousChapter";
            this.cmdPreviousChapter.Size = new System.Drawing.Size(23, 22);
            this.cmdPreviousChapter.Text = "⯇";
            this.cmdPreviousChapter.ToolTipText = "Previous chapter";
            this.cmdPreviousChapter.Click += new System.EventHandler(this.cmdPreviousChapter_Click);
            // 
            // cmdNextChapter
            // 
            this.cmdNextChapter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdNextChapter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdNextChapter.Image = ((System.Drawing.Image)(resources.GetObject("cmdNextChapter.Image")));
            this.cmdNextChapter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNextChapter.Name = "cmdNextChapter";
            this.cmdNextChapter.Size = new System.Drawing.Size(23, 22);
            this.cmdNextChapter.Text = "⯈";
            this.cmdNextChapter.ToolTipText = "Next chapter";
            this.cmdNextChapter.Click += new System.EventHandler(this.cmdNextChapter_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoSize = false;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 25);
            this.txtSearch.ToolTipText = "• Verse number\r\n• Verse reference\r\n• Search for words\r\n   (case-sensitive search:" +
    "\r\n     -> type uppercase or \"_\")";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 609);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "King James Bible - Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private RichTextBox richText;
        private ToolStrip toolBar;
        private ToolStripComboBox cbBook;
        private ToolStripComboBox cbChapter;
        private ToolStripButton cmdPreviousChapter;
        private ToolStripButton cmdNextChapter;
        private ToolStripTextBox txtSearch;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem advancedSearchToolStripMenuItem;
    }
}