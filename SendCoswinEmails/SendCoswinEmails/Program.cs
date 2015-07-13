using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;

namespace SendCoswinEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialisation de cryRpt étant de type ReportDocument
            ReportDocument cryRpt;
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

            //Création d'une instance ReportDocument
            cryRpt = new ReportDocument();

            //Chargement du rapport dans cette instance
            cryRpt.Load(rpt_path);

            crConnectionInfo.ServerName = "ibol1ora3.bologna.marelli.it";
            crConnectionInfo.DatabaseName = "SIM4D";
            crConnectionInfo.UserID = "cossechar";
            crConnectionInfo.Password = "cossechar";

            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            try
            {
                //Paramètres d'exportation du fichier .rpt
                ExportOptions CrExportOptions;
                DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                CrDiskFileDestinationOptions.DiskFileName = pdf_path;
                CrExportOptions = cryRpt.ExportOptions;
                CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                CrExportOptions.FormatOptions = CrFormatTypeOptions;

                //Exportation du RPT en PDF
                cryRpt.Export();

                //Méthode envoyant le mail avec le PDF
                Program s = new Program();
                s.sendmail(pdf_path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void sendmail(string pdfFile)
        {
            try
            {
                //Paramètrage de l'envoi (Serveur SMTP et PORT)
                SmtpClient smtp = new SmtpClient("139.128.51.129", 25);
                smtp.UseDefaultCredentials = true;
                smtp.Timeout = 10000;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                DateTime today = DateTime.Today;

                //Paramétrage de l'email
                MailMessage Msg = new MailMessage("coswin@magnetimarelli.com", "thibault.artus@external.magnetimarelli.com", "Rapport journalier du " + today.ToString("dd/MM/yyyy"), "Please, do not reply to this message.");
                Msg.BodyEncoding = UTF8Encoding.UTF8;
                Msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                Msg.Attachments.Add(new Attachment(pdfFile));
                smtp.Send(Msg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
