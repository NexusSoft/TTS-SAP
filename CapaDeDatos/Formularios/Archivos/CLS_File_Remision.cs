using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace CapaDeDatos
{
    public class CLS_File_Remision : ConexionBase
    {
        public string Id_Embarque { get; set; }
        public string Id_Folio { get; set; }
        public byte[] ArchivoPDF { get; set; }
        public string Usuario { get; set; }

        public void MtdSeleccionarRemisionPDFXML()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_File_Remision_PDFXML_Select";
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
        public void MtdSeleccionarRemisionPDFXMLView()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_File_Remision_PDFXML_Select";
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
        public void MtdInsertarRemisionPDFXML()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_File_Remision_PDFXML_Insert";
                _dato.CadenaTexto = Id_Embarque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Embarque");
                _dato.CadenaTexto = Id_Folio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Folio");
                _dato.Archivo = ArchivoPDF;
                _conexion.agregarParametro(EnumTipoDato.Archivo, _dato, "ArchivoPDF");
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
        public void MtdDeleteRemisionPDFXML()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "POD_File_Remision_PDFXML_Delete";
                _dato.CadenaTexto = Id_Embarque;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Embarque");
                _dato.CadenaTexto = Id_Folio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Id_Folio");
                _dato.Archivo = ArchivoPDF;
                _conexion.agregarParametro(EnumTipoDato.Archivo, _dato, "ArchivoPDF");
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
