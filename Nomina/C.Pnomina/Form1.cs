using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib_nomina;

namespace C.Pnomina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Instanciar la logica de negocios
                Nomina objNM = new Nomina();

                // Enviar los valores a la LN
                objNM.SetNombre = txtNombre.Text;
                objNM.SetCedula = txtCedula.Text;
                objNM.SetDiaLaborados = Convert.ToInt32(txtDtrabajados.Text);
                objNM.SetSueldoBase = (float) Convert.ToDouble(txtSueldo.Text);
                objNM.SetSalarioMinimo = 1000000;
                objNM.SetAuxilioStandart = 117172;
                objNM.SetTipoNomina = RbMensual.Checked ? 30 : 15;
                objNM.SetDividirSalario = RbMensual.Checked ? 1 : 2;


                ////////

                if (objNM.CalcularSalario() && objNM.CalcularAuxilioTransporte() && objNM.TotalDevengado())
                {
                    txtRbasico.Text = objNM.GetBasico.ToString();
                    txtRauxilio.Text = objNM.GetAuxilioTransporte.ToString();
                    txtRDevengado.Text = objNM.GetTotalDevengado.ToString();
                }
                else
                {
                    MessageBox.Show(objNM.GetError);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
