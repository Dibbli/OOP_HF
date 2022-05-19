using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace EXC8JY_OOP_HF
{
    public partial class form_newcontract : Form
    {
        protected Contract contract;
        internal Contract Contract
        {
            get { return contract; }
        }
        public form_newcontract()
        {
            InitializeComponent();
            contract = new Contract();
        }

        private void btn_SubmitContract_Click(object sender, EventArgs e)
        {
            ReadData();
            DialogResult = DialogResult.OK;
            
        }
        protected virtual void ReadData()
        {
            contract.Name = tb_ContractName.Text;
            contract.Deadline = dtp_Deadline.Value.ToString();
        }

        private void form_newcontract_Load(object sender, EventArgs e)
        {

        }
    }
}
