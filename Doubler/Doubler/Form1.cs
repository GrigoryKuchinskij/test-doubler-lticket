using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxOutp.Text = "";
        }

        private void buttonMultip_Click(object sender, EventArgs e)
        {
            if (TBoxInpIsValid())
                textBoxOutp.Text = Convert.ToString(Convert.ToInt64(textBoxInp.Text) * 2);
        }

        private void buttonDoubl_Click(object sender, EventArgs e)
        {
            if (TBoxInpIsValid())
                textBoxOutp.Text = textBoxInp.Text + textBoxInp.Text;
        }

        private bool TBoxInpIsValid()
        {
            if (textBoxInp.Text.Length >= 10)
            {
                try { Convert.ToInt64(textBoxInp.Text); return true; }
                catch { textBoxOutp.Text = "Допускается ввод только целых чисел"; textBoxInp.BackColor = Color.IndianRed; return false; };
            }
            else { textBoxOutp.Text = "В числе должно быть не менее 10 символов"; textBoxInp.BackColor = Color.IndianRed; return false; }
        }

        private void textBoxInp_Leave(object sender, EventArgs e)
        {
            TBoxInpIsValid();
        }

        private void textBoxInp_Enter(object sender, EventArgs e)
        {
            textBoxInp.BackColor = Color.White;
        }

    }
}
