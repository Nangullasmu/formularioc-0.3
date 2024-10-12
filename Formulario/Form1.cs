using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Formulario
{
    public partial class FFormulario : Form
    {
        string SqlConection = "Server = localhost; Port = 3306; Database = programacionavanzada;Uid = root; Pwd = 12345678";
        public FFormulario()
        {
            InitializeComponent();
            tbedad.TextChanged += ValidarEdad;
            tbestatura.TextChanged += ValidarEstatura;
            tbtelefono.Leave += ValidarTelefono;
            tbnombre.TextChanged += ValidarNombre;
            tbapellido.TextChanged += ValidarApellidos;
            btguardar.Click += btguardar_Click;
            btcancerlar.Click += btcancerlar_Click;
        }

        private void InsertarRegistro(string nom, string ape, int eda, decimal est, string tel, string gen)
        {
            using (MySqlConnection conection = new MySqlConnection(SqlConection))
            {
                conection.Open();
                string insertQuery = "INSERT INTO registros (Nombre, Apellido, Telefono, Estatura, Edad, Genero) VALUES (@Nombre, @Apellido, @Telefono, @Estatura, @Edad, @Genero)";
                using (MySqlCommand command = new MySqlCommand(insertQuery, conection))
                {
                    command.Parameters.AddWithValue("@Nombre", nom);
                    command.Parameters.AddWithValue("@Apellido", ape);
                    command.Parameters.AddWithValue("@Edad", eda);
                    command.Parameters.AddWithValue("@Telefono", tel);
                    command.Parameters.AddWithValue("@Estatura", est);
                    command.Parameters.AddWithValue("@Genero", gen);

                    command.ExecuteNonQuery();
                }
                conection.Close();
            }
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            string nom = tbnombre.Text;
            string ape = tbapellido.Text;
            string tel = tbtelefono.Text;
            string est = tbestatura.Text;
            string eda = tbedad.Text;

            string gen = "";
            if (cbhombre.Checked)
            {
                gen = "Hombre";
            }
            else if (cbmujer.Checked)
            {
                gen = "Mujer";
            }

            string datos = $"Nombre: {nom}\r\n Apellido: {ape}\r\n Telefono: {tel} \r\n Estatura: {est} \r\n Edad: {eda} \r\n Genero: {gen}";
            string rutaArchivo = "C:/Users/perez/OneDrive/Documentos/tareas semestre 3/Programacion Avanzada/C#/Formulario/datosformulario.txt";
            bool archivoexiste = File.Exists(rutaArchivo);

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if (archivoexiste)
                {
                    writer.WriteLine();
                    InsertarRegistro(nom, ape, int.Parse(eda), decimal.Parse(est), tel, gen);
                }
                writer.WriteLine(datos);
                InsertarRegistro(nom, ape, int.Parse(eda), decimal.Parse(est), tel, gen);
            }
            MessageBox.Show("Datos Guardados con exito: \n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }

        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }

        private bool EsEnteroValido10digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10;
        }

        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }

        private void ValidarEdad(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsEnteroValido(textbox.Text))
            {
                MessageBox.Show("Ingrese una edad valida", "Error Edad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void ValidarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Ingrese una estatura valida", "Error Estatura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarTelefono(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Length == 10 && EsEnteroValido10digitos(textbox.Text))
            {
                textbox.BackColor = Color.Green;
            }
            else
            {
                textbox.BackColor = Color.Red;
                MessageBox.Show("Ingrese un telefono de 10 digitos", "Error telefono", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void ValidarApellidos(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Ingrese Apellidos Validos", "Error Apellidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void ValidarNombre(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Ingrese Nombres Validos", "Error Nombres", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void btcancerlar_Click(object sender, EventArgs e)
        {
            tbnombre.Clear();
            tbapellido.Clear();
            tbtelefono.Clear();
            tbedad.Clear();
            tbestatura.Clear();
            cbhombre.Checked = false;
            cbmujer.Checked = false;
        }
    }
}