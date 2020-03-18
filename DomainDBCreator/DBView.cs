using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DomainDBCreator
{
    public partial class DBView : Form
    {
        private string Dir;

        public DBView(string dir)
        {
            InitializeComponent();
            Dir = dir;
        }

        private void tbox_search_TextChanged(object sender, EventArgs e)
        {
        }

        private void DBView_Shown(object sender, EventArgs e)
        {
            var jsis = Directory.GetFiles(Dir, "js.js", SearchOption.AllDirectories);
            foreach (var jsi_path in jsis)
            {
                string rpath = jsi_path.Substring(Dir.Length).TrimStart('\\');
                string dpath = rpath.Substring(0, rpath.Length - 6);
                lbox_items.Items.Add(dpath);
            }
        }

        private void lbox_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearInputs();

            if (lbox_items.SelectedItem == null) return;

            string jsipath = Path.Combine(Dir, lbox_items.SelectedItem.ToString(), "js.js");
            string[] jsils = File.ReadAllLines(jsipath);
            foreach (var jsil in jsils)
            {
                string[] jsiparse1 = jsil.Split('(');
                if (jsiparse1.Length != 2) continue;

                string jsiinfo = jsiparse1[1].TrimEnd(' ', ';', ')').Trim(' ', '"', '\'');

                switch (jsiparse1[0].Trim(' ')) 
                {
                    case "setFQDN":
                        tbox_fqdn.Text = jsiinfo;
                        break;
                    case "setOwner":
                        tbox_owner.Text = jsiinfo;
                        break;
                    case "setOwnerUrl":
                        tbox_ownerurl.Text = jsiinfo;
                        break;
                    case "setReporter":
                        tbox_reporter.Text = jsiinfo;
                        break;
                    case "setReportDate":
                        tbox_reportdate.Text = jsiinfo;
                        break;
                    case "setDescription":
                        tbox_desc.Text = jsiinfo;
                        break;
                }
            }
        }

        private void ClearInputs()
        { 
            tbox_fqdn.Text = string.Empty;
            tbox_owner.Text = string.Empty;
            tbox_ownerurl.Text = string.Empty;
            tbox_reporter.Text = string.Empty;
            tbox_reportdate.Text = string.Empty;
            tbox_desc.Text = string.Empty;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string[] fqdni = tbox_fqdn.Text.Trim(' ').Split('.').Reverse().ToArray();
            string fqdnp = string.Join("\\", fqdni);
            string jsidir = Path.Combine(Dir, fqdnp);
            string jsipath = Path.Combine(Dir, fqdnp, "js.js");
            string jsi = "// js.js for domaindb project." + '\n' +
                $"setFQDN('{tbox_fqdn.Text}')" + '\n' +
                $"setOwner(\"{tbox_owner.Text}\")" + '\n' +
                $"setOwnerUrl(\"{tbox_ownerurl.Text}\")" + '\n' +
                $"setReporter(\"{tbox_reporter.Text}\")" + '\n' +
                $"setReportDate('{tbox_reportdate.Text}')" + '\n' +
                $"setDescription(\"{tbox_desc.Text}\")";

            if (File.Exists(jsipath) && MessageBox.Show($"Overwrite \"{jsipath}\"", "DBView", MessageBoxButtons.YesNo) != DialogResult.Yes )
            {
                return;
            }

            Directory.CreateDirectory(jsidir);
            File.WriteAllText(jsipath, jsi);

            UpdateList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string jsipath = Path.Combine(Dir, lbox_items.SelectedItem.ToString(), "js.js");
            if (MessageBox.Show($"Delete \"{jsipath}\"", "DBView", MessageBoxButtons.YesNo) != DialogResult.Yes )
            {
                return;
            }
            File.Delete(jsipath);

            UpdateList();
        }

        private void UpdateList()
        { 
            lbox_items.Items.Clear();
            DBView_Shown(null, null);
        }
    }
}
