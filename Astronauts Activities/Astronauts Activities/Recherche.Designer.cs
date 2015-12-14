namespace Astronauts_Activities
{
    partial class Recherche
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
            this.DayActivities = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BeginHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Search = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.Filter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DayActivities
            // 
            this.DayActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Day,
            this.BeginHour,
            this.EndHour,
            this.Task});
            this.DayActivities.FullRowSelect = true;
            this.DayActivities.HideSelection = false;
            this.DayActivities.LabelWrap = false;
            this.DayActivities.Location = new System.Drawing.Point(285, 12);
            this.DayActivities.MultiSelect = false;
            this.DayActivities.Name = "DayActivities";
            this.DayActivities.Size = new System.Drawing.Size(397, 540);
            this.DayActivities.TabIndex = 9;
            this.DayActivities.UseCompatibleStateImageBehavior = false;
            this.DayActivities.View = System.Windows.Forms.View.Details;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 51;
            // 
            // Day
            // 
            this.Day.Text = "Day";
            this.Day.Width = 50;
            // 
            // BeginHour
            // 
            this.BeginHour.Text = "Begin";
            this.BeginHour.Width = 51;
            // 
            // EndHour
            // 
            this.EndHour.Text = "End";
            this.EndHour.Width = 72;
            // 
            // Task
            // 
            this.Task.Text = "Task";
            this.Task.Width = 169;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(12, 157);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(252, 23);
            this.Search.TabIndex = 10;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(13, 64);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(251, 20);
            this.SearchText.TabIndex = 11;
            // 
            // Filter
            // 
            this.Filter.FormattingEnabled = true;
            this.Filter.Items.AddRange(new object[] {
            "Activity Name",
            "Activity Record"});
            this.Filter.Location = new System.Drawing.Point(13, 114);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(251, 21);
            this.Filter.TabIndex = 12;
            // 
            // Recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 568);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.DayActivities);
            this.Name = "Recherche";
            this.Text = "Recherche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DayActivities;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader BeginHour;
        private System.Windows.Forms.ColumnHeader EndHour;
        private System.Windows.Forms.ColumnHeader Task;
        private System.Windows.Forms.ColumnHeader Day;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ComboBox Filter;
    }
}