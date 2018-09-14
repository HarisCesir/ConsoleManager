namespace Console_Manager
{
    partial class DodavanjeKonzola
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodavanjeKonzola));
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConsoleDatabaseDataSet = new Console_Manager.ConsoleDatabaseDataSet();
            this.managerTableAdapter = new Console_Manager.ConsoleDatabaseDataSetTableAdapters.managerTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxTV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxKonzole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsoleDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "manager";
            this.managerBindingSource.DataSource = this.ConsoleDatabaseDataSet;
            // 
            // ConsoleDatabaseDataSet
            // 
            this.ConsoleDatabaseDataSet.DataSetName = "ConsoleDatabaseDataSet";
            this.ConsoleDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxTV
            // 
            this.comboBoxTV.BackColor = System.Drawing.Color.Black;
            this.comboBoxTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxTV.ForeColor = System.Drawing.Color.LimeGreen;
            this.comboBoxTV.FormattingEnabled = true;
            this.comboBoxTV.Location = new System.Drawing.Point(110, 25);
            this.comboBoxTV.Name = "comboBoxTV";
            this.comboBoxTV.Size = new System.Drawing.Size(160, 24);
            this.comboBoxTV.TabIndex = 0;
            this.comboBoxTV.Text = "IZBOR ";
            this.comboBoxTV.SelectedIndexChanged += new System.EventHandler(this.comboBoxTV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberi TV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konzola:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(110, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 55);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(447, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "IZBOR KONZOLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(371, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Konzole:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(447, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 55);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxKonzole
            // 
            this.comboBoxKonzole.BackColor = System.Drawing.Color.Black;
            this.comboBoxKonzole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKonzole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxKonzole.ForeColor = System.Drawing.Color.LimeGreen;
            this.comboBoxKonzole.FormattingEnabled = true;
            this.comboBoxKonzole.Location = new System.Drawing.Point(110, 68);
            this.comboBoxKonzole.Name = "comboBoxKonzole";
            this.comboBoxKonzole.Size = new System.Drawing.Size(160, 24);
            this.comboBoxKonzole.TabIndex = 8;
            // 
            // DodavanjeKonzola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 303);
            this.Controls.Add(this.comboBoxKonzole);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTV);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DodavanjeKonzola";
            this.ShowIcon = false;
            this.Text = "Konzole";
            this.Load += new System.EventHandler(this.DodavanjeKonzola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsoleDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource managerBindingSource;
        private ConsoleDatabaseDataSet ConsoleDatabaseDataSet;
        private ConsoleDatabaseDataSetTableAdapters.managerTableAdapter managerTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxTV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxKonzole;
    }
}