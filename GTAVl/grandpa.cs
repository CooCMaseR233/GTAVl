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
    public partial class grandpa : Form
    {
        public grandpa()
        {
            InitializeComponent();
        }

        private void btnReality_Click(object sender, EventArgs e)
        {
            reality reality = new reality();
            reality.Show();
            this.Hide();
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
