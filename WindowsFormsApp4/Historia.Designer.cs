namespace WindowsFormsApp4
{
    partial class Historia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historia));
            this.dataDataSet = new WindowsFormsApp4.DataDataSet();
            this.dataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wymianyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wymianyTableAdapter = new WindowsFormsApp4.DataDataSetTableAdapters.WymianyTableAdapter();
            this.wymianyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Usuń = new WindowsFormsControlLibrary1.BunifuThinButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wymianyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wymianyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "DataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataDataSetBindingSource
            // 
            this.dataDataSetBindingSource.DataSource = this.dataDataSet;
            this.dataDataSetBindingSource.Position = 0;
            // 
            // wymianyBindingSource
            // 
            this.wymianyBindingSource.DataMember = "Wymiany";
            this.wymianyBindingSource.DataSource = this.dataDataSetBindingSource;
            // 
            // wymianyTableAdapter
            // 
            this.wymianyTableAdapter.ClearBeforeFill = true;
            // 
            // wymianyBindingSource1
            // 
            this.wymianyBindingSource1.DataMember = "Wymiany";
            this.wymianyBindingSource1.DataSource = this.dataDataSetBindingSource;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Swis721 Ex BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(554, 289);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Swis721 Ex BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(43, 53);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(248, 22);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Twoja historia zmian:";
            // 
            // Usuń
            // 
            this.Usuń.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Usuń.BackgroundImage")));
            this.Usuń.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Usuń.ButtonText = "Usuń";
            this.Usuń.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Usuń.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Usuń.ForeColorHoverState = System.Drawing.Color.White;
            this.Usuń.Iconimage = null;
            this.Usuń.IconVisible = true;
            this.Usuń.IconZoom = 90D;
            this.Usuń.ImageIconOverlay = false;
            this.Usuń.Location = new System.Drawing.Point(349, 39);
            this.Usuń.Name = "Usuń";
            this.Usuń.Size = new System.Drawing.Size(184, 36);
            this.Usuń.TabIndex = 2;
            this.Usuń.Click += new System.EventHandler(this.Usuń_Click_1);
            // 
            // Historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.Usuń);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.listBox1);
            this.Name = "Historia";
            this.Size = new System.Drawing.Size(557, 457);
            this.Load += new System.EventHandler(this.Historia_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wymianyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wymianyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource wymianyBindingSource;
        private System.Windows.Forms.BindingSource dataDataSetBindingSource;
        private DataDataSet dataDataSet;
        private DataDataSetTableAdapters.WymianyTableAdapter wymianyTableAdapter;
        private System.Windows.Forms.BindingSource wymianyBindingSource1;
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuThinButton Usuń;
    }
}
