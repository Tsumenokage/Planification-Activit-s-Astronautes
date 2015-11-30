namespace Astronauts_Activities
{
    partial class Map
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
            this.MapPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MapPic)).BeginInit();
            this.SuspendLayout();
            // 
            // MapPic
            // 
            this.MapPic.Location = new System.Drawing.Point(0, 0);
            this.MapPic.Name = "MapPic";
            this.MapPic.Size = new System.Drawing.Size(388, 449);
            this.MapPic.TabIndex = 0;
            this.MapPic.TabStop = false;
            this.MapPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MapPic_MouseUp);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(390, 444);
            this.Controls.Add(this.MapPic);
            this.Name = "Map";
            this.Text = "Map";
            ((System.ComponentModel.ISupportInitialize)(this.MapPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MapPic;
    }
}