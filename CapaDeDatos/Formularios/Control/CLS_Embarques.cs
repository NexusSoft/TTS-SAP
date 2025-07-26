using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace CapaDeDatos
{
    public class CLS_Embarques : ConexionBase
    {
        public int Id_Embarque { get; set; }
        public int Id_Realizo_embarque { get; set; }
        public int Id_Autorizo_embarque { get; set; }
        public string Fecha { get; set; }
        public string Hora_Inicio { get; set; }
        public string Hora_Fin { get; set; }
        public string Hora_Despacho { get; set; }
        public string Caja_Limpia { get; set; }
        public string Caja_Sanitizada { get; set; }
        public string Equipo_Funcionamiento { get; set; }
        public string Usuario { get; set; }

        public void MtdSeleccionarEmbarque()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_Embarque_Select";
                _dato.Entero = Id_Embarque;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Id_Embarque");
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
        public void MtdInsertarEmbarque()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_Embarque_Insert";
                _dato.Entero = Id_Embarque;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Id_Embarque");
                _dato.Entero = Id_Realizo_embarque;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Id_Realizo_embarque");
                _dato.Entero = Id_Autorizo_embarque;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Id_Autorizo_embarque");
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = Hora_Inicio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora_Inicio");
                _dato.CadenaTexto = Hora_Fin;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora_Fin");
                _dato.CadenaTexto = Hora_Despacho;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Hora_Despacho");
                _dato.CadenaTexto = Caja_Limpia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Caja_Limpia");
                _dato.CadenaTexto = Caja_Sanitizada;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Caja_Sanitizada");
                _dato.CadenaTexto = Equipo_Funcionamiento;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Equipo_Funcionamiento");
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
