using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalWebSiteApplication
{
    public class MemberPerson
    {
        public string Member_Username;
        public string Member_Type;
        public Boolean Member_status;
        public string Member_StaffType;
        public MemberPerson(string Username, string Memtype, string MemStaType)
        {
            Member_Username = Username;
            Member_Type = Memtype;
            Member_status = true;
            Member_StaffType = MemStaType;
        }
    }
}