using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            arrs.Add(@"C:\Users\Andraos\Downloads\videoplayback-_1_.wav");
            arrs.Add(@"C:\Users\Andraos\Downloads\videoplayback (2).wav");
            roundedPanel1.BackColor = Color.FromArgb(80, 0, 0, 0);
            roundedPanel2.BackColor = Color.FromArgb(120, 0, 0, 0);
        }
        // first_Button
        private void Enter_Pic_Click(object sender, EventArgs e)
        {
            choose_pic();
        }
        // secound_Button
        private void One_Pic_Click(object sender, EventArgs e)
        {
            int selected = 0;
            string path = "";
            roundedPanel2.Controls.Clear();
            for (int i = 0; i < countpic; i++)
            {
                if (statpic[i].Checked == true)
                {
                    path = statpic[i].Text;
                    selected++;
                }
            }
            if(selected == 0)
            {
                MessageBox.Show("You Must Select One Picture at First");
            }
            else if(selected > 1)
            {
                MessageBox.Show($"You Selected : {selected} \n Must Select One Picture");
            }
            else
            {
                pic = new PictureBox();
                pic.Image = Image.FromFile(path);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                roundedPanel2.Controls.Add(pic);
                pic.Dock = DockStyle.Fill;
            }
        }
        // three_Button
        private void Multiple_Pic_Click(object sender, EventArgs e)
        {
            int x = 15, y = 10;
            roundedPanel2.Controls.Clear();
            for (int i = 0; i < countpic; i++)
            {
                if (statpic[i].Checked == true)
                {
                    string path = statpic[i].Text;
                    pic = new PictureBox();
                    pic.Image = Image.FromFile(path);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    roundedPanel2.Controls.Add(pic);
                    pic.Location = new Point(x, y);
                    pic.Size = new Size(150, 100);
                    x += 165;
                    if((x+150) >=600)
                    {
                        x = 15;
                        y += 110;
                    }
                }
            }
        }
        // fourth_Button
        private void All_Pic_Click(object sender, EventArgs e)
        {
            indx = 0;
            pic = new PictureBox();
            timer1.Interval = 1000;
            roundedPanel2.Controls.Clear();
            timer1.Start();
        }
        // five_Button
        private void Close_Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void choose_pic()
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Files";

            openFileDialog1.Multiselect = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    allpic.Add(file);  
                }
                string path = "", name = "";
                for (var i = countpic; i < allpic.Count; i++)
                {
                    path = allpic[i].ToString();
                    name = "";
                    statpic[i] = new CheckBox();
                    statpic[i].Text = path;
                    pic = new PictureBox();
                    l = new Label();
                    rp = new RoundedPanel();
                    // pic
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Size = new Size(60, 90);
                    pic.Image = Image.FromFile(path);
                    // name
                    for (var a = path.Length - 1; a >= 0; a--)
                    {
                        if (path[a] == '\\')
                        {
                            break;
                        }
                        name = path[a] + name;
                    }
                    l.Text = name;
                    l.Font = new Font("Arial", 10, FontStyle.Bold);
                    l.ForeColor = Color.White;
                    roundedPanel3.Controls.Add(l);
                    rp.Controls.Add(pic);
                    rp.Controls.Add(l);
                    rp.Controls.Add(statpic[i]);
                    pic.Dock = DockStyle.Top;
                    l.Location = new Point(1, 100);
                    statpic[i].Location = new Point(60, 130);
                    statpic[i].Size = new Size(10, 10);
                    roundedPanel3.Controls.Add(rp);
                    rp.Location = new Point(6, pois_y);
                    rp.Size = new Size(150, 150);
                    rp.Thickness = 0;
                    rp.Radius = 50;
                    rp.BorderColor = Color.FromArgb(50, 0, 0, 0);
                    pois_y += 160;
                }
                countpic = allpic.Count;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (indx == allpic.Count)
            {
                timer1.Stop();
                roundedPanel2.Controls.Clear();
                return;
            }
            pic.Image = Image.FromFile(allpic[indx++].ToString());
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            roundedPanel2.Controls.Add(pic);
            pic.Dock = DockStyle.Fill;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                for(int i=0;i<countpic;i++)
                {
                    statpic[i].Checked = true;
                }
            }
            else
            {
                for (int i = 0; i < countpic; i++)
                {
                    statpic[i].Checked = false;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            roundedPanel3.Controls.Clear();
            countpic = 0;
            allpic.Clear();
            statpic = new CheckBox[100];
            pois_y = 0;
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            if (button_WOC2.Text == "Play ►")
            {
                s.SoundLocation = arrs[ins].ToString();
                s.Play();
                button_WOC2.Text = "Stop";
            }
            else
            {
                button_WOC2.Text = "Play ►";
                s.Stop();
            }


        }
        SoundPlayer s = new SoundPlayer();
        OpenFileDialog openFileDialog1;
        private ArrayList arrs = new ArrayList();
        private ArrayList allpic = new ArrayList();
        private CheckBox[] statpic = new CheckBox[100];
        Label l;
        PictureBox pic;
        RoundedPanel rp;
        int countpic = 0;
        int pois_y = 8;
        int indx = 0;
        int ins = 0;

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if(ins == 0)
            {
                ins = 1;
                
            }
            else
            {
                ins = 0;
            }
            s.Stop();
            s.SoundLocation = arrs[ins].ToString();
            s.Play();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            if (ins == 0)
            {
                ins = 1;
            }
            else
            {
                ins = 0;
            }
            s.Stop();
            s.SoundLocation = arrs[ins].ToString();
            s.Play();
        }
    }
}
