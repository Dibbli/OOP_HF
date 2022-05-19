namespace EXC8JY_OOP_HF
{
    partial class form_index
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.újFelvételeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_NewContract = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_NewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_Active = new System.Windows.Forms.ListBox();
            this.lb_Available = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_StatusForm = new System.Windows.Forms.Button();
            this.btn_ContractForm = new System.Windows.Forms.Button();
            this.label_Contractor = new System.Windows.Forms.Label();
            this.label_Deadline = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újFelvételeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(220, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // újFelvételeToolStripMenuItem
            // 
            this.újFelvételeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_NewContract,
            this.mi_NewUser});
            this.újFelvételeToolStripMenuItem.Name = "újFelvételeToolStripMenuItem";
            this.újFelvételeToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.újFelvételeToolStripMenuItem.Text = "Új Felvétele";
            // 
            // mi_NewContract
            // 
            this.mi_NewContract.Name = "mi_NewContract";
            this.mi_NewContract.Size = new System.Drawing.Size(180, 22);
            this.mi_NewContract.Text = "Új Szerződés";
            this.mi_NewContract.Click += new System.EventHandler(this.mi_NewContract_Click);
            // 
            // mi_NewUser
            // 
            this.mi_NewUser.Name = "mi_NewUser";
            this.mi_NewUser.Size = new System.Drawing.Size(180, 22);
            this.mi_NewUser.Text = "Új Válalkozó";
            // 
            // lb_Active
            // 
            this.lb_Active.FormattingEnabled = true;
            this.lb_Active.Location = new System.Drawing.Point(47, 188);
            this.lb_Active.Name = "lb_Active";
            this.lb_Active.Size = new System.Drawing.Size(120, 95);
            this.lb_Active.TabIndex = 1;
            // 
            // lb_Available
            // 
            this.lb_Available.FormattingEnabled = true;
            this.lb_Available.Location = new System.Drawing.Point(47, 45);
            this.lb_Available.Name = "lb_Available";
            this.lb_Available.Size = new System.Drawing.Size(120, 95);
            this.lb_Available.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Felvehető Szerződések";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Foglalt Szerződések";
            // 
            // btn_StatusForm
            // 
            this.btn_StatusForm.Location = new System.Drawing.Point(52, 289);
            this.btn_StatusForm.Name = "btn_StatusForm";
            this.btn_StatusForm.Size = new System.Drawing.Size(115, 23);
            this.btn_StatusForm.TabIndex = 7;
            this.btn_StatusForm.Text = "Szerződés státusza";
            this.btn_StatusForm.UseVisualStyleBackColor = true;
            // 
            // btn_ContractForm
            // 
            this.btn_ContractForm.Location = new System.Drawing.Point(52, 146);
            this.btn_ContractForm.Name = "btn_ContractForm";
            this.btn_ContractForm.Size = new System.Drawing.Size(115, 23);
            this.btn_ContractForm.TabIndex = 8;
            this.btn_ContractForm.Text = "Szerződés vállalása";
            this.btn_ContractForm.UseVisualStyleBackColor = true;
            // 
            // label_Contractor
            // 
            this.label_Contractor.AutoSize = true;
            this.label_Contractor.Location = new System.Drawing.Point(49, 315);
            this.label_Contractor.Name = "label_Contractor";
            this.label_Contractor.Size = new System.Drawing.Size(44, 13);
            this.label_Contractor.TabIndex = 9;
            this.label_Contractor.Text = "Vállalta:";
            // 
            // label_Deadline
            // 
            this.label_Deadline.AutoSize = true;
            this.label_Deadline.Location = new System.Drawing.Point(49, 341);
            this.label_Deadline.Name = "label_Deadline";
            this.label_Deadline.Size = new System.Drawing.Size(50, 13);
            this.label_Deadline.TabIndex = 10;
            this.label_Deadline.Text = "Határidő:";
            // 
            // form_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 385);
            this.Controls.Add(this.label_Deadline);
            this.Controls.Add(this.label_Contractor);
            this.Controls.Add(this.btn_ContractForm);
            this.Controls.Add(this.btn_StatusForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Available);
            this.Controls.Add(this.lb_Active);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_index";
            this.Text = "Szerződések";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox lb_Active;
        private System.Windows.Forms.ListBox lb_Available;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_StatusForm;
        private System.Windows.Forms.ToolStripMenuItem újFelvételeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_NewContract;
        private System.Windows.Forms.ToolStripMenuItem mi_NewUser;
        private System.Windows.Forms.Button btn_ContractForm;
        private System.Windows.Forms.Label label_Contractor;
        private System.Windows.Forms.Label label_Deadline;
    }
}

