using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_nomina
{
    public class Nomina
    {
        #region Atributos
        // DATOS TRABAJADOR
        private string nombre;
        private string cedula;
        private int dia_laborados;
        private float sueldo_base;
        // SALARIO Y AUXILIO
        private float salario_minimo;
        private float auxilio_standart;
        // DATOS ESPERADOS
        private float auxilio_transporte;
        public float total_devengado;
        private float basico;
        private string error;
        // TIPO DE NOMINA
        private int tipo_nomina;
        private int dividirSalario;
        #endregion

        #region Metodos Publicos
        public Nomina()
        {
            // DATOS TRABAJADOR
            nombre = "";
            cedula = "";
            dia_laborados = 0;
            sueldo_base = 0;
            // SALARIO Y AUXILIO
            salario_minimo = 0;
            auxilio_standart = 0;
            // DATOS ESPERADOS
            auxilio_transporte = 0;
            total_devengado = 0;
            basico = 0;
            error = "";
            // TIPO DE NOMINA
            tipo_nomina = 0;
            dividirSalario = 0;
        }


        public bool TotalDevengado()
        {
            try
            {
                if (!Validar())
                    return false;
              
                if (!CalcularAuxilioTransporte() || !CalcularSalario())
                    return false;
                
                total_devengado = basico + auxilio_transporte;
                
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        

        public bool CalcularSalario()
        {
            try
            {
                basico = ((sueldo_base * dia_laborados) / tipo_nomina) / dividirSalario;
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public bool CalcularAuxilioTransporte()
        {
            try
            {
                if (!ValidarAuxilioTransporte())
                {
                    auxilio_transporte = 0;
                    return true;
                }
                else
                {
                    auxilio_transporte = ((auxilio_standart * dia_laborados) / tipo_nomina) / dividirSalario;
                    return true;
                }
                
            }catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        #endregion

        #region Metodos Privados
        // -------- VALIDACIONES ---------
        private bool ValidarCedula()
        {
            if (cedula == "")
            {
                error = "Porfavor ingrese su cedula";
                return false;
            }
            return true;
        }
        private bool ValidarDiaLaborados()
        {
            if (dia_laborados < 0 || dia_laborados > tipo_nomina)
            {
                error = "Dias no validos";
                return false;
            }
            return true;
        }
        private bool ValidarSueldoBase()
        {
            if (sueldo_base < 0)
            {
                error = "Sueldo no valido";
                return false;
            }
            return true;
        }
        private bool ValidarNombre()
        {
            if (nombre == "")
            {
                error = "Nombre no valido";
                return false;
            }
            return true;
        }
        private bool Validar()
        {
            if (!ValidarCedula() || !ValidarDiaLaborados() || !ValidarSueldoBase() || !ValidarNombre())
                return false;
            return true;
        }
        // --------------------------------------------------------------
        // --- CALCULOS ---
        private bool ValidarAuxilioTransporte()
        {
            if(sueldo_base > (salario_minimo * 2))
            {
                error = "No se puede pagar el auxilio de transporte";
                return false;
            }
            return true;
        }
        #endregion

        #region Propiedades
        // ---------- SET
        public string SetNombre
        {
            set { nombre = value; }
        }
        public string SetCedula
        {
            set { cedula = value; }
        }
        public int SetDiaLaborados
        {
            set { dia_laborados = value; }
        }
        public float SetSueldoBase
        {
            set { sueldo_base = value; }
        }
        public float SetSalarioMinimo
        {
            set { salario_minimo = value; }
        }
        public float SetAuxilioStandart
        {
            set { auxilio_standart = value; }
        }
        public int SetTipoNomina
        {
            set { tipo_nomina = value; }
        }
        public int SetDividirSalario
        {
            set { dividirSalario = value; }
        }
        // ------------ GET
        public float GetAuxilioTransporte
        {
            get { return auxilio_transporte; }
        }
        public float GetTotalDevengado
        {
            get { return total_devengado; }
        }
        public float GetBasico
        {
            get { return basico; }
        }
        public string GetError
        {
            get { return error; }
        }
        #endregion

    }
}
