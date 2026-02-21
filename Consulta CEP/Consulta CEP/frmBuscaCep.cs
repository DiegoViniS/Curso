using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Net.NetworkInformation;

namespace Consulta_CEP
{
    public partial class frmBuscaCep : Form
    {
        public frmBuscaCep()
        {
            InitializeComponent();
        }

        private void frmBuscaCep_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas numeros no campo CEP", "Entrada Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
        }

        private void frmBuscaCep_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCep;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cep = txtCep.Text.Trim();
            if (cep.Length > 8 || cep.Length < 8)
            {
                MessageBox.Show("CEP INVALIDO!! o Cep tem oito digitos.", "CEP Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCep.Text = string.Empty;
                return;
            }
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://viacep.com.br/ws/{cep}/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();
            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor indisponivel!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");
                        string[] substrings = response.Split('\n');
                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                if (substring.Contains("."))
                                {
                                    string[] valor = substring.Split(':');
                                    if (valor.Length > 2 && valor[0].Trim().Replace("\"", "") == "erro")
                                    {
                                        MessageBox.Show("CEP não encontrado!", "Não econtrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtCep.Text = string.Empty;
                                        txtCep.Focus();
                                        return;
                                    }
                                }
                            }
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblEndereco.Text = valor[1];
                            }
                            if (cont == 3)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                string comp = valor[1];
                                if (comp != "null")
                                {
                                    lblComplemento.Text = comp;
                                }
                                else
                                {
                                    lblComplemento.Text = "Sem Complemento";
                                }
                            }
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblBairro.Text = valor[1];
                            }
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblCidade.Text = valor[1];
                            }
                            if (cont == 7)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblUf.Text = valor[1];
                            }
                            cont++;
                        }
                    }
                }

            }
            txtCep.Text = string.Empty;
            txtCep.Focus();
        }

    }
}
