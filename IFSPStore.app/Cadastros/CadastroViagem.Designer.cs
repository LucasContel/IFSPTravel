namespace IFSPStore.app
{
    partial class CadastroViagem
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
            txtSaida = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtChegada = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboOnibus = new ReaLTaiizor.Controls.MaterialComboBox();
            cboDestino = new ReaLTaiizor.Controls.MaterialComboBox();
            cboOrigem = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(797, 330);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboOrigem);
            tabPageCadastro.Controls.Add(cboDestino);
            tabPageCadastro.Controls.Add(cboOnibus);
            tabPageCadastro.Controls.Add(txtChegada);
            tabPageCadastro.Controls.Add(txtSaida);
            tabPageCadastro.Size = new Size(789, 295);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtSaida, 0);
            tabPageCadastro.Controls.SetChildIndex(txtChegada, 0);
            tabPageCadastro.Controls.SetChildIndex(cboOnibus, 0);
            tabPageCadastro.Controls.SetChildIndex(cboDestino, 0);
            tabPageCadastro.Controls.SetChildIndex(cboOrigem, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(574, 244);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(667, 244);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(661, 246);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(562, 246);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(463, 246);
            // 
            // txtSaida
            // 
            txtSaida.AllowPromptAsInput = true;
            txtSaida.AnimateReadOnly = false;
            txtSaida.AsciiOnly = false;
            txtSaida.BackgroundImageLayout = ImageLayout.None;
            txtSaida.BeepOnError = false;
            txtSaida.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtSaida.Depth = 0;
            txtSaida.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSaida.HidePromptOnLeave = false;
            txtSaida.HideSelection = true;
            txtSaida.Hint = "Data de Saída";
            txtSaida.InsertKeyMode = InsertKeyMode.Default;
            txtSaida.LeadingIcon = null;
            txtSaida.Location = new Point(22, 33);
            txtSaida.Mask = "99/99/9999";
            txtSaida.MaxLength = 32767;
            txtSaida.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSaida.Name = "txtSaida";
            txtSaida.PasswordChar = '\0';
            txtSaida.PrefixSuffixText = null;
            txtSaida.PromptChar = '_';
            txtSaida.ReadOnly = false;
            txtSaida.RejectInputOnFirstFailure = false;
            txtSaida.ResetOnPrompt = true;
            txtSaida.ResetOnSpace = true;
            txtSaida.RightToLeft = RightToLeft.No;
            txtSaida.SelectedText = "";
            txtSaida.SelectionLength = 0;
            txtSaida.SelectionStart = 0;
            txtSaida.ShortcutsEnabled = true;
            txtSaida.Size = new Size(369, 48);
            txtSaida.SkipLiterals = true;
            txtSaida.TabIndex = 1;
            txtSaida.TabStop = false;
            txtSaida.Text = "  /  /";
            txtSaida.TextAlign = HorizontalAlignment.Left;
            txtSaida.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSaida.TrailingIcon = null;
            txtSaida.UseSystemPasswordChar = false;
            txtSaida.ValidatingType = null;
            // 
            // txtChegada
            // 
            txtChegada.AllowPromptAsInput = true;
            txtChegada.AnimateReadOnly = false;
            txtChegada.AsciiOnly = false;
            txtChegada.BackgroundImageLayout = ImageLayout.None;
            txtChegada.BeepOnError = false;
            txtChegada.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtChegada.Depth = 0;
            txtChegada.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtChegada.HidePromptOnLeave = false;
            txtChegada.HideSelection = true;
            txtChegada.Hint = "Data de Chegada";
            txtChegada.InsertKeyMode = InsertKeyMode.Default;
            txtChegada.LeadingIcon = null;
            txtChegada.Location = new Point(397, 33);
            txtChegada.Mask = "99/99/9999";
            txtChegada.MaxLength = 32767;
            txtChegada.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtChegada.Name = "txtChegada";
            txtChegada.PasswordChar = '\0';
            txtChegada.PrefixSuffixText = null;
            txtChegada.PromptChar = '_';
            txtChegada.ReadOnly = false;
            txtChegada.RejectInputOnFirstFailure = false;
            txtChegada.ResetOnPrompt = true;
            txtChegada.ResetOnSpace = true;
            txtChegada.RightToLeft = RightToLeft.No;
            txtChegada.SelectedText = "";
            txtChegada.SelectionLength = 0;
            txtChegada.SelectionStart = 0;
            txtChegada.ShortcutsEnabled = true;
            txtChegada.Size = new Size(369, 48);
            txtChegada.SkipLiterals = true;
            txtChegada.TabIndex = 2;
            txtChegada.TabStop = false;
            txtChegada.Text = "  /  /";
            txtChegada.TextAlign = HorizontalAlignment.Left;
            txtChegada.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtChegada.TrailingIcon = null;
            txtChegada.UseSystemPasswordChar = false;
            txtChegada.ValidatingType = null;
            // 
            // cboOnibus
            // 
            cboOnibus.AutoResize = false;
            cboOnibus.BackColor = Color.FromArgb(255, 255, 255);
            cboOnibus.Depth = 0;
            cboOnibus.DrawMode = DrawMode.OwnerDrawVariable;
            cboOnibus.DropDownHeight = 174;
            cboOnibus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOnibus.DropDownWidth = 121;
            cboOnibus.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboOnibus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboOnibus.FormattingEnabled = true;
            cboOnibus.Hint = "Ônibus";
            cboOnibus.IntegralHeight = false;
            cboOnibus.ItemHeight = 43;
            cboOnibus.Location = new Point(133, 99);
            cboOnibus.MaxDropDownItems = 4;
            cboOnibus.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboOnibus.Name = "cboOnibus";
            cboOnibus.Size = new Size(560, 49);
            cboOnibus.StartIndex = 0;
            cboOnibus.TabIndex = 3;
            // 
            // cboDestino
            // 
            cboDestino.AutoResize = false;
            cboDestino.BackColor = Color.FromArgb(255, 255, 255);
            cboDestino.Depth = 0;
            cboDestino.DrawMode = DrawMode.OwnerDrawVariable;
            cboDestino.DropDownHeight = 174;
            cboDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDestino.DropDownWidth = 121;
            cboDestino.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboDestino.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboDestino.FormattingEnabled = true;
            cboDestino.Hint = "Destino";
            cboDestino.IntegralHeight = false;
            cboDestino.ItemHeight = 43;
            cboDestino.Location = new Point(22, 168);
            cboDestino.MaxDropDownItems = 4;
            cboDestino.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboDestino.Name = "cboDestino";
            cboDestino.Size = new Size(369, 49);
            cboDestino.StartIndex = 0;
            cboDestino.TabIndex = 4;
            // 
            // cboOrigem
            // 
            cboOrigem.AutoResize = false;
            cboOrigem.BackColor = Color.FromArgb(255, 255, 255);
            cboOrigem.Depth = 0;
            cboOrigem.DrawMode = DrawMode.OwnerDrawVariable;
            cboOrigem.DropDownHeight = 174;
            cboOrigem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrigem.DropDownWidth = 121;
            cboOrigem.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboOrigem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboOrigem.FormattingEnabled = true;
            cboOrigem.Hint = "Origem";
            cboOrigem.IntegralHeight = false;
            cboOrigem.ItemHeight = 43;
            cboOrigem.Location = new Point(397, 168);
            cboOrigem.MaxDropDownItems = 4;
            cboOrigem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboOrigem.Name = "cboOrigem";
            cboOrigem.Size = new Size(369, 49);
            cboOrigem.StartIndex = 0;
            cboOrigem.TabIndex = 5;
            // 
            // CadastroViagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Name = "CadastroViagem";
            Text = "Cadastro de Viagem";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtChegada;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtSaida;
        private ReaLTaiizor.Controls.MaterialComboBox cboOrigem;
        private ReaLTaiizor.Controls.MaterialComboBox cboDestino;
        private ReaLTaiizor.Controls.MaterialComboBox cboOnibus;
    }
}