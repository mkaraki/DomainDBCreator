namespace DomainDBCreator
{
    partial class Menu
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
            this.tbox_dbpath = new System.Windows.Forms.TextBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbox_dbpath
            // 
            this.tbox_dbpath.Location = new System.Drawing.Point(12, 24);
            this.tbox_dbpath.Name = "tbox_dbpath";
            this.tbox_dbpath.Size = new System.Drawing.Size(435, 19);
            this.tbox_dbpath.TabIndex = 0;
            this.tbox_dbpath.Text = "Z:\\Projects\\domaindb\\db";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(372, 73);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Open DB";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "DB Path";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 108);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.tbox_dbpath);
            this.Name = "Menu";
            this.Text = "domain db Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_dbpath;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label label1;
    }
}

