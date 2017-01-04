using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentPart3
{
    public class Account
    {
        //=======================================================
        //============JUST IGNORE THIS CLASS=====================
        //===============IT IS NOT USED==========================
        //=======================================================

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PPSN { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string DOB { get; set; }
        public int Height { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string[] RelStatus { get; set; }

        public string[] Sports { get; set; }

        public string[] Cultural { get; set; }


        public Account(string fname, string sname, string ppsn, string gender, int age, string dob, int height, string email, string phone, string[] relstatus, string[] sports, string[] cultural)
        {
            this.FirstName = fname;
            this.LastName = sname;
            this.PPSN = ppsn;
            this.Gender = gender;
            this.Age = age;
            this.DOB = dob;
            this.Height = height;
            this.Email = email;
            this.Phone = phone;
            this.RelStatus = relstatus;
            this.Sports = sports;
            this.Cultural = cultural;

        }

    }
}