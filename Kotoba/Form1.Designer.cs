namespace Kotoba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.pictureBox_LogIn = new System.Windows.Forms.PictureBox();
            this.button_SignIn = new System.Windows.Forms.Button();
            this.button_NewUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LogIn)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.ForeColor = System.Drawing.Color.White;
            this.label_Username.Location = new System.Drawing.Point(185, 112);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(96, 28);
            this.label_Username.TabIndex = 3;
            this.label_Username.Text = "username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.ForeColor = System.Drawing.Color.White;
            this.label_Password.Location = new System.Drawing.Point(186, 184);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(95, 28);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "password";
            // 
            // textBox_Username
            // 
            this.textBox_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.textBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Username.ForeColor = System.Drawing.Color.White;
            this.textBox_Username.Location = new System.Drawing.Point(190, 145);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(236, 34);
            this.textBox_Username.TabIndex = 5;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Password.ForeColor = System.Drawing.Color.White;
            this.textBox_Password.Location = new System.Drawing.Point(191, 217);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(235, 34);
            this.textBox_Password.TabIndex = 6;
            // 
            // pictureBox_LogIn
            // 
            this.pictureBox_LogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_LogIn.BackgroundImage")));
            this.pictureBox_LogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_LogIn.Location = new System.Drawing.Point(-426, 143);
            this.pictureBox_LogIn.Name = "pictureBox_LogIn";
            this.pictureBox_LogIn.Size = new System.Drawing.Size(1224, 528);
            this.pictureBox_LogIn.TabIndex = 7;
            this.pictureBox_LogIn.TabStop = false;
            // 
            // button_SignIn
            // 
            this.button_SignIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_SignIn.FlatAppearance.BorderSize = 0;
            this.button_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SignIn.ForeColor = System.Drawing.Color.Black;
            this.button_SignIn.Location = new System.Drawing.Point(191, 295);
            this.button_SignIn.Name = "button_SignIn";
            this.button_SignIn.Size = new System.Drawing.Size(235, 37);
            this.button_SignIn.TabIndex = 1;
            this.button_SignIn.Text = "Sign in";
            this.button_SignIn.UseVisualStyleBackColor = false;
            this.button_SignIn.Click += new System.EventHandler(this.button_SignIn_Click);
            // 
            // button_NewUser
            // 
            this.button_NewUser.BackColor = System.Drawing.Color.Gray;
            this.button_NewUser.FlatAppearance.BorderSize = 0;
            this.button_NewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NewUser.ForeColor = System.Drawing.Color.White;
            this.button_NewUser.Location = new System.Drawing.Point(190, 351);
            this.button_NewUser.Name = "button_NewUser";
            this.button_NewUser.Size = new System.Drawing.Size(235, 37);
            this.button_NewUser.TabIndex = 8;
            this.button_NewUser.Text = "New User";
            this.button_NewUser.UseVisualStyleBackColor = false;
            this.button_NewUser.Click += new System.EventHandler(this.button_NewUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(611, 552);
            this.Controls.Add(this.button_NewUser);
            this.Controls.Add(this.button_SignIn);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.pictureBox_LogIn);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Kotoba Flashcards";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LogIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.PictureBox pictureBox_LogIn;
        private System.Windows.Forms.Button button_SignIn;
        private System.Windows.Forms.Button button_NewUser;
    }
}

