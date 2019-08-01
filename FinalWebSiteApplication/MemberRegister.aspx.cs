using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Windows;

namespace FinalWebSiteApplication
{
    public partial class MemberRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpCookie cookie = Request.Cookies.Get("Member");
            if (cookie != null)
            {
                if (cookie["Logged"] == "true")
                {
                    Response.Redirect("Member.aspx");
                }

            }
            /*
            if (Application.Count != 0)
            {
                MemberPerson Person = (MemberPerson)Application["1"];
                if (Person.Member_status == true)
                {
                    Response.Redirect("Member.aspx");
                }
            }*/
            //Username.Text = "";
            //Password1.Text = "";
            //Password2.Text = "";
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            string fpath;
            //fpath = System.AppDomain.CurrentDomain.BaseDirectory;
            FileStream fS = null;
            int t = 0;
            fpath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"XML_Data\Members.xml");
            try
            {
                if (string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrEmpty(Username.Text))
                { }
                else
                {
                    XmlTextReader reader = null;
                    int f = 0;
                    try
                    {
                        reader = new XmlTextReader(System.AppDomain.CurrentDomain.BaseDirectory + "/XML_Data/Members.xml");
                        reader.WhitespaceHandling = WhitespaceHandling.None;
                        while (reader.Read())
                        {
                            //Console.WriteLine("Type ={ 0}\tName ={ 1}\tValue ={ 2}", reader.NodeType, reader.Name, reader.Value);
                            if (f == 1)
                            {
                                if (reader.Value == Username.Text)
                                {
                                    t = 1;
                                }
                                f = 0;
                            }
                            if (reader.Name == "Username")
                            {
                                f = 1;
                            }

                        }
                    }
                    finally
                    {
                        if (reader != null)
                            reader.Close();
                    }

                }
                if (string.IsNullOrEmpty(Password1.Text)
                    || string.IsNullOrEmpty(Password2.Text) || string.IsNullOrWhiteSpace(Password1.Text)
                    || string.IsNullOrWhiteSpace(Password2.Text)
                    || string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrEmpty(Username.Text))
                {
                    ErrorLabel.Text = "Please do not leave any fields empty";

                }
                else if (Password1.Text != Password2.Text)
                {
                    ErrorLabel.Text = "Please make sure you type the same password at both the given fields";
                }
                else if (t == 1)
                {
                    ErrorLabel.Text = "Username already taken";
                }
                else if (Username.Text.Any(x => Char.IsWhiteSpace(x)) || Password1.Text.Any(x => Char.IsWhiteSpace(x))|| Password2.Text.Any(x => Char.IsWhiteSpace(x)))
                {
                    ErrorLabel.Text = "Whitespaces are not allowed in your username/password";
                }
                else
                {
                    if (File.Exists(fpath))
                    {

                        XmlDocument xd = new XmlDocument();
                        xd.Load(System.AppDomain.CurrentDomain.BaseDirectory + "/XML_Data/Members.xml");
                        XmlElement Person = xd.CreateElement("Person");
                        XmlElement UsernameElement = xd.CreateElement("Username");
                        XmlElement PasswordElement = xd.CreateElement("Password");
                        XmlText UsernameXML = xd.CreateTextNode(Username.Text.Trim());
                        XmlText PasswordXML = xd.CreateTextNode(Password1.Text.Trim());
                        UsernameElement.AppendChild(UsernameXML);
                        PasswordElement.AppendChild(PasswordXML);
                        Person.AppendChild(UsernameElement);
                        Person.AppendChild(PasswordElement);
                        xd.DocumentElement.AppendChild(Person);
                        fS = new FileStream(fpath, FileMode.OpenOrCreate);
                        XmlTextWriter writer = new XmlTextWriter(fS, System.Text.Encoding.Unicode);
                        writer.Formatting = Formatting.Indented;
                        xd.WriteContentTo(writer);
                        writer.Close();
                        fS.Close();
                    }
                    else
                    {
                        fS = new FileStream(fpath, FileMode.OpenOrCreate);
                        XmlTextWriter writer = new XmlTextWriter(fS, System.Text.Encoding.Unicode);
                        writer.Formatting = Formatting.Indented;
                        writer.WriteStartDocument();
                        writer.WriteStartElement("MemberPersons");
                        writer.WriteStartElement("Person");
                        writer.WriteElementString("Username", Username.Text);
                        writer.WriteElementString("Password", Password1.Text);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Close();
                        fS.Close();
                    }
                    ErrorLabel.Text = "No Errors";
                }
                
            }
            catch (Exception g)
            {
                ErrorLabel.Text = g.Message;
            }
            Username.Text = "";
            Password1.Text = "";
            Password2.Text = "";
        }
    }
}
