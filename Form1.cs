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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CustomerICDesignProductSuiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICDesign iCDesignObj = new ICDesign();
            iCDesignObj.Show();
           
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
    
        }

        private void SystemDesignVerificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemDesignVerification SystemDesignVerificationObj = new SystemDesignVerification();
            SystemDesignVerificationObj.Show();
        }

        private void SystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemDesignVerificatioDigitalLogicSimulations SystemDesignDigitalLogicObj = new SystemDesignVerificatioDigitalLogicSimulations();
            SystemDesignDigitalLogicObj.Show(); 
        }

        private void CustomerICDesignProductSuiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ICDesign iCDesignObj = new ICDesign();
            iCDesignObj.Show();
        }

        private void SystemDesignAndVerificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemDesignVerification SystemDesignVerificationObj = new SystemDesignVerification();
            SystemDesignVerificationObj.Show();
        }

        private void DigitalSOCSimulationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemDesignVerificatioDigitalLogicSimulations SystemDesignDigitalLogicObj = new SystemDesignVerificatioDigitalLogicSimulations();
            SystemDesignDigitalLogicObj.Show();
        }

        private void SOCDigitalDesignProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPortfolioSOCProcess ProductPortfolioSOCProcessObj = new ProductPortfolioSOCProcess();
            ProductPortfolioSOCProcessObj.Show();
        }

        private void SOCDigitalDesignProcessToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductPortfolioSOCProcess ProductPortfolioSOCProcessObj = new ProductPortfolioSOCProcess();
            ProductPortfolioSOCProcessObj.Show();
        }

        private void PrintedCircuitBoardDesignAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintedCircuitBoardDesignAnalysis PrintedCircuitBoardDesignAnalysisObj = new PrintedCircuitBoardDesignAnalysis();
            PrintedCircuitBoardDesignAnalysisObj.Show();
        }

        private void PrintedCircuitBoardDesignAndAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintedCircuitBoardDesignAnalysis PrintedCircuitBoardDesignAnalysisObj = new PrintedCircuitBoardDesignAnalysis();
            PrintedCircuitBoardDesignAnalysisObj.Show();
        }

        private void EmbeddedSWIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmbeddedSWIPPortfolio EmbeddedSWIPPortfolioObj = new EmbeddedSWIPPortfolio();
            EmbeddedSWIPPortfolioObj.Show();
        }

        private void EmbeddedSWIPPortfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmbeddedSWIPPortfolio EmbeddedSWIPPortfolioObj = new EmbeddedSWIPPortfolio();
            EmbeddedSWIPPortfolioObj.Show();
        }

        private void ICPackageAndSiPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICPackagingSiPProductPortfolio ICPackagingSiPProductPortfolioObj = new ICPackagingSiPProductPortfolio();
            ICPackagingSiPProductPortfolioObj.Show();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ICPackagingSiPProductPortfolio ICPackagingSiPProductPortfolioObj = new ICPackagingSiPProductPortfolio();
            ICPackagingSiPProductPortfolioObj.Show();
        }
    }
}
