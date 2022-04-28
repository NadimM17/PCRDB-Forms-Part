using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Princess_Connect_Unit_Viewer
{
    public partial class FilteredView : Form
    {
        public static ImageList il;
        public static Panel p1;
        public FilteredView()
        {
            InitializeComponent();
            il = imageList1;
            p1 = panel1;
        }
        public static void pictures_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.GetType().GetProperty("Tag").GetValue(sender).ToString());
        }

        private void FilteredView_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Tags.Clear();
        }
    }
}
