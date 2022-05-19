using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXC8JY_OOP_HF
{
    
    public partial class form_index : Form
    {
        List<Contract> contracts = new List<Contract>();
        public form_index()
        {
            InitializeComponent();
            Open();
        }

        private void mi_NewContract_Click(object sender, EventArgs e)
        {
            form_newcontract frm = new form_newcontract();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                contracts.Add(frm.Contract);
                lb_Available.Items.Add(frm.Contract.Name);
            }
        }

        private void form_index_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("contracts.txt", string.Empty);
            StreamWriter writer = new StreamWriter("contracts.txt", true);
            foreach (Contract contract in contracts)
            {
                writer.WriteLine(contract.Stuff);
            }
            writer.Close();
        }
        void Open()
        {
            contracts.Clear();
            StreamReader reader = new StreamReader("contracts.txt");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                Contract contract;
                string[] piece = line.Split(',');
                
                if (piece.Length == 2)
                {
                    contract = new Contract();

                    contract.Stuff = line;
                    contracts.Add(contract);
                    lb_Available.Items.Add(contract.Name);
                }
                else
                {
                    contract = new ContractFinished();
                    contract.Stuff = line;
                    contracts.Add(contract);
                    lb_Active.Items.Add(contract.Name);
                }
            }
            reader.Close();
        }

    }
}
