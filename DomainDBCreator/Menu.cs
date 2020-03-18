using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomainDBCreator
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(tbox_dbpath.Text))
            {
                MessageBox.Show("No DB");
                return;
            }

            string dir = System.IO.Path.GetFullPath(tbox_dbpath.Text);

            DBView dbv = new DBView(dir);
            dbv.ShowDialog();
        }
    }
}
