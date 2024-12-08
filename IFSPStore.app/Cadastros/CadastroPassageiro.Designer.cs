namespace IFSPStore.app.Cadastros
{
    partial class CadastroPassageiro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPassageiro));
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCpf = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtTelefone = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(844, 306);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtTelefone);
            tabPageCadastro.Controls.Add(txtCpf);
            tabPageCadastro.Controls.Add(txtEmail);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Size = new Size(836, 271);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtEmail, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCpf, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTelefone, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(836, 271);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(561, 224);
            btnCancelar.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(681, 224);
            btnSalvar.TabIndex = 4;
            // 
            // imageList1
            // 
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            imageList1.Images.SetKeyName(2, "Seat - Icon.png");
            imageList1.Images.SetKeyName(3, "Rota - Icon.png");
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(29, 58);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(395, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "E-mail";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(317, 151);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(449, 48);
            txtEmail.TabIndex = 3;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtCpf
            // 
            txtCpf.AllowPromptAsInput = false;
            txtCpf.AnimateReadOnly = false;
            txtCpf.AsciiOnly = false;
            txtCpf.BackgroundImageLayout = ImageLayout.None;
            txtCpf.BeepOnError = false;
            txtCpf.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCpf.Depth = 0;
            txtCpf.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCpf.HidePromptOnLeave = false;
            txtCpf.HideSelection = true;
            txtCpf.Hint = "CPF";
            txtCpf.InsertKeyMode = InsertKeyMode.Default;
            txtCpf.LeadingIcon = null;
            txtCpf.Location = new Point(29, 151);
            txtCpf.Mask = "999,999,999-99";
            txtCpf.MaxLength = 32767;
            txtCpf.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCpf.Name = "txtCpf";
            txtCpf.PasswordChar = '\0';
            txtCpf.PrefixSuffixText = null;
            txtCpf.PromptChar = '_';
            txtCpf.ReadOnly = false;
            txtCpf.RejectInputOnFirstFailure = false;
            txtCpf.ResetOnPrompt = true;
            txtCpf.ResetOnSpace = true;
            txtCpf.RightToLeft = RightToLeft.No;
            txtCpf.SelectedText = "";
            txtCpf.SelectionLength = 0;
            txtCpf.SelectionStart = 0;
            txtCpf.ShortcutsEnabled = true;
            txtCpf.Size = new Size(263, 48);
            txtCpf.SkipLiterals = true;
            txtCpf.TabIndex = 2;
            txtCpf.TabStop = false;
            txtCpf.Text = "   .   .   -";
            txtCpf.TextAlign = HorizontalAlignment.Left;
            txtCpf.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCpf.TrailingIcon = null;
            txtCpf.UseSystemPasswordChar = false;
            txtCpf.ValidatingType = null;
            // 
            // txtTelefone
            // 
            txtTelefone.AllowPromptAsInput = true;
            txtTelefone.AnimateReadOnly = false;
            txtTelefone.AsciiOnly = false;
            txtTelefone.BackgroundImageLayout = ImageLayout.None;
            txtTelefone.BeepOnError = false;
            txtTelefone.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.Depth = 0;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefone.HidePromptOnLeave = false;
            txtTelefone.HideSelection = true;
            txtTelefone.Hint = "Telefone";
            txtTelefone.InsertKeyMode = InsertKeyMode.Default;
            txtTelefone.LeadingIcon = null;
            txtTelefone.Location = new Point(449, 58);
            txtTelefone.Mask = "(99) 99999-9999";
            txtTelefone.MaxLength = 32767;
            txtTelefone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PasswordChar = '\0';
            txtTelefone.PrefixSuffixText = null;
            txtTelefone.PromptChar = '_';
            txtTelefone.ReadOnly = false;
            txtTelefone.RejectInputOnFirstFailure = false;
            txtTelefone.ResetOnPrompt = true;
            txtTelefone.ResetOnSpace = true;
            txtTelefone.RightToLeft = RightToLeft.No;
            txtTelefone.SelectedText = "";
            txtTelefone.SelectionLength = 0;
            txtTelefone.SelectionStart = 0;
            txtTelefone.ShortcutsEnabled = true;
            txtTelefone.Size = new Size(316, 48);
            txtTelefone.SkipLiterals = true;
            txtTelefone.TabIndex = 1;
            txtTelefone.TabStop = false;
            txtTelefone.Text = "(  )      -";
            txtTelefone.TextAlign = HorizontalAlignment.Left;
            txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.TrailingIcon = null;
            txtTelefone.UseSystemPasswordChar = false;
            txtTelefone.ValidatingType = null;
            // 
            // CadastroPassageiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 372);
            Name = "CadastroPassageiro";
            Text = "Cadastro de Passageiro";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCpf;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTelefone;
    }
}