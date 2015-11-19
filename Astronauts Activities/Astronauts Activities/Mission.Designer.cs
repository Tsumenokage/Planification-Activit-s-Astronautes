namespace Astronauts_Activities
{
    partial class Mission
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listCalendar = new System.Windows.Forms.TreeView();
            this.DayActivities = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BeginHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AstronautList = new System.Windows.Forms.ComboBox();
            this.buttonShowReport = new System.Windows.Forms.Button();
            this.buttonNextDay = new System.Windows.Forms.Button();
            this.buttonPreviousDay = new System.Windows.Forms.Button();
            this.buttonEditTask = new System.Windows.Forms.Button();
            this.buttonRemoveTask = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlanningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoSurLaMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.EarthHour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MissionTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 38);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listCalendar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MissionTime);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.EarthHour);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.DayActivities);
            this.splitContainer1.Panel2.Controls.Add(this.AstronautList);
            this.splitContainer1.Panel2.Controls.Add(this.buttonShowReport);
            this.splitContainer1.Panel2.Controls.Add(this.buttonNextDay);
            this.splitContainer1.Panel2.Controls.Add(this.buttonPreviousDay);
            this.splitContainer1.Panel2.Controls.Add(this.buttonEditTask);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRemoveTask);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddTask);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 620);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 1;
            // 
            // listCalendar
            // 
            this.listCalendar.HideSelection = false;
            this.listCalendar.Location = new System.Drawing.Point(4, 4);
            this.listCalendar.Name = "listCalendar";
            this.listCalendar.Size = new System.Drawing.Size(362, 613);
            this.listCalendar.TabIndex = 0;
            this.listCalendar.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ViewDayPlanning);
            // 
            // DayActivities
            // 
            this.DayActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.BeginHour,
            this.EndHour,
            this.Task});
            this.DayActivities.FullRowSelect = true;
            this.DayActivities.HideSelection = false;
            this.DayActivities.LabelWrap = false;
            this.DayActivities.Location = new System.Drawing.Point(187, 48);
            this.DayActivities.MultiSelect = false;
            this.DayActivities.Name = "DayActivities";
            this.DayActivities.Size = new System.Drawing.Size(312, 540);
            this.DayActivities.TabIndex = 8;
            this.DayActivities.UseCompatibleStateImageBehavior = false;
            this.DayActivities.View = System.Windows.Forms.View.Details;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 51;
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
            this.Task.Width = 130;
            // 
            // AstronautList
            // 
            this.AstronautList.FormattingEnabled = true;
            this.AstronautList.Location = new System.Drawing.Point(13, 48);
            this.AstronautList.Name = "AstronautList";
            this.AstronautList.Size = new System.Drawing.Size(152, 21);
            this.AstronautList.TabIndex = 7;
            this.AstronautList.SelectedIndexChanged += new System.EventHandler(this.ViewDayPlanning);
            // 
            // buttonShowReport
            // 
            this.buttonShowReport.Location = new System.Drawing.Point(284, 4);
            this.buttonShowReport.Name = "buttonShowReport";
            this.buttonShowReport.Size = new System.Drawing.Size(133, 25);
            this.buttonShowReport.TabIndex = 6;
            this.buttonShowReport.Text = "Show Report";
            this.buttonShowReport.UseVisualStyleBackColor = true;
            // 
            // buttonNextDay
            // 
            this.buttonNextDay.Location = new System.Drawing.Point(593, 3);
            this.buttonNextDay.Name = "buttonNextDay";
            this.buttonNextDay.Size = new System.Drawing.Size(102, 23);
            this.buttonNextDay.TabIndex = 5;
            this.buttonNextDay.Text = "Next Day --->";
            this.buttonNextDay.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousDay
            // 
            this.buttonPreviousDay.Location = new System.Drawing.Point(4, 4);
            this.buttonPreviousDay.Name = "buttonPreviousDay";
            this.buttonPreviousDay.Size = new System.Drawing.Size(102, 23);
            this.buttonPreviousDay.TabIndex = 4;
            this.buttonPreviousDay.Text = "<--- Previous Day";
            this.buttonPreviousDay.UseVisualStyleBackColor = true;
            // 
            // buttonEditTask
            // 
            this.buttonEditTask.Location = new System.Drawing.Point(423, 594);
            this.buttonEditTask.Name = "buttonEditTask";
            this.buttonEditTask.Size = new System.Drawing.Size(133, 23);
            this.buttonEditTask.TabIndex = 3;
            this.buttonEditTask.Text = "Edit Selected Task";
            this.buttonEditTask.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveTask
            // 
            this.buttonRemoveTask.Location = new System.Drawing.Point(562, 594);
            this.buttonRemoveTask.Name = "buttonRemoveTask";
            this.buttonRemoveTask.Size = new System.Drawing.Size(133, 23);
            this.buttonRemoveTask.TabIndex = 2;
            this.buttonRemoveTask.Text = "Remove Selected Task";
            this.buttonRemoveTask.UseVisualStyleBackColor = true;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(284, 594);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(133, 23);
            this.buttonAddTask.TabIndex = 1;
            this.buttonAddTask.Text = "Add New Task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlanningToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPlanningToolStripMenuItem
            // 
            this.newPlanningToolStripMenuItem.Name = "newPlanningToolStripMenuItem";
            this.newPlanningToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newPlanningToolStripMenuItem.Text = "New Planning";
            this.newPlanningToolStripMenuItem.Click += new System.EventHandler(this.newPlanningToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoSurLaMissionToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // infoSurLaMissionToolStripMenuItem
            // 
            this.infoSurLaMissionToolStripMenuItem.Name = "infoSurLaMissionToolStripMenuItem";
            this.infoSurLaMissionToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.infoSurLaMissionToolStripMenuItem.Text = "Info sur la mission";
            this.infoSurLaMissionToolStripMenuItem.Click += new System.EventHandler(this.infoSurLaMissionToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Earth Hour";
            // 
            // EarthHour
            // 
            this.EarthHour.AutoSize = true;
            this.EarthHour.Location = new System.Drawing.Point(30, 152);
            this.EarthHour.Name = "EarthHour";
            this.EarthHour.Size = new System.Drawing.Size(36, 13);
            this.EarthHour.TabIndex = 10;
            this.EarthHour.Text = "Heure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mission Time";
            // 
            // MissionTime
            // 
            this.MissionTime.AutoSize = true;
            this.MissionTime.Location = new System.Drawing.Point(30, 248);
            this.MissionTime.Name = "MissionTime";
            this.MissionTime.Size = new System.Drawing.Size(36, 13);
            this.MissionTime.TabIndex = 12;
            this.MissionTime.Text = "Heure";
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 670);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mission";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlanningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoSurLaMissionToolStripMenuItem;
        private System.Windows.Forms.Button buttonRemoveTask;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonShowReport;
        private System.Windows.Forms.Button buttonNextDay;
        private System.Windows.Forms.Button buttonPreviousDay;
        private System.Windows.Forms.Button buttonEditTask;
        private System.Windows.Forms.TreeView listCalendar;
        private System.Windows.Forms.ComboBox AstronautList;
        private System.Windows.Forms.ListView DayActivities;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader BeginHour;
        private System.Windows.Forms.ColumnHeader EndHour;
        private System.Windows.Forms.ColumnHeader Task;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EarthHour;
        private System.Windows.Forms.Label MissionTime;
        private System.Windows.Forms.Label label2;
    }
}

