namespace EXC8JY_OOP_HF
{
    partial class form_beadas
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
            this.lb_Users = new System.Windows.Forms.ListBox();
            this.clb_Contracts = new System.Windows.Forms.CheckedListBox();
            this.btn_FinishContract = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Users
            // 
            this.lb_Users.FormattingEnabled = true;
            this.lb_Users.Location = new System.Drawing.Point(12, 31);
            this.lb_Users.Name = "lb_Users";
            this.lb_Users.Size = new System.Drawing.Size(120, 95);
            this.lb_Users.TabIndex = 0;
            // 
            // clb_Contracts
            // 
            this.clb_Contracts.FormattingEnabled = true;
            this.clb_Contracts.Location = new System.Drawing.Point(138, 31);
            this.clb_Contracts.Name = "clb_Contracts";
            this.clb_Contracts.Size = new System.Drawing.Size(120, 94);
            this.clb_Contracts.TabIndex = 1;
            // 
            // btn_FinishContract
            // 
            this.btn_FinishContract.Location = new System.Drawing.Point(96, 132);
            this.btn_FinishContract.Name = "btn_FinishContract";
            this.btn_FinishContract.Size = new System.Drawing.Size(75, 23);
            this.btn_FinishContract.TabIndex = 2;
            this.btn_FinishContract.Text = "Submit";
            this.btn_FinishContract.UseVisualStyleBackColor = true;
            this.btn_FinishContract.Click += new System.EventHandler(this.btn_FinishContract_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vállalkozók";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Szerződések";
            // 
            // form_beadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 166);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_FinishContract);
            this.Controls.Add(this.clb_Contracts);
            this.Controls.Add(this.lb_Users);
            this.Name = "form_beadas";
            this.Text = "Szerződés beadása";
            this.Load += new System.EventHandler(this.form_vallalas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Users;
        private System.Windows.Forms.CheckedListBox clb_Contracts;
        private System.Windows.Forms.Button btn_FinishContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}