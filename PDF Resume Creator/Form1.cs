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
using System.Drawing;


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
            string Skill1 = inforesume.Skill1;
            string Skill2 = inforesume.Skill2;
            string Skill3 = inforesume.Skill3;
            string Skill4 = inforesume.Skill4;

            //Converting Work Experience
            string WorkExperience = inforesume.WorkExperience;
            string WEAddress = inforesume.WEAddress;
            string Position = inforesume.Position;
            string WorkYears = inforesume.WorkYears;

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
                savefile.Filter = "PDF|*.pdf";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    PdfPage pdfpage = pdf.AddPage();

                    XGraphics xGraphics = XGraphics.FromPdfPage(pdfpage);

                    //Fonts
                    XFont namefont = new XFont("Opens Sans Light", 35, XFontStyle.Bold);
                    XFont Bfont = new XFont ("Arial", 18, XFontStyle.Bold);
                    XFont regularfont = new XFont("Arial", 14, XFontStyle.Regular);

                    //line colors
                    XPen line = new XPen(XColors.Black, 2);
                    XPen xPen = new XPen(XColors.Beige, 20);

                    //Background Design
                    xGraphics.DrawRoundedRectangle(XBrushes.LightPink, 0, 0, pdfpage.Width.Point, pdfpage.Height.Point, 0, 0);
                    xGraphics.DrawRectangle(xPen, 0, 0, pdfpage.Width.Point, pdfpage.Height.Point);

                    //Margins
                    int left = 55;
                    int down = 200;
                    

                    //Picture
                    string pic = (@"C:\Users\barbacena\Desktop\Programming\Ai.png");
                    XImage xImage = XImage.FromFile(pic);
                    xGraphics.DrawImage(xImage, left + 350, 45, 150, 150);

                    //Name
                    xGraphics.DrawString(LastName, namefont, XBrushes.Black, new XRect(left, down -100, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(FirstName, namefont, XBrushes.Black, new XRect(left, down - 70, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    //Basic Information
                    xGraphics.DrawString("Basic Information", Bfont, XBrushes.Black, new XRect(left, down - 15, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawRectangle(line, left, down  + 10, 500, 1);
                    xGraphics.DrawString("Email Address: " + EmailAddress, regularfont, XBrushes.Black, new XRect (left, down + 25, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString("Mobile Number: " + MobileNumber, regularfont, XBrushes.Black, new XRect (left, down + 40, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString("Address: " +StreetName + " " + City, regularfont, XBrushes.Black, new XRect (left, down  + 55, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString("Region: " + Province + " " + Region, regularfont, XBrushes.Black, new XRect (left, down + 70, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    //Skills
                    xGraphics.DrawString("Skills",Bfont, XBrushes.Black, new XRect (left, down +100, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawRectangle(line, left, down + 120, 500, 1);
                    xGraphics.DrawString(Skill1, regularfont, XBrushes.Black, new XRect(left, down + 130, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Skill2, regularfont, XBrushes.Black, new XRect(left, down + 145, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Skill3, regularfont, XBrushes.Black, new XRect(left, down + 160, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Skill4, regularfont, XBrushes.Black, new XRect(left, down + 175, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    //Work Experience
                    xGraphics.DrawString("Work Experience ", Bfont, XBrushes.Black, new XRect(left, down + 205, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawRectangle(line, left, down + 225, 500, 1);
                    xGraphics.DrawString("Company Name: " + WorkExperience, regularfont, XBrushes.Black, new XRect(left, down + 240, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString("COmpany Address: " + WEAddress, regularfont, XBrushes.Black, new XRect(left, down + 255, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString("Position: " + Position, regularfont, XBrushes.Black, new XRect(left, down + 270, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString("Year: " + WorkYears, regularfont, XBrushes.Black, new XRect(left, down + 285, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    //Educational Bg
                    xGraphics.DrawString("Educational Background", Bfont, XBrushes.Black, new XRect(left, down + 305, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawRectangle(line, left, down + 325, 500, 1);
                    xGraphics.DrawString("College: " + Tertiary, regularfont, XBrushes.Black, new XRect(left, down + 335, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString("Course: " + Course, regularfont, XBrushes.Black, new XRect(left, down + 350, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString("School Year: " + TertiaryYears, regularfont, XBrushes.Black, new XRect(left, down + 365, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    
                    xGraphics.DrawString("Senior High School: " + SeniorHighSchool, regularfont, XBrushes.Black, new XRect(left, down + 385, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString("Strand: " + Strand, regularfont, XBrushes.Black, new XRect(left, down + 400, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString("Graduated: " + SHSAward, regularfont, XBrushes.Black, new XRect(left, down + 415, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString("School Year: " + SecondaryYears, regularfont, XBrushes.Black, new XRect(left, down + 430, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    
                    xGraphics.DrawString("Junior High School: " + JuniorHighSchool, regularfont, XBrushes.Black, new XRect(left, down + 450, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString("Graduated: " + JHSAward, regularfont, XBrushes.Black, new XRect(left, down + 465, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString("School Year: " + JuniorYears, regularfont, XBrushes.Black, new XRect(left, down + 480, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    
                    //Awards
                    xGraphics.DrawString("Awards: ", Bfont, XBrushes.Black, new XRect(left, down + 510, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawRectangle(line, left, down + 530, 500, 1);
                    xGraphics.DrawString(Awards1, regularfont, XBrushes.Black, new XRect(left, down + 540, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Awards2, regularfont, XBrushes.Black, new XRect(left, down + 555, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    pdf.Save(savefile.FileName);
                    MessageBox.Show("Your PDF Resume is saved.");
                    Application.Exit();

                }
            }
        }
    }
}
