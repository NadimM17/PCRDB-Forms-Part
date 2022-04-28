using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Princess_Connect_Unit_Viewer
{
    public partial class confirmationForm : Form
    {
        public confirmationForm()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if(sapwTB.Text == Properties.Settings.Default.password)
            {
                AddUnitForm auf = new AddUnitForm();
                auf.ShowDialog();
                this.Close();
            }
            else
            {
                this.Close();
                MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
