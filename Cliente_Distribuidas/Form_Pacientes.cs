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
            paciente.NumeroIESS = textBox_numeroIESS.Text;

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
            CargarListadoGeneros();
        }

        private void CargarListadoPacientesDataGrid()
        {
            dataGridView_PACIENTES.DataSource = PacienteNegocio.DevolverListadoPacientes();
        }
        private void CargarListadoGeneros()
        {
            List<GeneroEntidad> generos = PacienteNegocio.DevolverListadoGeneros();
            comboBox_GENERO.DataSource = generos;
            comboBox_GENERO.DisplayMember = "nombre";
        }

        private void dataGridView_PACIENTES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView_PACIENTES.Rows[e.RowIndex].Cells["id"].Value.ToString());
            CargarPacientePorId(id);
        }

        private void CargarPacientePorId(int id)
        {
            //TODO: Invocar los datos desde la base de datos
            paciente = PacienteNegocio.DevolverPacientePorID(id);

            //TODO: Los resultados los vamos a cargar en el formulario
            textBox_ID.Text = paciente.Id.ToString();
            textBox_NOMBRE.Text = paciente.Nombre;
            textBox_APELLIDO.Text = paciente.Apellido;
            textBox_CEDULA.Text = paciente.Cedula;
            textBox_TELEFONO.Text = paciente.Telefono;
            textBox_DIRECCION.Text = paciente.Direccion;
            textBox_numeroIESS.Text = paciente.NumeroIESS;
        }

        private void comboBox_GENERO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
