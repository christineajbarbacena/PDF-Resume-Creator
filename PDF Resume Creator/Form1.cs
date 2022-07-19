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

                    XPen line = new XPen(XColors.White, 2);
                    XPen nline = new XPen(XColors.White, 3);

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
                    xGraphics.DrawRectangle(line, left, down  + 10, 300, 1);
                    xGraphics.DrawString(EmailAddress, regularfont, XBrushes.Black, new XRect (left, down + 25, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(MobileNumber, regularfont, XBrushes.Black, new XRect (left, down + 40, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(StreetName + " " + City, regularfont, XBrushes.Black, new XRect (left, down  + 55, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Province + " " + Region, regularfont, XBrushes.Black, new XRect (left, down + 70, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    //Skills
                    xGraphics.DrawString("Skills",Bfont, XBrushes.Black, new XRect (left, down +100, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawRectangle(line, left, down + 120, 150, 1);
                    xGraphics.DrawString(Skill1, regularfont, XBrushes.Black, new XRect(left, down + 130, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Skill2, regularfont, XBrushes.Black, new XRect(left, down + 145, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Skill3, regularfont, XBrushes.Black, new XRect(left, down + 160, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Skill4, regularfont, XBrushes.Black, new XRect(left, down + 175, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    //Work Experience
                    xGraphics.DrawString("Work Experience ", Bfont, XBrushes.Black, new XRect(left, down + 250, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawRectangle(line, left, down + 265, 150, 1);
                    xGraphics.DrawString(WorkExperience, regularfont, XBrushes.Black, new XRect(left, down + 270, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(WEAddress, regularfont, XBrushes.Black, new XRect(left, down + 285, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Position, regularfont, XBrushes.Black, new XRect(left, down + 300, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(WorkYears, regularfont, XBrushes.Black, new XRect(left, down + 315, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    //Educational Bg
                    xGraphics.DrawString("Educational Background", Bfont, XBrushes.Black, new XRect(left, down + 345, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawRectangle(line, left, down + 360, 150, 1);
                    xGraphics.DrawString(Tertiary, regularfont, XBrushes.Black, new XRect(left, down + 365, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Course, regularfont, XBrushes.Black, new XRect(left, down + 380, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(TertiaryYears, regularfont, XBrushes.Black, new XRect(left, down + 395, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    
                    xGraphics.DrawString(SeniorHighSchool, regularfont, XBrushes.Black, new XRect(left, down + 415, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Strand, regularfont, XBrushes.Black, new XRect(left, down + 430, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(SHSAward, regularfont, XBrushes.Black, new XRect(left, down + 445, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(SecondaryYears, regularfont, XBrushes.Black, new XRect(left, down + 460, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    
                    xGraphics.DrawString(JuniorHighSchool, regularfont, XBrushes.Black, new XRect(left, down + 480, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(JHSAward, regularfont, XBrushes.Black, new XRect(left, down + 485, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(JuniorYears, regularfont, XBrushes.Black, new XRect(left, down + 500, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    
                    //Awards
                    xGraphics.DrawString("Awards: ", Bfont, XBrushes.Black, new XRect(left, down + 530, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawRectangle(line, left, down + 535, 150, 1);
                    xGraphics.DrawString(Awards1, regularfont, XBrushes.Black, new XRect(left, down + 540, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Awards2, regularfont, XBrushes.Black, new XRect(left, down + 555, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    pdf.Save(savefile.FileName);
                    MessageBox.Show("Your resume is done.");
                    Application.Exit();

                }
            }
        }
    }
}
