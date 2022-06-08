using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Distribuidas;
using Negocio_Distribuidas;

namespace Cliente_Distribuidas
{
    public partial class Form_Pacientes : Form
    {
        PacienteEntidad paciente = new PacienteEntidad();
        public Form_Pacientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_GUARDAR_Click(object sender, EventArgs e)
        {
            GuardarPaciente();
        }

        private void GuardarPaciente()
        {
            paciente.Nombre = textBox_NOMBRE.Text;
            paciente.Apellido = textBox_APELLIDO.Text;
            paciente.Cedula = textBox_CEDULA.Text;
            paciente.Telefono = textBox_TELEFONO.Text;
            paciente.Direccion = textBox_DIRECCION.Text;

            PacienteNegocio.GuardarPacienteNegocio(paciente);

        }
    }
}
