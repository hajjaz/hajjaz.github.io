using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;

namespace Portfolio_Hajjaz
{
    public class Utilities
    {

        public static bool SendMail(string Email, string subject, string body)
        {
            bool success = false;
            var fromAddress = "hajjaz.aust@gmail.com";
            var toAddress = Email;

            try
            {
                var smtp = new SmtpClient();
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    //smtp.Credentials = new NetworkCredential("hajjaz.aust", "rnikrwumgqkaitub");
                    smtp.Credentials = new NetworkCredential("falcatepapertube", "jarajafar123");
                    smtp.Timeout = 20000;
                }

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                })
                {
                    smtp.Send(message);
                    success = true;
                    //Response.Write("Success");
                    //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Order Placed Successfully.');<script>");
                    //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Order Placed Successfully.')", true);
                    //Label1.Text = "Success";
                }
            }
            catch (Exception ex)
            {
                success = false;
                //Response.Write("Failed" + ex.ToString());
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Something went wrong, Pleases try again.');<script>");
                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Something went wrong, Pleases try again.')", true);
                //Label1.Text = ex.Message;
            }
            return success;
        }

        public static bool SendMail_Info(string Email, string subject, string body)
        {
            bool success = false;
            var fromAddress = "info@elsecode.com";
            var toAddress = Email;

            try
            {
                var smtp = new SmtpClient();
                {
                    smtp.Host = "mail.elsecode.com";
                    smtp.Port = 25;
                    smtp.EnableSsl = false;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    //smtp.Credentials = new NetworkCredential("hajjaz.aust", "kldrfwbhpxnhdpmc");
                    smtp.Credentials = new NetworkCredential("info@elsecode.com", "Info@pass123");
                    smtp.Timeout = 20000;
                }

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                })
                {
                    smtp.Send(message);
                    success = true;
                    //Response.Write("Success");
                    //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Order Placed Successfully.');<script>");
                    //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Order Placed Successfully.')", true);
                    //Label1.Text = "Success";
                }
            }
            catch (Exception ex)
            {
                success = false;
                //Response.Write("Failed" + ex.ToString());
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Something went wrong, Pleases try again.');<script>");
                //ScriptManager.RegisterClientScriptBlock(Utilities.this, this.GetType(), "alertMessage", "alert('Something went wrong, Pleases try again.')", true);
                //Label1.Text = ex.Message;
            }
            return success;
        }
    }
}