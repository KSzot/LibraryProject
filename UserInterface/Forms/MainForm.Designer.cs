namespace UserInterface.Forms
{
    partial class MainForm
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
            this.tabControlTop = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.buttonHuman = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.buttonBook = new System.Windows.Forms.Button();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabControlTop.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTop
            // 
            this.tabControlTop.Controls.Add(this.tabPageGeneral);
            this.tabControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlTop.Location = new System.Drawing.Point(0, 0);
            this.tabControlTop.Name = "tabControlTop";
            this.tabControlTop.SelectedIndex = 0;
            this.tabControlTop.Size = new System.Drawing.Size(834, 77);
            this.tabControlTop.TabIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.buttonBook);
            this.tabPageGeneral.Controls.Add(this.splitter1);
            this.tabPageGeneral.Controls.Add(this.buttonHuman);
            this.tabPageGeneral.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 23);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(826, 50);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Ogólne";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // buttonHuman
            // 
            this.buttonHuman.BackColor = System.Drawing.Color.White;
            this.buttonHuman.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonHuman.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuman.Image = global::UserInterface.Properties.Resources.man32;
            this.buttonHuman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHuman.Location = new System.Drawing.Point(3, 3);
            this.buttonHuman.Name = "buttonHuman";
            this.buttonHuman.Size = new System.Drawing.Size(112, 44);
            this.buttonHuman.TabIndex = 1;
            this.buttonHuman.Text = "Klienci";
            this.buttonHuman.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHuman.UseVisualStyleBackColor = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(115, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 44);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.White;
            this.buttonBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBook.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBook.Image = global::UserInterface.Properties.Resources.open_book32;
            this.buttonBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBook.Location = new System.Drawing.Point(118, 3);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(118, 44);
            this.buttonBook.TabIndex = 3;
            this.buttonBook.Text = "Zbiory";
            this.buttonBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBook.UseVisualStyleBackColor = false;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelVersion,
            this.toolStripStatusLabelUser});
            this.statusStripMain.Location = new System.Drawing.Point(0, 529);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(834, 22);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelVersion
            // 
            this.toolStripStatusLabelVersion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelVersion.Name = "toolStripStatusLabelVersion";
            this.toolStripStatusLabelVersion.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabelVersion.Text = "Wersja: 1.0.0";
            // 
            // toolStripStatusLabelUser
            // 
            this.toolStripStatusLabelUser.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelUser.Image = global::UserInterface.Properties.Resources.man;
            this.toolStripStatusLabelUser.Name = "toolStripStatusLabelUser";
            this.toolStripStatusLabelUser.Size = new System.Drawing.Size(132, 17);
            this.toolStripStatusLabelUser.Text = "Użytkownik: Krystian";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlMain.Location = new System.Drawing.Point(0, 77);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(834, 452);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 551);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.tabControlTop);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControlTop.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTop;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.Button buttonHuman;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUser;
        private System.Windows.Forms.TabControl tabControlMain;
    }
}