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
    public class CLS_ODC_Bind : ConexionBase
    {
        public string vOC { get; set; }
        public decimal vCantidad { get; set; }
        public string vCategoria { get; set; }
        public string vCodigo { get; set; }
        public string vComentarios { get; set; }
        public string vCreacion { get; set; }
        public string vDescripcion { get; set; }
        public string vNoProveedor { get; set; }
        public string vProveedor { get; set; }
        public decimal vCredito { get; set; }
        public string vDireccionProveedor { get; set; }
        public decimal vPendiente { get; set; }
        public decimal vPrecio { get; set; }
        public string vSucursal { get; set; }
        public decimal vTotal { get; set; }
        public string vVencimiento { get; set; }
        public string vVendedor { get; set; }
        public string vEstatus { get; set; }
        public decimal vPeso { get; set; }

        public string Fecha_Inicio { get; set; }
        public string Fecha_Fin { get; set; }
        public string Usuario { get; set; }




        public void MtdSeleccionarODCBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindODC_Select";
                _dato.CadenaTexto = vOC;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "OC");
                _dato.Decimal = vCantidad;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Cantidad");
                _dato.CadenaTexto = vCodigo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Codigo");
                _dato.Decimal = vTotal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Total");
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
        //public void MtdSeleccionarServicioCorteODCCont()
        //{
        //    TipoDato _dato = new TipoDato();
        //    Conexion _conexion = new Conexion(cadenaConexion);

        //    Exito = true;
        //    try
        //    {
        //        _conexion.NombreProcedimiento = "SP_OrdenesCorteODCCont_Select";
        //        _dato.CadenaTexto = v_ODC_ODC;
        //        _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "v_ODC_ODC");
        //        _conexion.EjecutarDataset();

        //        if (_conexion.Exito)
        //        {
        //            Datos = _conexion.Datos;
        //        }
        //        else
        //        {
        //            Mensaje = _conexion.Mensaje;
        //            Exito = false;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Mensaje = e.Message;
        //        Exito = false;
        //    }

        //}
        public void MtdSeleccionarODCBind_Fechas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_ODCBind_Select";
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

        public void MtdInsertarODCBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindODC_Insert";
                _dato.CadenaTexto = vOC;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "OC");
                _dato.Decimal = vCantidad;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Cantidad");
                _dato.CadenaTexto = vCategoria;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Categoria");
                _dato.CadenaTexto = vCodigo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Codigo");
                _dato.CadenaTexto = vComentarios;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Comentarios");
                _dato.CadenaTexto = vCreacion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Creacion");
                _dato.CadenaTexto = vDescripcion;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Descripcion");
                _dato.CadenaTexto = vNoProveedor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "NoProveedor");
                _dato.CadenaTexto = vProveedor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Proveedor");
                _dato.Decimal = vCredito;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Credito");
                _dato.CadenaTexto = vDireccionProveedor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "DireccionProveedor");
                _dato.Decimal = vPendiente;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Pendiente");
                _dato.Decimal = vPrecio;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Precio");
                _dato.CadenaTexto = vSucursal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Sucursal");
                _dato.Decimal = vTotal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Total");
                _dato.CadenaTexto = vVencimiento;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Vencimiento");
                _dato.CadenaTexto = vVendedor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Vendedor");
                _dato.CadenaTexto = vEstatus;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Estatus");
                _dato.Decimal = vPeso;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Peso");
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
        public void MtdEliminarODCBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindODC_Delete";
                _dato.CadenaTexto = vOC;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "OC");
                _dato.Decimal = vCantidad;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Cantidad");
                _dato.CadenaTexto = vCodigo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Codigo");
                _dato.Decimal = vTotal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Total");
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
