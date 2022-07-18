using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

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
