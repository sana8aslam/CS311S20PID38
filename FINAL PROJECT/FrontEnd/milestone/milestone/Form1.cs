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

        public static class Items
        {
            public static string Item;
        }
        // List<string> listFiles = new List<string>();
        public Form1()
        {
            InitializeComponent();
            button1.MouseEnter += OnMouseEnterButton;
            button1.MouseLeave += OnMouseLeaveButton;

        }

         private void OnMouseEnterButton(object sender, EventArgs e)
         {
             button6.BackColor = SystemColors.ButtonHighlight; // or Color.Red or whatever you want
             button7.BackColor = SystemColors.ButtonHighlight; // or Color.Red or whatever you want
         }
         private void OnMouseLeaveButton(object sender, EventArgs e)
         {
             button6.BackColor = SystemColors.ButtonFace;
             button7.BackColor = SystemColors.ButtonFace;
         }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Text File(.txt)|*.txt";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string item in ofd.FileNames)
                {
                    listBoxPath.Items.Add(item);
                    Items.Item = item;
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

            for (int i = 0; i < listpanel.Count; i++)
            {
                listpanel[i].Visible = false;
                listpanel[i].SendToBack();
            }
            listpanel[0].Visible = true;
            listpanel[0].BringToFront();


        }

        private void Button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red; // or Color.Red or whatever you want
           // button7.BackColor = SystemColors.ButtonFace;
            //panel1.Hide();
            //panel2.Hide();
            //panel4.Hide();
            //panel5.Hide();

            //panel3.Show();
            //panel3.Visible = true;
            //panel3.BringToFront();
            //panel3.Enabled = true;

            // panel4.BringToFront();
            if (index < listpanel.Count - 1)
            {
                ++index;

                for (int i = 0; i < listpanel.Count; i++)
                {
                    if (i != index)
                    {
                        listpanel[i].Visible = false;
                        listpanel[i].SendToBack();
                    }
                    else
                    {
                        listpanel[i].Visible = true;
                        listpanel[i].BringToFront();

                    }
                }
                
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red; // or Color.Red or whatever you want
           // button6.BackColor = SystemColors.ButtonFace;

            if (index > 0)
            {
                --index;

                for (int i = 0; i < listpanel.Count; i++)
                {
                    if (i != index)
                    {
                        listpanel[i].Visible = false;
                        listpanel[i].SendToBack();
                    }
                    else
                    {
                        listpanel[i].Visible = true;
                        listpanel[i].BringToFront();

                    }
                }
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Node> Nodes;
            Tree tree = new Tree();
            String filename = listBoxPath.Text ;
            //file = filename;
           // FileInfo f = new FileInfo(filename);


            Nodes = tree.CalculateFrequency(filename);

            tree.PrintFrequency(Nodes);
            tree.BuildTree(Nodes);
            tree.setHuffcode("", Nodes[0]);
            tree.Ascii("", Nodes[0]);
            tree.Filewrite(Nodes[0]);

            //tree.Filewrite(nodeList[0]);
            tree.Printcode(Nodes[0]);

            tree.Hufftree(0, Nodes[0]);
            tree.compressFile(0, Nodes[0]);
            tree.extension();

            this.Close();
            Application.Exit();
        }
    }
}
    

