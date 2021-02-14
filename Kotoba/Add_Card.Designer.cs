namespace Kotoba
{
    partial class Add_Card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Card));
            this.label_AddCard = new System.Windows.Forms.Label();
            this.label_Back = new System.Windows.Forms.Label();
            this.label_Front = new System.Windows.Forms.Label();
            this.label_Notice = new System.Windows.Forms.Label();
            this.button_AddCard = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_Front = new System.Windows.Forms.TextBox();
            this.textBox_Back = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_AddCard
            // 
            this.label_AddCard.AutoSize = true;
            this.label_AddCard.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddCard.Location = new System.Drawing.Point(219, 39);
            this.label_AddCard.Name = "label_AddCard";
            this.label_AddCard.Size = new System.Drawing.Size(139, 41);
            this.label_AddCard.TabIndex = 1;
            this.label_AddCard.Text = "Add Card";
            // 
            // label_Back
            // 
            this.label_Back.AutoSize = true;
            this.label_Back.Location = new System.Drawing.Point(93, 202);
            this.label_Back.Name = "label_Back";
            this.label_Back.Size = new System.Drawing.Size(56, 28);
            this.label_Back.TabIndex = 2;
            this.label_Back.Text = "Back:";
            // 
            // label_Front
            // 
            this.label_Front.AutoSize = true;
            this.label_Front.Location = new System.Drawing.Point(93, 118);
            this.label_Front.Name = "label_Front";
            this.label_Front.Size = new System.Drawing.Size(63, 28);
            this.label_Front.TabIndex = 3;
            this.label_Front.Text = "Front:";
            // 
            // label_Notice
            // 
            this.label_Notice.AutoSize = true;
            this.label_Notice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Notice.Location = new System.Drawing.Point(140, 250);
            this.label_Notice.MaximumSize = new System.Drawing.Size(330, 0);
            this.label_Notice.Name = "label_Notice";
            this.label_Notice.Size = new System.Drawing.Size(330, 46);
            this.label_Notice.TabIndex = 4;
            this.label_Notice.Text = "* if the term has several meanings use ; to separate them";
            // 
            // button_AddCard
            // 
            this.button_AddCard.BackColor = System.Drawing.Color.DimGray;
            this.button_AddCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddCard.ForeColor = System.Drawing.Color.White;
            this.button_AddCard.Location = new System.Drawing.Point(98, 355);
            this.button_AddCard.Name = "button_AddCard";
            this.button_AddCard.Size = new System.Drawing.Size(143, 39);
            this.button_AddCard.TabIndex = 5;
            this.button_AddCard.Text = "Add Card";
            this.button_AddCard.UseVisualStyleBackColor = false;
            this.button_AddCard.Click += new System.EventHandler(this.button_AddCard_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.DimGray;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.Location = new System.Drawing.Point(323, 354);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(147, 41);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // textBox_Front
            // 
            this.textBox_Front.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Front.Location = new System.Drawing.Point(167, 115);
            this.textBox_Front.Name = "textBox_Front";
            this.textBox_Front.Size = new System.Drawing.Size(303, 34);
            this.textBox_Front.TabIndex = 7;
            // 
            // textBox_Back
            // 
            this.textBox_Back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Back.Location = new System.Drawing.Point(167, 199);
            this.textBox_Back.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.textBox_Back.Name = "textBox_Back";
            this.textBox_Back.Size = new System.Drawing.Size(303, 34);
            this.textBox_Back.TabIndex = 8;
            // 
            // Add_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(568, 453);
            this.Controls.Add(this.textBox_Back);
            this.Controls.Add(this.textBox_Front);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_AddCard);
            this.Controls.Add(this.label_Notice);
            this.Controls.Add(this.label_Front);
            this.Controls.Add(this.label_Back);
            this.Controls.Add(this.label_AddCard);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Add_Card";
            this.Text = "Add Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AddCard;
        private System.Windows.Forms.Label label_Back;
        private System.Windows.Forms.Label label_Front;
        private System.Windows.Forms.Label label_Notice;
        private System.Windows.Forms.Button button_AddCard;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_Front;
        private System.Windows.Forms.TextBox textBox_Back;
    }
}