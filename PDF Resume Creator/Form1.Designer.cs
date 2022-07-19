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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttncnvrt
            // 
            this.bttncnvrt.BackColor = System.Drawing.Color.BurlyWood;
            this.bttncnvrt.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttncnvrt.Location = new System.Drawing.Point(94, 139);
            this.bttncnvrt.Name = "bttncnvrt";
            this.bttncnvrt.Size = new System.Drawing.Size(188, 37);
            this.bttncnvrt.TabIndex = 0;
            this.bttncnvrt.Text = "Convert";
            this.bttncnvrt.UseVisualStyleBackColor = false;
            this.bttncnvrt.Click += new System.EventHandler(this.bttncnvrt_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.Moccasin;
            this.lblInstructions.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(66, 83);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(249, 42);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Click convert button to convert \r\nJson file into pdf file. ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.MistyRose;
            this.lblName.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 262);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(185, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "By: Christine April Joy Barbacena";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 284);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.bttncnvrt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PDFResume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttncnvrt;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblName;
    }
}

