namespace W02_BibliotecaWinformUI
{
    partial class BookDetailsFormDialog
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titolLabel = new System.Windows.Forms.Label();
            this.descripcioLabel = new System.Windows.Forms.Label();
            this.autorLabel = new System.Windows.Forms.Label();
            this.departamentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(42, 336);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 336);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::W02_BibliotecaWinformUI.Properties.Resources.logoSPDVI;
            this.pictureBox1.Location = new System.Drawing.Point(18, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // titolLabel
            // 
            this.titolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titolLabel.Location = new System.Drawing.Point(246, 26);
            this.titolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titolLabel.Name = "titolLabel";
            this.titolLabel.Size = new System.Drawing.Size(249, 71);
            this.titolLabel.TabIndex = 3;
            this.titolLabel.Text = "TITOL DEL LLIBRE";
            // 
            // descripcioLabel
            // 
            this.descripcioLabel.Location = new System.Drawing.Point(246, 107);
            this.descripcioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descripcioLabel.Name = "descripcioLabel";
            this.descripcioLabel.Size = new System.Drawing.Size(249, 65);
            this.descripcioLabel.TabIndex = 4;
            this.descripcioLabel.Text = "DESCRIPCIO";
            // 
            // autorLabel
            // 
            this.autorLabel.Location = new System.Drawing.Point(246, 187);
            this.autorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autorLabel.Name = "autorLabel";
            this.autorLabel.Size = new System.Drawing.Size(249, 64);
            this.autorLabel.TabIndex = 5;
            this.autorLabel.Text = "AUTHOR";
            // 
            // departamentLabel
            // 
            this.departamentLabel.Location = new System.Drawing.Point(246, 267);
            this.departamentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departamentLabel.Name = "departamentLabel";
            this.departamentLabel.Size = new System.Drawing.Size(237, 51);
            this.departamentLabel.TabIndex = 6;
            this.departamentLabel.Text = "DEPARTAMENT";
            // 
            // BookDetailsFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 400);
            this.Controls.Add(this.departamentLabel);
            this.Controls.Add(this.autorLabel);
            this.Controls.Add(this.descripcioLabel);
            this.Controls.Add(this.titolLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BookDetailsFormDialog";
            this.Text = "BookDetailsFormDialog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titolLabel;
        private System.Windows.Forms.Label descripcioLabel;
        private System.Windows.Forms.Label autorLabel;
        private System.Windows.Forms.Label departamentLabel;
    }
}