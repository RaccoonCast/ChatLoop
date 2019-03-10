namespace chatloop_HOT_UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stylemanager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chattextbox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.delayValue = new System.Windows.Forms.Timer(this.components);
            this.startbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.msvalue = new System.Windows.Forms.TextBox();
            this.savefile = new System.Windows.Forms.Button();
            this.presetload = new System.Windows.Forms.Button();
            this.safeFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.delaylabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.stylemanager1)).BeginInit();
            this.SuspendLayout();
            // 
            // stylemanager1
            // 
            this.stylemanager1.Owner = null;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(735, 329);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Theme";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // chattextbox
            // 
            this.chattextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.chattextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chattextbox.ForeColor = System.Drawing.Color.Black;
            this.chattextbox.Location = new System.Drawing.Point(23, 63);
            this.chattextbox.Name = "chattextbox";
            this.chattextbox.Size = new System.Drawing.Size(678, 376);
            this.chattextbox.TabIndex = 5;
            this.chattextbox.Text = "";
            this.chattextbox.TextChanged += new System.EventHandler(this.chattextbox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(710, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Light";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(710, 380);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Dark";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // delayValue
            // 
            this.delayValue.Interval = 1000;
            this.delayValue.Tick += new System.EventHandler(this.delayValue_Tick);
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startbutton.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startbutton.Location = new System.Drawing.Point(712, 185);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(96, 52);
            this.startbutton.TabIndex = 8;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopbutton.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stopbutton.Location = new System.Drawing.Point(712, 243);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(96, 52);
            this.stopbutton.TabIndex = 9;
            this.stopbutton.Text = "Stop";
            this.stopbutton.UseVisualStyleBackColor = false;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // msvalue
            // 
            this.msvalue.BackColor = System.Drawing.Color.White;
            this.msvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msvalue.Location = new System.Drawing.Point(708, 149);
            this.msvalue.Name = "msvalue";
            this.msvalue.Size = new System.Drawing.Size(100, 20);
            this.msvalue.TabIndex = 10;
            this.msvalue.TextChanged += new System.EventHandler(this.msvalue_TextChanged);
            // 
            // savefile
            // 
            this.savefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.savefile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savefile.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savefile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.savefile.Location = new System.Drawing.Point(710, 92);
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(97, 23);
            this.savefile.TabIndex = 12;
            this.savefile.Text = "Save Preset";
            this.savefile.UseVisualStyleBackColor = false;
            this.savefile.Click += new System.EventHandler(this.savefile_Click);
            // 
            // presetload
            // 
            this.presetload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.presetload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.presetload.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.presetload.Location = new System.Drawing.Point(710, 63);
            this.presetload.Name = "presetload";
            this.presetload.Size = new System.Drawing.Size(97, 23);
            this.presetload.TabIndex = 14;
            this.presetload.Text = "Load Preset";
            this.presetload.UseVisualStyleBackColor = false;
            this.presetload.Click += new System.EventHandler(this.presetload_Click);
            // 
            // safeFileDialog
            // 
            this.safeFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.sfd_FileOk);
            // 
            // delaylabel
            // 
            this.delaylabel.AutoSize = true;
            this.delaylabel.BackColor = System.Drawing.Color.Transparent;
            this.delaylabel.ForeColor = System.Drawing.Color.Black;
            this.delaylabel.Location = new System.Drawing.Point(726, 127);
            this.delaylabel.Name = "delaylabel";
            this.delaylabel.Size = new System.Drawing.Size(70, 19);
            this.delaylabel.TabIndex = 15;
            this.delaylabel.Text = "Delay (ms)";
            this.delaylabel.UseCustomBackColor = true;
            this.delaylabel.UseCustomForeColor = true;
            this.delaylabel.UseStyleColors = true;
            this.delaylabel.Click += new System.EventHandler(this.delaylabel_Click);
            // 
            // Form1
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 462);
            this.Controls.Add(this.delaylabel);
            this.Controls.Add(this.presetload);
            this.Controls.Add(this.savefile);
            this.Controls.Add(this.msvalue);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chattextbox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "ChatLoop ";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stylemanager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager stylemanager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.RichTextBox chattextbox;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer delayValue;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.TextBox msvalue;
        private System.Windows.Forms.Button savefile;
        private System.Windows.Forms.Button presetload;
        private System.Windows.Forms.SaveFileDialog safeFileDialog;
        public MetroFramework.Controls.MetroLabel delaylabel;
    }
}

