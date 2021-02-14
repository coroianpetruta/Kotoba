namespace Kotoba
{
    partial class Add_Deck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Deck));
            this.label_AddDeck = new System.Windows.Forms.Label();
            this.label_DeckName = new System.Windows.Forms.Label();
            this.textBox_DeckName = new System.Windows.Forms.TextBox();
            this.button_AddDeck = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_AddDeck
            // 
            this.label_AddDeck.AutoSize = true;
            this.label_AddDeck.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddDeck.Location = new System.Drawing.Point(188, 26);
            this.label_AddDeck.Name = "label_AddDeck";
            this.label_AddDeck.Size = new System.Drawing.Size(204, 41);
            this.label_AddDeck.TabIndex = 0;
            this.label_AddDeck.Text = "Add New Deck";
            // 
            // label_DeckName
            // 
            this.label_DeckName.AutoSize = true;
            this.label_DeckName.Location = new System.Drawing.Point(121, 98);
            this.label_DeckName.Name = "label_DeckName";
            this.label_DeckName.Size = new System.Drawing.Size(68, 28);
            this.label_DeckName.TabIndex = 1;
            this.label_DeckName.Text = "Name:";
            // 
            // textBox_DeckName
            // 
            this.textBox_DeckName.Location = new System.Drawing.Point(195, 95);
            this.textBox_DeckName.Name = "textBox_DeckName";
            this.textBox_DeckName.Size = new System.Drawing.Size(230, 34);
            this.textBox_DeckName.TabIndex = 2;
            // 
            // button_AddDeck
            // 
            this.button_AddDeck.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AddDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddDeck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button_AddDeck.Location = new System.Drawing.Point(95, 178);
            this.button_AddDeck.Name = "button_AddDeck";
            this.button_AddDeck.Size = new System.Drawing.Size(143, 39);
            this.button_AddDeck.TabIndex = 3;
            this.button_AddDeck.Text = "Add Deck";
            this.button_AddDeck.UseVisualStyleBackColor = false;
            this.button_AddDeck.Click += new System.EventHandler(this.button_AddDeck_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button_Cancel.Location = new System.Drawing.Point(300, 177);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(147, 41);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Add_Deck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(546, 248);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_AddDeck);
            this.Controls.Add(this.textBox_DeckName);
            this.Controls.Add(this.label_DeckName);
            this.Controls.Add(this.label_AddDeck);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Add_Deck";
            this.Text = "Add New Deck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AddDeck;
        private System.Windows.Forms.Label label_DeckName;
        private System.Windows.Forms.TextBox textBox_DeckName;
        private System.Windows.Forms.Button button_AddDeck;
        private System.Windows.Forms.Button button_Cancel;
    }
}