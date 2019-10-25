namespace W02_BibliotecaWinformUI
{
    partial class BibliotecaMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gotoSearchAuthorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIFP PAU CASESNOVES LIBRARY";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(41, 96);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(351, 26);
            this.searchTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search the Library:";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(422, 92);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(99, 34);
            this.FindButton.TabIndex = 3;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // booksListBox
            // 
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.ItemHeight = 20;
            this.booksListBox.Location = new System.Drawing.Point(41, 178);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(480, 264);
            this.booksListBox.TabIndex = 4;
            this.booksListBox.DoubleClick += new System.EventHandler(this.booksListBox_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Books found:";
            // 
            // gotoSearchAuthorButton
            // 
            this.gotoSearchAuthorButton.Location = new System.Drawing.Point(349, 461);
            this.gotoSearchAuthorButton.Name = "gotoSearchAuthorButton";
            this.gotoSearchAuthorButton.Size = new System.Drawing.Size(172, 60);
            this.gotoSearchAuthorButton.TabIndex = 6;
            this.gotoSearchAuthorButton.Text = "Search authors >>";
            this.gotoSearchAuthorButton.UseVisualStyleBackColor = true;
            this.gotoSearchAuthorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BibliotecaMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 533);
            this.Controls.Add(this.gotoSearchAuthorButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BibliotecaMainForm";
            this.Text = "Biblioteca - Cavern Times";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gotoSearchAuthorButton;
    }
}

