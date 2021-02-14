namespace Kotoba
{
    partial class NewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserForm));
            this.pictureBox_Hello = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_SignIn = new System.Windows.Forms.Button();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hello)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Hello
            // 
            this.pictureBox_Hello.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Hello.BackgroundImage")));
            this.pictureBox_Hello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Hello.Location = new System.Drawing.Point(231, 415);
            this.pictureBox_Hello.Name = "pictureBox_Hello";
            this.pictureBox_Hello.Size = new System.Drawing.Size(975, 471);
            this.pictureBox_Hello.TabIndex = 0;
            this.pictureBox_Hello.TabStop = false;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(383, 65);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(277, 81);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "New User";
            // 
            // textBox_Email
            // 
            this.textBox_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.textBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.ForeColor = System.Drawing.Color.White;
            this.textBox_Email.Location = new System.Drawing.Point(406, 185);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(236, 34);
            this.textBox_Email.TabIndex = 6;
            // 
            // textBox_Username
            // 
            this.textBox_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.textBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.ForeColor = System.Drawing.Color.White;
            this.textBox_Username.Location = new System.Drawing.Point(406, 249);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(236, 34);
            this.textBox_Username.TabIndex = 7;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.ForeColor = System.Drawing.Color.White;
            this.textBox_Password.Location = new System.Drawing.Point(406, 313);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(236, 34);
            this.textBox_Password.TabIndex = 8;
            // 
            // button_SignIn
            // 
            this.button_SignIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_SignIn.FlatAppearance.BorderSize = 0;
            this.button_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SignIn.ForeColor = System.Drawing.Color.Black;
            this.button_SignIn.Location = new System.Drawing.Point(407, 391);
            this.button_SignIn.Name = "button_SignIn";
            this.button_SignIn.Size = new System.Drawing.Size(235, 37);
            this.button_SignIn.TabIndex = 9;
            this.button_SignIn.Text = "Sign up";
            this.button_SignIn.UseVisualStyleBackColor = false;
            this.button_SignIn.Click += new System.EventHandler(this.button_SignIn_Click);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.ForeColor = System.Drawing.Color.White;
            this.label_Email.Location = new System.Drawing.Point(280, 187);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(63, 28);
            this.label_Email.TabIndex = 10;
            this.label_Email.Text = "Email:";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.ForeColor = System.Drawing.Color.White;
            this.label_Username.Location = new System.Drawing.Point(280, 251);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(103, 28);
            this.label_Username.TabIndex = 11;
            this.label_Username.Text = "Username:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.Color.White;
            this.label_Password.Location = new System.Drawing.Point(280, 315);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(97, 28);
            this.label_Password.TabIndex = 12;
            this.label_Password.Text = "Password:";
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1056, 837);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.button_SignIn);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.pictureBox_Hello);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewUserForm";
            this.Text = "NewUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hello)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Hello;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_SignIn;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
    }
}