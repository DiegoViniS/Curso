using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace AppTempo
{
    public partial class frmTempo : Form
    {
        private const string Apikey = "a76e98b418728200c0cfb6520e085262";
        private const string ApiBaseURL = "http://api.openweathermap.org/data/2.5/weather";
        public frmTempo()
        {
            InitializeComponent();
        }

        private void frmTempo_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCidade;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            string city = txtCidade.Text.Trim();
            if (!string.IsNullOrEmpty(city))
            {
                string apiUrl = $"{ApiBaseURL}?lang=pt-br?q={city}&apiid={Apikey}&units=metric";
                try
                {
                    string jsonResponse = await FecthDataAsync(apiUrl);
                    DisplayWeather(jsonResponse);
                }
                catch (Exception er)
                {
                    MessageBox.Show($"Erro:{er.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Por favor, insira o nome de uma cidade.", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
        }
        private async Task<string> FecthDataAsync(string apiurl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiurl);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new HttpRequestException($"Erro ao acessar a API: {response.ReasonPhrase}");
                }
            }
        }
        private void DisplayWeather(string jsonResponse)
        {
            JObject data = JObject.Parse(jsonResponse);
            string nomecidade = data["name"].ToString();
            string temperatura = data["main"]["temp"].ToString();
            string descricao = data["weather"][0]["description"].ToString();
            string umidade = data["main"]["humidity"].ToString();
            string pressao = data["main"]["pressure"].ToString();
            string pais = data["sys"]["country"].ToString();
            lblCidade.Text = nomecidade;
            lblPais.Text = pais;
            lblTemperatura.Text = $"{temperatura} ºC";
            lblDescricao.Text = descricao;
            lblUmidade.Text = umidade + "%";
            lblPressao.Text = pressao + "hPa";
        }

    }
}
