namespace Astronauts_Activities
{
    partial class SelectAstroDelete
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
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AstronautView
            // 
            this.AstronautView.CheckBoxes = true;
            this.AstronautView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AstroName});
            this.AstronautView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.AstronautView.Location = new System.Drawing.Point(12, 12);
            this.AstronautView.Name = "AstronautView";
            this.AstronautView.Size = new System.Drawing.Size(276, 120);
            this.AstronautView.TabIndex = 21;
            this.AstronautView.UseCompatibleStateImageBehavior = false;
            this.AstronautView.View = System.Windows.Forms.View.Details;
            this.AstronautView.SelectedIndexChanged += new System.EventHandler(this.AstronautView_SelectedIndexChanged);
            // 
            // AstroName
            // 
            this.AstroName.Width = 271;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 151);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 22;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(109, 151);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 23;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(203, 151);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(85, 23);
            this.DeleteAll.TabIndex = 24;
            this.DeleteAll.Text = "Delete for All";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // SelectAstroDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 201);
            this.Controls.Add(this.DeleteAll);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.AstronautView);
            this.Name = "SelectAstroDelete";
            this.Text = "SelectAstroDelete";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView AstronautView;
        private System.Windows.Forms.ColumnHeader AstroName;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DeleteAll;
    }
}