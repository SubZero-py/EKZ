namespace abonementbiblioteka
{
    partial class deletebook
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.booksCheckBox = new System.Windows.Forms.CheckBox();
            this.genresCheckBox = new System.Windows.Forms.CheckBox();
            this.authorCheckBox = new System.Windows.Forms.CheckBox();
            this.publishCheckBox = new System.Windows.Forms.CheckBox();
            this.boreCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(178, 79);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(406, 39);
            this.idTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(623, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // booksCheckBox
            // 
            this.booksCheckBox.AutoSize = true;
            this.booksCheckBox.Location = new System.Drawing.Point(16, 13);
            this.booksCheckBox.Name = "booksCheckBox";
            this.booksCheckBox.Size = new System.Drawing.Size(67, 20);
            this.booksCheckBox.TabIndex = 3;
            this.booksCheckBox.Text = "Книги";
            this.booksCheckBox.UseVisualStyleBackColor = true;
            // 
            // genresCheckBox
            // 
            this.genresCheckBox.AutoSize = true;
            this.genresCheckBox.Location = new System.Drawing.Point(160, 13);
            this.genresCheckBox.Name = "genresCheckBox";
            this.genresCheckBox.Size = new System.Drawing.Size(75, 20);
            this.genresCheckBox.TabIndex = 4;
            this.genresCheckBox.Text = "Жанры";
            this.genresCheckBox.UseVisualStyleBackColor = true;
            // 
            // authorCheckBox
            // 
            this.authorCheckBox.AutoSize = true;
            this.authorCheckBox.Location = new System.Drawing.Point(341, 13);
            this.authorCheckBox.Name = "authorCheckBox";
            this.authorCheckBox.Size = new System.Drawing.Size(78, 20);
            this.authorCheckBox.TabIndex = 5;
            this.authorCheckBox.Text = "Авторы";
            this.authorCheckBox.UseVisualStyleBackColor = true;
            // 
            // publishCheckBox
            // 
            this.publishCheckBox.AutoSize = true;
            this.publishCheckBox.Location = new System.Drawing.Point(489, 13);
            this.publishCheckBox.Name = "publishCheckBox";
            this.publishCheckBox.Size = new System.Drawing.Size(94, 20);
            this.publishCheckBox.TabIndex = 6;
            this.publishCheckBox.Text = "Издатели";
            this.publishCheckBox.UseVisualStyleBackColor = true;
            // 
            // boreCheckBox
            // 
            this.boreCheckBox.AutoSize = true;
            this.boreCheckBox.Location = new System.Drawing.Point(644, 13);
            this.boreCheckBox.Name = "boreCheckBox";
            this.boreCheckBox.Size = new System.Drawing.Size(92, 20);
            this.boreCheckBox.TabIndex = 7;
            this.boreCheckBox.Text = "Читатели";
            this.boreCheckBox.UseVisualStyleBackColor = true;
            // 
            // deletebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 197);
            this.Controls.Add(this.boreCheckBox);
            this.Controls.Add(this.publishCheckBox);
            this.Controls.Add(this.authorCheckBox);
            this.Controls.Add(this.genresCheckBox);
            this.Controls.Add(this.booksCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTextBox);
            this.Name = "deletebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление записей";
            this.Load += new System.EventHandler(this.deletebook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox booksCheckBox;
        private System.Windows.Forms.CheckBox genresCheckBox;
        private System.Windows.Forms.CheckBox authorCheckBox;
        private System.Windows.Forms.CheckBox publishCheckBox;
        private System.Windows.Forms.CheckBox boreCheckBox;
    }
}