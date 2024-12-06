using IFSPStore.app.Cadastros;
using IFSPStore.app.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace IFSPStore.app
{
    public partial class FormMenuPrincipal : MaterialForm
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCidade>();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroPassageiro>();
        }

        private void onibusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroOnibus>();
        }

        private void viagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroViagem>();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroReserva>();
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
