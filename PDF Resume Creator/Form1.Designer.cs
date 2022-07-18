namespace PDF_Resume_Creator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttncnvrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttncnvrt
            // 
            this.bttncnvrt.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttncnvrt.Location = new System.Drawing.Point(12, 266);
            this.bttncnvrt.Name = "bttncnvrt";
            this.bttncnvrt.Size = new System.Drawing.Size(158, 34);
            this.bttncnvrt.TabIndex = 0;
            this.bttncnvrt.Text = "Convert";
            this.bttncnvrt.UseVisualStyleBackColor = true;
            this.bttncnvrt.Click += new System.EventHandler(this.bttncnvrt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 312);
            this.Controls.Add(this.bttncnvrt);
            this.Name = "Form1";
            this.Text = "PDFResume";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttncnvrt;
    }
}

