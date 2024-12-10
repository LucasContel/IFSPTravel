using IFSPStore.app.Base;
using IFSPStore.app.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using Microsoft.Web.WebView2.WinForms;
using ReaLTaiizor.Controls;

namespace IFSPStore.app
{
    public partial class CadastroViagem : CadastroBase
    {

        private readonly IBaseService<Cidade>? _cidadeService;
        private readonly IBaseService<Onibus>? _onibusService;
        private readonly IBaseService<Viagem>? _viagemService;

        private List<ViagemModel>? viagens;

        public CadastroViagem(IBaseService<Cidade> cidadeService, IBaseService<Onibus> onibusService, IBaseService<Viagem> viagemService)
        {
            _cidadeService = cidadeService;
            _onibusService = onibusService;
            _viagemService = viagemService;


            InitializeComponent();

            CarregarData();

            CarregarCombo();
        }

        private async void CarregaSite()
        {
            if (cboOrigemRota.SelectedValue != null && cboDestinoRota.SelectedValue != null)
            {
                if (int.TryParse(cboOrigemRota.SelectedValue.ToString(), out var idOrigem))
                {
                    var origem = _cidadeService.GetById<Cidade>(idOrigem);

                    if (int.TryParse(cboDestinoRota.SelectedValue.ToString(), out var idDestino))
                    {
                        var destino = _cidadeService.GetById<Cidade>(idDestino);

                        await webRota.EnsureCoreWebView2Async(null);
                        string origemRota = $"{origem.Nome}, {origem.Estado}";
                        string destinoRota = $"{destino.Nome}, {destino.Estado}";
                        string url = $"https://www.google.com/maps/dir/?api=1&origin={origemRota}&destination={destinoRota}&travelmode=transit";
                        webRota.Source = new Uri(url);
                    }
                }




            }
            else
            {
                MessageBox.Show("Por favor, insira Cidades antes de Viagens!", "IFSP Travel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregaHora()
        {
            if (txtHoraSaida.Text.Contains(' ')) 
            {
                txtHoraSaida.Text = $"{DateTime.Now.Hour:D2}:{DateTime.Now.Minute:D2}";
            }
            if (txtHoraChegada.Text.Contains(' '))
            {
                txtHoraChegada.Text = $"{DateTime.Now.Hour:D2}:{DateTime.Now.Minute:D2}";
            }
        }

        private void CarregarData()
        {

            dataChegada.Value = DateTime.Now.Date;
            dataSaida.Value = DateTime.Now.Date;

        }


        private void CarregarCombo()
        {
            cboOnibus.ValueMember = "Id";
            cboOnibus.DisplayMember = "ModeloPlaca";
            cboOnibus.DataSource = _onibusService?.Get<OnibusModel>().ToList();

            cboOrigem.ValueMember = "Id";
            cboOrigem.DisplayMember = "NomeEstado";
            cboOrigem.DataSource = _cidadeService?.Get<CidadeModel>().ToList();

            TrocaDestino();

            cboOrigemRota.ValueMember = "Id";
            cboOrigemRota.DisplayMember = "NomeEstado";
            cboOrigemRota.DataSource = _cidadeService?.Get<CidadeModel>().ToList();

            TrocaDestinoRota();
        }


        private void TrocaDestino()
        {

            if (cboOrigem.SelectedValue != null)
            {

                if (int.TryParse(cboOrigem.SelectedValue.ToString(), out var idOrigem))
                {
                    string cboValue = "";
                    if(cboDestino.SelectedValue != null)
                    {
                        cboValue = cboDestino.SelectedValue.ToString();
                    }
                    cboDestino.DataSource = _cidadeService?.Get<CidadeModel>().ToList()
                    .Where(c => c.Id != idOrigem)
                    .ToList();

                    cboDestino.DisplayMember = "NomeEstado";
                    cboDestino.ValueMember = "Id";

                    if(cboValue != "" && cboValue != cboOrigem.SelectedValue.ToString())
                    {
                        cboDestino.SelectedValue = int.Parse(cboValue);
                    }
                }

            }
        }

        private void TrocaDestinoRota()
        {

            if (cboOrigemRota.SelectedValue != null)
            {

                if (int.TryParse(cboOrigemRota.SelectedValue.ToString(), out var idOrigem))
                {
                    string cboValue = "";
                    if (cboDestinoRota.SelectedValue != null)
                    {
                        cboValue = cboDestinoRota.SelectedValue.ToString();
                    }

                    cboDestinoRota.DataSource = _cidadeService?.Get<CidadeModel>().ToList()
                    .Where(c => c.Id != idOrigem)
                    .ToList();

                    cboDestinoRota.DisplayMember = "NomeEstado";
                    cboDestinoRota.ValueMember = "Id";

                    if (cboValue != "" && cboValue != cboOrigemRota.SelectedValue.ToString())
                    {
                        cboDestinoRota.SelectedValue = int.Parse(cboValue);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira Cidades antes de Viagens!", "IFSP Travel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencheObjeto(Viagem viagem)
        {

            if (TimeSpan.TryParse(txtHoraSaida.Text, out TimeSpan horaSaida))
            {
                viagem.DataSaida = dataSaida.Value.Date.Add(horaSaida);
                if (TimeSpan.TryParse(txtHoraChegada.Text, out TimeSpan horaChegada))
                {
                    viagem.DataChegada = dataChegada.Value.Date.Add(horaChegada);
                }
            }
            else
            {

                MessageBox.Show("Por favor, insira uma hora de saída válida!", "IFSP Travel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (int.TryParse(cboOnibus.SelectedValue.ToString(), out var idOnibus))
            {
                var onibus = _onibusService.GetById<Onibus>(idOnibus);
                viagem.Onibus = onibus;
            }

            if (int.TryParse(cboOrigem.SelectedValue.ToString(), out var idOrigem))
            {
                var origem = _cidadeService.GetById<Cidade>(idOrigem);
                viagem.Origem = origem;
            }

            if (int.TryParse(cboDestino.SelectedValue.ToString(), out var idDestino))
            {
                var destino = _cidadeService.GetById<Cidade>(idDestino);
                viagem.Destino = destino;
            }
        }


        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId, out var id))
                    {
                        var viagem = _viagemService.GetById<Viagem>(id);
                        PreencheObjeto(viagem);
                        _viagemService.Update<Viagem, Viagem, ViagemValidator>(viagem);
                    }
                }
                else
                {
                    var viagem = new Viagem();
                    PreencheObjeto(viagem);
                    _viagemService.Add<Viagem, Viagem, ViagemValidator>(viagem);
                }

                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Travel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void Deletar(int id)
        {
            try
            {
                _viagemService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Travel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            viagens = _viagemService.Get<ViagemModel>(new[] { "Origem" }).ToList();
            dataGridViewConsulta.DataSource = viagens;
            dataGridViewConsulta.Columns["Id"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdOrigem"]!.Visible = false;
            dataGridViewConsulta.Columns["IdDestino"]!.Visible = false;
            dataGridViewConsulta.Columns["IdOnibus"]!.Visible = false;
            dataGridViewConsulta.Columns["Informacoes"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            dataChegada.Value = DateTime.Parse(linha?.Cells["DataChegada"].Value.ToString());
            dataSaida.Value = DateTime.Parse(linha?.Cells["DataSaida"].Value.ToString());
            txtHoraChegada.Text = DateTime.Parse(linha?.Cells["DataChegada"].Value.ToString()).TimeOfDay.ToString();
            txtHoraSaida.Text = DateTime.Parse(linha?.Cells["DataSaida"].Value.ToString()).TimeOfDay.ToString();
            cboOrigem.SelectedValue = linha?.Cells["IdOrigem"].Value;
            cboDestino.SelectedValue = linha?.Cells["IdDestino"].Value;
            cboOnibus.SelectedValue = linha?.Cells["IdOnibus"].Value;
        }

        private void cboOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrocaDestino();
        }

        private void tabPageRota_Enter(object sender, EventArgs e)
        {
            cboOrigemRota.SelectedValue = cboOrigem.SelectedValue;
            TrocaDestinoRota();
            cboDestinoRota.SelectedValue = cboDestino.SelectedValue;
            CarregaSite();
        }

        private void btnRota_Click(object sender, EventArgs e)
        {
            tabControlCadastro.SelectedIndex = 2;
        }

        private void tabPageCadastro_Enter(object sender, EventArgs e)
        {
            CarregaHora();
            cboOrigem.SelectedIndex = cboOrigemRota.SelectedIndex;
            TrocaDestino();
            cboDestino.SelectedIndex = cboDestinoRota.SelectedIndex;
        }

        private void cboOrigemRota_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TrocaDestinoRota();
            CarregaSite();
        }

        private void cboDestinoRota_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CarregaSite();
        }

        private void btnRetornar_Click_1(object sender, EventArgs e)
        {
            tabControlCadastro.SelectedIndex = 0;
        }
    }
}
