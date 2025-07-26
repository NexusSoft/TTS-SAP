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
    public class CLS_CartaPorte_Bind : ConexionBase
    {
        public string vUUID { get; set; }
        public string vFecha { get; set; }
        public decimal vTC { get; set; }
        public string vMoneda { get; set; }
        public string vProveedor { get; set; }
        public string vChofer { get; set; }
        public string vCaja { get; set; }
        public string vPlacas { get; set; }
        public decimal vTotal { get; set; }
        public string vDestino { get; set; }


        public string Fecha_Inicio { get; set; }
        public string Fecha_Fin { get; set; }
        public string Usuario { get; set; }



        public void MtdSeleccionarCartaPorteBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindCartaPorte_Select";
                _dato.CadenaTexto = vUUID;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "UUID");
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

        public void MtdSeleccionarCartaPorteBind_Fechas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindCartaPorteFechas_Select";
                _dato.CadenaTexto = Fecha_Inicio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Inicio");
                _dato.CadenaTexto = Fecha_Fin;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha_Fin");
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
        public void MtdInsertarCartaPorteBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindCartaPorte_Insert";
                _dato.CadenaTexto = vUUID;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "UUID");
                _dato.CadenaTexto = vFecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.Decimal = vTC;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "TC");
                _dato.CadenaTexto = vMoneda;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Moneda");
                _dato.CadenaTexto = vProveedor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Proveedor");
                _dato.CadenaTexto = vChofer;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Chofer");
                _dato.CadenaTexto = vCaja;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Caja");
                _dato.CadenaTexto = vPlacas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Placas");
                _dato.Decimal = vTotal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Total");
                _dato.CadenaTexto = vDestino;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Destino");
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
        public void MtdEliminarCartaPorteBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindCartaPorte_Delete";
                _dato.CadenaTexto = vUUID;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "UUID");
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
