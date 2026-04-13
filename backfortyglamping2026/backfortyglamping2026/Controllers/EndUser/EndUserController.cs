using backfortyglamping2026.Models.NewsLetter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace backfortyglamping2026.Controllers
{
    public class EndUserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult aboutus()
        {
            return View();
        }
        public ActionResult amenities()
        {
            return View();
        }
        public ActionResult contactus()
        {
            return View();
        }
        public ActionResult dining()
        {
            return View();
        }
        public ActionResult domes()
        {
            return View();
        }
        public ActionResult gallery()
        {
            return View();
        }
        public ActionResult localarea()
        {
            return View();
        }
        public ActionResult policies()
        {
            return View();
        }
        //public ActionResult Concierge()
        //{
        //    return View();
        //}
        public ActionResult Sitemap()
        {
            return View();
        }
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
        public ActionResult ErrorPage404()
        {
            return View();
        }

        public JsonResult SendGetintouchmail(string name, string email)
        {
            string result = "";
            int count = 0;
            string Name = name;
            string Email = email;
            DateTime Udt = DateTime.Now.ToUniversalTime();
            string UniTime = DateTime.Now.ToUniversalTime().ToString();
            bool Isdaylight = Udt.IsDaylightSavingTime();
            string ESTTime = "";
            if (Isdaylight)
            {
                Udt = Udt.AddHours(-4);
                ESTTime = Udt.ToString();
            }
            else
            {
                Udt = Udt.AddHours(-5);
                ESTTime = Udt.ToString();
            }
            //DateTime DateProcessed = Convert.ToDateTime(DateTime.Now.ToString());
            // NOW Add Subscriber to MailerLite API
            try
            {
                string apiUrl = "https://connect.mailerlite.com/api/subscribers";
                string apiToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiI0IiwianRpIjoiOGQ4NjVhYmI2ZjY0ZjIxYzY2YzllMGFkZjFjN2I4NWVjNzEzZjI3Mzk3YWMyNjI3MTY0M2M5MjM0NTVkOWY3ZDRmMTE3NjE1YzUxNWVjZTgiLCJpYXQiOjE3NzI2NDg1NDkuNjU5MzM1LCJuYmYiOjE3NzI2NDg1NDkuNjU5MzM4LCJleHAiOjQ5MjgzMjIxNDkuNjUyODQyLCJzdWIiOiIyMTc3NjAxIiwic2NvcGVzIjpbXX0.K6-plzqWq2oDKK7gf6WXOpyZrWA7xUXx2U6tTckqQ6Cy2honFUBeNDbbp0CInQYJq_b7Vy3IbJSynyuq1jxdozdu7Roeywa78WPAuOZ_QA6Gi_3YiH4Zh4uqa7PBNSMS0S_Gy5wm0pnGlmBvDLUsz8IUHIuTUq9nA1t3bY7kieJ4UDwclU5_y2JPAd6_cWWQOPaiH_oZigy1H0epGsxwP0fLE8p7JOZD_CZ85HP3umf-WO3I3rzjlT1HWohGwYl1Apl7HJhz6S-sT70Rpt0e4luq-99_tcuab3_YpUGHV6ZRIoxy5jt7TNUXsAg8nbCSsKXpjkScpTM_vspPGS91AS05rCdiOQN_8isWHkMge8SyUWuMvtvLXxuuD3q-Og1f2H_tR-6zfC6YCjEK7ARQPB8IhMP4PpEGXU8c1xrzniK6sWqDln_y0KU4JbqRgT_suhFTYZ4oJFixeSXjnoSc-ogxTlU6PfIHbGJ7_RlwLBafy2wqetH7SBMI60fOTizufg502PwOlZEK1J3_nm0hENEbWr2HRS17hzjNZSfKzOCfr252nzxZUqDk-8jxoUSO-epOJHa1tR6o5pBqznuq_gWxwqxHFmSZGOGDZVmuGSSaQDsjLsZ_yHovWKu1bkwGNpXJq6Y45cfJ-cYLfxsCNOpST19cTWwQAm1fOZD5DKY";

                var client = new HttpClient();
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiToken);

                var subscriberData = new
                {
                    email = Email,
                    fields = new
                    {
                        name = Name
                    },
                    groups = new[] { "181035006631609763" }
                };

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(subscriberData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = client.PostAsync(apiUrl, content).Result;
                var apiResponse = response.Content.ReadAsStringAsync().Result;

                if (!response.IsSuccessStatusCode)
                {
                    // API Failed but DB Saved — Log but don't break
                    result = "saved_db_api_failed";
                }
                else
                {
                    result = "success";
                }
            }
            catch (Exception ex)
            {
                // API Exception but DB Saved
                result = "saved_db_api_exception";
            }
            {
                if (!string.IsNullOrWhiteSpace(name) &&
              !string.IsNullOrWhiteSpace(email))
                {
                    //#region form code start here
                    //DateTime DateProcessed = Convert.ToDateTime(ESTTime);
                    //string dtProcessed = String.Format("{0:dd-MMM-yyyy}", DateProcessed) + " " + String.Format("{0:T}", DateProcessed);
                    //string ampmProcessed = dtProcessed.Substring(dtProcessed.Length - 2, 2);
                    //dtProcessed = dtProcessed.Substring(0, dtProcessed.Length - 3);
                    //string surrDate = dtProcessed + " " + ampmProcessed;
                    //dtProcessed = ""; ampmProcessed = "";

                    //string message = "";

                    //message = message + "<table border=0 cellpadding=0 style=\"border-collapse: collapse;border-color:#707654\" width=800px align=left>";
                    //message = message + "<tbody>";

                    //message = message + "<tr>";
                    //message = message + "<td style=\"padding:10px 0 20px 0 ;\" colspan=\"2\">" + name + " completed the Back Forty Glamping get in touch form on " + surrDate + "";
                    //message = message + "</td>";
                    //message = message + "</tr>";

                    //message = message + "<tr>";
                    //message = message + "<td width=\"25%\"  style=\"padding:8px 0 6px 0 \">Name:";
                    //message = message + "</td>";
                    //message = message + "<td style=\"padding:8px 0 6px 0 \" width=\"80%\"> " + Name + "";
                    //message = message + "</td>";
                    //message = message + "</tr>";

                    //message = message + "<tr>";
                    //message = message + "<td width=\"25%\" style=\"padding:6px 0 6px 0 \">Email:";
                    //message = message + "</td>";
                    //message = message + "<td style=\"padding:6px 0 6px 0 \" width=\"80%\"> " + Email + "";
                    //message = message + "</td>";
                    //message = message + "</tr>";



                    //message = message + "</tbody>";
                    //message = message + " </table>";

                    //string mailTo = System.Configuration.ConfigurationManager.AppSettings["SendGetintouchmail"].ToString();

                    //System.Net.Mail.MailMessage mailToAdmin = new System.Net.Mail.MailMessage();
                    //mailToAdmin.From = new System.Net.Mail.MailAddress("noreply@digitalhospitality.com", "Back Forty Glamping");
                    //mailToAdmin.To.Add(mailTo);
                    //mailToAdmin.Subject = "News & Specials from website: " + Name;
                    //mailToAdmin.Body = message;
                    //mailToAdmin.IsBodyHtml = true;

                    //System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient();
                    //SmtpServer.UseDefaultCredentials = true;
                    //SmtpServer.Host = "smtp.gmail.com";
                    //SmtpServer.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    //SmtpServer.Port = 587;
                    ////   SmtpServer.UseDefaultCredentials = false;            
                    //SmtpServer.Credentials = new System.Net.NetworkCredential("noreply@digitalhospitality.com", "ztdvnxfycctqqils");
                    //SmtpServer.EnableSsl = true;
                    //SmtpServer.Send(mailToAdmin);

                    //#endregion
                    
                    using (Back_Forty_Glamping_DBEntities db = new Back_Forty_Glamping_DBEntities())
                    {
                        count = db.SignUpNewsLetters.Where(a => a.Email.ToLower() == email.ToLower()).Count();
                    }
                    if (count == 0)
                    {
                        Back_Forty_Glamping_DBEntities db = new Back_Forty_Glamping_DBEntities();
                        SignUpNewsLetter sn = new SignUpNewsLetter();
                        sn.Name = Name;
                        sn.Email = email;
                        sn.Date = ESTTime;
                        db.SignUpNewsLetters.Add(sn);
                        db.SaveChanges();
                        result = "sucesss";
                    }
                    else
                    {
                        result = "0";
                    }
                }

               


            }
            return Json(result, JsonRequestBehavior.DenyGet);
        }

        public void SendContactUsmail(string Namegetintuch, string PhoneTour, string EmailTour, string addtioncomments)
        {
            DateTime Udt = DateTime.Now.ToUniversalTime();
            string UniTime = DateTime.Now.ToUniversalTime().ToString();
            bool Isdaylight = Udt.IsDaylightSavingTime();

            string ESTTime = "";

            if (Isdaylight)
            {
                Udt = Udt.AddHours(-4);
                ESTTime = Udt.ToString();
            }
            else
            {
                Udt = Udt.AddHours(-5);
                ESTTime = Udt.ToString();
            }

            {
                if (!string.IsNullOrWhiteSpace(Namegetintuch) &&
              !string.IsNullOrWhiteSpace(PhoneTour) &&
              !string.IsNullOrWhiteSpace(EmailTour))
                {
                    #region form code start here
                    DateTime DateProcessed = Convert.ToDateTime(ESTTime);
                    string dtProcessed = String.Format("{0:dd-MMM-yyyy}", DateProcessed) + " " + String.Format("{0:T}", DateProcessed);
                    string ampmProcessed = dtProcessed.Substring(dtProcessed.Length - 2, 2);
                    dtProcessed = dtProcessed.Substring(0, dtProcessed.Length - 3);
                    string surrDate = dtProcessed + " " + ampmProcessed;
                    dtProcessed = ""; ampmProcessed = "";

                    string message = "";

                    message = message + "<table border=0 cellpadding=0 style=\"border-collapse: collapse;border-color:#707654\" width=800px align=left>";
                    message = message + "<tbody>";

                    message = message + "<tr>";
                    message = message + "<td style=\"padding:10px 0 20px 0 ;\" colspan=\"2\">" + Namegetintuch + " completed Back Forty Glamping get in touch inquiry form on " + surrDate + "";
                    message = message + "</td>";
                    message = message + "</tr>";

                    message = message + "<tr>";
                    message = message + "<td width=\"30%\"  style=\"padding:8px 0 6px 0 \"> Name:";
                    message = message + "</td>";
                    message = message + "<td style=\"padding:8px 0 6px 0 \" width=\"70%\"> " + Namegetintuch;
                    message = message + "</td>";
                    message = message + "</tr>";

                    message = message + "<tr>";
                    message = message + "<td width=\"30%\" style=\"padding:6px 0 6px 0;vertical-align:top\"> Your Email:";
                    message = message + "</td>";
                    message = message + "<td style=\"padding:6px 0 6px 0 \" width=\"70%\"> " + EmailTour + "";
                    message = message + "</td>";
                    message = message + "</tr>";

                    message = message + "<tr>";
                    message = message + "<td width=\"30%\" style=\"padding:6px 0 6px 0;vertical-align:top\">Your Phone:";
                    message = message + "</td>";
                    message = message + "<td style=\"padding:6px 0 6px 0 \" width=\"70%\"> " + PhoneTour + "";
                    message = message + "</td>";
                    message = message + "</tr>";

                    message = message + "<tr>";
                    message = message + "<td width=\"30%\" style=\"padding:6px 0 6px 0;vertical-align:top\">Message:";
                    message = message + "</td>";
                    message = message + "<td style=\"padding:6px 0 6px 0 \" width=\"70%\"> " + addtioncomments + "";
                    message = message + "</td>";
                    message = message + "</tr>";

                    message = message + "</tbody>";
                    message = message + " </table>";


                    string mailTo = System.Configuration.ConfigurationManager.AppSettings["SendContactUsmail"].ToString();

                    System.Net.Mail.MailMessage mailToAdmin = new System.Net.Mail.MailMessage();
                    mailToAdmin.From = new System.Net.Mail.MailAddress("noreply@digitalhospitality.com", "Back Forty Glamping");
                    mailToAdmin.ReplyToList.Add(new System.Net.Mail.MailAddress(EmailTour));
                    mailToAdmin.To.Add(mailTo);
                    mailToAdmin.Subject = "Get in touch inquiry from website: " + Namegetintuch;
                    mailToAdmin.Body = message;
                    mailToAdmin.IsBodyHtml = true;

                    System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient();
                    SmtpServer.UseDefaultCredentials = true;
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    SmtpServer.Port = 25;
                    //   SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("noreply@digitalhospitality.com", "ztdvnxfycctqqils");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mailToAdmin);

                }
                #endregion
            }
        }

        #region excel import
        public void NewsLetterExport()
        {
            List<NewsLetterModel> model = new List<NewsLetterModel>();
            using (Back_Forty_Glamping_DBEntities db = new Back_Forty_Glamping_DBEntities())
            {
                List<SignUpNewsLetter> sign = new List<SignUpNewsLetter>();
                sign = db.SignUpNewsLetters.OrderByDescending(a => a.Id).ToList();

                GridView gv = new GridView();
                model = sign.Select(x => new NewsLetterModel
                {
                    Signupdate = dateformate(x.Date.ToString()),
                    Timeupdate = timeformate(x.Date.ToString()),
                    FirstName = x.Name,
                    email = x.Email,

                }).ToList();
                gv.DataSource = model;
                gv.DataBind();
                Response.ClearContent();
                Response.Buffer = true;
                Response.AddHeader("content-disposition", "attachment; filename=NewsLetterSignUp.xls");
                Response.ContentType = "application/ms-excel";
                Response.Charset = "";

                StringWriter sw = new StringWriter();
                HtmlTextWriter htw = new HtmlTextWriter(sw);
                gv.RenderControl(htw);
                Response.Output.Write(sw.ToString().Replace("Signupdate", "Date Signed Up").Replace("Timeupdate", "Time Signed Up").Replace("FirstName", "Name").Replace("email", "Email Address"));

                Response.Flush();
                Response.End();

            }
        }
        public string dateformate(string date)
        {
            // Parse the input string to a DateTime object
            DateTime DateProcessed = Convert.ToDateTime(date);

            // Format: 08-March-2026
            // "dd" = Day, "MMMM" = Full Month Name, "yyyy" = Year
            return DateProcessed.ToString("dd-MMMM-yyyy");
        }

        public string timeformate(string date)
        {
            // Parse the input string to a DateTime object
            DateTime DateProcessed = Convert.ToDateTime(date);

            // Format: 1:02:48 PM
            // "h:mm:ss tt" = 12-hour clock with AM/PM
            return DateProcessed.ToString("h:mm:ss tt");
        }
        #endregion
    }
}