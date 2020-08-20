using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using WindowsFrmConsumirAPI.Model;

namespace ServicoWebAPI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private async void RetornarDados()
        {
            string URI = txtUriWebAPI.Text;

            using (var cliente = new HttpClient())
            {
                using (var response = await cliente.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ClienteJsonString = await
                        response.Content.ReadAsStringAsync();
                        dgvDados.DataSource = JsonConvert.DeserializeObject<Cliente[]>(ClienteJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter os dados: " + response.StatusCode);
                    }
                }
            }
        }

        private void BtnRetornarDados_Click(object sender, EventArgs e)
        {
            RetornarDados();
        }
    }
}
