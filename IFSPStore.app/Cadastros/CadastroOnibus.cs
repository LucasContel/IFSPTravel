using IFSPStore.app.Base;
using IFSPStore.app.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.app.Cadastros
{
    public partial class CadastroOnibus : CadastroBase
    {
        private List<AssentoModel> _assentos;
        private readonly IBaseService<Onibus>? _onibusService;
        private readonly IBaseService<Assento>? _assentoService;

        private List<OnibusModel>? onibuses;

        public CadastroOnibus(IBaseService<Onibus> onibusService, IBaseService<Assento> assentoService)
        {
            _assentoService = assentoService;
            _onibusService = onibusService;
            _assentos = new List<AssentoModel>();
            InitializeComponent();
        }
        private void PreencheObjeto(Onibus onibus)
        {
            onibus.Placa = txtPlaca.Text;
            onibus.Modelo = txtModelo.Text;
            onibus.Wifi = wifiSim.Checked;

            if (isAlteracao)
            {

                var assentoQuantidade = _assentoService?.Get<Assento>().Count(a => a.Onibus.Id == onibus.Id);

                var assentoQuantidadeString = assentoQuantidade.ToString();

                if (!cboAssentos.Items.Contains(assentoQuantidadeString))
                {
                    cboAssentos.Items.Add(assentoQuantidadeString!);
                }

                for (int i = int.Parse(assentoQuantidadeString!); i > int.Parse(cboAssentos.Text); i--)
                {
                    var assentoDelete = _assentoService?.Get<Assento>().FirstOrDefault(a => a.Onibus.Id == onibus.Id && a.NumeroAssento == i);
                    if(assentoDelete != null)
                    {
                        DeletarAssento(assentoDelete.Id);
                        onibus.Assentos.Remove(assentoDelete);
                    }
                        
                }

                int adicionar = int.Parse(cboAssentos.Text) - int.Parse(assentoQuantidadeString!);

                for (int i = (int.Parse(assentoQuantidadeString)+1); i <= (int.Parse(assentoQuantidadeString) + adicionar); i++)
                {
                    var assento = new Assento
                    {
                        Onibus = onibus,
                        NumeroAssento = (i)
                    };

                    onibus.Assentos.Add(assento);
                }

                int prioridade = (int)Math.Floor(int.Parse(cboAssentos.Text) * .1);
                for (int i = 0; i < onibus.Assentos.Count; i++)
                {
                    if (i >= int.Parse(cboAssentos.Text) - prioridade)
                    {
                        onibus.Assentos[i].Prioritario = true;
                    }
                    else
                    {
                        onibus.Assentos[i].Prioritario = false;
                    }

                }

            }
            else
            {
                int prioridade = (int)Math.Floor(int.Parse(cboAssentos.Text) * .1);

                for (int i = 0; i < int.Parse(cboAssentos.Text); i++)
                {
                    bool prioritario;
                    if (i >= int.Parse(cboAssentos.Text) - prioridade)
                    {
                        prioritario = true;
                    }
                    else
                    {
                        prioritario = false;
                    }

                    var assento = new Assento
                    {
                        Onibus = onibus,
                        Prioritario = prioritario,
                        NumeroAssento = (i + 1)
                    };

                    onibus.Assentos.Add(assento);
                }
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
                        var onibus = _onibusService.GetById<Onibus>(id);
                        PreencheObjeto(onibus);
                        onibus = _onibusService.Update<Onibus, Onibus, OnibusValidator>(onibus);
                    }
                }
                else
                {
                    var onibus = new Onibus();
                    PreencheObjeto(onibus);
                    _onibusService.Add<Onibus, Onibus, OnibusValidator>(onibus);
                }
                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void DeletarAssento(int id)
        {
            try
            {
                _assentoService.Delete(id);
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
                _onibusService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CarregaGrid()
        {
            onibuses = _onibusService.Get<OnibusModel>().ToList();

            foreach (var onibus in onibuses)
            {
                var assentoQuantidade = _assentoService?.Get<Assento>().Count(a => a.Onibus.Id == onibus.Id);
                onibus.NumeroAssentos = int.Parse(assentoQuantidade.ToString());
            }

            dataGridViewConsulta.DataSource = onibuses;
            dataGridViewConsulta.Columns["Modelo"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            txtModelo.Text = linha?.Cells["Modelo"].Value.ToString();
            txtPlaca.Text = linha?.Cells["Placa"].Value.ToString();
            
            if (int.TryParse(txtId, out var id))
            {
                var onibus = _onibusService.GetById<Onibus>(id);

                var assentoQuantidade = _assentoService?.Get<Assento>().Count(a => a.Onibus.Id == onibus.Id);

                var assentoQuantidadeString = assentoQuantidade.ToString();

                if (!cboAssentos.Items.Contains(assentoQuantidadeString))
                {
                    cboAssentos.Items.Add(assentoQuantidadeString!);
                }

                cboAssentos.SelectedItem = assentoQuantidadeString;
            }
        }
    }
    
}
