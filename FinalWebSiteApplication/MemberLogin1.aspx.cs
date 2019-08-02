using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace FinalWebSiteApplication
{
    public partial class MemberLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpCookie cookie = Request.Cookies.Get("Member");
            if(cookie!=null)
            {
                if (cookie["Logged"] == "true")
                {
                    Response.Redirect("Member.aspx");
                }

            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                XmlTextReader reader = null;
                int f1 = 0;
                int f2 = 0;
                int t = 0;
                if (Username.Text.Any(x => Char.IsWhiteSpace(x)) || Password.Text.Any(x => Char.IsWhiteSpace(x)))
                {
                    ErrorLabel.Text = "Please make sure there are no spaces in your username or password";
                }
                else if (string.IsNullOrEmpty(Password.Text) || string.IsNullOrWhiteSpace(Password.Text) || string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrEmpty(Username.Text))
                {
                    ErrorLabel.Text = "Please enter a username or password";
                }
                else
                {
                    try
                    {
                        reader = new XmlTextReader(System.AppDomain.CurrentDomain.BaseDirectory + "/XML_Data/Members.xml");
                        reader.WhitespaceHandling = WhitespaceHandling.None;
                        while (reader.Read())
                        {
                            //Console.WriteLine("Type ={ 0}\tName ={ 1}\tValue ={ 2}", reader.NodeType, reader.Name, reader.Value);
                            if (f1 == 1)
                            {
                                if (reader.Value == Username.Text)
                                {
                                    t = 1;
                                }
                                f1 = 0;
                            }

                            if (f2 == 1 && t == 1)
                            {

                                if (reader.Value == Password.Text)
                                {
                                    t = 2;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                f2 = 0;
                            }
                            if (reader.Name == "Password")
                            {
                                f2 = 1;
                            }
                            if (reader.Name == "Username")
                            {
                                f1 = 1;
                            }

                        }
                    }
                    finally
                    {
                        if (reader != null)
                            reader.Close();
                    }

                    if (t == 2)
                    {
                        HttpCookie myCookies = new HttpCookie("Member");
                        myCookies["Username"] = Username.Text;
                        myCookies["Logged"] = "true";
                        //myCookies.Expires = DateTime.Now.AddMinutes(10.0);
                        myCookies.Expires = DateTime.Now.AddMonths(6);
                        Response.Cookies.Add(myCookies);
                        Response.Redirect("Member.aspx");
                    }
                    else
                    {
                        ErrorLabel.Text = "Incorrect password or username";
                    }
                    Username.Text = "";
                    Password.Text = "";
                }
            } catch (Exception g)
            {
                ErrorLabel.Text = g.Message;
            }
            
        }
    }
}