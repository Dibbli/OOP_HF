namespace EXC8JY_OOP_HF
{
    partial class form_newuser
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
            this.tb_Nev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Nev
            // 
            this.tb_Nev.Location = new System.Drawing.Point(51, 41);
            this.tb_Nev.Name = "tb_Nev";
            this.tb_Nev.Size = new System.Drawing.Size(100, 20);
            this.tb_Nev.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(64, 67);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // form_newuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 119);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Nev);
            this.Name = "form_newuser";
            this.Text = "Új Vállalkozó";
            this.Load += new System.EventHandler(this.form_newuser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Nev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Submit;
    }
}