using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace SAP_TTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateSampleJson();
        }

        private void CreateSampleJson()
        {
            var sample = new { Message = "Hello, JSON" };
            string json = JsonSerializer.Serialize(sample);
            File.WriteAllText("sample.json", json);
        }

        private void BtnFormatoJSON_Click(object sender, EventArgs e)
        {
            var persona = new PersonaPrueba
            {
                Nombre = "Francisco",
                Apellido = "Garcia",
                DatosFiscales = new DatosFiscales
                {
                    RFC = "GACF800101X",
                    Homoclave = "001"
                },
                Domicilio = new Domicilio
                {
                    Calle = "Avenida de las delicias",
                    Colonia = "Jicalan",
                    Numero = 100
                    
                }
               

            };
            string json = JsonSerializer.Serialize(persona, new JsonSerializerOptions { WriteIndented = true });


            richTextBox1.Text = json;
        }
    }
    public class PersonaPrueba
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DatosFiscales DatosFiscales { get; set; }
        public Domicilio Domicilio { get; set; }
    }
    public class DatosFiscales
    {
        public string RFC { get; set; }
        public string Homoclave { get; set; }
    }
    public class Domicilio
    {
        public string Calle {  get; set; }
        public string Colonia {  get; set; }
        public int Numero {  get; set; }
    }
}
