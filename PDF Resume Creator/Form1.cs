using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Json.Net;

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
            String Resumefile = (@"C:\Users\barbacena\source\repos\PDF Resume Creator\PDF Resume Creator\ResumeInfo.json");
            String readresume = File.ReadAllText(Resumefile);
            Infos sresume = JsonSerializer.Deserialize<Infos>(readresume)!;

            //Personal Information

        }
    }
}
