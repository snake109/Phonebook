using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsTH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phonebook 1.0.1 \nWritten by: Naist", "About");
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.telefoneTextBox.Text = Regex.Replace(this.telefoneTextBox.Text, @"(\d{0})(\d{2})(\d{0})(\d{5})", "$1($2)$3 $4-");
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }
        
        private void phoneNumberStringFormat()
        {
            if (telefoneTextBox.Text.Length < 11)
            {
                MessageBox.Show("The written phonenumber does not applies to a correct format. Please enter a correct phonenumber. \nExample: (21)995897161.");
            }
        }
    }
}
