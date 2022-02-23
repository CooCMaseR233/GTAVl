using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTAVl
{
    public partial class Men : Form
    {
        public Men()
        {
            InitializeComponent();
        }

        private void btnGrandpa_Click(object sender, EventArgs e)
        {
            grandpa grandpa = new grandpa();
            grandpa.Show();
            this.Hide();
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
