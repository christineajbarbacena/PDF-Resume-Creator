using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace PDF_Resume_Creator
{
    public class Infos
    {
        //Basic Information
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Province  { get; set; }
        public string Region { get; set; }

        //skills and objectives
        public string Objective { get; set; }
        public string Skill1 { get; set; }
        public string Skill2 { get; set; }
        public string Skill3 { get; set; }
        public string Skill4 { get; set; }

        //work experience
        public string WorkExperience { get; set; }
        public string WEAddress { get; set; }
        public string Position { get; set; }
        public string WorkYears { get; set; }

        //Educational Background
        public string Tertiary { get; set; }
        public string Course { get; set; }
        public string TertiaryYears { get; set; }
        public string SeniorHighSchool { get; set; }
        public string Strand { get; set; }
        public string SHSAward { get; set; }
        public string SecondaryYears { get; set; }
        public string JuniorHighSchool { get; set; }
        public string JHSAward { get; set; }
        public string JuniorYears { get; set; }
        
        //Awards
        public string Awards1 { get; set; }
        public string Awards2 { get; set; }
    }

}