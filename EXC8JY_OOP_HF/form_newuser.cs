using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXC8JY_OOP_HF
{
    public partial class form_newuser : Form
    {
        protected User user;
        internal User User
        {
            get { return user; }
        }
        public form_newuser()
        {
            InitializeComponent();
            user = new User();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            ReadData();
            DialogResult = DialogResult.OK;
        }
        protected virtual void ReadData()
        {
            user.Name = tb_Nev.Text;
        }
        private void form_newuser_Load(object sender, EventArgs e)
        {

        }
    }
}
