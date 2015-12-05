namespace Astronauts_Activities
{
    partial class TaskForm
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
            this.labelAstronauts = new System.Windows.Forms.Label();
            this.labelStartHour = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelActivityName = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonAddActivity = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.StartHour = new System.Windows.Forms.NumericUpDown();
            this.MinutesStart = new System.Windows.Forms.NumericUpDown();
            this.DurationHour = new System.Windows.Forms.NumericUpDown();
            this.DurationMinute = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ActivityView = new System.Windows.Forms.TreeView();
            this.AstronautView = new System.Windows.Forms.ListView();
            this.AstroName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MapPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapPic)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAstronauts
            // 
            this.labelAstronauts.AutoSize = true;
            this.labelAstronauts.Location = new System.Drawing.Point(482, 20);
            this.labelAstronauts.Name = "labelAstronauts";
            this.labelAstronauts.Size = new System.Drawing.Size(57, 13);
            this.labelAstronauts.TabIndex = 1;
            this.labelAstronauts.Text = "Astronauts";
            // 
            // labelStartHour
            // 
            this.labelStartHour.AutoSize = true;
            this.labelStartHour.Location = new System.Drawing.Point(193, 74);
            this.labelStartHour.Name = "labelStartHour";
            this.labelStartHour.Size = new System.Drawing.Size(55, 13);
            this.labelStartHour.TabIndex = 5;
            this.labelStartHour.Text = "Start Hour";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(201, 99);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(47, 13);
            this.labelDuration.TabIndex = 6;
            this.labelDuration.Text = "Duration";
            // 
            // labelActivityName
            // 
            this.labelActivityName.AutoSize = true;
            this.labelActivityName.Location = new System.Drawing.Point(58, 20);
            this.labelActivityName.Name = "labelActivityName";
            this.labelActivityName.Size = new System.Drawing.Size(84, 13);
            this.labelActivityName.TabIndex = 7;
            this.labelActivityName.Text = "Name of Activity";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(196, 173);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(409, 116);
            this.richTextBoxDescription.TabIndex = 9;
            this.richTextBoxDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(193, 157);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(162, 13);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description (400 characters max)";
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Location = new System.Drawing.Point(280, 295);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(75, 23);
            this.buttonAddActivity.TabIndex = 11;
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(446, 295);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // StartHour
            // 
            this.StartHour.Location = new System.Drawing.Point(254, 72);
            this.StartHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.StartHour.Name = "StartHour";
            this.StartHour.Size = new System.Drawing.Size(32, 20);
            this.StartHour.TabIndex = 13;
            this.StartHour.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // MinutesStart
            // 
            this.MinutesStart.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MinutesStart.Location = new System.Drawing.Point(318, 72);
            this.MinutesStart.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinutesStart.Name = "MinutesStart";
            this.MinutesStart.Size = new System.Drawing.Size(32, 20);
            this.MinutesStart.TabIndex = 14;
            // 
            // DurationHour
            // 
            this.DurationHour.Location = new System.Drawing.Point(254, 99);
            this.DurationHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.DurationHour.Name = "DurationHour";
            this.DurationHour.Size = new System.Drawing.Size(32, 20);
            this.DurationHour.TabIndex = 15;
            // 
            // DurationMinute
            // 
            this.DurationMinute.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DurationMinute.Location = new System.Drawing.Point(318, 99);
            this.DurationMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.DurationMinute.Name = "DurationMinute";
            this.DurationMinute.Size = new System.Drawing.Size(32, 20);
            this.DurationMinute.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "H";
            // 
            // ActivityView
            // 
            this.ActivityView.Location = new System.Drawing.Point(13, 35);
            this.ActivityView.Name = "ActivityView";
            this.ActivityView.Size = new System.Drawing.Size(161, 361);
            this.ActivityView.TabIndex = 19;
            this.ActivityView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ActivityView_NodeMouseClick);
            // 
            // AstronautView
            // 
            this.AstronautView.CheckBoxes = true;
            this.AstronautView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AstroName});
            this.AstronautView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.AstronautView.Location = new System.Drawing.Point(402, 36);
            this.AstronautView.Name = "AstronautView";
            this.AstronautView.Size = new System.Drawing.Size(203, 97);
            this.AstronautView.TabIndex = 20;
            this.AstronautView.UseCompatibleStateImageBehavior = false;
            this.AstronautView.View = System.Windows.Forms.View.Details;
            // 
            // MapPic
            // 
            this.MapPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MapPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MapPic.Location = new System.Drawing.Point(649, 39);
            this.MapPic.Name = "MapPic";
            this.MapPic.Size = new System.Drawing.Size(299, 357);
            this.MapPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapPic.TabIndex = 21;
            this.MapPic.TabStop = false;
            this.MapPic.DoubleClick += new System.EventHandler(this.MapPic_DoubleClick);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 451);
            this.Controls.Add(this.MapPic);
            this.Controls.Add(this.AstronautView);
            this.Controls.Add(this.ActivityView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DurationMinute);
            this.Controls.Add(this.DurationHour);
            this.Controls.Add(this.MinutesStart);
            this.Controls.Add(this.StartHour);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddActivity);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelActivityName);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelStartHour);
            this.Controls.Add(this.labelAstronauts);
            this.Name = "TaskForm";
            this.Text = "Task";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TaskForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.StartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAstronauts;
        private System.Windows.Forms.Label labelStartHour;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelActivityName;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonAddActivity;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown StartHour;
        private System.Windows.Forms.NumericUpDown MinutesStart;
        private System.Windows.Forms.NumericUpDown DurationHour;
        private System.Windows.Forms.NumericUpDown DurationMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView ActivityView;
        private System.Windows.Forms.ListView AstronautView;
        private System.Windows.Forms.ColumnHeader AstroName;
        private System.Windows.Forms.PictureBox MapPic;
    }
}