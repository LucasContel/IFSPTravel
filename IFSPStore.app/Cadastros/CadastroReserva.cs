using IFSPStore.app.Base;
using IFSPStore.app.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using ReaLTaiizor.Controls;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IFSPStore.app.Cadastros
{
    public partial class CadastroReserva : CadastroBase
    {

        public static int viagemRotaId { get; set; }

        private int assentoEscolhido = -1;

        private readonly IBaseService<Assento>? _assentoService;
        private readonly IBaseService<Viagem>? _viagemService;
        private readonly IBaseService<Passageiro>? _passageiroService;
        private readonly IBaseService<Reserva>? _reservaService;
        private readonly IBaseService<Onibus>? _onibusService;
        private readonly IBaseService<Cidade>? _cidadeService;

        private List<ReservaModel>? reservas;

        public CadastroReserva(IBaseService<Assento> assentoService, IBaseService<Viagem> viagemService, IBaseService<Passageiro> passageiroService, IBaseService<Reserva> reservaService, IBaseService<Onibus> onibusService, IBaseService<Cidade> cidadeService)
        {
            _assentoService = assentoService;
            _viagemService = viagemService;
            _passageiroService = passageiroService;
            _reservaService = reservaService;
            _onibusService = onibusService;
            _cidadeService = cidadeService;

            InitializeComponent();

            CarregarCombo();
        }

        private void CriaAssentos()
        {
            int numeroAssentos = 0;
            assentoEscolhido = -1;

            if (cboViagem.SelectedValue != null)
            {
                if (int.TryParse(cboViagem.SelectedValue!.ToString(), out var idViagem))
                {
                    var viagem = _viagemService.GetById<Viagem>(idViagem);
                    var onibus = _onibusService.GetById<Onibus>(viagem.Onibus.Id);
                    var assentoQuantidade = _assentoService?.Get<Assento>().Count(a => a.Onibus.Id == onibus.Id);
                    numeroAssentos = (int)assentoQuantidade;


                    int assentosColuna = 4;
                    int NumeroColunas = (int)Math.Ceiling((double)numeroAssentos / assentosColuna);


                    tblPnl.Controls.Clear();
                    tblPnl.ColumnCount = NumeroColunas;
                    tblPnl.RowCount = 5;
                    tblPnl.AutoScroll = true;
                    int assento = 1;

                    tblPnl.ColumnStyles.Clear();
                    tblPnl.RowStyles.Clear();

                    for (int i = 0; i < tblPnl.ColumnCount; i++)
                    {
                        tblPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
                    }

                    for (int i = 0; i < tblPnl.RowCount; i++)
                    {
                        tblPnl.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    }

                    for (int linha = 0; linha < assentosColuna + 1; linha++)
                    {
                        if (linha == 2)
                        {
                            for (int coluna = 0; coluna < assentosColuna; coluna++)
                            {
                                Label vazio = new Label();
                                vazio.Text = "";
                                vazio.Size = new Size(50, 50);
                                tblPnl.Controls.Add(vazio, coluna, linha);
                            }
                            continue;
                        }

                        for (int coluna = 0; coluna < NumeroColunas; coluna++)
                        {
                            int numeroAssento = assento + assentosColuna * coluna;
                            if (numeroAssento <= numeroAssentos)
                            {
                                System.Windows.Forms.Button botaoAssento = new System.Windows.Forms.Button();
                                botaoAssento.Size = new Size(50, 50);

                                botaoAssento.Text = numeroAssento.ToString();
                                botaoAssento.Name = "Assento" + numeroAssento;


                                var _assento = _assentoService?.Get<Assento>().FirstOrDefault(a => a.Onibus.Id == onibus.Id && a.NumeroAssento == numeroAssento);
                                var reserva = _reservaService?.Get<Reserva>().FirstOrDefault(a => a.Viagem.Onibus.Id == onibus.Id && a.Assento.NumeroAssento == numeroAssento);

                                if (reserva != null)
                                {
                                    botaoAssento.BackColor = Color.FromArgb(212, 212, 212);
                                    botaoAssento.Enabled = false;
                                }
                                else
                                {
                                    if (_assento.Prioritario)
                                    {
                                        botaoAssento.BackColor = Color.FromArgb(58, 186, 244);
                                        botaoAssento.Tag = "Prioritario";
                                    }
                                    else
                                    {
                                        botaoAssento.BackColor = Color.FromArgb(10, 251, 21);
                                        botaoAssento.Tag = "Normal";
                                    }
                                }


                                botaoAssento.Click += (sender, args) =>
                                {
                                    AssentoSelecionado(((System.Windows.Forms.Button)sender));
                                };



                                tblPnl.Controls.Add(botaoAssento, coluna, linha);
                            }


                        }
                        assento++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira Viagens antes de Reservas!", @"IFSP Travel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarCombo()
        {
            cboPassageiro.DataSource = _passageiroService.Get<PassageiroModel>().ToList();
            cboPassageiro.ValueMember = "Id";
            cboPassageiro.DisplayMember = "NomeCpf";

            var onibusService = _onibusService.Get<Onibus>();
            var cidadeService = _cidadeService.Get<Cidade>();
            var viagemService = _viagemService.Get<ViagemModel>().ToList();

            cboViagem.DataSource = viagemService;
            cboViagem.DisplayMember = "Informacoes";
            cboViagem.ValueMember = "Id";
            if (viagemRotaId != 0)
                cboViagem.SelectedValue = viagemRotaId;
        }

        private void PreencheObjeto(Reserva reserva)
        {

            if (int.TryParse(cboPassageiro.SelectedValue!.ToString(), out var idPassageiro))
            {
                var passageiro = _passageiroService.GetById<Passageiro>(idPassageiro);
                reserva.Passageiro = passageiro;
            }

            if (int.TryParse(cboViagem.SelectedValue!.ToString(), out var idViagem))
            {
                var viagem = _viagemService.GetById<Viagem>(idViagem);
                reserva.Viagem = viagem;

                if (assentoEscolhido != -1)
                {

                    var onibus = _onibusService?.Get<Onibus>().FirstOrDefault(c => c.Id == viagem.Onibus.Id);

                    var assento = _assentoService?.Get<Assento>().FirstOrDefault(a => a.Onibus.Id == onibus.Id && a.NumeroAssento == assentoEscolhido);

                    reserva.Assento = assento;
                }
            }
        }

        private void AssentoLimpo()
        {
            string assento = "Assento" + assentoEscolhido.ToString();
            var botaoAnterior = this.Controls.Find(assento, true).FirstOrDefault();
            if (botaoAnterior != null)
            {
                if (botaoAnterior.Tag == "Prioritario")
                {
                    botaoAnterior.BackColor = Color.FromArgb(58, 186, 244);
                }
                else
                {
                    botaoAnterior.BackColor = Color.FromArgb(10, 251, 21);
                }

                botaoAnterior.Font = new Font(botaoAnterior.Font, FontStyle.Regular);

            }
        }

        private void AssentoSelecionado(System.Windows.Forms.Button botaoSelecionado)
        {
            AssentoLimpo();

            botaoSelecionado.BackColor = Color.FromArgb(213, 76, 76);

            botaoSelecionado.Font = new Font(botaoSelecionado.Font, FontStyle.Bold);

            assentoEscolhido = int.Parse(botaoSelecionado.Text);
        }

        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId, out var id))
                    {
                        var reserva = _reservaService.GetById<Reserva>(id);
                        PreencheObjeto(reserva);
                        reserva = _reservaService.Update<Reserva, Reserva, ReservaValidator>(reserva);
                    }
                }
                else
                {
                    var reserva = new Reserva();
                    PreencheObjeto(reserva);
                    _reservaService.Add<Reserva, Reserva, ReservaValidator>(reserva);
                }


                tabControlCadastro.SelectedIndex = 1;
                AssentoLimpo();
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
                _reservaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Travel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            reservas = _reservaService.Get<ReservaModel>(new[] { "Passageiro", "Viagem", "Assento" }).ToList();
            dataGridViewConsulta.DataSource = reservas;
            dataGridViewConsulta.Columns["IdPassageiro"]!.Visible = false;
            dataGridViewConsulta.Columns["IdViagem"]!.Visible = false;
            dataGridViewConsulta.Columns["IdAssento"]!.Visible = false;
            dataGridViewConsulta.Columns["NomeCpf"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            cboPassageiro.SelectedValue = linha?.Cells["IdPassageiro"].Value;
            cboViagem.SelectedValue = linha?.Cells["IdViagem"].Value;


        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tabControlCadastro.SelectedIndex = 2;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControlCadastro.SelectedIndex = 1;
        }

        private void tabPageAssento_Enter(object sender, EventArgs e)
        {
            CriaAssentos();
        }

        private void btnSalvarAssento_Click_1(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnCancelarAssento_Click_1(object sender, EventArgs e)
        {
            tabControlCadastro.SelectedIndex = 1;
        }
    }
}
