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
    public partial class PrintedCircuitBoardDesignAnalysis : Form
    {
        public PrintedCircuitBoardDesignAnalysis()
        {
            InitializeComponent();
        }

        private void PrintedCircuitBoardDesignAnalysis_Load(object sender, EventArgs e)
        {

        }

        private void PCBDesignAnalysis_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cadence.com/content/cadence-www/global/en_US/home/tools/pcb-design-and-analysis.html");
        }
    }
}
