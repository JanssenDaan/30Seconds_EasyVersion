namespace _30SecondsSwil
{
    partial class Form1
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
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlTeams = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.tclSwil = new System.Windows.Forms.TabControl();
            this.tbpPlayersTeams = new System.Windows.Forms.TabPage();
            this.tpbGameSettings = new System.Windows.Forms.TabPage();
            this.tpbPlay = new System.Windows.Forms.TabPage();
            this.tclSwil.SuspendLayout();
            this.tbpPlayersTeams.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(67, 15);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeam.TabIndex = 0;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(291, 15);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlayer.TabIndex = 1;
            this.btnAddPlayer.Text = "Add Players";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(675, 15);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 134);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "TO GAME SETTINGS";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // pnlTeams
            // 
            this.pnlTeams.Location = new System.Drawing.Point(0, 44);
            this.pnlTeams.Name = "pnlTeams";
            this.pnlTeams.Size = new System.Drawing.Size(213, 337);
            this.pnlTeams.TabIndex = 3;
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.Location = new System.Drawing.Point(219, 44);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(276, 337);
            this.pnlPlayers.TabIndex = 4;
            // 
            // tclSwil
            // 
            this.tclSwil.Controls.Add(this.tbpPlayersTeams);
            this.tclSwil.Controls.Add(this.tpbGameSettings);
            this.tclSwil.Controls.Add(this.tpbPlay);
            this.tclSwil.Location = new System.Drawing.Point(2, 0);
            this.tclSwil.Name = "tclSwil";
            this.tclSwil.SelectedIndex = 0;
            this.tclSwil.Size = new System.Drawing.Size(800, 452);
            this.tclSwil.TabIndex = 5;
            // 
            // tbpPlayersTeams
            // 
            this.tbpPlayersTeams.Controls.Add(this.btnAddTeam);
            this.tbpPlayersTeams.Controls.Add(this.pnlPlayers);
            this.tbpPlayersTeams.Controls.Add(this.btnAddPlayer);
            this.tbpPlayersTeams.Controls.Add(this.pnlTeams);
            this.tbpPlayersTeams.Controls.Add(this.btnNext);
            this.tbpPlayersTeams.Location = new System.Drawing.Point(4, 22);
            this.tbpPlayersTeams.Name = "tbpPlayersTeams";
            this.tbpPlayersTeams.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPlayersTeams.Size = new System.Drawing.Size(792, 426);
            this.tbpPlayersTeams.TabIndex = 0;
            this.tbpPlayersTeams.Text = "Select Players And Teams";
            this.tbpPlayersTeams.UseVisualStyleBackColor = true;
            // 
            // tpbGameSettings
            // 
            this.tpbGameSettings.Location = new System.Drawing.Point(4, 22);
            this.tpbGameSettings.Name = "tpbGameSettings";
            this.tpbGameSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpbGameSettings.Size = new System.Drawing.Size(792, 426);
            this.tpbGameSettings.TabIndex = 1;
            this.tpbGameSettings.Text = "Game View";
            this.tpbGameSettings.UseVisualStyleBackColor = true;
            // 
            // tpbPlay
            // 
            this.tpbPlay.Location = new System.Drawing.Point(4, 22);
            this.tpbPlay.Name = "tpbPlay";
            this.tpbPlay.Size = new System.Drawing.Size(792, 426);
            this.tpbPlay.TabIndex = 2;
            this.tpbPlay.Text = "Play";
            this.tpbPlay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tclSwil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tclSwil.ResumeLayout(false);
            this.tbpPlayersTeams.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabControl tclSwil;
        private System.Windows.Forms.TabPage tbpPlayersTeams;
        private System.Windows.Forms.TabPage tpbGameSettings;
        public System.Windows.Forms.FlowLayoutPanel pnlTeams;
        public System.Windows.Forms.FlowLayoutPanel pnlPlayers;
        private System.Windows.Forms.TabPage tpbPlay;
    }
}

