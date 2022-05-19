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
    public partial class form_beadas : Form
    {
        public List<Contract> contracts = new List<Contract>();
        public List<User> users = new List<User>();
        public form_beadas()
        {
            InitializeComponent();
            Open();
        }

        private void form_vallalas_Load(object sender, EventArgs e)
        {
            
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
                    clb_Contracts.Items.Add(contract.Name);
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
                lb_Users.Items.Add(user.Name);
            }
            reader2.Close();
        }

        private void btn_FinishContract_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nincs implementálva");
            DialogResult = DialogResult.OK;
        }
    }
}
