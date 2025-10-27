using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarComponentesExtra();
        }
        // 1. Declarar una cola de tipo string para almacenar los datos del cliente
        // El string almacenará: ID, Nombre y Motivo de visita.
        private Queue<string> colaClientes = new Queue<string>();
        private List<string> historialAtendidos = new List<string>(); // Para almacenar el historial de clientes atendidos
        private int contadorClientes = 0; // Para el ID sucesivo (#001, #002, etc.)

        private void InicializarComponentesExtra()
        {
            // Inicializar el ComboBox de Motivos
            cmbMotivo.Items.Add("Depósito");
            cmbMotivo.Items.Add("Retiro");
            cmbMotivo.Items.Add("Asesoría de Crédito");
            cmbMotivo.Items.Add("Pago de Servicios");
            cmbMotivo.SelectedIndex = 0; // Selecciona un valor por defecto
            lblMensaje.Text = "Sistema de Cola del Banco iniciado. Listo para registrar clientes.";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            try
            {
                // **Manejo de Excepciones: Validación de Datos**
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    // Lanza una excepción si el nombre está vacío o es solo espacios
                    throw new Exception("El nombre del cliente no puede estar vacío. Por favor, ingrese un nombre.");
                }

                if (cmbMotivo.SelectedIndex == -1)
                {
                    // Lanza una excepción si no se ha seleccionado un motivo
                    throw new Exception("Debe seleccionar un motivo de visita.");
                }

                // Generar ID y datos
                contadorClientes++;
                // Formato de ID: #001, #002, etc.
                string clienteID = $"#{contadorClientes:D3}";
                string nombre = txtNombre.Text.Trim();
                string motivo = cmbMotivo.SelectedItem.ToString();

                // Formato de la cadena a encolar
                string clienteData = $"{clienteID} - {nombre} (Motivo: {motivo})";

                // Encolar (Enqueue) al cliente
                colaClientes.Enqueue(clienteData);

                lblMensaje.Text = $"Cliente {nombre} agregado a la cola. Su ID es: {clienteID}";
                txtNombre.Clear(); // Limpia el TextBox
                MostrarEstadoCola(); // Actualiza el ListBox

            }
            catch (Exception ex)
            {
                // Captura la excepción de validación y la muestra al usuario
                MessageBox.Show(ex.Message, "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblMensaje.Text = $"Error: {ex.Message}";
                txtNombre.Focus(); // Permite al usuario reingresar el dato
            }
        }
        

        private void btnAtender_Click(object sender, EventArgs e)
        {
            try
            {
                // **Manejo de Excepciones para Cola Vacía**
                if (colaClientes.Count == 0)
                {
                    // Lanza la excepción si la cola está vacía
                    throw new InvalidOperationException("La cola está vacía. No hay clientes para atender.");
                }

                // Desencolar (Dequeue) al primer cliente
                string clienteAtendido = colaClientes.Dequeue();
                historialAtendidos.Add(clienteAtendido); // Agregar al historial de atendidos


                // 5. Mostrar el nombre del cliente atendido
                lblMensaje.Text = $"Cliente Atendido: {clienteAtendido}. La cola ha avanzado.";

                // 5. Mostrar la cola después de atender al cliente
                MostrarEstadoCola();
            }
            catch (InvalidOperationException ex)
            {
                // Captura la excepción específica de cola vacía
                MessageBox.Show(ex.Message, "Cola Vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMensaje.Text = $"Advertencia: {ex.Message}";
                MostrarEstadoCola(); // Mostrar estado final (vacío)
            }
            catch (Exception ex)
            {
                // Captura cualquier otra excepción inesperada
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblMensaje.Text = $"Error inesperado: {ex.Message}";
            }
        }


        private void MostrarEstadoCola()
        {
            lstCola.Items.Clear();
            lstHistorial.Items.Clear();

            // 6. Indicar si la cola está vacía
            if (colaClientes.Count == 0)
            {
                lstCola.Items.Add("--- LA COLA ESTÁ VACÍA ---");
                lblMensaje.Text = "La cola está vacía. Esperando nuevos clientes.";
            }
            else
            {
                // Copia la cola a un array para poder iterar y mostrar el orden (FIFO)
                string[] clientes = colaClientes.ToArray();
                for (int i = 0; i < clientes.Length; i++)
                {
                    // Muestra la posición y el cliente
                    lstCola.Items.Add($"Posición {i + 1}: {clientes[i]}");
                }

                // Muestra el cliente que sigue sin desencolarlo (Peek)
                lblMensaje.Text = $"Clientes en espera: {colaClientes.Count}. Próximo a atender: {colaClientes.Peek()}";
            }
            if (historialAtendidos.Count == 0)
            {
                lstHistorial.Items.Add("--- NO HAY CLIENTES ATENDIDOS AÚN ---");
            }
            else
            {
                foreach (var cliente in historialAtendidos)
                {
                    lstHistorial.Items.Add(cliente);
                }
            }
        }
        private void lstCola_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

