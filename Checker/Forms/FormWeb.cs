using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checker.Forms
{
    public partial class FormWeb : Form
    {
        public FormWeb()
        {
            InitializeComponent();
        }

        private void btnXone_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://xone.fun");
        }
    }
}
