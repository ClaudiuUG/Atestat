using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Mut_Daria
{
    public partial class Generic : Form
    {
        public Generic()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Nivel1 f = new Nivel1();
            this.Hide();
            f.ShowDialog();
        }

        private void Generic_Load(object sender, EventArgs e)
        {

        }
    }
}
