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

            paciente = PacienteNegocio.GuardarPacienteNegocio(paciente);
            if(paciente != null)
            {
                textBox_ID.Text = paciente.Id.ToString();
                MessageBox.Show("los datos se insertaron satisfactoriamente");
                CargarListadoPacientesDataGrid();
            }

        }

        private void Form_Pacientes_Load(object sender, EventArgs e)
        {
            CargarValoresIniciales();
        }

        private void CargarValoresIniciales()
        {
            CargarListadoPacientesDataGrid();
        }

        private void CargarListadoPacientesDataGrid()
        {
            dataGridView_PACIENTES.DataSource = PacienteNegocio.DevolverListadoPacientes();
        }
    }
}
