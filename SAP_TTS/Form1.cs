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
    }
}
