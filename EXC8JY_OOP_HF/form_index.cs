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
        public List<Contract> contracts = new List<Contract>();
        public List<User> users = new List<User>();
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
            if (frm.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Szerződés nem lett hozzáadva");
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
            File.WriteAllText("users.txt", string.Empty);
            StreamWriter writer2 = new StreamWriter("users.txt", true);
            foreach (User user in users)
            {
                writer2.WriteLine(user.Stuff);
            }
            writer2.Close();
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

            users.Clear();
            StreamReader reader2 = new StreamReader("users.txt");
            while (!reader2.EndOfStream)
            {
                string line = reader2.ReadLine();
                User user;
                string[] piece = line.Split(',');
                user = new User();
                user.Name = piece[0];
                users.Add(user);
                
            }
            reader2.Close();
        }
            private void mi_NewUser_Click(object sender, EventArgs e)
        {
            form_newuser frm = new form_newuser();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                users.Add(frm.User);
            }
            if (frm.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Válalkozó nem lett hozzáadva");
            }
        }

        private void btn_AcceptContract_Click(object sender, EventArgs e)
        {
            File.WriteAllText("contracts.txt", string.Empty);
            StreamWriter writer = new StreamWriter("contracts.txt", true);
            foreach (Contract contract in contracts)
            {
                writer.WriteLine(contract.Stuff);
            }
            writer.Close();
            File.WriteAllText("users.txt", string.Empty);
            StreamWriter writer2 = new StreamWriter("users.txt", true);
            foreach (User user in users)
            {
                writer2.WriteLine(user.Stuff);
            }
            writer2.Close();
            form_beadas frm = new form_beadas();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
            }
            if (frm.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Szerzodes nem lett leadva");
            }
        }
    }
}
