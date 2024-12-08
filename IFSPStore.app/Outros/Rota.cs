using IFSPStore.app.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using ReaLTaiizor.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Web.WebView2.WinForms;
using IFSPStore.app.Infra;
using IFSPStore.app.Cadastros;

namespace IFSPStore.app.Outros
{
    public partial class Rota : MaterialForm
    {
        private readonly IBaseService<Onibus>? _onibusService;
        private readonly IBaseService<Cidade>? _cidadeService;
        private readonly IBaseService<Viagem>? _viagemService;

        public Rota(IBaseService<Cidade> cidadeService, IBaseService<Viagem> viagemService, IBaseService<Onibus> onibusService)
        {
            _viagemService = viagemService;
            _cidadeService = cidadeService;
            _onibusService = onibusService;

            InitializeComponent();

            CarregaCombo();

            CriaRota();
        }

        private void CarregaCombo()
        {
            _onibusService.Get<Onibus>().ToList();
            _cidadeService.Get<Cidade>().ToList();

            if (TimeSpan.TryParse(txtHoraSaida.Text, out TimeSpan horaSaida))
            {
                if (TimeSpan.TryParse(txtHoraChegada.Text, out TimeSpan horaChegada))
                {
                    var viagemService = _viagemService.Get<ViagemModel>()

                    .Where(v => v.DataChegada <= (dataChegada.Value.Date.Add(horaChegada)) && v.DataSaida >= (dataSaida.Value.Date.Add(horaSaida)))
                    .ToList();
                    cboViagem.DataSource = viagemService;
                }
                else
                {
                    var viagemService = _viagemService.Get<ViagemModel>().ToList();
                    cboViagem.DataSource = viagemService;
                }
            }
            else
            {
                var viagemService = _viagemService.Get<ViagemModel>().ToList();
                cboViagem.DataSource = viagemService;
            }

            cboViagem.DisplayMember = "Informacoes";
            cboViagem.ValueMember = "Id";
        }

        private bool ChecaDataHara()
        {
            if (TimeSpan.TryParse(txtHoraSaida.Text, out TimeSpan horaSaida))
            {
                if (TimeSpan.TryParse(txtHoraChegada.Text, out TimeSpan horaChegada))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private async void CriaRota()
        {


            if (cboViagem.SelectedValue != null)
            {
                if (int.TryParse(cboViagem.SelectedValue.ToString(), out var idViagem))
                {

                    var viagem = _viagemService.GetById<Viagem>(idViagem);

                    await webRota.EnsureCoreWebView2Async(null);

                    string origem = $"{viagem.Origem.Nome}, {viagem.Origem.Estado}";
                    string destino = $"{viagem.Destino.Nome}, {viagem.Destino.Estado}";
                    string url = $"https://www.google.com/maps/dir/?api=1&origin={origem}&destination={destino}&travelmode=transit";
                    webRota.Source = new Uri(url);
                }

            }
            else
            {
                MessageBox.Show("Por favor, insira Viagens para poder verificar Rotas!", "IFSPTravel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViagem_Click(object sender, EventArgs e)
        {
            CadastroReserva.viagemRotaId = int.Parse(cboViagem.SelectedValue.ToString());
            ExibeFormulario<CadastroReserva>();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            CarregaCombo();
        }

        private void cboViagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            CriaRota();
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {

            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.Show();
            }
        }
    }
}
