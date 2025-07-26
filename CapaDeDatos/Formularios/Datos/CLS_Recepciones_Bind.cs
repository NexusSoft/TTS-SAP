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
    public class CLS_Recepciones_Bind : ConexionBase
    {
        public string vNo { get; set; }
        public string vFolio { get; set; }
        public string vNoExt { get; set; }
        public string vFechadeDocumento { get; set; }
        public string vFechaOrdenDeCompra { get; set; }
        public string vOrdenDeCompra { get; set; }
        public string vEmisión { get; set; }
        public string vRecepción { get; set; }
        public string vVencimiento { get; set; }
        public int vVencimientoaldíadehoy { get; set; }
        public string vProveedor { get; set; }
        public decimal vCosto { get; set; }
        public decimal vGastosAdicionales { get; set; }
        public decimal vSubtotal { get; set; }
        public decimal vIVA { get; set; }
        public decimal vTotal { get; set; }
        public decimal vPagos { get; set; }
        public decimal vPendiente { get; set; }
        public string vGrupo { get; set; }
        public string vAlmacen { get; set; }
        public string vProducto { get; set; }
        public string vCategoria { get; set; }
        public decimal vIEPS { get; set; }
        public string vMoneda { get; set; }
        public decimal vMonedaOriginal { get; set; }
        public string vLotePedimento { get; set; }
        public decimal vCantidad { get; set; }
        public decimal vTC { get; set; }
        public string vTipo { get; set; }
        public string vEstatus { get; set; }
        public string vFolioFiscal { get; set; }
        public decimal vPeso { get; set; }
        public string vComentarios { get; set; }
        
        public string Fecha_Inicio { get; set; }
        public string Fecha_Fin { get; set; }


        public void MtdSeleccionarRecepcionesBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindRecepciones_Select";
                _dato.CadenaTexto = vNo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "No");
                _dato.CadenaTexto = vOrdenDeCompra;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "OrdenDeCompra");
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
        public void MtdSeleccionarRecpecionesBind_Fechas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_FacturasBind_Select";
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
        public void MtdInsertaRecepcionesBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindRecepciones_Insert";
                _dato.CadenaTexto = vNo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "No");
                _dato.CadenaTexto = vFolio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Folio");
                _dato.CadenaTexto = vNoExt;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "NoExt");
                _dato.CadenaTexto = vFechadeDocumento;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FechadeDocumento");
                _dato.CadenaTexto = vFechaOrdenDeCompra;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FechaOrdenDeCompra");
                _dato.CadenaTexto = vOrdenDeCompra;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "OrdenDeCompra");
                _dato.CadenaTexto = vEmisión;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Emisión");
                _dato.CadenaTexto = vRecepción;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Recepción");
                _dato.CadenaTexto = vVencimiento;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Vencimiento");
                _dato.Entero = vVencimientoaldíadehoy;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Vencimientoaldíadehoy");
                _dato.CadenaTexto = vProveedor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Proveedor");
                _dato.Decimal = vCosto;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Costo");
                _dato.Decimal = vGastosAdicionales;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "GastosAdicionales");
                _dato.Decimal = vSubtotal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Subtotal");
                _dato.Decimal = vIVA;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "IVA");
                _dato.Decimal = vTotal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Total");
                _dato.Decimal = vPagos;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Pagos");
                _dato.Decimal = vPendiente;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Pendiente");
                _dato.CadenaTexto = vGrupo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Grupo");
                _dato.CadenaTexto = vAlmacen;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Almacen");
                _dato.CadenaTexto = vProducto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Producto");
                _dato.CadenaTexto = vCategoria;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Categoria");
                _dato.Decimal = vIEPS;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "IEPS");
                _dato.CadenaTexto = vMoneda;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Moneda");
                _dato.Decimal = vMonedaOriginal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "MonedaOriginal");
                _dato.CadenaTexto = vLotePedimento;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "LotePedimento");
                _dato.Decimal = vCantidad;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Cantidad");
                _dato.Decimal = vTC;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "TC");
                _dato.CadenaTexto = vTipo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Tipo");
                _dato.CadenaTexto = vEstatus;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Estatus");
                _dato.CadenaTexto = vFolioFiscal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FolioFiscal");
                _dato.Decimal = vPeso;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Peso");
                _dato.CadenaTexto = vComentarios;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Comentarios");
                
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
        public void MtdEliminarRecepcionesBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindRecepciones_Delete";
                _dato.CadenaTexto = vNo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "No");
                _dato.CadenaTexto = vOrdenDeCompra;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "OrdenDeCompra");
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
