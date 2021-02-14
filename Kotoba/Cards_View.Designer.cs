namespace Kotoba
{
    partial class Cards_View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cards_View));
            this.label_DeckName = new System.Windows.Forms.Label();
            this.dataGridView_Cards = new System.Windows.Forms.DataGridView();
            this.button_AddCard = new System.Windows.Forms.Button();
            this.button_UpdateCards = new System.Windows.Forms.Button();
            this.button_DeleteCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cards)).BeginInit();
            this.SuspendLayout();
            // 
            // label_DeckName
            // 
            this.label_DeckName.AutoSize = true;
            this.label_DeckName.Font = new System.Drawing.Font("Segoe UI Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DeckName.ForeColor = System.Drawing.Color.White;
            this.label_DeckName.Location = new System.Drawing.Point(130, 73);
            this.label_DeckName.Name = "label_DeckName";
            this.label_DeckName.Size = new System.Drawing.Size(246, 51);
            this.label_DeckName.TabIndex = 0;
            this.label_DeckName.Text = "Deck: German";
            // 
            // dataGridView_Cards
            // 
            this.dataGridView_Cards.AllowUserToAddRows = false;
            this.dataGridView_Cards.AllowUserToDeleteRows = false;
            this.dataGridView_Cards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Cards.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridView_Cards.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Cards.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Cards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Cards.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Cards.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridView_Cards.Location = new System.Drawing.Point(128, 144);
            this.dataGridView_Cards.Name = "dataGridView_Cards";
            this.dataGridView_Cards.RowTemplate.Height = 24;
            this.dataGridView_Cards.Size = new System.Drawing.Size(615, 340);
            this.dataGridView_Cards.TabIndex = 1;
            // 
            // button_AddCard
            // 
            this.button_AddCard.BackColor = System.Drawing.Color.DimGray;
            this.button_AddCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddCard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddCard.ForeColor = System.Drawing.Color.White;
            this.button_AddCard.Location = new System.Drawing.Point(305, 514);
            this.button_AddCard.Name = "button_AddCard";
            this.button_AddCard.Size = new System.Drawing.Size(154, 39);
            this.button_AddCard.TabIndex = 5;
            this.button_AddCard.Text = "Add Card";
            this.button_AddCard.UseVisualStyleBackColor = false;
            this.button_AddCard.Click += new System.EventHandler(this.button_AddCard_Click);
            // 
            // button_UpdateCards
            // 
            this.button_UpdateCards.BackColor = System.Drawing.Color.DimGray;
            this.button_UpdateCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UpdateCards.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdateCards.ForeColor = System.Drawing.Color.White;
            this.button_UpdateCards.Location = new System.Drawing.Point(128, 514);
            this.button_UpdateCards.Name = "button_UpdateCards";
            this.button_UpdateCards.Size = new System.Drawing.Size(154, 39);
            this.button_UpdateCards.TabIndex = 6;
            this.button_UpdateCards.Text = "Update";
            this.button_UpdateCards.UseVisualStyleBackColor = false;
            this.button_UpdateCards.Click += new System.EventHandler(this.button_UpdateCards_Click);
            // 
            // button_DeleteCard
            // 
            this.button_DeleteCard.BackColor = System.Drawing.Color.Brown;
            this.button_DeleteCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeleteCard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteCard.ForeColor = System.Drawing.Color.White;
            this.button_DeleteCard.Location = new System.Drawing.Point(589, 514);
            this.button_DeleteCard.Name = "button_DeleteCard";
            this.button_DeleteCard.Size = new System.Drawing.Size(154, 39);
            this.button_DeleteCard.TabIndex = 7;
            this.button_DeleteCard.Text = "Delete";
            this.button_DeleteCard.UseVisualStyleBackColor = false;
            this.button_DeleteCard.Click += new System.EventHandler(this.button_DeleteCard_Click);
            // 
            // Cards_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(958, 652);
            this.Controls.Add(this.button_DeleteCard);
            this.Controls.Add(this.button_UpdateCards);
            this.Controls.Add(this.button_AddCard);
            this.Controls.Add(this.dataGridView_Cards);
            this.Controls.Add(this.label_DeckName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cards_View";
            this.Text = "Cards View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DeckName;
        private System.Windows.Forms.DataGridView dataGridView_Cards;
        private System.Windows.Forms.Button button_AddCard;
        private System.Windows.Forms.Button button_UpdateCards;
        private System.Windows.Forms.Button button_DeleteCard;
    }
}