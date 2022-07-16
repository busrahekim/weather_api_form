using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace weatherapiform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String api = "a314fd0382f962e5310e07512358cddf";
            String c = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument w = XDocument.Load(c);
            var temp = w.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var weather = w.Descendants("weather").ElementAt(0).Attribute("value").Value;
            String celsius = "°C";
            label2.Text = temp + celsius;
            label5.Text = weather.ToUpper();
        }

    }
}
