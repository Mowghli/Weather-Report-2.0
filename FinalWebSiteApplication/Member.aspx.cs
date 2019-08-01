using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalWebSiteApplication
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies.Get("Member");
            if (cookie != null)
            {
                if (cookie["Logged"] !="true")
                {
                    Response.Redirect("MemberLogin.aspx");
                }
            }
            else
            {
                Response.Redirect("MemberLogin.aspx");
            }


            /*
            if (Application.Count == 0)
            {
                Response.Redirect("MemberLogin.aspx");
            }
            MemberPerson Person = (MemberPerson)Application["1"];
            if (Person.Member_status == false)
            {
                Response.Redirect("MemberLogin.aspx");
            }*/
        }

        protected void Signout_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies.Get("Member");
            cookie["Username"] = "";
            cookie["Logged"] = "false";
            Response.Cookies.Add(cookie);
            Response.Redirect("MemberLogin.aspx");
            /*
            MemberPerson Member;
            MemberPerson FormerMember = new MemberPerson("", "", "");
            Member= (MemberPerson)Application["1"];
            FormerMember.Member_status = false;
            Application["1"] = FormerMember;
            if (Member.Member_Type == "Member")
            {
                Response.Redirect("MemberLogin.aspx");
            }
            else
            {
                Response.Redirect("StaffLogin.aspx");
            }*/
        }
    }
}