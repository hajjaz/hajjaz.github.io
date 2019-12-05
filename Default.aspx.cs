using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio_Hajjaz
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            string Name = tvName.Text;
            string Email = tvEmail.Text;
            string Phone = tvPhone.Text;

            string subject = "Thank you for your interest";
            string body = "Dear Mr/Mrs " + Name + ",<br />Thank you for your interest. You will be contacted " +
            "as soon as possible.<br /><br />Thanks & Regards,<br />Hajjaz Bin Ibrahim";

            string message = tvMessage.Text;
            string subject2 = "PortfolioMail: " + Name + " want's to talk to you.";
            string body2 = "<br />Name: " + Name + "<br />Email: " + Email + "<br />Phone: " + Phone + "<br />Message: " + message;

            bool hajjaz = Utilities.SendMail_Info("hajjaz.aust@gmail.com", subject2, body2);
            bool user = Utilities.SendMail_Info(Email, subject, body);

            string s = hajjaz ? "Sent" : "Failed";
            string s1 = user ? "Sent" : "Failed";

            string script = "alert('Mail = hajjaz: '" + s + ", user: " + s1 + " ');";
            System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Test", script, true);
        }


    }
}