namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.original = new Emgu.CV.UI.ImageBox();
            this.processed = new Emgu.CV.UI.ImageBox();
            this.PauseOrPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed)).BeginInit();
            this.SuspendLayout();
            // 
            // original
            // 
            this.original.Location = new System.Drawing.Point(101, 31);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(250, 250);
            this.original.TabIndex = 2;
            this.original.TabStop = false;
            // 
            // processed
            // 
            this.processed.Location = new System.Drawing.Point(438, 31);
            this.processed.Name = "processed";
            this.processed.Size = new System.Drawing.Size(250, 250);
            this.processed.TabIndex = 3;
            this.processed.TabStop = false;
            // 
            // PauseOrPlay
            // 
            this.PauseOrPlay.Location = new System.Drawing.Point(101, 356);
            this.PauseOrPlay.Name = "PauseOrPlay";
            this.PauseOrPlay.Size = new System.Drawing.Size(100, 25);
            this.PauseOrPlay.TabIndex = 4;
            this.PauseOrPlay.Text = "Pause";
            this.PauseOrPlay.UseVisualStyleBackColor = true;
            this.PauseOrPlay.Click += new System.EventHandler(this.PauseOrPlay_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PauseOrPlay);
            this.Controls.Add(this.processed);
            this.Controls.Add(this.original);
            this.Name = "MainForm";
            this.Text = "MyGrayscaler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox original;
        private Emgu.CV.UI.ImageBox processed;
        private System.Windows.Forms.Button PauseOrPlay;
    }
}

