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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            stylemanager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroLabel1.ForeColor = Color.White;
            this.Refresh();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            stylemanager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel1.ForeColor = Color.Black;
            this.Refresh();
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
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stylemanager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroLabel1.ForeColor = Color.White;
            this.Refresh();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
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
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, chattextbox.Text);
        }

        private void sfd_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

