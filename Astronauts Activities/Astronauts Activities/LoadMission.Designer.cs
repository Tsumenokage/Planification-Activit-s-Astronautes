namespace Astronauts_Activities
{
    partial class LoadMission
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.MissionText = new System.Windows.Forms.TextBox();
            this.SaveText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(485, 51);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(109, 94);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // MissionText
            // 
            this.MissionText.Location = new System.Drawing.Point(143, 51);
            this.MissionText.Name = "MissionText";
            this.MissionText.Size = new System.Drawing.Size(302, 20);
            this.MissionText.TabIndex = 1;
            this.MissionText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MissionText_MouseClick);
            // 
            // SaveText
            // 
            this.SaveText.Location = new System.Drawing.Point(143, 107);
            this.SaveText.Name = "SaveText";
            this.SaveText.Size = new System.Drawing.Size(302, 20);
            this.SaveText.TabIndex = 2;
            this.SaveText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SaveText_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Xml Mission File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Xml Save File";
            // 
            // LoadMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 205);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveText);
            this.Controls.Add(this.MissionText);
            this.Controls.Add(this.LoadButton);
            this.Name = "LoadMission";
            this.Text = "LoadMission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox MissionText;
        private System.Windows.Forms.TextBox SaveText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}