namespace Astronauts_Activities
{
    partial class MissionMap
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
            this.StartDaySelector = new System.Windows.Forms.NumericUpDown();
            this.labelStartHour = new System.Windows.Forms.Label();
            this.EndDaySelector = new System.Windows.Forms.NumericUpDown();
            this.EndDay = new System.Windows.Forms.Label();
            this.MapPic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartDaySelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDaySelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapPic)).BeginInit();
            this.SuspendLayout();
            // 
            // StartDaySelector
            // 
            this.StartDaySelector.Location = new System.Drawing.Point(73, 50);
            this.StartDaySelector.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.StartDaySelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartDaySelector.Name = "StartDaySelector";
            this.StartDaySelector.Size = new System.Drawing.Size(68, 20);
            this.StartDaySelector.TabIndex = 25;
            this.StartDaySelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelStartHour
            // 
            this.labelStartHour.AutoSize = true;
            this.labelStartHour.Location = new System.Drawing.Point(12, 52);
            this.labelStartHour.Name = "labelStartHour";
            this.labelStartHour.Size = new System.Drawing.Size(51, 13);
            this.labelStartHour.TabIndex = 23;
            this.labelStartHour.Text = "Start Day";
            // 
            // EndDaySelector
            // 
            this.EndDaySelector.Location = new System.Drawing.Point(73, 86);
            this.EndDaySelector.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.EndDaySelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndDaySelector.Name = "EndDaySelector";
            this.EndDaySelector.Size = new System.Drawing.Size(68, 20);
            this.EndDaySelector.TabIndex = 27;
            this.EndDaySelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EndDay
            // 
            this.EndDay.AutoSize = true;
            this.EndDay.Location = new System.Drawing.Point(12, 88);
            this.EndDay.Name = "EndDay";
            this.EndDay.Size = new System.Drawing.Size(48, 13);
            this.EndDay.TabIndex = 26;
            this.EndDay.Text = "End Day";
            // 
            // MapPic
            // 
            this.MapPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MapPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MapPic.Location = new System.Drawing.Point(367, 12);
            this.MapPic.Name = "MapPic";
            this.MapPic.Size = new System.Drawing.Size(299, 357);
            this.MapPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapPic.TabIndex = 22;
            this.MapPic.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MissionMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EndDaySelector);
            this.Controls.Add(this.EndDay);
            this.Controls.Add(this.StartDaySelector);
            this.Controls.Add(this.labelStartHour);
            this.Controls.Add(this.MapPic);
            this.Name = "MissionMap";
            this.Text = "MissionMap";
            ((System.ComponentModel.ISupportInitialize)(this.StartDaySelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDaySelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MapPic;
        private System.Windows.Forms.NumericUpDown StartDaySelector;
        private System.Windows.Forms.Label labelStartHour;
        private System.Windows.Forms.NumericUpDown EndDaySelector;
        private System.Windows.Forms.Label EndDay;
        private System.Windows.Forms.Button button1;
    }
}