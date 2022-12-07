using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject.Forms
{
    public partial class klimenkoForm : Form
    {
        public klimenkoForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
