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
            string Objective = inforesume.Objective;
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

                    XPen xPen = new XPen(XColors.White, 20);

                    //Background Design
                    xGraphics.DrawRoundedRectangle(XBrushes.LightGray, 0, 0, pdfpage.Width.Point, pdfpage.Height.Point, 0, 0);
                    xGraphics.DrawRectangle(xPen, 0, 0, pdfpage.Width.Point, pdfpage.Height.Point);

                    //Margins
                    int mleft1 = 25;
                    int mleft2 = 200;
                    int mdown = 430;

                    //Picture
                    string pic = (@"C:\Users\barbacena\Desktop\Programming\Ai.png");
                    XImage xImage = XImage.FromFile(pic);
                    xGraphics.DrawImage(xImage, mleft2, 50, 150, 150);

                    //Name
                    xGraphics.DrawString(FirstName + " " + MiddleName + "" + LastName, namefont, XBrushes.Black, new XRect(mleft1, mleft2 -100, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    //Basic Information
                    xGraphics.DrawString("Basic Information", Bfont, XBrushes.Black, new XRect(mdown, mleft2 +20, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawRectangle(line, mdown, mleft2 + 45, 150, 1);
                    xGraphics.DrawString(EmailAddress, regularfont, XBrushes.Black, new XRect (mdown, mleft2 + 50, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(MobileNumber, regularfont, XBrushes.Black, new XRect (mdown, mleft2 + 65, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(StreetName + " " + City, regularfont, XBrushes.Black, new XRect (mdown, mleft2 + 80, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Province + " " + Region, regularfont, XBrushes.Black, new XRect (mdown, mleft2 + 95, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    //Skills and Objectives
                    xGraphics.DrawString("Objectives And Skills: ",Bfont, XBrushes.Black, new XRect (mdown, mleft2 +125, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawRectangle(line, mdown, mleft2 + 145, 150, 1);
                    xGraphics.DrawString(Objective, regularfont, XBrushes.Black, new XRect (mdown, mleft2 + 150, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Skill1, regularfont, XBrushes.Black, new XRect(mdown, mleft2 + 165, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Skill2, regularfont, XBrushes.Black, new XRect(mdown, mleft2 + 180, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Skill3, regularfont, XBrushes.Black, new XRect(mdown, mleft2 + 195, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Skill4, regularfont, XBrushes.Black, new XRect(mdown, mleft2 + 210, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    //Work Experience
                    xGraphics.DrawString("Work Experience: ", Bfont, XBrushes.Black, new XRect(mdown, mleft2 + 240, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawRectangle(line, mdown, mleft2 + 255, 150, 1);
                    xGraphics.DrawString(WorkExperience, regularfont, XBrushes.Black, new XRect(mdown, mleft2 + 260, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(WEAddress, regularfont, XBrushes.Black, new XRect(mdown, mleft2 + 275, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(Position, regularfont, XBrushes.Black, new XRect(mdown, mleft2 + 290, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawString(WorkYears, regularfont, XBrushes.Black, new XRect(mdown, mleft2 + 305, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    xGraphics.DrawString("Educational Background", Bfont, XBrushes.Black, new XRect(mdown, mleft2 + 335, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xGraphics.DrawRectangle(nline, mleft1, mleft2 + 25, 150, 1);



                    pdf.Save(savefile.FileName);
                    MessageBox.Show("Your resume is done.");
                    Application.Exit();

                }
            }
        }
    }
}
