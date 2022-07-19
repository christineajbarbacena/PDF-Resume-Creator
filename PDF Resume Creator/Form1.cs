using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Json.Net;
using System.Text.Json;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Text;


namespace PDF_Resume_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttncnvrt_Click(object sender, EventArgs e)
        {
            string resumefile = (@"C:\Users\barbacena\source\repos\PDF Resume Creator\PDF Resume Creator\ResumeInfo.json");
            string readresume = File.ReadAllText(resumefile);
            Infos inforesume = System.Text.Json.JsonSerializer.Deserialize<Infos>(readresume);

            //Converting basic Information
            string FirstName = inforesume.FirstName;
            string MiddleName = inforesume.MiddleName;
            string LastName = inforesume.LastName;
            string EmailAddress = inforesume.EmailAddress;
            string MobileNumber = inforesume.MobileNumber;
            string StreetName = inforesume.StreetName;
            string City = inforesume.City;
            string Province = inforesume.Province;
            string Region = inforesume.Region;

            //Converting Skills and Objectives
            string Objective = inforesume.Objective;
            string Skill1 = inforesume.Skill1;
            string Skill2 = inforesume.Skill2;
            string Skill3 = inforesume.Skill3;
            string Skill4 = inforesume.Skill4;

            //Converting Educational Background
            string Tertiary = inforesume.Tertiary;
            string Course = inforesume.Course;
            string TertiaryYears = inforesume.TertiaryYears;
            string SeniorHighSchool = inforesume.SeniorHighSchool;
            string Strand = inforesume.Strand;
            string SHSAward = inforesume.SHSAward;
            string SecondaryYears = inforesume.SecondaryYears;
            string JuniorHighSchool = inforesume.JuniorHighSchool;
            string JHSAward = inforesume.JHSAward;
            string JuniorYears = inforesume.JuniorYears;

            //Converting Awards
            string Awards1 = inforesume.Awards1;
            string Awards2 = inforesume.Awards2;

            //saving file

            using (SaveFileDialog savefile = new SaveFileDialog())
            {
                savefile.InitialDirectory = (@"C:\Users\barbacena\Desktop\Programming\Resume Creator");
                savefile.FileName = LastName + ".pdf";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    PdfPage pdfpage = pdf.AddPage();
                }
            }
        }
    }
}
