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
    public class CLS_Pedimento_Bind : ConexionBase
    {
        public string vNoPedimento { get; set; }
        public decimal vTipoCambio { get; set; }
        public decimal vPesoBruto { get; set; }
        public string vNumero { get; set; }
        public string vTipo { get; set; }
        public string vFecha { get; set; }
        public string vUUID { get; set; }
        public string vINCONTERM { get; set; }
        public string vMonedaFactura { get; set; }
        public decimal vValorMontoFactura { get; set; }
        public decimal vFactorMontoFactura { get; set; }
        public decimal vMontoDolares { get; set; }
        public string vIDFiscal { get; set; }
        public string vComprador { get; set; }
        public string vIDComplemento { get; set; }
        public string vComplemento { get; set; }
        public decimal vIVAPedimento { get; set; }
        public decimal vSubTotalPedimento { get; set; }
        public string vComentarios { get; set; }
        public string vFraccion { get; set; }
        public string vProducto { get; set; }
        public decimal vCantidad { get; set; }
        public decimal vPrecioUnitario { get; set; }
        public decimal vValorComercial { get; set; }
        public decimal vValorDolares { get; set; }


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
                _conexion.NombreProcedimiento = "POD_BindPedimento_Select";
                _dato.CadenaTexto = vUUID;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "UUID");
                _dato.CadenaTexto = vNoPedimento;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "NoPedimento");
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
        public void MtdSeleccionarCartaPorteBind_Fechas()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_BindPedimento_Select";
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
                _conexion.NombreProcedimiento = "POD_BindPedimento_Insert";
                _dato.CadenaTexto = vNoPedimento; 
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "NoPedimento");
                _dato.Decimal = vTipoCambio; 
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "TipoCambio");
                _dato.Decimal = vPesoBruto; 
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "PesoBruto");
                _dato.CadenaTexto = vNumero; 
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Numero");
                _dato.CadenaTexto = vTipo; 
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Tipo");
                _dato.CadenaTexto = vFecha; 
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
                _dato.CadenaTexto = vUUID; 
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "UUID");
                _dato.CadenaTexto = vINCONTERM; 
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "INCONTERM");
                _dato.CadenaTexto = vMonedaFactura; 
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "MonedaFactura");
                _dato.Decimal = vValorMontoFactura; 
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "ValorMontoFactura");
                _dato.Decimal = vFactorMontoFactura; 
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "FactorMontoFactura");
                _dato.Decimal = vMontoDolares; 
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "MontoDolares");
                _dato.CadenaTexto = vIDFiscal; 
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "IDFiscal");
                _dato.CadenaTexto = vComprador; 
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Comprador");
                _dato.CadenaTexto = vIDComplemento; 
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "IDComplemento");
                _dato.CadenaTexto = vComplemento; 
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Complemento");
                _dato.Decimal = vIVAPedimento; 
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "IVAPedimento");
                _dato.Decimal = vSubTotalPedimento; 
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "SubTotalPedimento");
                _dato.CadenaTexto = vComentarios; 
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Comentarios");
                _dato.CadenaTexto = vFraccion; 
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fraccion");
                _dato.CadenaTexto = vProducto; 
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Producto");
                _dato.Decimal = vCantidad; 
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "Cantidad");
                _dato.Decimal = vPrecioUnitario; 
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "PrecioUnitario");
                _dato.Decimal = vValorComercial; 
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "ValorComercial");
                _dato.Decimal = vValorDolares; 
                _conexion.agregarParametro(EnumTipoDato.Tipodecimal, _dato, "ValorDolares");

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
                _conexion.NombreProcedimiento = "POD_BindPedimento_Delete";
                _dato.CadenaTexto = vUUID;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "UUID");
                _dato.CadenaTexto = vNoPedimento;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "NoPedimento");
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
