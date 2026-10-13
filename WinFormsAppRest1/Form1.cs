using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WinFormsAppRest1
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void cmdIncluir_Click(object sender, EventArgs e)
        {
            // URL da API com o ID do recurso a ser atualizado
            string url = "http://127.0.0.1:8400/rest/zWSProdutos/new";

            // Objeto com os novos dados
            var novoProduto = new
            {
                cod = txtCod.Text,
                desc = txtDesc.Text,
                tipo = cboTipo.Text.Substring(0, cboTipo.Text.IndexOf("-") - 1),
                um = cboUM.Text.Substring(0, cboUM.Text.IndexOf("-") - 1),
                locpad = cboLocpad.Text.Substring(0, cboLocpad.Text.IndexOf("-") - 1),
                grupo = cboGrupo.Text.Substring(0, cboGrupo.Text.IndexOf("-") - 1)
            };

            try
            {
                cmdIncluir.Enabled = false;

                // Envia a requisição PUT com o objeto serializado para JSON
                HttpResponseMessage response = await client.PostAsJsonAsync(url, novoProduto);

                // Garante que a operação foi bem-sucedida
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produto salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCod.Text = "";
                    txtDesc.Text = "";
                    txtCod.Focus();
                }
                else
                {
                    string conteudoErro = await response.Content.ReadAsStringAsync();
                    using JsonDocument doc = JsonDocument.Parse(conteudoErro);
                    JsonElement root = doc.RootElement;
                    string solution = root.GetProperty("solution").GetString();
                    MessageBox.Show($"Erro na atualização:\n\n{solution}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCod.Focus();
            }
            finally
            {
                cmdIncluir.Enabled = true;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            cmdIncluir.Enabled = false;

            // Tipo
            string url = "http://127.0.0.1:8400/rest/zWSChaves/get_id?id=tipo";
            string jsonString = await client.GetStringAsync(url);

            var tronco = JsonDocument.Parse(jsonString);
            var galhos = tronco.RootElement.GetProperty("objects");

            foreach (var galho in galhos.EnumerateArray())
            {
                string chv = galho.GetProperty("chave").ToString();
                string dsc = galho.GetProperty("desc").ToString();
                string chave = chv + " - " + dsc;
                cboTipo.Items.Add(chave);
            }
            cboTipo.SelectedItem = "PA - PRODUTO ACABADO";

            // Unidade de Medida
            url = "http://127.0.0.1:8400/rest/zWSChaves/get_id?id=um";
            jsonString = await client.GetStringAsync(url);

            tronco = JsonDocument.Parse(jsonString);
            galhos = tronco.RootElement.GetProperty("objects");

            foreach (var galho in galhos.EnumerateArray())
            {
                string chv = galho.GetProperty("chave").ToString();
                string dsc = galho.GetProperty("desc").ToString();
                string chave = chv + " - " + dsc;
                cboUM.Items.Add(chave);
            }
            cboUM.SelectedItem = "PC - PECA";

           // Armazens
            url = "http://127.0.0.1:8400/rest/zWSChaves/get_id?id=local";
            jsonString = await client.GetStringAsync(url);

            tronco = JsonDocument.Parse(jsonString);
            galhos = tronco.RootElement.GetProperty("objects");

            foreach (var galho in galhos.EnumerateArray())
            {
                string chv = galho.GetProperty("chave").ToString();
                string dsc = galho.GetProperty("desc").ToString();
                string chave = chv + " - " + dsc;
                cboLocpad.Items.Add(chave);
            }
            cboLocpad.SelectedItem = "01 - ARMAZEM PADRAO";

            // Grupos
            url = "http://127.0.0.1:8400/rest/zWSChaves/get_id?id=grupo";
            jsonString = await client.GetStringAsync(url);

            tronco = JsonDocument.Parse(jsonString);
            galhos = tronco.RootElement.GetProperty("objects");

            foreach (var galho in galhos.EnumerateArray())
            {
                string chv = galho.GetProperty("chave").ToString();
                string dsc = galho.GetProperty("desc").ToString();
                string chave = chv + " - " + dsc;
                cboGrupo.Items.Add(chave);
            }
            cboGrupo.SelectedItem = "ARM - ARMAZENAMENTO";

            txtCod.Focus();
            cmdIncluir.Enabled = true;
        }
    }
}
