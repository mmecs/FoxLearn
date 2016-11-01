using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroWaitForm
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        void Save()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(20);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (var waitForm = new frmWaitForm(Save))
            {
                waitForm.ShowDialog(this);
                MessageBox.Show("", "");
            }
        }
    }
}
