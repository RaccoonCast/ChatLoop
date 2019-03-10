using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading; 

namespace chatloop_HOT_UI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int lineNumber = 0;
        private int result;
        public Form1()
        {
            InitializeComponent();

            this.StyleManager = stylemanager1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stylemanager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroLabel1.ForeColor = Color.White;
            delaylabel.ForeColor = Color.White;
            this.chattextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(96)))), ((int)(((byte)(83)))));
            this.chattextbox.ForeColor = System.Drawing.Color.White;
            this.chattextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msvalue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(96)))), ((int)(((byte)(83)))));
            this.msvalue.ForeColor = System.Drawing.Color.White;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stopbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.savefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.savefile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.presetload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.presetload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            //  this.msvalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Refresh();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            stylemanager1.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            stylemanager1.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            stylemanager1.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            stylemanager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel1.ForeColor = Color.Black;
            delaylabel.ForeColor = Color.Black;
            this.chattextbox.BackColor = System.Drawing.Color.White;
            this.chattextbox.ForeColor = System.Drawing.Color.Black;
            this.chattextbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.msvalue.BackColor = System.Drawing.Color.White;
            this.msvalue.ForeColor = System.Drawing.Color.Black;
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stopbutton.BackColor = System.Drawing.Color.Silver;
            this.stopbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startbutton.BackColor = System.Drawing.Color.Silver;
            this.startbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.savefile.BackColor = System.Drawing.Color.Silver;
            this.savefile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.presetload.BackColor = System.Drawing.Color.Silver;
            this.presetload.ForeColor = System.Drawing.SystemColors.ControlText;
            // this.msvalue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stylemanager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroLabel1.ForeColor = Color.White;
            delaylabel.ForeColor = Color.White;
            this.chattextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(96)))), ((int)(((byte)(83)))));
            this.chattextbox.ForeColor = System.Drawing.Color.White;
            this.chattextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msvalue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(96)))), ((int)(((byte)(83)))));
            this.msvalue.ForeColor = System.Drawing.Color.White;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stopbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.savefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.savefile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.presetload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.presetload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            //  this.msvalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Refresh();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1250);
            lineNumber = 0;
            delayValue.Enabled = true;
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            delayValue.Enabled = false;
        }

        private void msvalue_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(msvalue.Text, out result))
            {
                if (int.Parse(msvalue.Text) > 0)
                {
                    delayValue.Interval = Convert.ToInt32(msvalue.Text);
                }
            }
            else
            {
                delayValue.Interval = Convert.ToInt32(10);
            }

        }

        private void delayValue_Tick(object sender, EventArgs e)
        {
            try
            {
                string text = (chattextbox.Lines[(this.lineNumber)]);
                Clipboard.SetText(text);
                SendKeys.Send("^{v}");
                SendKeys.Send("{ENTER}");
                lineNumber += 1;
            }
            catch (Exception)
            {
                lineNumber = 0;
            }
        }

        private void chattextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void presetload_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    chattextbox.Text = filetext;
                }
            }
        }

        private void savefile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            // if you want to add text name saveFileDialog.FileName = "Preset.txt";  
            saveFileDialog.Filter = "Preset File | *.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (
                    // this is what ur parents mean when they say don't touch -- don't touch code
                    Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(chattextbox.Text);

                }

            }
        }

        private void sfd_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void delaylabel_Click(object sender, EventArgs e)
        {

        }
    }
}

