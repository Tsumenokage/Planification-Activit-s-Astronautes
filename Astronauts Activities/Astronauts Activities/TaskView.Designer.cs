namespace Astronauts_Activities
{
    partial class TaskView
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
            this.AstronautView = new System.Windows.Forms.ListView();
            this.AstroName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActivityView = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddActivity = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelActivityName = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelStartHour = new System.Windows.Forms.Label();
            this.labelAstronauts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AstronautView
            // 
            this.AstronautView.CheckBoxes = true;
            this.AstronautView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AstroName});
            this.AstronautView.Enabled = false;
            this.AstronautView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.AstronautView.Location = new System.Drawing.Point(218, 27);
            this.AstronautView.Name = "AstronautView";
            this.AstronautView.Size = new System.Drawing.Size(203, 97);
            this.AstronautView.TabIndex = 52;
            this.AstronautView.UseCompatibleStateImageBehavior = false;
            this.AstronautView.View = System.Windows.Forms.View.Details;
            // 
            // ActivityView
            // 
            this.ActivityView.Enabled = false;
            this.ActivityView.Location = new System.Drawing.Point(12, 27);
            this.ActivityView.Name = "ActivityView";
            this.ActivityView.Size = new System.Drawing.Size(161, 24);
            this.ActivityView.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "H";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "H";
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Location = new System.Drawing.Point(167, 305);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(75, 23);
            this.buttonAddActivity.TabIndex = 43;
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(9, 148);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(162, 13);
            this.labelDescription.TabIndex = 42;
            this.labelDescription.Text = "Description (400 characters max)";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Enabled = false;
            this.richTextBoxDescription.Location = new System.Drawing.Point(12, 164);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(409, 116);
            this.richTextBoxDescription.TabIndex = 41;
            this.richTextBoxDescription.Text = "";
            // 
            // labelActivityName
            // 
            this.labelActivityName.AutoSize = true;
            this.labelActivityName.Location = new System.Drawing.Point(44, 11);
            this.labelActivityName.Name = "labelActivityName";
            this.labelActivityName.Size = new System.Drawing.Size(84, 13);
            this.labelActivityName.TabIndex = 40;
            this.labelActivityName.Text = "Name of Activity";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(17, 90);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(47, 13);
            this.labelDuration.TabIndex = 39;
            this.labelDuration.Text = "Duration";
            // 
            // labelStartHour
            // 
            this.labelStartHour.AutoSize = true;
            this.labelStartHour.Location = new System.Drawing.Point(9, 65);
            this.labelStartHour.Name = "labelStartHour";
            this.labelStartHour.Size = new System.Drawing.Size(55, 13);
            this.labelStartHour.TabIndex = 38;
            this.labelStartHour.Text = "Start Hour";
            // 
            // labelAstronauts
            // 
            this.labelAstronauts.AutoSize = true;
            this.labelAstronauts.Location = new System.Drawing.Point(298, 11);
            this.labelAstronauts.Name = "labelAstronauts";
            this.labelAstronauts.Size = new System.Drawing.Size(57, 13);
            this.labelAstronauts.TabIndex = 37;
            this.labelAstronauts.Text = "Astronauts";
            // 
            // TaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 340);
            this.Controls.Add(this.AstronautView);
            this.Controls.Add(this.ActivityView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddActivity);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelActivityName);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelStartHour);
            this.Controls.Add(this.labelAstronauts);
            this.Name = "TaskView";
            this.Text = "TaskView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView AstronautView;
        private System.Windows.Forms.ColumnHeader AstroName;
        private System.Windows.Forms.TreeView ActivityView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddActivity;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelActivityName;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelStartHour;
        private System.Windows.Forms.Label labelAstronauts;

    }
}