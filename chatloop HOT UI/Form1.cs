using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Button3_Click(object sender, EventArgs e)
        {
            DelayValue.Enabled = false;
        }
       private void Button4_Click(object sender, EventArgs e)
        {
            DelayValue.Enabled = true;
        }
        private void DelayValue_Tick(object sender, EventArgs e)
        {
            try
            {
                string textcheck = (ChatLoopText.Lines[(this.lineNumber)]);
                if (string.IsNullOrEmpty(textcheck))
                {
                    lineNumber = 0;
                }
                string text = (ChatLoopText.Lines[(this.lineNumber)]);
                Clipboard.SetText(text);
                SendKeys.Send("^{v}");
                SendKeys.Send("{ENTER}");
                lineNumber = lineNumber + 1;
            }
            catch (Exception)
            {
                lineNumber = 0;
            }
        }

        private void ChatLoopText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DelayValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
