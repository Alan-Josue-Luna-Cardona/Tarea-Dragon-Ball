using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_Dragon_Ball.Data;

namespace Tarea_Dragon_Ball
{
    public partial class Form1 : Form
    {
        private PersonajesDB personajes;
        private string[] razasDragonBall = {
    "Android",
    "Bio-Android",
    "Humana",
    "Humano",
    "Majin",
    "Namekuseijin",
    "Saiyajin",
    "Saiyajin/Humano",
    "Saiyajin/Saiyajin"
};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1raza.Items.AddRange(razasDragonBall);
        }
        


        private void nivelpoder_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void BuscarPorId()
        {

            int idPersonajeBuscar = int.Parse(Boxid.Text);



            DataTable personajeEncontrado = personajes.BuscarPersonajePorId(idPersonajeBuscar);
            if (personajeEncontrado.Rows.Count > 0)
            {
                string tnombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string traza = personajeEncontrado.Rows[0]["raza"].ToString();
                int tnivelPoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());

                DateTime fecha_creacion = (DateTime)personajeEncontrado.Rows[0]["fecha_creacion"];
                string historia = personajeEncontrado.Rows[0]["historia"].ToString();
                Boxnombre.Text = tnombre;
                comboBox1raza.Text = traza;
                nivelpoder.Value = tnivelPoder;
                textBoxhistoria.Text = historia;
                dateTimePicker1.Value = fecha_creacion;

            }
            else
            {
                MessageBox.Show("No hay nada");
            }
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonbuscar_Click_1(object sender, EventArgs e)
        {
            BuscarPorId();
        }

        private void crear_Click_1(object sender, EventArgs e)
        {

            string tnombre = Boxnombre.Text;
            string traza = comboBox1raza.Text;
            int tnivelPoder = (int)nivelpoder.Value;
            string historia = textBoxhistoria.Text;
            DateTime fecha_creacion = DateTime.Now;
            int respuesta = personajes.CrearPersonaje(tnombre, traza, tnivelPoder, historia, fecha_creacion);

            if (respuesta > 0)
            {
                MessageBox.Show("creado con exito");
                dataGridViewPersonajes.DataSource = personajes.LeerPersonajes();

            }
            else
            {

                MessageBox.Show("La fregaste en algo");

            }
        }

        private void cargar_Click_1(object sender, EventArgs e)
        {
            DataTable dt = personajes.LeerPersonajes();
            dataGridViewPersonajes.DataSource = dt;
        }

        private void buttonactu_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Boxid.Text);
            string nombre = Boxnombre.Text;
            string raza = comboBox1raza.Text;
            int nivelPoder = (int)nivelpoder.Value;
            string historia = textBoxhistoria.Text;
            DateTime fecha_creacion = dateTimePicker1.Value;
            int respuesta = personajes.ActualizarPersonaje(id, nombre, raza, nivelPoder, historia, fecha_creacion);
            if (respuesta > 0)
            {
                MessageBox.Show("Ya estuvo");
                dataGridViewPersonajes.DataSource = personajes.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("No lo hiciste bien.");
            }
        }

        private void buttoneliminar_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Boxid.Text);
            int respuesta = personajes.BorrarPersonaje(id);
            if (respuesta > 0)
            {
                MessageBox.Show("Ya se fue");
                Boxid.Clear();
                Boxnombre.Clear();
                comboBox1raza.SelectedIndex = -1;
                nivelpoder.Value = 0;
                textBoxhistoria.Clear();
                dataGridViewPersonajes.DataSource = personajes.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("O sigue aqui. O nunca estuvo");
            }
        }

        private void prueba_Click_1(object sender, EventArgs e)
        {

            if (personajes.ProbarConexion())

            {
                MessageBox.Show("SI");
            }
            else
            {

                MessageBox.Show("NO");


            }
        }
    }
}

