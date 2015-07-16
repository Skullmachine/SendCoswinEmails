using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace TestConnection
{
     public partial class Form1 : Form
    {
        ReportDocument cryRpt;

        // private System.Timers.Timer timerClock = new System.Timers.Timer();
        private const int TIMER_INTERVAL = 50;
        private string TimeStamp, CBody, pdf_path;
        private int count;
        private bool MailSent;
        //Email variable
        private string SMTPserver, IDstr, FromEmail, FromName, ToList, Subject, Body, Password, crUserID, crPassword;
        private int Port;
        private bool bSSL;
        //__________________________

        public Form1()
        {
            InitializeComponent();

            //Initialisation du Timer
            timer1.Interval = TIMER_INTERVAL;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Récupération des paramètres du serveur SMTP
            SMTPserver = TBSMTP.Text.ToString();
            IDstr = TBID.Text.ToString();
            Port = int.Parse(TBPORT.Text);
            Password = MBTPASS.Text.ToString();

            //Récupération des paramètres du serveur Oracle
            crUserID = TBOID.Text.ToString();
            crPassword = MTBPASS.Text.ToString();

            //Récupération des informations de l'email à envoyer
            ToList = TBTO.Text.ToString();
            FromEmail = TBFROM.Text.ToString();
            FromName = TBAKA.Text.ToString();
            Subject = TBSUBJECT.Text.ToString();
            Body = RTBBODY.Text.ToString();

            //Activation de SSL ou non
            if (CBSSL.Checked)
                bSSL = true;
            else
                bSSL = false;

            //Affichage de l'heure dans le mail
            //TimeStamp = "\n\n\n\nTimestamp->" + "." + TBHour.Text + "." + TBMinu.Text + "." + TBSeco.Text;
            //Body += TimeStamp;

             //Instancitation de la classe
            Form1 s = new Form1();
            count = 0;
            //Exportation du fichier Crystal Report
            pdf_path = s.exportCrystalReports(crUserID, crPassword);

            //Envoie du mail (Si toujours pas envoyé au bout de 5 essais --> erreur)
           
            while (count < 5)
            {
                MailSent = s.sendMail(bSSL, SMTPserver, IDstr, Port, FromEmail, FromName, ToList, Subject, Body, Password, pdf_path);


                if (MailSent)
                {
                    MessageBox.Show("MAIL SENT! \n\r SUCESS!", "RESULT:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
                else
                {
                    count++;
                }
            }
            if (count > 0)
                MessageBox.Show("MAIL SENDING \n\r FAILED", "RESULT:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool sendMail(bool bSSL,string SMTPserver, string IDstr, int Port,string FromEmail, string FromName, string ToList, string Subject, string Body, string Password, string pdfFile)
        {
            try
            {
                //Paramètrage de l'envoi (Serveur SMTP et PORT)
                SmtpClient smtp = new SmtpClient(SMTPserver, Port);
                smtp.UseDefaultCredentials = true;
                smtp.Timeout = 10000;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                DateTime today = DateTime.Today;

                //Paramétrage de l'email
                Subject = "Rapport journalier du " + today.ToString("dd/MM/yyyy");

                MailMessage Msg = new MailMessage(FromEmail, ToList, Subject, Body);
                Msg.BodyEncoding = UTF8Encoding.UTF8;
                Msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                Msg.Attachments.Add(new Attachment(pdfFile));
                smtp.Send(Msg);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

            
        }

        private string exportCrystalReports(string crUserID, string crPassword)
        {
            //Instanciation des classes permettant l'exportation des données
            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            //Enregistre le chemin du répertoire de sortie du projet --> répertoire de sortie veut dire Debug ou Release
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

            //Répertoire où se trouve le fichier .rpt
            var rptPath = Path.Combine(outPutDirectory, "Reports\\Serveur mail - OT quotidiens.rpt");

            //Cast en chaine de caractere de rptPath
            string rpt_path = new Uri(rptPath).LocalPath;

            //Répertoire où se trouve le PDF envoyé par mail
            var pdfPath = Path.Combine(outPutDirectory, "Reports\\Serveur mail - OT quotidiens.pdf");

            //Cast en chaine de caractere de pdfPath
            string pdf_path = new Uri(pdfPath).LocalPath;

            try
            {
                //Chargement du rapport dans cette instance
                cryRpt.Load(rpt_path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //Paramétres de la base de données
            crConnectionInfo.UserID = crUserID;
            crConnectionInfo.Password = crPassword;

            CrTables = cryRpt.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            try
            {
                crystalReportViewer4.ReportSource = cryRpt;
                crystalReportViewer4.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                //Paramètres d'exportation du fichier .rpt
                ExportOptions CrExportOptions;
                DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                CrDiskFileDestinationOptions.DiskFileName = pdf_path;
                CrExportOptions = cryRpt.ExportOptions;
                {
                    CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                    CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                    CrExportOptions.FormatOptions = CrFormatTypeOptions;
                }
                cryRpt.Export();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return pdf_path;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            //Initialisation du Timer
            TBSeco.Enabled = false;
            TBMinu.Enabled = false;
            TBHour.Enabled = false;
            //_____________________________

            //Initialisation des TextBoxes
            FromEmail = "coswin@magnetimarelli.com";
            FromName = "Coswin";
            ToList = "thibault.artus@external.magnetimarelli.com";
            Subject = "Rapport journalier du " + today.ToString("dd/MM/yyyy");
            Body = String.Format
                (
                "Please, do not reply to this message."
                );
            SMTPserver = "139.128.51.129";
            IDstr = "";

            Port = 25;
            bSSL = false;
            Password = "";

            crUserID = "cossechar";
            crPassword = "cossechar";

            TBSMTP.Text = SMTPserver;
            TBID.Text = IDstr;
            TBPORT.Text = Port.ToString();
            MBTPASS.Text = Password;

            TBOID.Text = crUserID;
            MTBPASS.Text = crPassword;

            TBFROM.Text = FromEmail;
            TBTO.Text = ToList;
            TBAKA.Text = FromName;
            TBSUBJECT.Text = Subject;
            RTBBODY.Text = Body;
            //____________________________

            //Initialisation des CheckBoxes
            CBSSL.CheckState = CheckState.Unchecked;
            CBLSC.CheckState = CheckState.Unchecked;
            //____________________________

            MailSent = false;

            //Instanciation des classes permettant l'exportation des données
            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            //Enregistre le chemin du répertoire de sortie du projet --> répertoire de sortie veut dire Debug ou Release
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

            //Répertoire où se trouve le fichier .rpt
            var rptPath = Path.Combine(outPutDirectory, "Reports\\Serveur mail - OT quotidiens.rpt");

            //Cast en chaine de caractere de rptPath
            string rpt_path = new Uri(rptPath).LocalPath;

            cryRpt.Load(rpt_path);

            //Paramétres de la base de données
            crConnectionInfo.UserID = "cossechar";
            crConnectionInfo.Password = "cossechar";

            CrTables = cryRpt.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer4.ReportSource = cryRpt;
            crystalReportViewer4.Zoom(75);
            crystalReportViewer4.Refresh(); 

        }

        private void crystalReportViewer4_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TBMinu_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string m_CSec = DateTime.Now.Second.ToString();
            string m_CMin = DateTime.Now.Minute.ToString();
            string m_CHor = DateTime.Now.Hour.ToString();

            TBHour.Text = m_CHor;
            TBMinu.Text = m_CMin;
            TBSeco.Text = m_CSec;
            if (AlarmTog.Checked)
            {
                NUDHor.Enabled = false;
                NUDMin.Enabled = false;
                NUDSec.Enabled = false;

                if ((m_CSec == NUDSec.Value.ToString()) && (m_CMin == NUDMin.Value.ToString()) && (m_CHor == NUDHor.Value.ToString()))//alarm on
                {
                    button3_Click(sender, e);
                    AlarmTog.Checked = true;
                    //timer1.Stop();

                }
            }
            else
            {
                NUDHor.Enabled = true;
                NUDMin.Enabled = true;
                NUDSec.Enabled = true;
            }


            if (CBLSC.Checked)
            {
                TBSMTP.Enabled = false;
                TBID.Enabled = false;
                TBPORT.Enabled = false;
                MBTPASS.Enabled = false;
            }
            else
            {
                TBSMTP.Enabled = true;
                TBID.Enabled = true;
                TBPORT.Enabled = true;
                MBTPASS.Enabled = true;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        

              
    }
}
