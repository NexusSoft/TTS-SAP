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
    public class CLS_Facturas_Bind : ConexionBase
    {
        public string vGrupo { get; set; }
        public string vSerie { get; set; }
        public string vNo { get; set; }
        public string vFolio { get; set; }
        public string vEmision { get; set; }
        public string vVencimiento { get; set; }
        public string vCliente { get; set; }
        public string vNombrecomercial { get; set; }
        public string vRFCCliente { get; set; }
        public string vOrdenDeCompra { get; set; }
        public decimal vCosto { get; set; }
        public decimal vUtlidad { get; set; }
        public decimal vSubtotal { get; set; }
        public decimal vSubtotalServicios { get; set; }
        public decimal vSubtotalProductos { get; set; }
        public decimal vDescuento { get; set; }
        public decimal vIVA { get; set; }
        public decimal vIEPS { get; set; }
        public decimal vTotal { get; set; }
        public decimal vPagos { get; set; }
        public decimal vNC { get; set; }
        public decimal vPendiente { get; set; }
        public string vCodigoProdServ { get; set; }
        public string vVendedor { get; set; }
        public string vPedido { get; set; }
        public string vSucursal { get; set; }
        public string vAlmacen { get; set; }
        public string vProductoConcepto { get; set; }
        public decimal vMonedaOriginal { get; set; }
        public string vCategoria { get; set; }
        public string vCategoria1 { get; set; }
        public string vCategoria2 { get; set; }
        public string vCategoria3 { get; set; }
        public string vMoneda { get; set; }
        public string vLotePedimento { get; set; }
        public decimal vCantidad { get; set; }
        public string vEstado { get; set; }
        public string vFuente { get; set; }
        public string vTipo { get; set; }
        public string vEstatus { get; set; }
        public string vFolioFiscal { get; set; }
        public decimal vTC { get; set; }
        public string vComentarios { get; set; }
        public decimal vPeso { get; set; }
        public string vTelefono { get; set; }
        public string Fecha_Inicio { get; set; }
        public string Fecha_Fin { get; set; }
        public string Usuario { get; set; }



        public void MtdSeleccionarFacturasBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindFacturas_Select";
                _dato.CadenaTexto = vNo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "No");
                _dato.Decimal = vTotal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Total");
                _dato.Decimal = vCantidad;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Cantidad");
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
       
        public void MtdSeleccionarFacturasBind_Fechas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindFacturasFechas_Select";
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

        public void MtdInsertarFacturasBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindFacturas_Insert";
                _dato.CadenaTexto = vGrupo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Grupo");
                _dato.CadenaTexto = vSerie;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Serie");
                _dato.CadenaTexto = vNo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "No");
                _dato.CadenaTexto = vFolio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Folio");
                _dato.CadenaTexto = vEmision;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Emision");
                _dato.CadenaTexto = vVencimiento;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Vencimiento");
                _dato.CadenaTexto = vCliente;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Cliente");
                _dato.CadenaTexto = vNombrecomercial;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombrecomercial");
                _dato.CadenaTexto = vRFCCliente;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "RFCCliente");
                _dato.CadenaTexto = vOrdenDeCompra;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "OrdenDeCompra");
                _dato.Decimal = vCosto;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Costo");
                _dato.Decimal = vUtlidad;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Utlidad");
                _dato.Decimal = vSubtotal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Subtotal");
                _dato.Decimal = vSubtotalServicios;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "SubtotalServicios");
                _dato.Decimal = vSubtotalProductos;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "SubtotalProductos");
                _dato.Decimal = vDescuento;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Descuento");
                _dato.Decimal = vIVA;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "IVA");
                _dato.Decimal = vIEPS;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "IEPS");
                _dato.Decimal = vTotal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Total");
                _dato.Decimal = vPagos;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Pagos");
                _dato.Decimal = vNC;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "NC");
                _dato.Decimal = vPendiente;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Pendiente");
                _dato.CadenaTexto = vCodigoProdServ;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "CodigoProdServ");
                _dato.CadenaTexto = vVendedor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Vendedor");
                _dato.CadenaTexto = vPedido;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Pedido");
                _dato.CadenaTexto = vSucursal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Sucursal");
                _dato.CadenaTexto = vAlmacen;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Almacen");
                _dato.CadenaTexto = vProductoConcepto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "ProductoConcepto");
                _dato.Decimal = vMonedaOriginal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "MonedaOriginal");
                _dato.CadenaTexto = vCategoria;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Categoria");
                _dato.CadenaTexto = vCategoria1;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Categoria1");
                _dato.CadenaTexto = vCategoria2;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Categoria2");
                _dato.CadenaTexto = vCategoria3;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Categoria3");
                _dato.CadenaTexto = vMoneda;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Moneda");
                _dato.CadenaTexto = vLotePedimento;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "LotePedimento");
                _dato.Decimal = vCantidad;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Cantidad");
                _dato.CadenaTexto = vEstado;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Estado");
                _dato.CadenaTexto = vFuente;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fuente");
                _dato.CadenaTexto = vTipo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Tipo");
                _dato.CadenaTexto = vEstatus;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Estatus");
                _dato.CadenaTexto = vFolioFiscal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FolioFiscal");
                _dato.Decimal = vTC;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "TC");
                _dato.CadenaTexto = vComentarios;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Comentarios");
                _dato.Decimal = vPeso;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Peso");
                _dato.CadenaTexto = vTelefono;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Telefono");
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
        
        public void MtdEliminarFacturaBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindFacturas_Delete";
                _dato.CadenaTexto = vNo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "No");
                _dato.Decimal = vTotal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Total");
                _dato.Decimal = vCantidad;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Cantidad");
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
