using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormMemberSystem x = new FormMemberSystem();
            x.MdiParent = this;
            x.WindowState = FormWindowState.Maximized;
            x.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 關閉目前視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild!=null)
            this.ActiveMdiChild.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormRecipeSystem x = new FormRecipeSystem();
            x.MdiParent = this;
            x.WindowState = FormWindowState.Maximized;
            x.Show();
        }

        private void 關閉所有視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin L= new FormLogin();
            L.ShowDialog();
        }
    }
}
