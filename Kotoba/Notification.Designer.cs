namespace Kotoba
{
    partial class Notification
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
            this.button_Ok = new System.Windows.Forms.Button();
            this.label_Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Ok
            // 
            this.button_Ok.BackColor = System.Drawing.Color.DimGray;
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ok.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ok.ForeColor = System.Drawing.Color.White;
            this.button_Ok.Location = new System.Drawing.Point(150, 104);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(124, 38);
            this.button_Ok.TabIndex = 0;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = false;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.ForeColor = System.Drawing.Color.White;
            this.label_Message.Location = new System.Drawing.Point(48, 43);
            this.label_Message.MaximumSize = new System.Drawing.Size(300, 0);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(0, 28);
            this.label_Message.TabIndex = 1;
            this.label_Message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(420, 171);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.button_Ok);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Label label_Message;
    }
}