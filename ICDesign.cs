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
    public partial class ICDesign : Form
    {
        public ICDesign()
        {
            InitializeComponent();
        }

        private void ICDesign_Load(object sender, EventArgs e)
        {

        }

        private void VirtuosoSystemDesignPlatform_Click(object sender, EventArgs e)
        {
         System.Diagnostics.Process.Start("https://www.cadence.com/content/cadence-www/global/en_US/home/tools/ic-package-design-and-analysis/ic-package-design-flows/virtuoso-system-design-platform.html");
        }
    }
}
