using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace FinalWebSiteApplication
{
    public partial class StaffLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application.Count != 0)
            {
                MemberPerson Person = (MemberPerson)Application["1"];
                if (Person.Member_status == false)
                {

                }
                else if (Person.Member_Type == "Member")
                {

                    Response.Redirect("Member.aspx");
                }
                else if (Person.Member_StaffType == "Staff1")
                {
                    Response.Redirect("Staff1.aspx");
                }
                else if (Person.Member_StaffType == "Staff2")
                {
                    Response.Redirect("Staff2.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = "yolo";
                XmlTextReader reader = null;
                int f1 = 0;
                int f2 = 0;
                int f3 = 0;
                int t = 0;
                if (Username.Text.Any(x => Char.IsWhiteSpace(x)) || Password.Text.Any(x => Char.IsWhiteSpace(x)))
                {
                    ErrorLabel.Text = "Please make sure there are no spaces in your username or password";
                }
                else if (string.IsNullOrEmpty(Password.Text) || string.IsNullOrWhiteSpace(Password.Text) || string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrEmpty(Username.Text))
                {
                    ErrorLabel.Text = "Please enter a proper username and password";
                }
                else
                {
                    try
                    {
                        reader = new XmlTextReader(System.AppDomain.CurrentDomain.BaseDirectory + "/XML_Data/StaffMembers.xml");
                        reader.WhitespaceHandling = WhitespaceHandling.None;
                        while (reader.Read())
                        {
                            
                            if (t == 2 && f3 == 1)
                            {
                                temp = reader.Value;
                                break;
                            }
                           
                            if (f1 == 1 && t!=2)
                            {
                                if (reader.Value == Username.Text)
                                {
                                    //tempo = reader.Value;
                                    t = 1;
                                }
                                f1 = 0;
                            }
                            
                            if (f2 == 1 && t == 1)
                            {
                                if (reader.Value == Password.Text)
                                {
                                    //tempo = reader.Value;
                                    t = 2;
                                    f1 = f2 = 0;
                                    f3 = 0;
                                }
                                else
                                {
                                    //tempo = reader.Value;
                                    break;
                                }
                            }
                            else
                            {
                                f2 = 0;
                            }
                            if (reader.Name == "Password" && t!=2)
                            {
                                f2 = 1;
                            }
                            if (reader.Name == "Username" && t!=2)
                            {
                                f1 = 1;
                                
                            }
                            if (reader.Name == "StaffType" && t==2)
                            {
                                temp = reader.Value;
                                f3 = 1;
                            }

                        }
                    }
                    finally
                    {
                        if (reader != null)
                            reader.Close();
                    }

                    if (t == 2 && !string.IsNullOrEmpty(temp))
                    {
                        MemberPerson Person = new MemberPerson(Username.Text, "Staff", temp);
                        Application["1"] = Person;
                        if (temp == "Staff1")
                        {
                            Response.Redirect("Staff1.aspx");
                        }
                        else if (temp == "Staff2")
                        {
                            Response.Redirect("Staff2.aspx");
                        }

                    }
                    else 
                    {
                        ErrorLabel.Text = "Incorrect password or username";
                    }
                    Username.Text = "";
                    Password.Text = "";
                }
            }
            catch (Exception g)
            {
                ErrorLabel.Text = g.Message;
            }
        }
    }
}