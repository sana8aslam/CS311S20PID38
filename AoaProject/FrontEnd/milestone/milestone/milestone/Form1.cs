using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milestone
{
    public partial class Form1 : Form
    {
        List<Panel> listpanel = new List<Panel>();
        int index;

        List<string> listFiles = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            listFiles.Clear();
            listView.Items.Clear();
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                    foreach (string item in Directory.GetFiles(fbd.SelectedPath))
                    {
                        imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                        FileInfo fi = new FileInfo(item);
                        listFiles.Add(fi.FullName);
                        listView.Items.Add(fi.Name, imageList.Images.Count - 1);

                    }
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listpanel.Add(panel1);
            listpanel.Add(panel2);
            listpanel.Add(panel3);
            listpanel.Add(panel4);
            listpanel.Add(panel5);
            listpanel.Add(panel6);
            listpanel[index].BringToFront();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (index < listpanel.Count - 1)
                listpanel[++index].BringToFront();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listpanel[--index].BringToFront();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

