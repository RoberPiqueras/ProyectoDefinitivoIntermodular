using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProyectoIntermodularLinkBD
{
    public partial class Form1: Form
    {
        private MySqlConnection conexion;
        MySqlConnectionStringBuilder builder =
                    new MySqlConnectionStringBuilder();
        private String seleccion = "";
        private bool columna;
        String tipoOperacion;
        String query = "";
        int contadorColumnas = 0;

        public Form1()
        {
            InitializeComponent();
        }




        // ComboBox

        private void cbBaseDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }
            if (cbBaseDatos.SelectedIndex != -1)
            {
                seleccion = cbBaseDatos.SelectedItem.ToString();
                MessageBox.Show("Has seleccionado: " + seleccion);
                gbAgregacion.Enabled = false;

            }

        }

        //FormularioLoad 

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Definir la conexión correctamente
                string connectionString = "Server=localhost;Port=3306;UserID=root;Password=Rober1410;";
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = "SHOW DATABASES;";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cbBaseDatos.Items.Clear(); // Limpiar ComboBox antes de agregar datos

                    while (reader.Read())
                    {
                        cbBaseDatos.Items.Add(reader.GetString(0)); // Agregar BD al ComboBox
                    }

                    reader.Close();

                    foreach (Control control in this.Controls)
                    {
                        if (control != gbSeleccionarBD && control != cbBaseDatos)
                        {
                            control.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las bases de datos: " + ex.Message);
            }
        }

        //CheckBox

        private void cbTabla_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTabla.Checked) 
            {
                cbColumna.Enabled = true;
                tbColumna.ReadOnly = false;
                cbProcedure.Enabled = false;
                tbProcedure.ReadOnly = true;
                cbTrigger.Enabled = false;
                tbTrigger.ReadOnly = true;
            } 
            else 
            {
                cbColumna.Enabled = true;
                tbColumna.ReadOnly = false;
                cbProcedure.Enabled = true;
                tbProcedure.ReadOnly = false;
                cbTrigger.Enabled = true;
                tbTrigger.ReadOnly = false;
            }
        }

        private void cbColumna_CheckedChanged(object sender, EventArgs e)
        {
            if (cbColumna.Checked)
            {
                cbTabla.Enabled = true;
                tbTabla.ReadOnly = false;
                cbProcedure.Enabled = false;
                tbProcedure.ReadOnly = true;
                cbTrigger.Enabled = false;
                tbTrigger.ReadOnly = true;
            }else 
            {
                cbTabla.Enabled = true;
                tbTabla.ReadOnly = false;
                cbProcedure.Enabled = true;
                tbProcedure.ReadOnly = false;
                cbTrigger.Enabled = true;
                tbTrigger.ReadOnly = false;
            }
        }

        private void cbProcedure_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProcedure.Checked)
            {
                tbQuery.ReadOnly = false;
                cbTabla.Enabled = false;
                tbTabla.ReadOnly = true;
                cbColumna.Enabled = false;
                tbColumna.ReadOnly = true;
                cbTrigger.Enabled = false;
                tbTrigger.ReadOnly = true;
            }
            else
            {
                tbQuery.ReadOnly = true;
                cbTabla.Enabled = true;
                tbTabla.ReadOnly = false;
                cbColumna.Enabled = true;
                tbColumna.ReadOnly = false;
                cbTrigger.Enabled = true;
                tbTrigger.ReadOnly = false;
            }
        }

        private void cbTrigger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTrigger.Checked)
            {
                tbQuery.ReadOnly = false;
                cbColumna.Enabled = false;
                tbColumna.ReadOnly = true;
                cbProcedure.Enabled = false;
                tbProcedure.ReadOnly = true;
                cbTabla.Enabled = false;
                tbTabla.ReadOnly = true;
            }
            else
            {
                tbQuery.ReadOnly = true;
                cbColumna.Enabled = true;
                tbColumna.ReadOnly = false;
                cbProcedure.Enabled = true;
                tbProcedure.ReadOnly = false;
                cbTabla.Enabled = true;
                tbTabla.ReadOnly = false;
            }
        }

        private void cbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAscendente.Checked)
            {
                tbOrdenar.ReadOnly = false;
            }
            else 
            {
                tbOrdenar.ReadOnly = true;
            }
            
        }

        private void cbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDescendente.Checked)
            {
                tbOrdenar.ReadOnly = false;
            }
            else
            {
                tbOrdenar.ReadOnly = true;
            }
        }

        private void cbAscendente1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAscendente1.Checked)
            {
                tbAgrupar.ReadOnly = false;
            }
            else
            {
                tbAgrupar.ReadOnly = true;
            }
        }

        private void cbDescendente1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDescendente1.Checked)
            {
                tbAgrupar.ReadOnly = false;
            }
            else
            {
                tbAgrupar.ReadOnly = true;
            }
        }

        private void cbAgregacion_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbAgregacion.Checked)
            {
                cbSUM.Enabled = false;
                cbCOUNT.Enabled = false;
                cbAVG.Enabled = false;
                cbMIN.Enabled = false;
                cbMAX.Enabled = false;
            }
            else
            {
                cbSUM.Enabled = true;
                cbCOUNT.Enabled = true;
                cbAVG.Enabled = true;
                cbMIN.Enabled = true;
                cbMAX.Enabled = true;
            }
        }

        // Botones

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            try
            {
                List<string> listanombres = new List<string>();
                
                if (cbTabla.Checked && contadorColumnas == 1)
                {
                    conexion.Open();
                    query = "Create table @nombre (@nombreColumna @tipo_dato @restricciones);";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", tbTabla.Text);
                    cmd.Parameters.AddWithValue("@nombreColumna", tbTabla.Text);
                    cmd.Parameters.AddWithValue("@tipo_dato", tbTabla.Text);
                    cmd.Parameters.AddWithValue("@restricciones", tbTabla.Text);
                    conexion.Close();

                } else if (cbTabla.Checked && contadorColumnas > 1) 
                {
                    for (int i = 0; i < contadorColumnas; i++) 
                    {
                        conexion.Open();
                        query += "(@nombreColumna @tipo_dato @restricciones);";
                        MySqlCommand cmd = new MySqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@nombreColumna", listanombres[+1]);
                        conexion.Close();
                    }
                }


            } catch (Exception ex) 
            {
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Select";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Upadate";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cbTabla.Enabled = true;
            tbTabla.ReadOnly = false;
            cbColumna.Enabled = true;
            tbColumna.ReadOnly = false;

            MessageBox.Show("Has dado al botón eliminar, ahora debes \n" +
                "seleccionar que quieres eliminar, tabla entera o una columna");


            if (cbTabla.Checked)
            {
                query = "DROP TABLE " + tbTabla.Text;
            }
            else if (cbColumna.Checked)
            {
                query = "ALTER TABLE " + tbTabla.Text + " DROP COLUMN " + tbColumna.Text;
            }


        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder =
                new MySqlConnectionStringBuilder();

            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Rober1410";
            builder.Database = seleccion;


            conexion = new MySqlConnection(builder.ToString());
            MessageBox.Show("Conectado");
        }

        //Funciones

        public void visualizar(String query) 
        {
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                // Asignar el DataTable al DataGridView
                dataGV.DataSource = dt;
            
        }

        private void btanadirColumna_Click(object sender, EventArgs e)
        {
            contadorColumnas++;
            string nombre = tbColumna.Text;
            tbColumna.Clear();
            MessageBox.Show("Has insertado la columna: " + nombre);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}

