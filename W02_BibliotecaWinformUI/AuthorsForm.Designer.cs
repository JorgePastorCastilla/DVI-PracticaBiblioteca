namespace W02_BibliotecaWinformUI
{
    partial class AuthorsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.authorsListBox = new System.Windows.Forms.ListBox();
            this.authorFindButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.authorSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gotoSearchBooksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Authors found:";
            // 
            // authorsListBox
            // 
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.ItemHeight = 20;
            this.authorsListBox.Location = new System.Drawing.Point(24, 191);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(480, 264);
            this.authorsListBox.TabIndex = 10;
            // 
            // authorFindButton
            // 
            this.authorFindButton.Location = new System.Drawing.Point(405, 105);
            this.authorFindButton.Name = "authorFindButton";
            this.authorFindButton.Size = new System.Drawing.Size(99, 34);
            this.authorFindButton.TabIndex = 9;
            this.authorFindButton.Text = "Find";
            this.authorFindButton.UseVisualStyleBackColor = true;
            this.authorFindButton.Click += new System.EventHandler(this.authorFindButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search authors:";
            // 
            // authorSearchTextBox
            // 
            this.authorSearchTextBox.Location = new System.Drawing.Point(24, 109);
            this.authorSearchTextBox.Name = "authorSearchTextBox";
            this.authorSearchTextBox.Size = new System.Drawing.Size(351, 26);
            this.authorSearchTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "CIFP PAU CASESNOVES LIBRARY";
            // 
            // gotoSearchBooksButton
            // 
            this.gotoSearchBooksButton.Location = new System.Drawing.Point(24, 481);
            this.gotoSearchBooksButton.Name = "gotoSearchBooksButton";
            this.gotoSearchBooksButton.Size = new System.Drawing.Size(172, 60);
            this.gotoSearchBooksButton.TabIndex = 12;
            this.gotoSearchBooksButton.Text = "<< Search books";
            this.gotoSearchBooksButton.UseVisualStyleBackColor = true;
            this.gotoSearchBooksButton.Click += new System.EventHandler(this.gotoSearchBooksButton_Click);
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 553);
            this.Controls.Add(this.gotoSearchBooksButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorsListBox);
            this.Controls.Add(this.authorFindButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorSearchTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AuthorsForm";
            this.Text = "AuthorsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthorsForm_FormClosed);
            this.Load += new System.EventHandler(this.AuthorsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox authorsListBox;
        private System.Windows.Forms.Button authorFindButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authorSearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gotoSearchBooksButton;
    }
}