namespace Console_Manager
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cjenovnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konzoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.održavanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.managerToolStripMenuItem,
            this.cjenovnikToolStripMenuItem,
            this.konzoleToolStripMenuItem,
            this.održavanjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.korisniciToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj Korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.managerToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.managerToolStripMenuItem.Text = "Aplikacija";
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // cjenovnikToolStripMenuItem
            // 
            this.cjenovnikToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cjenovnikToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cjenovnikToolStripMenuItem.Name = "cjenovnikToolStripMenuItem";
            this.cjenovnikToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.cjenovnikToolStripMenuItem.Text = "Cjenovnik";
            this.cjenovnikToolStripMenuItem.Click += new System.EventHandler(this.cjenovnikToolStripMenuItem_Click);
            // 
            // konzoleToolStripMenuItem
            // 
            this.konzoleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.konzoleToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.konzoleToolStripMenuItem.Name = "konzoleToolStripMenuItem";
            this.konzoleToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.konzoleToolStripMenuItem.Text = "Konzole";
            this.konzoleToolStripMenuItem.Click += new System.EventHandler(this.konzoleToolStripMenuItem_Click);
            // 
            // održavanjeToolStripMenuItem
            // 
            this.održavanjeToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.održavanjeToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.održavanjeToolStripMenuItem.Name = "održavanjeToolStripMenuItem";
            this.održavanjeToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.održavanjeToolStripMenuItem.Text = "Održavanje";
            this.održavanjeToolStripMenuItem.Click += new System.EventHandler(this.održavanjeToolStripMenuItem_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 245);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Manager";
            this.ShowIcon = false;
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_FormClosing);
            this.Load += new System.EventHandler(this.Manager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cjenovnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konzoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem održavanjeToolStripMenuItem;
    }
}