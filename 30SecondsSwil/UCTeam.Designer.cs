namespace _30SecondsSwil
{
    partial class UCTeam
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxTeamName
            // 
            this.tbxTeamName.Location = new System.Drawing.Point(4, 38);
            this.tbxTeamName.Name = "tbxTeamName";
            this.tbxTeamName.Size = new System.Drawing.Size(100, 20);
            this.tbxTeamName.TabIndex = 0;
            this.tbxTeamName.TextChanged += new System.EventHandler(this.tbxTeamName_TextChanged);
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(4, 19);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(62, 13);
            this.lblTeamName.TabIndex = 1;
            this.lblTeamName.Text = "TeamName";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Location = new System.Drawing.Point(110, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 55);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Delete";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UCTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.tbxTeamName);
            this.Name = "UCTeam";
            this.Size = new System.Drawing.Size(186, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.TextBox tbxTeamName;
    }
}
