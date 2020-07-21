namespace OCRApp
{
    partial class OCRApp
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
            this.OriginalImage = new Emgu.CV.UI.ImageBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.PictureLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginalImage
            // 
            this.OriginalImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.OriginalImage.Location = new System.Drawing.Point(0, 0);
            this.OriginalImage.Name = "OriginalImage";
            this.OriginalImage.Size = new System.Drawing.Size(250, 450);
            this.OriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalImage.TabIndex = 2;
            this.OriginalImage.TabStop = false;
            this.OriginalImage.Click += new System.EventHandler(this.OriginalImage_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Location = new System.Drawing.Point(350, 50);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(350, 350);
            this.ResultTextBox.TabIndex = 3;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(461, 22);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(125, 25);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Detected Text";
            // 
            // PictureLabel
            // 
            this.PictureLabel.AutoSize = true;
            this.PictureLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureLabel.Location = new System.Drawing.Point(48, 22);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(147, 25);
            this.PictureLabel.TabIndex = 5;
            this.PictureLabel.Text = "Selected Picture";
            // 
            // OCRApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.OriginalImage);
            this.Name = "OCRApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox OriginalImage;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label PictureLabel;
    }
}

