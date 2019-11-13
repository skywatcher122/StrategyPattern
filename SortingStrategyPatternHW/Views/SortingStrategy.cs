using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortingStrategyPatternHW.Controllers;
namespace SortingStrategyPatternHW.Views
{
    public partial class SortingStrategy : Form
    {
        public SortingStrategy()
        {
            InitializeComponent();
            cboSort.SelectedIndex = 0;
            this.Text = "Sorting Application : " + cboSort.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var SSCon = new SortingStrategyController();
                txtOutput.Text = SSCon.Sorting(txtInput.Text, cboSort.SelectedIndex);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = "Sorting Application : " + cboSort.Text;
            txtOutput.Clear();
        }
    }
}
