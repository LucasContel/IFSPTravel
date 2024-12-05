using IFSPStore.app.Base;
using IFSPStore.app.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

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
            cidadeService = _cidadeService;
            onibusService = _onibusService;
            viagemService = _viagemService;

            InitializeComponent();

            CarregarCombo();
        }
        private void CarregarCombo()
        {
            cboOnibus.ValueMember = "Id";
            cboOnibus.DisplayMember = "Nome";
            cboOnibus.DataSource = _onibusService?.Get<OnibusModel>().ToList();

            cboDestino.ValueMember = "Id";
            cboDestino.DisplayMember = "NomeEstado";
            cboDestino.DataSource = _cidadeService?.Get<CidadeModel>().ToList();

            cboOrigem.ValueMember = "Id";
            cboOrigem.DisplayMember = "NomeEstado";
            cboOrigem.DataSource = _cidadeService?.Get<CidadeModel>().ToList();
        }

        private void PreencheObjeto(Viagem viagem)
        {
            string format = "dd/MM/yyyy";

            if (DateTime.TryParseExact(txtChegada.Text, format,
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out DateTime dataChegada))
            {
                viagem.DataChegada = dataChegada;
            }
            else
            {
                MessageBox.Show("Por favor, insira uma data de chegada válida!", "IFSPTravel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (DateTime.TryParseExact(txtSaida.Text, format,
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out DateTime dataSaida))
            {
                viagem.DataSaida = dataSaida;
            }
            else
            {
                MessageBox.Show("Por favor, insira uma data de saída válida!", "IFSPTravel", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            viagens = _viagemService.Get<ViagemModel>(new[] { "Cidade" }).ToList();
            dataGridViewConsulta.DataSource = viagens;
            dataGridViewConsulta.Columns["Origem"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdCidade"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            txtChegada.Text = linha?.Cells["Chegada"].Value.ToString();
            txtSaida.Text = linha?.Cells["Origem"].Value.ToString();
            cboOrigem.SelectedValue = linha?.Cells["IdCidade"].Value;
            cboDestino.SelectedValue = linha?.Cells["IdCidade"].Value;
            cboOnibus.SelectedValue = linha?.Cells["Onibus"].Value;
        }
    }
}
