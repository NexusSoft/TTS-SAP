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
    public class CLS_Gastos_Bind : ConexionBase
    {
        public string vCategoria { get; set; }
        public string vConcepto { get; set; }
        public string vFolio { get; set; }
        public string vComentarios { get; set; }
        public int vDiasDeCredito { get; set; }
        public string vDocumento { get; set; }
        public string vElaboradoPor { get; set; }
        public string vEstatus { get; set; }
        public string vFecha { get; set; }
        public string vFolioFiscal { get; set; }
        public string vBanco { get; set; }
        public string vCuenta_CLABE { get; set; }
        public decimal vIVA { get; set; }
        public decimal vIVAMXN { get; set; }
        public string vMoneda { get; set; }
        public string vNumero { get; set; }
        public decimal vPendiente { get; set; }
        public decimal vPendienteMXN { get; set; }
        public string vProveedor { get; set; }
        public decimal vSubtotal { get; set; }
        public decimal vSubtotalMXN { get; set; }
        public string vSucursal { get; set; }
        public decimal vTipoCambio { get; set; }
        public decimal vTotal { get; set; }
        public decimal vTotalMXN { get; set; }
        public string vVencimiento { get; set; }
        public string vCC { get; set; }
        public decimal vCantidad { get; set; }
        public string Usuario { get; set; }

        public string Fecha_Inicio { get; set; }
        public string Fecha_Fin { get; set; }




        public void MtdSeleccionarGastosBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindGastos_Select";
                _dato.CadenaTexto = vNumero;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Numero");
                _dato.CadenaTexto = vConcepto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Concepto");
                _dato.CadenaTexto = vCategoria;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Categoria");
                _dato.CadenaTexto = vFolioFiscal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FolioFiscal");
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

        public void MtdSeleccionarGastosBind_Fechas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindGastos_Select";
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

        public void MtdInsertarGastosBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindGastos_Insert";
                _dato.CadenaTexto = vCategoria;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Categoria");
                _dato.CadenaTexto = vConcepto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Concepto");
                _dato.CadenaTexto = vFolio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Folio");
                _dato.CadenaTexto = vComentarios;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Comentarios");
                _dato.Entero = vDiasDeCredito;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "DiasDeCredito");
                _dato.CadenaTexto = vDocumento;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Documento");
                _dato.CadenaTexto = vElaboradoPor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "ElaboradoPor");
                _dato.CadenaTexto = vEstatus;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Estatus");
                _dato.CadenaTexto = vFecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = vFolioFiscal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FolioFiscal");
                _dato.CadenaTexto = vBanco;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Banco");
                _dato.CadenaTexto = vCuenta_CLABE;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Cuenta_CLABE");
                _dato.Decimal = vIVA;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "IVA");
                _dato.Decimal = vIVAMXN;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "IVAMXN");
                _dato.CadenaTexto = vMoneda;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Moneda");
                _dato.CadenaTexto = vNumero;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Numero");
                _dato.Decimal = vPendiente;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Pendiente");
                _dato.Decimal = vPendienteMXN;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "PendienteMXN");
                _dato.CadenaTexto = vProveedor;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Proveedor");
                _dato.Decimal = vSubtotal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Subtotal");
                _dato.Decimal = vSubtotalMXN;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "SubtotalMXN");
                _dato.CadenaTexto = vSucursal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Sucursal");
                _dato.Decimal = vTipoCambio;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "TipoCambio");
                _dato.Decimal = vTotal;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Total");
                _dato.Decimal = vTotalMXN;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "TotalMXN");
                _dato.CadenaTexto = vVencimiento;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Vencimiento");
                _dato.CadenaTexto = vCC;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "CC");
                _dato.Decimal = vCantidad;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Cantidad");
                _dato.CadenaTexto = Usuario;
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Usuario");
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
        
        public void MtdEliminarGastosBind()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindGastos_Delete";
                _dato.CadenaTexto = vNumero;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Numero");
                _dato.CadenaTexto = vConcepto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Concepto");
                _dato.CadenaTexto = vCategoria;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Categoria");
                _dato.CadenaTexto = vFolioFiscal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FolioFiscal");
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
