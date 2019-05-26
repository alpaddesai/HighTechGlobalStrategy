using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadencePublicProductPortfolio
{
    public partial class EmbeddedSWIPPortfolio : Form
    {
        public EmbeddedSWIPPortfolio()
        {
            InitializeComponent();
        }

        private void EmbeddedSWIPPortfolio_Load(object sender, EventArgs e)
        {

        }

        private void EmbeddedSoftwareIPPortfolio_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ip.cadence.com/");
        }
    }
}
