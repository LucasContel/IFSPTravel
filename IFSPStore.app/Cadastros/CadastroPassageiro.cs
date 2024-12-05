using IFSPStore.app.Base;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Mapping;
using IFSPStore.Service.Validators;

namespace IFSPStore.app.Cadastros
{
    public partial class CadastroPassageiro : CadastroBase
    {

        private readonly IBaseService<Passageiro> _passageiroService;
        private List<Passageiro>? passageiros;

        public CadastroPassageiro(IBaseService<Passageiro> passageiroService)
        {
            _passageiroService = passageiroService;
            InitializeComponent();
        }

        private void PreencheObjeto(Passageiro passageiro)
        {
            passageiro.Nome = txtNome.Text;
            passageiro.Telefone = txtTelefone.Text;
            passageiro.Cpf = txtCpf.Text;
            passageiro.Email = txtEmail.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (isAlteracao)
                {
                    if (int.TryParse(txtId, out var id))
                    {
                        var passageiro = _passageiroService.GetById<Passageiro>(id);
                        PreencheObjeto(passageiro);
                        passageiro = _passageiroService.Update<Passageiro, Passageiro, PassageiroValidator>(passageiro);
                    }
                }
                else
                {
                    var passageiro = new Passageiro();
                    PreencheObjeto(passageiro);
                    _passageiroService.Add<Passageiro, Passageiro, PassageiroValidator>(passageiro);
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
                _passageiroService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            passageiros = _passageiroService.Get<Passageiro>().ToList();
            dataGridViewConsulta.DataSource = passageiros;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            txtCpf.Text = linha?.Cells["Cpf"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
        }

    }
}
