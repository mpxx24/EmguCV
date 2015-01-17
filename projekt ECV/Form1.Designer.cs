namespace projekt_ECV
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.histogramBox = new Emgu.CV.UI.HistogramBox();
            this.pictureList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(382, 40);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(259, 230);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // histogramBox
            // 
            this.histogramBox.Location = new System.Drawing.Point(56, 40);
            this.histogramBox.Name = "histogramBox";
            this.histogramBox.Size = new System.Drawing.Size(270, 230);
            this.histogramBox.TabIndex = 3;
            // 
            // pictureList
            // 
            this.pictureList.FormattingEnabled = true;
            this.pictureList.Location = new System.Drawing.Point(760, 40);
            this.pictureList.Name = "pictureList";
            this.pictureList.Size = new System.Drawing.Size(233, 225);
            this.pictureList.TabIndex = 4;
            this.pictureList.SelectedIndexChanged += new System.EventHandler(this.pictureList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 327);
            this.Controls.Add(this.pictureList);
            this.Controls.Add(this.histogramBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Projekt EmguCV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private Emgu.CV.UI.HistogramBox histogramBox;
        private System.Windows.Forms.ListBox pictureList;
    }
}

