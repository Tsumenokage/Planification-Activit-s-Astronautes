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
            this.checkedListBoxAstronauts = new System.Windows.Forms.CheckedListBox();
            this.labelAstronauts = new System.Windows.Forms.Label();
            this.textBoxStartHour = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.comboBoxActivity = new System.Windows.Forms.ComboBox();
            this.labelStartHour = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelActivityName = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonAddActivity = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxAstronauts
            // 
            this.checkedListBoxAstronauts.FormattingEnabled = true;
            this.checkedListBoxAstronauts.Location = new System.Drawing.Point(271, 36);
            this.checkedListBoxAstronauts.Name = "checkedListBoxAstronauts";
            this.checkedListBoxAstronauts.Size = new System.Drawing.Size(159, 94);
            this.checkedListBoxAstronauts.TabIndex = 0;
            // 
            // labelAstronauts
            // 
            this.labelAstronauts.AutoSize = true;
            this.labelAstronauts.Location = new System.Drawing.Point(326, 20);
            this.labelAstronauts.Name = "labelAstronauts";
            this.labelAstronauts.Size = new System.Drawing.Size(57, 13);
            this.labelAstronauts.TabIndex = 1;
            this.labelAstronauts.Text = "Astronauts";
            // 
            // textBoxStartHour
            // 
            this.textBoxStartHour.Location = new System.Drawing.Point(79, 89);
            this.textBoxStartHour.Name = "textBoxStartHour";
            this.textBoxStartHour.Size = new System.Drawing.Size(156, 20);
            this.textBoxStartHour.TabIndex = 2;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(79, 117);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(156, 20);
            this.textBoxDuration.TabIndex = 3;
            // 
            // comboBoxActivity
            // 
            this.comboBoxActivity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxActivity.FormattingEnabled = true;
            this.comboBoxActivity.Location = new System.Drawing.Point(21, 36);
            this.comboBoxActivity.Name = "comboBoxActivity";
            this.comboBoxActivity.Size = new System.Drawing.Size(154, 21);
            this.comboBoxActivity.TabIndex = 4;
            // 
            // labelStartHour
            // 
            this.labelStartHour.AutoSize = true;
            this.labelStartHour.Location = new System.Drawing.Point(18, 92);
            this.labelStartHour.Name = "labelStartHour";
            this.labelStartHour.Size = new System.Drawing.Size(55, 13);
            this.labelStartHour.TabIndex = 5;
            this.labelStartHour.Text = "Start Hour";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(26, 117);
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
            this.richTextBoxDescription.Location = new System.Drawing.Point(21, 174);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(409, 116);
            this.richTextBoxDescription.TabIndex = 9;
            this.richTextBoxDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(18, 158);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(162, 13);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description (400 characters max)";
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Location = new System.Drawing.Point(105, 296);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(75, 23);
            this.buttonAddActivity.TabIndex = 11;
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(271, 296);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 326);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddActivity);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelActivityName);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelStartHour);
            this.Controls.Add(this.comboBoxActivity);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.textBoxStartHour);
            this.Controls.Add(this.labelAstronauts);
            this.Controls.Add(this.checkedListBoxAstronauts);
            this.Name = "TaskForm";
            this.Text = "Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxAstronauts;
        private System.Windows.Forms.Label labelAstronauts;
        private System.Windows.Forms.TextBox textBoxStartHour;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.ComboBox comboBoxActivity;
        private System.Windows.Forms.Label labelStartHour;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelActivityName;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonAddActivity;
        private System.Windows.Forms.Button buttonCancel;

    }
}