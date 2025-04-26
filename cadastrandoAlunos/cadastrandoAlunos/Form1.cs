using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastrandoAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string curso = cbCurso.SelectedItem?.ToString() ?? "Não selecionado";
            string turno = "";

            if (rbManha.Checked)
                turno = "Manhão";
            else if (rbTarde.Checked)
                turno = "Tarde";
            else if (rbNoite.Checked)
                turno = "Noite";
            else
                turno = "Não selecionado";

            string recebeEmail = chkEmail.Checked ? "Sim" : "Não";

            lblResultado.Text = $"Nome: {nome}\nCurso: {curso}\nTurno: {turno}\nRecebe e-emails: {recebeEmail}";
        }
    }
}
