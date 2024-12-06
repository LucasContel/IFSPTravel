using IFSPStore.app.Base;
using IFSPStore.app.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using System.Globalization;

//using System.Globalization;
using System.Windows.Forms;

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

        private void CarregarData()
        {
            txtHoraChegada.Text = $"{DateTime.Now.Hour.ToString()}:{DateTime.Now.Minute.ToString()}";
            txtHoraSaida.Text = $"{DateTime.Now.Hour.ToString()}:{DateTime.Now.Minute.ToString()}";
            dataChegada.Value = DateTime.Now.Date;
            dataSaida.Value = DateTime.Now.Date;
        }


        private void CarregarCombo()
        {
            cboOnibus.ValueMember = "Id";
            cboOnibus.DisplayMember = "ModeloPlaca";
            cboOnibus.DataSource = _onibusService?.Get<OnibusModel>().ToList();
            /*
            cboDestino.ValueMember = "Id";
            cboDestino.DisplayMember = "NomeEstado";
            cboDestino.DataSource = _cidadeService?.Get<CidadeModel>().ToList();
            */
            cboOrigem.ValueMember = "Id";
            cboOrigem.DisplayMember = "NomeEstado";
            cboOrigem.DataSource = _cidadeService?.Get<CidadeModel>().ToList();
            TrocaDestino();
        }


        private void TrocaDestino()
        {
            if (int.TryParse(cboOrigem.SelectedValue.ToString(), out var idOrigem))
            {
                cboDestino.DataSource = _cidadeService?.Get<CidadeModel>().ToList()
                .Where(c => c.Id != idOrigem)
                .ToList();

                cboDestino.DisplayMember = "NomeEstado";
                cboDestino.ValueMember = "Id";
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
                else
                {
                    MessageBox.Show("Por favor, insira uma hora de chegada válida!", "IFSPTravel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("Por favor, insira uma hora de saída válida!", "IFSPTravel", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
