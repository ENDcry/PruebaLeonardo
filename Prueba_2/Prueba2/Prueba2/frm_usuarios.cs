using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2
{
    public partial class frm_usuarios : Form
    {
        public frm_usuarios()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int nCodigo_us = 0;
        int nEstadoGuarda = 0;
        #endregion

        #region "Mis Metodos"


        private void Listado_us(string cTexto)
        {
            D_Usuarios Datos = new D_Usuarios();
            Dgv_usuarios.DataSource = Datos.Listado_cl(cTexto);
                }

        private void Limpia_texto()
        {
            Txt_Name.Text = "";
            Txt_Paterno.Text = "";
            Txt_Materno.Text = "";
            Txt_Sueldo.Text = "";
            //Txt_Fecha_Ingresa2.Text = "";
        }
        private void Seleccion_item() 
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_usuarios.CurrentRow.Cells["Nombres"].Value)))
            {
                MessageBox.Show("Selecciona un registro",
                                "Aviso de sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                this.nCodigo_us = Convert.ToInt32(Dgv_usuarios.CurrentRow.Cells["userId"].Value);
                Console.WriteLine(nCodigo_us);
                Txt_Sueldo.Text = Convert.ToString(Dgv_usuarios.CurrentRow.Cells["Sueldo"].Value);
                Txt_Name.Text = Convert.ToString(Dgv_usuarios.CurrentRow.Cells["Nombres"].Value);
                Txt_Paterno.Text = Convert.ToString(Dgv_usuarios.CurrentRow.Cells["Paterno"].Value);
                Txt_Materno.Text = Convert.ToString(Dgv_usuarios.CurrentRow.Cells["Materno"].Value);
                //Txt_Fecha_Ingresa2.Text = Convert.ToString(Dgv_usuarios.CurrentRow.Cells["FechaIngreso"].Value);
            }
        }

        #endregion


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Limpia_texto();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nEstadoGuarda = 1;
        }

        private void Dgv_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            P_Usuarios oAr = new P_Usuarios();
            oAr.Nombre = Txt_Name.Text;
            oAr.Paterno = Txt_Paterno.Text;
            oAr.Materno = Txt_Materno.Text;
            oAr.sueldo = Convert.ToDouble(Txt_Sueldo.Text);
            oAr.FechaIngreso = DateTime.Now.ToString("yyyy-MM-dd");

            D_Usuarios Datos = new D_Usuarios();
            Rpta = Datos.Guardar_ar(nEstadoGuarda, oAr);
            if (Rpta.Equals("OK"))
            {
                nCodigo_us = 0;
                MessageBox.Show("Los datos se han guardado correctamente",
                                 "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else 
            {
          
                MessageBox.Show(Rpta, "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            
         }
        



        private void frm_usuarios_Load_1(object sender, EventArgs e)
        {
            this.Listado_us("%");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1;
            this.Limpia_texto();
            
        }

        private void Dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Seleccion_item();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
