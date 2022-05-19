namespace EXC8JY_OOP_HF
{
    partial class form_newcontract
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
            this.tb_ContractName = new System.Windows.Forms.TextBox();
            this.btn_SubmitContract = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Deadline = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tb_ContractName
            // 
            this.tb_ContractName.Location = new System.Drawing.Point(49, 25);
            this.tb_ContractName.Name = "tb_ContractName";
            this.tb_ContractName.Size = new System.Drawing.Size(100, 20);
            this.tb_ContractName.TabIndex = 0;
            // 
            // btn_SubmitContract
            // 
            this.btn_SubmitContract.Location = new System.Drawing.Point(58, 93);
            this.btn_SubmitContract.Name = "btn_SubmitContract";
            this.btn_SubmitContract.Size = new System.Drawing.Size(75, 23);
            this.btn_SubmitContract.TabIndex = 3;
            this.btn_SubmitContract.Text = "Submit";
            this.btn_SubmitContract.UseVisualStyleBackColor = true;
            this.btn_SubmitContract.Click += new System.EventHandler(this.btn_SubmitContract_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Szerződés Neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Határidő";
            // 
            // dtp_Deadline
            // 
            this.dtp_Deadline.Location = new System.Drawing.Point(3, 67);
            this.dtp_Deadline.Name = "dtp_Deadline";
            this.dtp_Deadline.Size = new System.Drawing.Size(200, 20);
            this.dtp_Deadline.TabIndex = 6;
            // 
            // form_newcontract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 119);
            this.Controls.Add(this.dtp_Deadline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SubmitContract);
            this.Controls.Add(this.tb_ContractName);
            this.Name = "form_newcontract";
            this.Text = "Új Szerződés";
            this.Load += new System.EventHandler(this.form_newcontract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ContractName;
        private System.Windows.Forms.Button btn_SubmitContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Deadline;
    }
}