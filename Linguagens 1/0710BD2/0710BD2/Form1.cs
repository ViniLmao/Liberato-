using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0710BD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Empresa'. Você pode movê-la ou removê-la conforme necessário.
            this.empresaTableAdapter.Fill(this.database1DataSet.Empresa);
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Departamento'. Você pode movê-la ou removê-la conforme necessário.
            this.departamentoTableAdapter.Fill(this.database1DataSet.Departamento);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
