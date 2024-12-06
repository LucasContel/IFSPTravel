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
            cboOnibus = new ReaLTaiizor.Controls.MaterialComboBox();
            cboDestino = new ReaLTaiizor.Controls.MaterialComboBox();
            cboOrigem = new ReaLTaiizor.Controls.MaterialComboBox();
            dataSaida = new DateTimePicker();
            lblSaida = new ReaLTaiizor.Controls.BigLabel();
            dataChegada = new DateTimePicker();
            lblChegada = new ReaLTaiizor.Controls.BigLabel();
            txtHoraSaida = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtHoraChegada = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(840, 319);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtHoraChegada);
            tabPageCadastro.Controls.Add(txtHoraSaida);
            tabPageCadastro.Controls.Add(dataChegada);
            tabPageCadastro.Controls.Add(dataSaida);
            tabPageCadastro.Controls.Add(lblSaida);
            tabPageCadastro.Controls.Add(cboOrigem);
            tabPageCadastro.Controls.Add(cboDestino);
            tabPageCadastro.Controls.Add(cboOnibus);
            tabPageCadastro.Controls.Add(lblChegada);
            tabPageCadastro.Size = new Size(832, 284);
            tabPageCadastro.Controls.SetChildIndex(lblChegada, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(cboOnibus, 0);
            tabPageCadastro.Controls.SetChildIndex(cboDestino, 0);
            tabPageCadastro.Controls.SetChildIndex(cboOrigem, 0);
            tabPageCadastro.Controls.SetChildIndex(lblSaida, 0);
            tabPageCadastro.Controls.SetChildIndex(dataSaida, 0);
            tabPageCadastro.Controls.SetChildIndex(dataChegada, 0);
            tabPageCadastro.Controls.SetChildIndex(txtHoraSaida, 0);
            tabPageCadastro.Controls.SetChildIndex(txtHoraChegada, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(832, 284);
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
            cboDestino.Location = new Point(412, 175);
            cboDestino.MaxDropDownItems = 4;
            cboDestino.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboDestino.Name = "cboDestino";
            cboDestino.Size = new Size(332, 49);
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
            cboOrigem.Location = new Point(22, 175);
            cboOrigem.MaxDropDownItems = 4;
            cboOrigem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboOrigem.Name = "cboOrigem";
            cboOrigem.Size = new Size(332, 49);
            cboOrigem.StartIndex = 0;
            cboOrigem.TabIndex = 5;
            cboOrigem.SelectedIndexChanged += cboOrigem_SelectedIndexChanged;
            // 
            // dataSaida
            // 
            dataSaida.CalendarForeColor = SystemColors.ControlDarkDark;
            dataSaida.CalendarTitleForeColor = SystemColors.AppWorkspace;
            dataSaida.CustomFormat = "dd/MM/yyyy";
            dataSaida.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataSaida.Format = DateTimePickerFormat.Short;
            dataSaida.Location = new Point(22, 46);
            dataSaida.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dataSaida.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dataSaida.Name = "dataSaida";
            dataSaida.Size = new Size(216, 35);
            dataSaida.TabIndex = 7;
            dataSaida.Value = new DateTime(2024, 12, 5, 0, 0, 0, 0);
            // 
            // lblSaida
            // 
            lblSaida.AutoSize = true;
            lblSaida.BackColor = Color.Transparent;
            lblSaida.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSaida.ForeColor = Color.Gray;
            lblSaida.Location = new Point(22, 27);
            lblSaida.Name = "lblSaida";
            lblSaida.Size = new Size(111, 20);
            lblSaida.TabIndex = 9;
            lblSaida.Text = "Data de Saída";
            // 
            // dataChegada
            // 
            dataChegada.CalendarForeColor = SystemColors.ControlDarkDark;
            dataChegada.CalendarTitleForeColor = SystemColors.AppWorkspace;
            dataChegada.CustomFormat = "dd/MM/yyyy";
            dataChegada.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataChegada.Format = DateTimePickerFormat.Short;
            dataChegada.Location = new Point(412, 46);
            dataChegada.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dataChegada.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dataChegada.Name = "dataChegada";
            dataChegada.Size = new Size(216, 35);
            dataChegada.TabIndex = 10;
            dataChegada.Value = new DateTime(2024, 12, 5, 0, 0, 0, 0);
            // 
            // lblChegada
            // 
            lblChegada.AutoSize = true;
            lblChegada.BackColor = Color.Transparent;
            lblChegada.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblChegada.ForeColor = Color.Gray;
            lblChegada.Location = new Point(421, 27);
            lblChegada.Name = "lblChegada";
            lblChegada.Size = new Size(135, 20);
            lblChegada.TabIndex = 14;
            lblChegada.Text = "Data de Chegada";
            // 
            // txtHoraSaida
            // 
            txtHoraSaida.AllowPromptAsInput = true;
            txtHoraSaida.AnimateReadOnly = false;
            txtHoraSaida.AsciiOnly = false;
            txtHoraSaida.BackgroundImageLayout = ImageLayout.None;
            txtHoraSaida.BeepOnError = false;
            txtHoraSaida.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtHoraSaida.Depth = 0;
            txtHoraSaida.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHoraSaida.HidePromptOnLeave = false;
            txtHoraSaida.HideSelection = true;
            txtHoraSaida.Hint = "Hora de Saída";
            txtHoraSaida.InsertKeyMode = InsertKeyMode.Default;
            txtHoraSaida.LeadingIcon = null;
            txtHoraSaida.Location = new Point(244, 33);
            txtHoraSaida.Mask = "90:00";
            txtHoraSaida.MaxLength = 32767;
            txtHoraSaida.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtHoraSaida.Name = "txtHoraSaida";
            txtHoraSaida.PasswordChar = '\0';
            txtHoraSaida.PrefixSuffixText = null;
            txtHoraSaida.PromptChar = '_';
            txtHoraSaida.ReadOnly = false;
            txtHoraSaida.RejectInputOnFirstFailure = false;
            txtHoraSaida.ResetOnPrompt = true;
            txtHoraSaida.ResetOnSpace = true;
            txtHoraSaida.RightToLeft = RightToLeft.No;
            txtHoraSaida.SelectedText = "";
            txtHoraSaida.SelectionLength = 0;
            txtHoraSaida.SelectionStart = 0;
            txtHoraSaida.ShortcutsEnabled = true;
            txtHoraSaida.Size = new Size(110, 48);
            txtHoraSaida.SkipLiterals = true;
            txtHoraSaida.TabIndex = 15;
            txtHoraSaida.TabStop = false;
            txtHoraSaida.Text = "  :";
            txtHoraSaida.TextAlign = HorizontalAlignment.Left;
            txtHoraSaida.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtHoraSaida.TrailingIcon = null;
            txtHoraSaida.UseSystemPasswordChar = false;
            txtHoraSaida.ValidatingType = null;
            // 
            // txtHoraChegada
            // 
            txtHoraChegada.AllowPromptAsInput = true;
            txtHoraChegada.AnimateReadOnly = false;
            txtHoraChegada.AsciiOnly = false;
            txtHoraChegada.BackgroundImageLayout = ImageLayout.None;
            txtHoraChegada.BeepOnError = false;
            txtHoraChegada.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtHoraChegada.Depth = 0;
            txtHoraChegada.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHoraChegada.HidePromptOnLeave = false;
            txtHoraChegada.HideSelection = true;
            txtHoraChegada.Hint = "Hora de Chegada";
            txtHoraChegada.InsertKeyMode = InsertKeyMode.Default;
            txtHoraChegada.LeadingIcon = null;
            txtHoraChegada.Location = new Point(634, 33);
            txtHoraChegada.Mask = "90:00";
            txtHoraChegada.MaxLength = 32767;
            txtHoraChegada.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtHoraChegada.Name = "txtHoraChegada";
            txtHoraChegada.PasswordChar = '\0';
            txtHoraChegada.PrefixSuffixText = null;
            txtHoraChegada.PromptChar = '_';
            txtHoraChegada.ReadOnly = false;
            txtHoraChegada.RejectInputOnFirstFailure = false;
            txtHoraChegada.ResetOnPrompt = true;
            txtHoraChegada.ResetOnSpace = true;
            txtHoraChegada.RightToLeft = RightToLeft.No;
            txtHoraChegada.SelectedText = "";
            txtHoraChegada.SelectionLength = 0;
            txtHoraChegada.SelectionStart = 0;
            txtHoraChegada.ShortcutsEnabled = true;
            txtHoraChegada.Size = new Size(110, 48);
            txtHoraChegada.SkipLiterals = true;
            txtHoraChegada.TabIndex = 16;
            txtHoraChegada.TabStop = false;
            txtHoraChegada.Text = "  :";
            txtHoraChegada.TextAlign = HorizontalAlignment.Left;
            txtHoraChegada.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtHoraChegada.TrailingIcon = null;
            txtHoraChegada.UseSystemPasswordChar = false;
            txtHoraChegada.ValidatingType = null;
            // 
            // CadastroViagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 385);
            Name = "CadastroViagem";
            Text = "Cadastro de Viagem";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtChegada;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtSaida;
        private ReaLTaiizor.Controls.MaterialComboBox cboOrigem;
        private ReaLTaiizor.Controls.MaterialComboBox cboDestino;
        private ReaLTaiizor.Controls.MaterialComboBox cboOnibus;
        private DateTimePicker dataSaida;
        private ReaLTaiizor.Controls.BigLabel lblSaida;
        private DateTimePicker dataChegada;
        private ReaLTaiizor.Controls.BigLabel lblChegada;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtHoraChegada;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtHoraSaida;
    }
}