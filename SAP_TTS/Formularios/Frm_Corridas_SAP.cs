using CapaDeDatos;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SAP_TTS.Frm_Corridas_SAP;

namespace SAP_TTS
{
    public partial class Frm_Corridas_SAP : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Corridas_SAP()
        {
            InitializeComponent();
        }

        private void btn_BuscarLote_Click(object sender, EventArgs e)
        {
            CLS_Corridas_SAP sel = new CLS_Corridas_SAP();
            sel.IdLote = Convert.ToInt32(txtIdLote.Text);
            sel.MtdSeleccionarCorridaLote();
            if (sel.Exito)
            {
                if (sel.Datos.Rows.Count > 0)
                {
                    dtgLote.DataSource = sel.Datos;


                }
            }
        }
        private void btn_GeneraJSON_Click(object sender, EventArgs e)
        {
            CLS_Corridas_SAP sel = new CLS_Corridas_SAP();
            sel.IdLote = Convert.ToInt32(txtIdLote.Text);
            sel.MtdSeleccionarCorridaLote();
            if (sel.Exito)
            {

                if (sel.Datos.Rows.Count > 0)
                {
                    string vDocDate = string.Empty;
                    string vDocDueDate = string.Empty;
                    string vCardCode = string.Empty;
                    string vNumAtCard = string.Empty;
                    string vJournalMemo = string.Empty;
                    var documentLines = new List<DocumentLine>();
                    for (int i = 0; i < sel.Datos.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            vDocDate = sel.Datos.Rows[i]["DocDate"].ToString();
                            vDocDueDate = sel.Datos.Rows[i]["DocDueDate"].ToString();
                            vCardCode = sel.Datos.Rows[i]["CardCode"].ToString();
                            vNumAtCard = sel.Datos.Rows[i]["NumAtCard"].ToString();
                            vJournalMemo = sel.Datos.Rows[i]["JournalMemo"].ToString();
                        }
                        string itemCode = sel.Datos.Rows[i]["ItemCode"].ToString();
                        double quantity = Convert.ToDouble(sel.Datos.Rows[i]["Quantity"].ToString());
                        decimal price = Convert.ToDecimal(sel.Datos.Rows[i]["Price"].ToString());
                        string taxCode = sel.Datos.Rows[i]["TaxCode"].ToString();
                        string warehouse = sel.Datos.Rows[i]["WarehouseCode"].ToString();
                        string batch = sel.Datos.Rows[i]["BatchNumber"].ToString();
                        string productor = sel.Datos.Rows[i]["Productor"].ToString();
                        string huerta = sel.Datos.Rows[i]["Huerta"].ToString();
                        var line = new DocumentLine
                        {
                            ItemCode = itemCode,
                            Quantity = quantity,
                            Price = price,
                            TaxCode = taxCode,
                            WarehouseCode = warehouse,
                            BatchNumbers = new List<BatchNumbers>
                            {
                                new BatchNumbers
                                    {
                                        BatchNumber = batch,
                                        Quantity = quantity,
                                        ManufacturerSerialNumber = productor,
                                        InternalSerialNumber = huerta
                                     }
                            }
                        };

                        documentLines.Add(line);
                    }
                    DateTime vFecha = Convert.ToDateTime(vDocDate);
                    vDocDate= vFecha.Year+"-"+ DosCeros(vFecha.Month.ToString())+"-"+ DosCeros(vFecha.Day.ToString());
                    vFecha = Convert.ToDateTime(vDocDueDate);
                    vDocDueDate = vFecha.Year + "-" + DosCeros(vFecha.Month.ToString()) + "-" + DosCeros(vFecha.Day.ToString());
                    var documento = new Documento
                    {
                        DocDate = vDocDate,
                        DocDueDate = vDocDueDate,
                        CardCode = vCardCode,
                        NumAtCard = vNumAtCard,
                        JournalMemo = vJournalMemo,
                        DocumentLines = documentLines
                    };
                    string Nombre_Archivo = vNumAtCard + ".json";
                    string json = JsonConvert.SerializeObject(documento, Formatting.Indented);
                    File.WriteAllText(Nombre_Archivo, json);

                    XtraMessageBox.Show("JSON generado exitosamente en documento.json");
                }
            }
        }
        public string DosCeros(string sVal)
        {
            string str = "";
            if (sVal.Length == 1)
            {
                return (str = "0" + sVal);
            }
            return sVal;
        }
        public class BatchNumbers
        {
            public string BatchNumber { get; set; }
            public double Quantity { get; set; }
            public string ManufacturerSerialNumber { get; set; }
            public string InternalSerialNumber { get; set; }
        }

        public class DocumentLine
        {
            public string ItemCode { get; set; }
            public double Quantity { get; set; }
            public decimal Price { get; set; }
            public string TaxCode { get; set; }
            public string WarehouseCode { get; set; }
            public List<BatchNumbers> BatchNumbers { get; set; }
        }

        public class Documento
        {
            public string DocDate { get; set; }
            public string DocDueDate { get; set; }
            public string CardCode { get; set; }
            public string NumAtCard { get; set; }
            public string JournalMemo { get; set; }
            public List<DocumentLine> DocumentLines { get; set; }



        }
    }
}