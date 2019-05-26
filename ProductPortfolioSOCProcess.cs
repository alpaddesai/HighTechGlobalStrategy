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
    public partial class ProductPortfolioSOCProcess : Form
    {
        public ProductPortfolioSOCProcess()
        {
            InitializeComponent();
        }

        private void ProductPortfolioSOCProcess_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ProductPortfolioSOCProcess_Load_1(object sender, EventArgs e)
        {

        }

        private void DigitalDesignProcess_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cadence.com/content/cadence-www/global/en_US/home/tools/digital-design-and-signoff.html");

        }
    }
}
