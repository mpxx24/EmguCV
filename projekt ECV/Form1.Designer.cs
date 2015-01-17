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
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureList = new System.Windows.Forms.ListBox();
            this.pictureBoxHSV = new System.Windows.Forms.PictureBox();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.histogramBoxHSV = new Emgu.CV.UI.HistogramBox();
            this.zedGraphQ = new ZedGraph.ZedGraphControl();
            this.odleglosciButton = new System.Windows.Forms.Button();
            this.porownanieButton = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            this.labelTest2 = new System.Windows.Forms.Label();
            this.pictureBoxNajR = new System.Windows.Forms.PictureBox();
            this.pictureBoxNajG = new System.Windows.Forms.PictureBox();
            this.pictureBoxNajB = new System.Windows.Forms.PictureBox();
            this.labelTestNazwa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNajR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNajG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNajB)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(780, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(259, 230);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // pictureList
            // 
            this.pictureList.FormattingEnabled = true;
            this.pictureList.Location = new System.Drawing.Point(806, 314);
            this.pictureList.Name = "pictureList";
            this.pictureList.Size = new System.Drawing.Size(233, 225);
            this.pictureList.TabIndex = 4;
            this.pictureList.SelectedIndexChanged += new System.EventHandler(this.pictureList_SelectedIndexChanged);
            // 
            // pictureBoxHSV
            // 
            this.pictureBoxHSV.Location = new System.Drawing.Point(479, 45);
            this.pictureBoxHSV.Name = "pictureBoxHSV";
            this.pictureBoxHSV.Size = new System.Drawing.Size(208, 172);
            this.pictureBoxHSV.TabIndex = 5;
            this.pictureBoxHSV.TabStop = false;
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(12, 21);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(377, 230);
            this.zedGraph.TabIndex = 11;
            // 
            // histogramBoxHSV
            // 
            this.histogramBoxHSV.Location = new System.Drawing.Point(12, 314);
            this.histogramBoxHSV.Name = "histogramBoxHSV";
            this.histogramBoxHSV.Size = new System.Drawing.Size(270, 230);
            this.histogramBoxHSV.TabIndex = 6;
            // 
            // zedGraphQ
            // 
            this.zedGraphQ.Location = new System.Drawing.Point(395, 21);
            this.zedGraphQ.Name = "zedGraphQ";
            this.zedGraphQ.ScrollGrace = 0D;
            this.zedGraphQ.ScrollMaxX = 0D;
            this.zedGraphQ.ScrollMaxY = 0D;
            this.zedGraphQ.ScrollMaxY2 = 0D;
            this.zedGraphQ.ScrollMinX = 0D;
            this.zedGraphQ.ScrollMinY = 0D;
            this.zedGraphQ.ScrollMinY2 = 0D;
            this.zedGraphQ.Size = new System.Drawing.Size(377, 230);
            this.zedGraphQ.TabIndex = 12;
            // 
            // odleglosciButton
            // 
            this.odleglosciButton.Location = new System.Drawing.Point(780, 272);
            this.odleglosciButton.Name = "odleglosciButton";
            this.odleglosciButton.Size = new System.Drawing.Size(75, 23);
            this.odleglosciButton.TabIndex = 13;
            this.odleglosciButton.Text = "Odleglosci";
            this.odleglosciButton.UseVisualStyleBackColor = true;
            this.odleglosciButton.Click += new System.EventHandler(this.odleglosciButton_Click);
            // 
            // porownanieButton
            // 
            this.porownanieButton.Location = new System.Drawing.Point(964, 272);
            this.porownanieButton.Name = "porownanieButton";
            this.porownanieButton.Size = new System.Drawing.Size(75, 23);
            this.porownanieButton.TabIndex = 14;
            this.porownanieButton.Text = "porównaj";
            this.porownanieButton.UseVisualStyleBackColor = true;
            this.porownanieButton.Click += new System.EventHandler(this.porownanieButton_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(395, 272);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(58, 13);
            this.labelTest.TabIndex = 15;
            this.labelTest.Text = "Manhattan";
            // 
            // labelTest2
            // 
            this.labelTest2.AutoSize = true;
            this.labelTest2.Location = new System.Drawing.Point(398, 295);
            this.labelTest2.Name = "labelTest2";
            this.labelTest2.Size = new System.Drawing.Size(47, 13);
            this.labelTest2.TabIndex = 16;
            this.labelTest2.Text = "Euklides";
            // 
            // pictureBoxNajR
            // 
            this.pictureBoxNajR.Location = new System.Drawing.Point(2, 314);
            this.pictureBoxNajR.Name = "pictureBoxNajR";
            this.pictureBoxNajR.Size = new System.Drawing.Size(259, 230);
            this.pictureBoxNajR.TabIndex = 17;
            this.pictureBoxNajR.TabStop = false;
            // 
            // pictureBoxNajG
            // 
            this.pictureBoxNajG.Location = new System.Drawing.Point(267, 314);
            this.pictureBoxNajG.Name = "pictureBoxNajG";
            this.pictureBoxNajG.Size = new System.Drawing.Size(259, 230);
            this.pictureBoxNajG.TabIndex = 18;
            this.pictureBoxNajG.TabStop = false;
            // 
            // pictureBoxNajB
            // 
            this.pictureBoxNajB.Location = new System.Drawing.Point(541, 314);
            this.pictureBoxNajB.Name = "pictureBoxNajB";
            this.pictureBoxNajB.Size = new System.Drawing.Size(259, 230);
            this.pictureBoxNajB.TabIndex = 19;
            this.pictureBoxNajB.TabStop = false;
            // 
            // labelTestNazwa
            // 
            this.labelTestNazwa.AutoSize = true;
            this.labelTestNazwa.Location = new System.Drawing.Point(26, 281);
            this.labelTestNazwa.Name = "labelTestNazwa";
            this.labelTestNazwa.Size = new System.Drawing.Size(35, 13);
            this.labelTestNazwa.TabIndex = 20;
            this.labelTestNazwa.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 556);
            this.Controls.Add(this.labelTestNazwa);
            this.Controls.Add(this.pictureBoxNajB);
            this.Controls.Add(this.pictureBoxNajG);
            this.Controls.Add(this.pictureBoxNajR);
            this.Controls.Add(this.labelTest2);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.porownanieButton);
            this.Controls.Add(this.odleglosciButton);
            this.Controls.Add(this.zedGraphQ);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.histogramBoxHSV);
            this.Controls.Add(this.pictureBoxHSV);
            this.Controls.Add(this.pictureList);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Projekt EmguCV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNajR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNajG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNajB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListBox pictureList;
        private System.Windows.Forms.PictureBox pictureBoxHSV;
        private ZedGraph.ZedGraphControl zedGraph;
        private Emgu.CV.UI.HistogramBox histogramBoxHSV;
        private ZedGraph.ZedGraphControl zedGraphQ;
        private System.Windows.Forms.Button odleglosciButton;
        private System.Windows.Forms.Button porownanieButton;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Label labelTest2;
        private System.Windows.Forms.PictureBox pictureBoxNajR;
        private System.Windows.Forms.PictureBox pictureBoxNajG;
        private System.Windows.Forms.PictureBox pictureBoxNajB;
        private System.Windows.Forms.Label labelTestNazwa;
    }
}

