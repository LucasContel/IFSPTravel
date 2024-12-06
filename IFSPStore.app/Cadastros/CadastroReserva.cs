using IFSPStore.app.Base;
using IFSPStore.app.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using ReaLTaiizor.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IFSPStore.app.Cadastros
{
    public partial class CadastroReserva : CadastroBase
    {

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

            CreateSeats();
        }

        private void CreateSeats()
        {
            int totalSeats = 0;

            if (int.TryParse(cboPassageiro.SelectedValue!.ToString(), out var idViagem))
            {
                var viagem = _viagemService.GetById<Viagem>(idViagem);
                var onibus = _onibusService.GetById<Onibus>(viagem.Onibus.Id);
                var assentoQuantidade = _assentoService?.Get<Assento>().Count(a => a.Onibus.Id == onibus.Id);
                totalSeats = (int)assentoQuantidade;
            }
            MessageBox.Show("Seats:" + totalSeats.ToString());

            int seatsPerRow = 4; // Number of seats per row (2 seats per side)
            int ColumnCount = (int)Math.Ceiling((double)totalSeats / seatsPerRow); // Calculate the number of rows

            MessageBox.Show("Columns:" + ColumnCount.ToString());

            // Clear existing controls before adding new ones
            tblPnl.Controls.Clear();
            tblPnl.ColumnCount = ColumnCount;
            tblPnl.RowCount= 5;
            tblPnl.AutoScroll = true;
            int seatIndex = 1; // To keep track of the seat number

            tblPnl.ColumnStyles.Clear(); // Clear any existing styles
            tblPnl.RowStyles.Clear();    // Clear any existing row styles

            for (int i = 0; i < tblPnl.ColumnCount; i++)
            {
                tblPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 20F)); // Equal width for all columns
            }

            for (int i = 0; i < tblPnl.RowCount; i++)
            {
                tblPnl.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // Auto-size for rows
            }

            for (int row = 0; row < seatsPerRow+1; row++)
            {
                if (row == 2) // Skip the middle row (index 2)
                {
                    // Add a placeholder row for the empty corridor
                    for (int col = 0; col < seatsPerRow; col++)
                    {
                        Label placeholder = new Label();
                        placeholder.Text = ""; // Empty placeholder
                        placeholder.Size = new Size(50, 50); // Match button size
                        tblPnl.Controls.Add(placeholder, col, row);
                    }
                    continue;
                }

                for (int col = 0; col < ColumnCount; col++)
                {
                    int texto = seatIndex + seatsPerRow * col;
                    if (texto <= totalSeats)
                    {
                        MaterialButton seatButton = new MaterialButton();
                        seatButton.Size = new Size(50, 50); // Seat button size
                        
                        seatButton.Text = texto.ToString(); // Seat number as button text
                        seatButton.Name = "Assento" + texto; // Name for identification
                        seatButton.Tag = texto; // Use Tag to store seat number or any other identifier

                        // Position seats in two rows, adjust X, Y based on row and column
                        //seatButton.Location = new Point(col, row); // Adjust distance between seats

                        // Optionally: Set up events for when a seat is clicked
                        //seatButton.Click += SeatButton_Click;

                        // Add seat button to panel or container (panelSeats is your container)
                        tblPnl.Controls.Add(seatButton, col, row);
                    }

                    
                }
                seatIndex++; // Increment seat number
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
        }

        private void PreencheObjeto(Reserva reserva)
        {
            if (int.TryParse(cboPassageiro.SelectedValue!.ToString(), out var idPassageiro))
            {
                var passageiro = _passageiroService.GetById<Passageiro>(idPassageiro);
                reserva.Passageiro = passageiro;
            }

            if (int.TryParse(cboPassageiro.SelectedValue!.ToString(), out var idViagem))
            {
                var viagem = _viagemService.GetById<Viagem>(idViagem);
                reserva.Viagem = viagem;
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
            reservas = _reservaService.Get<ReservaModel>(new[] { "Passageiro" }).ToList();
            dataGridViewConsulta.DataSource = reservas;
            dataGridViewConsulta.Columns["IdPassageiro"]!.Visible = false;
            dataGridViewConsulta.Columns["IdViagem"]!.Visible = false;
            dataGridViewConsulta.Columns["IdAssento"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            cboPassageiro.SelectedValue = linha?.Cells["IdPassageiro"].Value;
            cboViagem.SelectedValue = linha?.Cells["IdViagem"].Value;

        }
    }
}
