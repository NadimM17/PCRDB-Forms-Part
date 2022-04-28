using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;

namespace Princess_Connect_Unit_Viewer
{
    public partial class MainForm : Form
    {
        public static List<string> Tags = new List<string>();
        dynamic fullCharaList;
        public const string APIurl = "https://localhost:5001/api/PCRDB";
        public MainForm()
        {
            InitializeComponent();
            charList.Text = "Select a character...";
            string AllUnitsJSON = new WebClient().DownloadString($"{APIurl}/GetUnits");
            fullCharaList = JsonConvert.DeserializeObject<dynamic>(AllUnitsJSON);
            for(int i = 0; i < fullCharaList.Count; i++)
            {
                charList.Items.Add(fullCharaList[i]["Name"].ToString());
            }
        }

        private void charList_SelectedValueChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < charList.Items.Count; i++)
            {
                if(fullCharaList[i]["Name"].ToString() == charList.SelectedItem.ToString())
                {
                    atkTypeTB.Text = fullCharaList[i]["Type"].ToString();
                    posTB.Text = fullCharaList[i]["Position"].ToString();
                    iconPb.ImageLocation = fullCharaList[i]["Icon"].ToString();
                    fullCard.ImageLocation = fullCharaList[i]["FullImage"].ToString();
                }
            }
        }

        private void summerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show new form with filtered icons clickable and return to old form
            if(Application.OpenForms["FilteredView"] != null)
            {
                MessageBox.Show("Filtered View is already opened, please close it before opening a separate one.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                FilteredView fv = new FilteredView();
                fv.Show();
                string SummerUnitsJSON = new WebClient().DownloadString($"{APIurl}/Events/GetSummerUnits");
                fullCharaList = JsonConvert.DeserializeObject<dynamic>(SummerUnitsJSON);
                for (int i = 0; i < fullCharaList.Count; i++)
                {
                    Image img = Image.FromFile(fullCharaList[i]["Icon"].ToString());
                    Tags.Add(fullCharaList[i]["Name"].ToString());
                    FilteredView.il.Images.Add(img);
                }
                PictureBox[] pics = new PictureBox[FilteredView.il.Images.Count];
                for (int i = 0; i < FilteredView.il.Images.Count; i++)
                {
                    pics[i] = new PictureBox();
                    pics[i].Size = new Size(128, 128);
                    pics[i].Location = new Point(128 * i);
                    pics[i].Image = FilteredView.il.Images[i];
                    pics[i].Tag = Tags[i];
                    pics[i].Click += FilteredView.pictures_Click;
                }
                FilteredView.p1.Controls.AddRange(pics);
            }
        }

        private void halloweenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FilteredView"] != null)
            {
                MessageBox.Show("Filtered View is already opened, please close it before opening a separate one.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                FilteredView fv = new FilteredView();
                fv.Show();
                string HalloweenUnitsJSON = new WebClient().DownloadString($"{APIurl}/Events/GetHalloweenUnits");
                fullCharaList = JsonConvert.DeserializeObject<dynamic>(HalloweenUnitsJSON);
                for (int i = 0; i < fullCharaList.Count; i++)
                {
                    Image img = Image.FromFile(fullCharaList[i]["Icon"].ToString());
                    Tags.Add(fullCharaList[i]["Name"].ToString());
                    FilteredView.il.Images.Add(img);
                }
                PictureBox[] pics = new PictureBox[FilteredView.il.Images.Count];
                for (int i = 0; i < FilteredView.il.Images.Count; i++)
                {
                    pics[i] = new PictureBox();
                    pics[i].Size = new Size(128, 128);
                    pics[i].Location = new Point(128 * i);
                    pics[i].Image = FilteredView.il.Images[i];
                    pics[i].Tag = Tags[i];
                    pics[i].Click += FilteredView.pictures_Click;
                }
                FilteredView.p1.Controls.AddRange(pics);
            }
        }

        private void holidayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FilteredView"] != null)
            {
                MessageBox.Show("Filtered View is already opened, please close it before opening a separate one.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                FilteredView fv = new FilteredView();
                fv.Show();
                string HolidayUnitsJSON = new WebClient().DownloadString($"{APIurl}/Events/GetHolidayUnits");
                fullCharaList = JsonConvert.DeserializeObject<dynamic>(HolidayUnitsJSON);
                for(int i = 0; i < fullCharaList.Count; i++)
                {
                    Image img = Image.FromFile(fullCharaList[i]["Icon"].ToString());
                    Tags.Add(fullCharaList[i]["Name"].ToString());
                    FilteredView.il.Images.Add(img);
                }
                PictureBox[] pics = new PictureBox[FilteredView.il.Images.Count];
                for (int i = 0; i < FilteredView.il.Images.Count; i++)
                {
                    pics[i] = new PictureBox();
                    pics[i].Size = new Size(128, 128);
                    pics[i].Location = new Point(128 * i);
                    pics[i].Image = FilteredView.il.Images[i];
                    pics[i].Tag = Tags[i];
                    pics[i].Click += FilteredView.pictures_Click;
                }
                FilteredView.p1.Controls.AddRange(pics);
            }
        }

        private void newYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FilteredView"] != null)
            {
                MessageBox.Show("Filtered View is already opened, please close it before opening a separate one.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                FilteredView fv = new FilteredView();
                fv.Show();
                string NewYearUnitsJSON = new WebClient().DownloadString($"{APIurl}/Events/GetNewYearUnits");
                fullCharaList = JsonConvert.DeserializeObject<dynamic>(NewYearUnitsJSON);
                for (int i = 0; i < fullCharaList.Count; i++)
                {
                    Image img = Image.FromFile(fullCharaList[i]["Icon"].ToString());
                    Tags.Add(fullCharaList[i]["Name"].ToString());
                    FilteredView.il.Images.Add(img);
                }
                PictureBox[] pics = new PictureBox[FilteredView.il.Images.Count];
                for (int i = 0; i < FilteredView.il.Images.Count; i++)
                {
                    pics[i] = new PictureBox();
                    pics[i].Size = new Size(128, 128);
                    pics[i].Location = new Point(128 * i);
                    pics[i].Image = FilteredView.il.Images[i];
                    pics[i].Tag = Tags[i];
                    pics[i].Click += FilteredView.pictures_Click;
                }
                FilteredView.p1.Controls.AddRange(pics);
            }
        }

        private void valentineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FilteredView"] != null)
            {
                MessageBox.Show("Filtered View is already opened, please close it before opening a separate one.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                FilteredView fv = new FilteredView();
                fv.Show();
                string ValentineUnitsJSON = new WebClient().DownloadString($"{APIurl}/Events/GetValentineUnits");
                fullCharaList = JsonConvert.DeserializeObject<dynamic>(ValentineUnitsJSON);
                for (int i = 0; i < fullCharaList.Count; i++)
                {
                    Image img = Image.FromFile(fullCharaList[i]["Icon"].ToString());
                    Tags.Add(fullCharaList[i]["Name"].ToString());
                    FilteredView.il.Images.Add(img);
                }
                PictureBox[] pics = new PictureBox[FilteredView.il.Images.Count];
                for (int i = 0; i < FilteredView.il.Images.Count; i++)
                {
                    pics[i] = new PictureBox();
                    pics[i].Size = new Size(128, 128);
                    pics[i].Location = new Point(128 * i);
                    pics[i].Image = FilteredView.il.Images[i];
                    pics[i].Tag = Tags[i];
                    pics[i].Click += FilteredView.pictures_Click;
                }
                FilteredView.p1.Controls.AddRange(pics);
            }
        }

        private void ooedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FilteredView"] != null)
            {
                MessageBox.Show("Filtered View is already opened, please close it before opening a separate one.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                FilteredView fv = new FilteredView();
                fv.Show();
                string OedoUnitsJSON = new WebClient().DownloadString($"{APIurl}/Events/GetOedoUnits");
                fullCharaList = JsonConvert.DeserializeObject<dynamic>(OedoUnitsJSON);
                for (int i = 0; i < fullCharaList.Count; i++)
                {
                    Image img = Image.FromFile(fullCharaList[i]["Icon"].ToString());
                    Tags.Add(fullCharaList[i]["Name"].ToString());
                    FilteredView.il.Images.Add(img);
                }
                PictureBox[] pics = new PictureBox[FilteredView.il.Images.Count];
                for (int i = 0; i < FilteredView.il.Images.Count; i++)
                {
                    pics[i] = new PictureBox();
                    pics[i].Size = new Size(128, 128);
                    pics[i].Location = new Point(128 * i);
                    pics[i].Image = FilteredView.il.Images[i];
                    pics[i].Tag = Tags[i];
                    pics[i].Click += FilteredView.pictures_Click;
                }
                FilteredView.p1.Controls.AddRange(pics);
            }
        }

        private void addUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Only do this if you're a SA", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                confirmationForm cf = new confirmationForm();
                cf.ShowDialog();
            }
            else
                return;
        }
    }
}