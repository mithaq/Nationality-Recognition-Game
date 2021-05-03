namespace Nationality_Recognition_Game
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.JapaneseBox = new System.Windows.Forms.GroupBox();
            this.ChineseBox = new System.Windows.Forms.GroupBox();
            this.ThaiBox = new System.Windows.Forms.GroupBox();
            this.KoreanBox = new System.Windows.Forms.GroupBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.MovingTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelScore = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLastScore = new System.Windows.Forms.Label();
            this.RulesBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PanelScore.SuspendLayout();
            this.RulesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // JapaneseBox
            // 
            this.JapaneseBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JapaneseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.JapaneseBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JapaneseBox.Location = new System.Drawing.Point(12, 12);
            this.JapaneseBox.Name = "JapaneseBox";
            this.JapaneseBox.Size = new System.Drawing.Size(170, 180);
            this.JapaneseBox.TabIndex = 0;
            this.JapaneseBox.TabStop = false;
            this.JapaneseBox.Text = "Japanese";
            this.JapaneseBox.Visible = false;
            // 
            // ChineseBox
            // 
            this.ChineseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChineseBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChineseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ChineseBox.Location = new System.Drawing.Point(915, 12);
            this.ChineseBox.Name = "ChineseBox";
            this.ChineseBox.Size = new System.Drawing.Size(170, 180);
            this.ChineseBox.TabIndex = 0;
            this.ChineseBox.TabStop = false;
            this.ChineseBox.Text = "Chinese";
            this.ChineseBox.Visible = false;
            // 
            // ThaiBox
            // 
            this.ThaiBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ThaiBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ThaiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ThaiBox.Location = new System.Drawing.Point(915, 453);
            this.ThaiBox.Name = "ThaiBox";
            this.ThaiBox.Size = new System.Drawing.Size(170, 180);
            this.ThaiBox.TabIndex = 0;
            this.ThaiBox.TabStop = false;
            this.ThaiBox.Text = "Thai";
            this.ThaiBox.Visible = false;
            // 
            // KoreanBox
            // 
            this.KoreanBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.KoreanBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KoreanBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KoreanBox.Location = new System.Drawing.Point(12, 453);
            this.KoreanBox.Name = "KoreanBox";
            this.KoreanBox.Size = new System.Drawing.Size(170, 180);
            this.KoreanBox.TabIndex = 0;
            this.KoreanBox.TabStop = false;
            this.KoreanBox.Text = "Korean";
            this.KoreanBox.Visible = false;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnStartGame.Location = new System.Drawing.Point(425, 472);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(258, 100);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // MovingTimer
            // 
            this.MovingTimer.Interval = 10;
            this.MovingTimer.Tick += new System.EventHandler(this.MovingTimer_Tick);
            // 
            // PanelScore
            // 
            this.PanelScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelScore.Controls.Add(this.lblScore);
            this.PanelScore.Controls.Add(this.lblLastScore);
            this.PanelScore.Location = new System.Drawing.Point(425, 578);
            this.PanelScore.Name = "PanelScore";
            this.PanelScore.Size = new System.Drawing.Size(258, 67);
            this.PanelScore.TabIndex = 2;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(131, 21);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(21, 24);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            // 
            // lblLastScore
            // 
            this.lblLastScore.AutoSize = true;
            this.lblLastScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastScore.Location = new System.Drawing.Point(16, 21);
            this.lblLastScore.Name = "lblLastScore";
            this.lblLastScore.Size = new System.Drawing.Size(114, 24);
            this.lblLastScore.TabIndex = 1;
            this.lblLastScore.Text = "Last Score:";
            // 
            // RulesBox
            // 
            this.RulesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RulesBox.Controls.Add(this.richTextBox1);
            this.RulesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RulesBox.Location = new System.Drawing.Point(207, 28);
            this.RulesBox.Name = "RulesBox";
            this.RulesBox.Size = new System.Drawing.Size(691, 438);
            this.RulesBox.TabIndex = 3;
            this.RulesBox.TabStop = false;
            this.RulesBox.Text = "Rules of the game";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(18, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(651, 386);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 645);
            this.Controls.Add(this.RulesBox);
            this.Controls.Add(this.PanelScore);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.JapaneseBox);
            this.Controls.Add(this.ThaiBox);
            this.Controls.Add(this.ChineseBox);
            this.Controls.Add(this.KoreanBox);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.PanelScore.ResumeLayout(false);
            this.PanelScore.PerformLayout();
            this.RulesBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox JapaneseBox;
        private System.Windows.Forms.GroupBox ChineseBox;
        private System.Windows.Forms.GroupBox ThaiBox;
        private System.Windows.Forms.GroupBox KoreanBox;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Timer MovingTimer;
        private System.Windows.Forms.Panel PanelScore;
        private System.Windows.Forms.Label lblLastScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.GroupBox RulesBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

