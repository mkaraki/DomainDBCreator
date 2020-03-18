namespace DomainDBCreator
{
    partial class DBView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.lbox_items = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbox_reportdate = new System.Windows.Forms.TextBox();
            this.tbox_reporter = new System.Windows.Forms.TextBox();
            this.tbox_ownerurl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_fqdn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_desc = new System.Windows.Forms.TextBox();
            this.tbox_owner = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbox_search, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbox_items, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(266, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbox_search
            // 
            this.tbox_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_search.Location = new System.Drawing.Point(3, 3);
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.Size = new System.Drawing.Size(260, 19);
            this.tbox_search.TabIndex = 0;
            this.tbox_search.TextChanged += new System.EventHandler(this.tbox_search_TextChanged);
            // 
            // lbox_items
            // 
            this.lbox_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_items.FormattingEnabled = true;
            this.lbox_items.ItemHeight = 12;
            this.lbox_items.Location = new System.Drawing.Point(3, 31);
            this.lbox_items.Name = "lbox_items";
            this.lbox_items.Size = new System.Drawing.Size(260, 384);
            this.lbox_items.TabIndex = 1;
            this.lbox_items.SelectedIndexChanged += new System.EventHandler(this.lbox_items_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_delete, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_add, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 421);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(260, 26);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete.Location = new System.Drawing.Point(3, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(124, 20);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add.Location = new System.Drawing.Point(133, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(124, 20);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tbox_reportdate, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.tbox_reporter, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbox_ownerurl, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbox_fqdn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.tbox_desc, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.tbox_owner, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_save, 1, 6);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(530, 450);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tbox_reportdate
            // 
            this.tbox_reportdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_reportdate.Location = new System.Drawing.Point(83, 115);
            this.tbox_reportdate.Name = "tbox_reportdate";
            this.tbox_reportdate.Size = new System.Drawing.Size(444, 19);
            this.tbox_reportdate.TabIndex = 5;
            // 
            // tbox_reporter
            // 
            this.tbox_reporter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_reporter.Location = new System.Drawing.Point(83, 87);
            this.tbox_reporter.Name = "tbox_reporter";
            this.tbox_reporter.Size = new System.Drawing.Size(444, 19);
            this.tbox_reporter.TabIndex = 4;
            // 
            // tbox_ownerurl
            // 
            this.tbox_ownerurl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_ownerurl.Location = new System.Drawing.Point(83, 59);
            this.tbox_ownerurl.Name = "tbox_ownerurl";
            this.tbox_ownerurl.Size = new System.Drawing.Size(444, 19);
            this.tbox_ownerurl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "FQDN";
            // 
            // tbox_fqdn
            // 
            this.tbox_fqdn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_fqdn.Location = new System.Drawing.Point(83, 3);
            this.tbox_fqdn.Name = "tbox_fqdn";
            this.tbox_fqdn.Size = new System.Drawing.Size(444, 19);
            this.tbox_fqdn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Owner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Owner URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Reporter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Report Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Description";
            // 
            // tbox_desc
            // 
            this.tbox_desc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_desc.Location = new System.Drawing.Point(83, 143);
            this.tbox_desc.Multiline = true;
            this.tbox_desc.Name = "tbox_desc";
            this.tbox_desc.Size = new System.Drawing.Size(444, 270);
            this.tbox_desc.TabIndex = 6;
            // 
            // tbox_owner
            // 
            this.tbox_owner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_owner.Location = new System.Drawing.Point(83, 31);
            this.tbox_owner.Name = "tbox_owner";
            this.tbox_owner.Size = new System.Drawing.Size(444, 19);
            this.tbox_owner.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save.Location = new System.Drawing.Point(83, 419);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(444, 28);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // DBView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DBView";
            this.Text = "DBView";
            this.Shown += new System.EventHandler(this.DBView_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.ListBox lbox_items;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_fqdn;
        private System.Windows.Forms.TextBox tbox_reportdate;
        private System.Windows.Forms.TextBox tbox_reporter;
        private System.Windows.Forms.TextBox tbox_ownerurl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_desc;
        private System.Windows.Forms.TextBox tbox_owner;
        private System.Windows.Forms.Button btn_save;
    }
}