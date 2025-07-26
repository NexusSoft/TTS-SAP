using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CLS_TipoCambio : ConexionBase
    {
        public string vFecha { get; set; }
        public decimal vTipoCambio { get; set; }
        
        public string Fecha_Inicio { get; set; }
        public string Fecha_Fin { get; set; }
        public string Usuario { get; set; }


        public void MtdInsertarTipoCambioBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindTipoCambio_Insert";
                _dato.CadenaTexto = vFecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_TC");
                _dato.Decimal = vTipoCambio;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "TC");
                _dato.CadenaTexto = Usuario;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Usuario");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        
    }
}
