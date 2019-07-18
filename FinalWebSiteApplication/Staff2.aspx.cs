﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalWebSiteApplication
{
    public partial class Staff2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application.Count == 0)
            {
                Response.Redirect("StaffLogin.aspx");
            }
            MemberPerson Person = (MemberPerson)Application["1"];
            if (Person.Member_status == false)
            {
                Response.Redirect("StaffLogin.aspx");
            }
            else if (Person.Member_StaffType == "NA")
            {
                Response.Redirect("Member.aspx");
            }
            else if (Person.Member_StaffType == "Staff1")
            {
                Response.Redirect("Staff1.aspx");
            }
        }

        protected void Signout_Click(object sender, EventArgs e)
        {
            MemberPerson Member;
            MemberPerson FormerMember = new MemberPerson("", "", "");
            Member = (MemberPerson)Application["1"];
            FormerMember.Member_status = false;
            Application["1"] = FormerMember;
            if (Member.Member_Type == "Member")
            {
                Response.Redirect("MemberLogin.aspx");
            }
            else
            {
                Response.Redirect("StaffLogin.aspx");
            }
        }
    }
}