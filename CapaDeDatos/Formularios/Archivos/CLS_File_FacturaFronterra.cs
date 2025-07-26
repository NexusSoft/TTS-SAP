using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace CapaDeDatos
{
    public class CLS_File_FacturaFronterra : ConexionBase
    {
        public string Id_Embarque { get; set; }
        public string Id_Folio { get; set; }
        public byte[] ArchivoPDF { get; set; }
        public byte[] ArchivoXML { get; set; }
        public string Usuario { get; set; }

        public void MtdSeleccionarFacturaFronterraPDFXML()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_File_FacturaFronterra_PDFXML_Select";
                _dato.CadenaTexto = Id_Embarque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Embarque");
                _dato.CadenaTexto = Id_Folio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Folio");
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
        public void MtdSeleccionarFacturaFronterraPDFXMLView()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_File_FacturaFronterra_PDFXML_Select";
                _dato.CadenaTexto = Id_Embarque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Embarque");
                _dato.CadenaTexto = Id_Folio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Folio");
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
        public void MtdInsertarFacturaFronterraPDFXML()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_File_FacturaFronterra_PDFXML_Insert";
                _dato.CadenaTexto = Id_Embarque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Embarque");
                _dato.CadenaTexto = Id_Folio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Folio");
                _dato.Archivo = ArchivoPDF;
                _conexion.agregarParametro(EnumTipoDato.Archivo, _dato, "FacturaPDF");
                _dato.Archivo = ArchivoXML;
                _conexion.agregarParametro(EnumTipoDato.Archivo, _dato, "FacturaXML");
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
        public void MtdDeleteFacturaFronterraPDFXML()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_File_FacturaFronterra_PDFXML_Delete";
                _dato.CadenaTexto = Id_Embarque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Embarque");
                _dato.CadenaTexto = Id_Folio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Folio");
                _dato.Archivo = ArchivoPDF;
                _conexion.agregarParametro(EnumTipoDato.Archivo, _dato, "FacturaPDF");
                _dato.Archivo = ArchivoXML;
                _conexion.agregarParametro(EnumTipoDato.Archivo, _dato, "FacturaXML");
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
