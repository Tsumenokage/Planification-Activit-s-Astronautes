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
            this.listCalendar = new System.Windows.Forms.ListView();
            this.buttonShowReport = new System.Windows.Forms.Button();
            this.buttonNextDay = new System.Windows.Forms.Button();
            this.buttonPreviousDay = new System.Windows.Forms.Button();
            this.buttonEditTask = new System.Windows.Forms.Button();
            this.buttonRemoveTask = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.listActivityOfDay = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlanningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoSurLaMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.splitContainer1.Panel2.Controls.Add(this.buttonShowReport);
            this.splitContainer1.Panel2.Controls.Add(this.buttonNextDay);
            this.splitContainer1.Panel2.Controls.Add(this.buttonPreviousDay);
            this.splitContainer1.Panel2.Controls.Add(this.buttonEditTask);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRemoveTask);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddTask);
            this.splitContainer1.Panel2.Controls.Add(this.listActivityOfDay);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 620);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 1;
            // 
            // listCalendar
            // 
            this.listCalendar.Location = new System.Drawing.Point(3, 3);
            this.listCalendar.Name = "listCalendar";
            this.listCalendar.Size = new System.Drawing.Size(363, 614);
            this.listCalendar.TabIndex = 0;
            this.listCalendar.UseCompatibleStateImageBehavior = false;
            this.listCalendar.View = System.Windows.Forms.View.List;
            this.listCalendar.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // listActivityOfDay
            // 
            this.listActivityOfDay.Location = new System.Drawing.Point(4, 35);
            this.listActivityOfDay.Name = "listActivityOfDay";
            this.listActivityOfDay.Size = new System.Drawing.Size(691, 553);
            this.listActivityOfDay.TabIndex = 0;
            this.listActivityOfDay.UseCompatibleStateImageBehavior = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listCalendar;
        private System.Windows.Forms.ListView listActivityOfDay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlanningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
<<<<<<< HEAD:Astronauts Activities/Astronauts Activities/Mission.Designer.cs
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoSurLaMissionToolStripMenuItem;
=======
        private System.Windows.Forms.Button buttonRemoveTask;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonShowReport;
        private System.Windows.Forms.Button buttonNextDay;
        private System.Windows.Forms.Button buttonPreviousDay;
        private System.Windows.Forms.Button buttonEditTask;
>>>>>>> origin/master:Astronauts Activities/Astronauts Activities/Form1.Designer.cs
    }
}

