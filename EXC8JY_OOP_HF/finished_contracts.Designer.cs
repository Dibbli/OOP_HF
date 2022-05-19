namespace EXC8JY_OOP_HF
{
    partial class finished_contracts
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
            this.lb_KeszSzerzodesek = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_KeszSzerzodesek
            // 
            this.lb_KeszSzerzodesek.FormattingEnabled = true;
            this.lb_KeszSzerzodesek.Location = new System.Drawing.Point(0, 0);
            this.lb_KeszSzerzodesek.Name = "lb_KeszSzerzodesek";
            this.lb_KeszSzerzodesek.Size = new System.Drawing.Size(220, 173);
            this.lb_KeszSzerzodesek.TabIndex = 1;
            // 
            // finished_contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(219, 174);
            this.Controls.Add(this.lb_KeszSzerzodesek);
            this.Name = "finished_contracts";
            this.Text = "Kész Szerződések";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_KeszSzerzodesek;
    }
}