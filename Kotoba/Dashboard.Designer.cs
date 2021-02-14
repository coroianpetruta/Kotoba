namespace Kotoba
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.listBox_Decks = new System.Windows.Forms.ListBox();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.button_AddDeck = new System.Windows.Forms.Button();
            this.button_DeleteDeck = new System.Windows.Forms.Button();
            this.button_Test = new System.Windows.Forms.Button();
            this.button_Practice = new System.Windows.Forms.Button();
            this.button_View = new System.Windows.Forms.Button();
            this.label_Decks = new System.Windows.Forms.Label();
            this.label_Dashboard = new System.Windows.Forms.Label();
            this.pictureBox_Background = new System.Windows.Forms.PictureBox();
            this.label_Empty = new System.Windows.Forms.Label();
            this.pictureBox_Empty = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Empty)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Decks
            // 
            this.listBox_Decks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Decks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.listBox_Decks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Decks.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Decks.ForeColor = System.Drawing.Color.White;
            this.listBox_Decks.FormattingEnabled = true;
            this.listBox_Decks.ItemHeight = 37;
            this.listBox_Decks.Location = new System.Drawing.Point(46, 85);
            this.listBox_Decks.Name = "listBox_Decks";
            this.listBox_Decks.Size = new System.Drawing.Size(438, 370);
            this.listBox_Decks.TabIndex = 0;
            // 
            // panel_Content
            // 
            this.panel_Content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Content.Controls.Add(this.panel2);
            this.panel_Content.Controls.Add(this.panel1);
            this.panel_Content.Controls.Add(this.pictureBox_Empty);
            this.panel_Content.Controls.Add(this.label_Empty);
            this.panel_Content.Controls.Add(this.button_AddDeck);
            this.panel_Content.Controls.Add(this.button_DeleteDeck);
            this.panel_Content.Controls.Add(this.button_Test);
            this.panel_Content.Controls.Add(this.button_Practice);
            this.panel_Content.Controls.Add(this.button_View);
            this.panel_Content.Controls.Add(this.label_Decks);
            this.panel_Content.Controls.Add(this.listBox_Decks);
            this.panel_Content.Location = new System.Drawing.Point(231, 140);
            this.panel_Content.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(730, 538);
            this.panel_Content.TabIndex = 1;
            // 
            // button_AddDeck
            // 
            this.button_AddDeck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddDeck.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddDeck.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_AddDeck.Location = new System.Drawing.Point(338, 40);
            this.button_AddDeck.Name = "button_AddDeck";
            this.button_AddDeck.Size = new System.Drawing.Size(162, 39);
            this.button_AddDeck.TabIndex = 7;
            this.button_AddDeck.Text = "+ Add Deck";
            this.button_AddDeck.UseVisualStyleBackColor = true;
            this.button_AddDeck.Click += new System.EventHandler(this.button_AddDeck_Click);
            this.button_AddDeck.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button_AddDeck.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button_DeleteDeck
            // 
            this.button_DeleteDeck.BackColor = System.Drawing.Color.Brown;
            this.button_DeleteDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeleteDeck.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteDeck.ForeColor = System.Drawing.Color.White;
            this.button_DeleteDeck.Location = new System.Drawing.Point(511, 268);
            this.button_DeleteDeck.Name = "button_DeleteDeck";
            this.button_DeleteDeck.Size = new System.Drawing.Size(176, 39);
            this.button_DeleteDeck.TabIndex = 6;
            this.button_DeleteDeck.Text = "Delete";
            this.button_DeleteDeck.UseVisualStyleBackColor = false;
            this.button_DeleteDeck.Click += new System.EventHandler(this.button_DeleteDeck_Click);
            // 
            // button_Test
            // 
            this.button_Test.BackColor = System.Drawing.Color.DimGray;
            this.button_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Test.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Test.ForeColor = System.Drawing.Color.White;
            this.button_Test.Location = new System.Drawing.Point(511, 208);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(176, 39);
            this.button_Test.TabIndex = 5;
            this.button_Test.Text = "Test";
            this.button_Test.UseVisualStyleBackColor = false;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // button_Practice
            // 
            this.button_Practice.BackColor = System.Drawing.Color.DimGray;
            this.button_Practice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Practice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Practice.ForeColor = System.Drawing.Color.White;
            this.button_Practice.Location = new System.Drawing.Point(511, 146);
            this.button_Practice.Name = "button_Practice";
            this.button_Practice.Size = new System.Drawing.Size(176, 39);
            this.button_Practice.TabIndex = 4;
            this.button_Practice.Text = "Practice";
            this.button_Practice.UseVisualStyleBackColor = false;
            this.button_Practice.Click += new System.EventHandler(this.button_Practice_Click);
            // 
            // button_View
            // 
            this.button_View.BackColor = System.Drawing.Color.DimGray;
            this.button_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_View.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_View.ForeColor = System.Drawing.Color.White;
            this.button_View.Location = new System.Drawing.Point(511, 85);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(176, 39);
            this.button_View.TabIndex = 3;
            this.button_View.Text = "View";
            this.button_View.UseVisualStyleBackColor = false;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // label_Decks
            // 
            this.label_Decks.AutoSize = true;
            this.label_Decks.Font = new System.Drawing.Font("Segoe UI Semilight", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Decks.ForeColor = System.Drawing.Color.White;
            this.label_Decks.Location = new System.Drawing.Point(15, 18);
            this.label_Decks.Name = "label_Decks";
            this.label_Decks.Size = new System.Drawing.Size(118, 51);
            this.label_Decks.TabIndex = 1;
            this.label_Decks.Text = "Decks";
            // 
            // label_Dashboard
            // 
            this.label_Dashboard.AutoSize = true;
            this.label_Dashboard.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dashboard.ForeColor = System.Drawing.Color.White;
            this.label_Dashboard.Location = new System.Drawing.Point(292, 78);
            this.label_Dashboard.Name = "label_Dashboard";
            this.label_Dashboard.Size = new System.Drawing.Size(608, 81);
            this.label_Dashboard.TabIndex = 2;
            this.label_Dashboard.Text = "Username\'s Dashboard";
            // 
            // pictureBox_Background
            // 
            this.pictureBox_Background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Background.BackgroundImage")));
            this.pictureBox_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Background.Location = new System.Drawing.Point(97, -38);
            this.pictureBox_Background.Name = "pictureBox_Background";
            this.pictureBox_Background.Size = new System.Drawing.Size(1301, 823);
            this.pictureBox_Background.TabIndex = 3;
            this.pictureBox_Background.TabStop = false;
            // 
            // label_Empty
            // 
            this.label_Empty.AutoSize = true;
            this.label_Empty.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Empty.ForeColor = System.Drawing.Color.White;
            this.label_Empty.Location = new System.Drawing.Point(114, 358);
            this.label_Empty.MaximumSize = new System.Drawing.Size(275, 0);
            this.label_Empty.Name = "label_Empty";
            this.label_Empty.Size = new System.Drawing.Size(270, 114);
            this.label_Empty.TabIndex = 8;
            this.label_Empty.Text = "No decks found. Add new deck to start learning!";
            this.label_Empty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_Empty.Visible = false;
            // 
            // pictureBox_Empty
            // 
            this.pictureBox_Empty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Empty.BackgroundImage")));
            this.pictureBox_Empty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Empty.Location = new System.Drawing.Point(104, 105);
            this.pictureBox_Empty.Name = "pictureBox_Empty";
            this.pictureBox_Empty.Size = new System.Drawing.Size(290, 240);
            this.pictureBox_Empty.TabIndex = 9;
            this.pictureBox_Empty.TabStop = false;
            this.pictureBox_Empty.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(26, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 392);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(490, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 392);
            this.panel2.TabIndex = 11;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 770);
            this.Controls.Add(this.label_Dashboard);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.pictureBox_Background);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel_Content.ResumeLayout(false);
            this.panel_Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Empty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Decks;
        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.Label label_Dashboard;
        private System.Windows.Forms.Label label_Decks;
        private System.Windows.Forms.PictureBox pictureBox_Background;
        private System.Windows.Forms.Button button_DeleteDeck;
        private System.Windows.Forms.Button button_Test;
        private System.Windows.Forms.Button button_Practice;
        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.Button button_AddDeck;
        private System.Windows.Forms.PictureBox pictureBox_Empty;
        private System.Windows.Forms.Label label_Empty;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}