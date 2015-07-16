namespace TestConnection
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.crystalReportViewer4 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TBORACLE = new System.Windows.Forms.TextBox();
            this.TBINSTANCE = new System.Windows.Forms.TextBox();
            this.TBOID = new System.Windows.Forms.TextBox();
            this.MTBPASS = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RTBBODY = new System.Windows.Forms.RichTextBox();
            this.TBAKA = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TBTO = new System.Windows.Forms.TextBox();
            this.TBFROM = new System.Windows.Forms.TextBox();
            this.TBSUBJECT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CBLSC = new System.Windows.Forms.CheckBox();
            this.TBSMTP = new System.Windows.Forms.TextBox();
            this.TBPORT = new System.Windows.Forms.TextBox();
            this.TBID = new System.Windows.Forms.TextBox();
            this.MBTPASS = new System.Windows.Forms.MaskedTextBox();
            this.CBSSL = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AlarmTog = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NUDHor = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NUDSec = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBHour = new System.Windows.Forms.TextBox();
            this.TBSeco = new System.Windows.Forms.TextBox();
            this.TBMinu = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSec)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer4
            // 
            this.crystalReportViewer4.ActiveViewIndex = -1;
            this.crystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer4.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer4.Location = new System.Drawing.Point(3, 15);
            this.crystalReportViewer4.Name = "crystalReportViewer4";
            this.crystalReportViewer4.Size = new System.Drawing.Size(1466, 730);
            this.crystalReportViewer4.TabIndex = 1;
            this.crystalReportViewer4.Load += new System.EventHandler(this.crystalReportViewer4_Load);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Location = new System.Drawing.Point(12, 49);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1483, 774);
            this.tab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.TBAKA);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.TBTO);
            this.tabPage1.Controls.Add(this.TBFROM);
            this.tabPage1.Controls.Add(this.TBSUBJECT);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.AlarmTog);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1475, 748);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Email";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TBORACLE);
            this.groupBox5.Controls.Add(this.TBINSTANCE);
            this.groupBox5.Controls.Add(this.TBOID);
            this.groupBox5.Controls.Add(this.MTBPASS);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Location = new System.Drawing.Point(30, 298);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(279, 212);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Orcale Server Configuration (Crystal Report)";
            // 
            // TBORACLE
            // 
            this.TBORACLE.Location = new System.Drawing.Point(105, 29);
            this.TBORACLE.Name = "TBORACLE";
            this.TBORACLE.Size = new System.Drawing.Size(168, 20);
            this.TBORACLE.TabIndex = 8;
            // 
            // TBINSTANCE
            // 
            this.TBINSTANCE.Location = new System.Drawing.Point(105, 62);
            this.TBINSTANCE.Name = "TBINSTANCE";
            this.TBINSTANCE.Size = new System.Drawing.Size(168, 20);
            this.TBINSTANCE.TabIndex = 7;
            // 
            // TBOID
            // 
            this.TBOID.Location = new System.Drawing.Point(105, 98);
            this.TBOID.Name = "TBOID";
            this.TBOID.Size = new System.Drawing.Size(168, 20);
            this.TBOID.TabIndex = 6;
            // 
            // MTBPASS
            // 
            this.MTBPASS.Location = new System.Drawing.Point(105, 130);
            this.MTBPASS.Name = "MTBPASS";
            this.MTBPASS.Size = new System.Drawing.Size(168, 20);
            this.MTBPASS.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "PASSWORD";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "INSTANCE";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "SERVER";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(339, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 30);
            this.button3.TabIndex = 23;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RTBBODY);
            this.groupBox4.Location = new System.Drawing.Point(334, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 255);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message body";
            // 
            // RTBBODY
            // 
            this.RTBBODY.Location = new System.Drawing.Point(5, 16);
            this.RTBBODY.Name = "RTBBODY";
            this.RTBBODY.Size = new System.Drawing.Size(334, 232);
            this.RTBBODY.TabIndex = 0;
            this.RTBBODY.Text = "";
            // 
            // TBAKA
            // 
            this.TBAKA.Location = new System.Drawing.Point(576, 6);
            this.TBAKA.Name = "TBAKA";
            this.TBAKA.Size = new System.Drawing.Size(102, 20);
            this.TBAKA.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(546, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "AKA";
            // 
            // TBTO
            // 
            this.TBTO.Location = new System.Drawing.Point(389, 41);
            this.TBTO.Name = "TBTO";
            this.TBTO.Size = new System.Drawing.Size(289, 20);
            this.TBTO.TabIndex = 17;
            // 
            // TBFROM
            // 
            this.TBFROM.Location = new System.Drawing.Point(389, 6);
            this.TBFROM.Name = "TBFROM";
            this.TBFROM.Size = new System.Drawing.Size(153, 20);
            this.TBFROM.TabIndex = 18;
            // 
            // TBSUBJECT
            // 
            this.TBSUBJECT.Location = new System.Drawing.Point(389, 71);
            this.TBSUBJECT.Name = "TBSUBJECT";
            this.TBSUBJECT.Size = new System.Drawing.Size(289, 20);
            this.TBSUBJECT.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(332, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "SUBJECT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "TO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "FROM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CBLSC);
            this.groupBox3.Controls.Add(this.TBSMTP);
            this.groupBox3.Controls.Add(this.TBPORT);
            this.groupBox3.Controls.Add(this.TBID);
            this.groupBox3.Controls.Add(this.MBTPASS);
            this.groupBox3.Controls.Add(this.CBSSL);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(30, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 212);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SMTP Server Configuration";
            // 
            // CBLSC
            // 
            this.CBLSC.AutoSize = true;
            this.CBLSC.Location = new System.Drawing.Point(105, 103);
            this.CBLSC.Name = "CBLSC";
            this.CBLSC.Size = new System.Drawing.Size(144, 17);
            this.CBLSC.TabIndex = 9;
            this.CBLSC.Text = "LOCK SERVER CONFIG";
            this.CBLSC.UseVisualStyleBackColor = true;
            // 
            // TBSMTP
            // 
            this.TBSMTP.Location = new System.Drawing.Point(105, 29);
            this.TBSMTP.Name = "TBSMTP";
            this.TBSMTP.Size = new System.Drawing.Size(168, 20);
            this.TBSMTP.TabIndex = 8;
            // 
            // TBPORT
            // 
            this.TBPORT.Location = new System.Drawing.Point(105, 62);
            this.TBPORT.Name = "TBPORT";
            this.TBPORT.Size = new System.Drawing.Size(168, 20);
            this.TBPORT.TabIndex = 7;
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(105, 138);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(168, 20);
            this.TBID.TabIndex = 6;
            // 
            // MBTPASS
            // 
            this.MBTPASS.Location = new System.Drawing.Point(105, 170);
            this.MBTPASS.Name = "MBTPASS";
            this.MBTPASS.Size = new System.Drawing.Size(168, 20);
            this.MBTPASS.TabIndex = 5;
            // 
            // CBSSL
            // 
            this.CBSSL.AutoSize = true;
            this.CBSSL.Location = new System.Drawing.Point(8, 103);
            this.CBSSL.Name = "CBSSL";
            this.CBSSL.Size = new System.Drawing.Size(82, 17);
            this.CBSSL.TabIndex = 4;
            this.CBSSL.Text = "SSL Enable";
            this.CBSSL.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "PASSWORD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "PORT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "SMTP SERVER";
            // 
            // AlarmTog
            // 
            this.AlarmTog.AutoSize = true;
            this.AlarmTog.Location = new System.Drawing.Point(238, 3);
            this.AlarmTog.Name = "AlarmTog";
            this.AlarmTog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AlarmTog.Size = new System.Drawing.Size(71, 17);
            this.AlarmTog.TabIndex = 7;
            this.AlarmTog.Text = "Timer ON";
            this.AlarmTog.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NUDHor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NUDMin);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NUDSec);
            this.groupBox2.Location = new System.Drawing.Point(146, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 54);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Timer";
            // 
            // NUDHor
            // 
            this.NUDHor.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.NUDHor.Location = new System.Drawing.Point(9, 21);
            this.NUDHor.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NUDHor.Name = "NUDHor";
            this.NUDHor.Size = new System.Drawing.Size(40, 20);
            this.NUDHor.TabIndex = 5;
            this.NUDHor.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // NUDMin
            // 
            this.NUDMin.Location = new System.Drawing.Point(61, 20);
            this.NUDMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUDMin.Name = "NUDMin";
            this.NUDMin.Size = new System.Drawing.Size(40, 20);
            this.NUDMin.TabIndex = 6;
            this.NUDMin.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // NUDSec
            // 
            this.NUDSec.Location = new System.Drawing.Point(115, 20);
            this.NUDSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUDSec.Name = "NUDSec";
            this.NUDSec.Size = new System.Drawing.Size(40, 20);
            this.NUDSec.TabIndex = 6;
            this.NUDSec.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBHour);
            this.groupBox1.Controls.Add(this.TBSeco);
            this.groupBox1.Controls.Add(this.TBMinu);
            this.groupBox1.Location = new System.Drawing.Point(29, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 54);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // TBHour
            // 
            this.TBHour.Location = new System.Drawing.Point(5, 21);
            this.TBHour.Name = "TBHour";
            this.TBHour.Size = new System.Drawing.Size(25, 20);
            this.TBHour.TabIndex = 1;
            // 
            // TBSeco
            // 
            this.TBSeco.Location = new System.Drawing.Point(82, 21);
            this.TBSeco.Name = "TBSeco";
            this.TBSeco.Size = new System.Drawing.Size(25, 20);
            this.TBSeco.TabIndex = 3;
            // 
            // TBMinu
            // 
            this.TBMinu.Location = new System.Drawing.Point(43, 21);
            this.TBMinu.Name = "TBMinu";
            this.TBMinu.Size = new System.Drawing.Size(25, 20);
            this.TBMinu.TabIndex = 2;
            this.TBMinu.TextChanged += new System.EventHandler(this.TBMinu_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.crystalReportViewer4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1475, 748);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(540, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(413, 26);
            this.label17.TabIndex = 3;
            this.label17.Text = "Envoi de rapports crystal via e-mails  ";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1507, 835);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSec)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.Button button2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer4;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox RTBBODY;
        private System.Windows.Forms.TextBox TBAKA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBTO;
        private System.Windows.Forms.TextBox TBFROM;
        private System.Windows.Forms.TextBox TBSUBJECT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox CBLSC;
        private System.Windows.Forms.TextBox TBSMTP;
        private System.Windows.Forms.TextBox TBPORT;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.MaskedTextBox MBTPASS;
        private System.Windows.Forms.CheckBox CBSSL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox AlarmTog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown NUDHor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUDMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUDSec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBHour;
        private System.Windows.Forms.TextBox TBSeco;
        private System.Windows.Forms.TextBox TBMinu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TBORACLE;
        private System.Windows.Forms.TextBox TBINSTANCE;
        private System.Windows.Forms.TextBox TBOID;
        private System.Windows.Forms.MaskedTextBox MTBPASS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

