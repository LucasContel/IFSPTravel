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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroViagem));
            cboOnibus = new ReaLTaiizor.Controls.MaterialComboBox();
            cboDestino = new ReaLTaiizor.Controls.MaterialComboBox();
            cboOrigem = new ReaLTaiizor.Controls.MaterialComboBox();
            dataSaida = new DateTimePicker();
            lblSaida = new ReaLTaiizor.Controls.BigLabel();
            dataChegada = new DateTimePicker();
            lblChegada = new ReaLTaiizor.Controls.BigLabel();
            txtHoraSaida = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtHoraChegada = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabPageRota = new TabPage();
            splitContainer = new SplitContainer();
            webRota = new Microsoft.Web.WebView2.WinForms.WebView2();
            cboOrigemRota = new ReaLTaiizor.Controls.MaterialComboBox();
            cboDestinoRota = new ReaLTaiizor.Controls.MaterialComboBox();
            btnRetornar = new ReaLTaiizor.Controls.MaterialButton();
            btnRota = new ReaLTaiizor.Controls.MaterialButton();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageRota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webRota).BeginInit();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Controls.Add(tabPageRota);
            tabControlCadastro.Size = new Size(1077, 654);
            tabControlCadastro.Controls.SetChildIndex(tabPageRota, 0);
            tabControlCadastro.Controls.SetChildIndex(tabPageConsulta, 0);
            tabControlCadastro.Controls.SetChildIndex(tabPageCadastro, 0);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btnRota);
            tabPageCadastro.Controls.Add(txtHoraChegada);
            tabPageCadastro.Controls.Add(txtHoraSaida);
            tabPageCadastro.Controls.Add(dataChegada);
            tabPageCadastro.Controls.Add(dataSaida);
            tabPageCadastro.Controls.Add(lblSaida);
            tabPageCadastro.Controls.Add(cboOrigem);
            tabPageCadastro.Controls.Add(cboDestino);
            tabPageCadastro.Controls.Add(cboOnibus);
            tabPageCadastro.Controls.Add(lblChegada);
            tabPageCadastro.Size = new Size(1069, 619);
            tabPageCadastro.Enter += tabPageCadastro_Enter;
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
            tabPageCadastro.Controls.SetChildIndex(btnRota, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(1069, 619);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(688, 308);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(781, 308);
            // 
            // imageList1
            // 
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            imageList1.Images.SetKeyName(2, "Seat - Icon.png");
            imageList1.Images.SetKeyName(3, "Rota - Icon.png");
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
            cboOnibus.Location = new Point(245, 129);
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
            cboDestino.Location = new Point(524, 217);
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
            cboOrigem.Location = new Point(134, 217);
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
            dataSaida.Location = new Point(134, 55);
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
            lblSaida.Location = new Point(134, 36);
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
            dataChegada.Location = new Point(524, 55);
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
            lblChegada.Location = new Point(533, 36);
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
            txtHoraSaida.Location = new Point(356, 42);
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
            txtHoraChegada.Location = new Point(746, 42);
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
            // tabPageRota
            // 
            tabPageRota.Controls.Add(splitContainer);
            tabPageRota.ImageKey = "Rota - Icon.png";
            tabPageRota.Location = new Point(4, 31);
            tabPageRota.Name = "tabPageRota";
            tabPageRota.Padding = new Padding(3);
            tabPageRota.Size = new Size(1069, 619);
            tabPageRota.TabIndex = 2;
            tabPageRota.Text = "Rota";
            tabPageRota.UseVisualStyleBackColor = true;
            tabPageRota.Enter += tabPageRota_Enter;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(3, 3);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(webRota);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(cboOrigemRota);
            splitContainer.Panel2.Controls.Add(cboDestinoRota);
            splitContainer.Panel2.Controls.Add(btnRetornar);
            splitContainer.Size = new Size(1063, 613);
            splitContainer.SplitterDistance = 553;
            splitContainer.TabIndex = 0;
            // 
            // webRota
            // 
            webRota.AllowExternalDrop = true;
            webRota.CreationProperties = null;
            webRota.DefaultBackgroundColor = Color.White;
            webRota.Dock = DockStyle.Fill;
            webRota.Location = new Point(0, 0);
            webRota.Name = "webRota";
            webRota.Size = new Size(1063, 553);
            webRota.TabIndex = 0;
            webRota.ZoomFactor = 1D;
            // 
            // cboOrigemRota
            // 
            cboOrigemRota.AutoResize = false;
            cboOrigemRota.BackColor = Color.FromArgb(255, 255, 255);
            cboOrigemRota.Depth = 0;
            cboOrigemRota.DrawMode = DrawMode.OwnerDrawVariable;
            cboOrigemRota.DropDownHeight = 174;
            cboOrigemRota.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrigemRota.DropDownWidth = 121;
            cboOrigemRota.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboOrigemRota.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboOrigemRota.FormattingEnabled = true;
            cboOrigemRota.Hint = "Origem";
            cboOrigemRota.IntegralHeight = false;
            cboOrigemRota.ItemHeight = 43;
            cboOrigemRota.Location = new Point(72, 4);
            cboOrigemRota.MaxDropDownItems = 4;
            cboOrigemRota.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboOrigemRota.Name = "cboOrigemRota";
            cboOrigemRota.Size = new Size(332, 49);
            cboOrigemRota.StartIndex = 0;
            cboOrigemRota.TabIndex = 23;
            cboOrigemRota.SelectedIndexChanged += cboOrigemRota_SelectedIndexChanged_1;
            // 
            // cboDestinoRota
            // 
            cboDestinoRota.AutoResize = false;
            cboDestinoRota.BackColor = Color.FromArgb(255, 255, 255);
            cboDestinoRota.Depth = 0;
            cboDestinoRota.DrawMode = DrawMode.OwnerDrawVariable;
            cboDestinoRota.DropDownHeight = 174;
            cboDestinoRota.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDestinoRota.DropDownWidth = 121;
            cboDestinoRota.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboDestinoRota.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboDestinoRota.FormattingEnabled = true;
            cboDestinoRota.Hint = "Destino";
            cboDestinoRota.IntegralHeight = false;
            cboDestinoRota.ItemHeight = 43;
            cboDestinoRota.Location = new Point(645, 2);
            cboDestinoRota.MaxDropDownItems = 4;
            cboDestinoRota.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboDestinoRota.Name = "cboDestinoRota";
            cboDestinoRota.Size = new Size(332, 49);
            cboDestinoRota.StartIndex = 0;
            cboDestinoRota.TabIndex = 22;
            cboDestinoRota.SelectedIndexChanged += cboDestinoRota_SelectedIndexChanged_1;
            // 
            // btnRetornar
            // 
            btnRetornar.AutoSize = false;
            btnRetornar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRetornar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRetornar.Depth = 0;
            btnRetornar.HighEmphasis = true;
            btnRetornar.Icon = null;
            btnRetornar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnRetornar.Location = new Point(456, 7);
            btnRetornar.Margin = new Padding(4, 6, 4, 6);
            btnRetornar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnRetornar.Name = "btnRetornar";
            btnRetornar.NoAccentTextColor = Color.Empty;
            btnRetornar.Size = new Size(130, 43);
            btnRetornar.TabIndex = 21;
            btnRetornar.Text = "Retornar";
            btnRetornar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRetornar.UseAccentColor = false;
            btnRetornar.UseVisualStyleBackColor = true;
            btnRetornar.Click += btnRetornar_Click_1;
            // 
            // btnRota
            // 
            btnRota.AutoSize = false;
            btnRota.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRota.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRota.Depth = 0;
            btnRota.HighEmphasis = true;
            btnRota.Icon = null;
            btnRota.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnRota.Location = new Point(430, 308);
            btnRota.Margin = new Padding(4, 6, 4, 6);
            btnRota.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnRota.Name = "btnRota";
            btnRota.NoAccentTextColor = Color.Empty;
            btnRota.Size = new Size(130, 27);
            btnRota.TabIndex = 17;
            btnRota.Text = "Verificar Rota";
            btnRota.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRota.UseAccentColor = false;
            btnRota.UseVisualStyleBackColor = true;
            btnRota.Click += btnRota_Click;
            // 
            // CadastroViagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 720);
            Name = "CadastroViagem";
            Text = "Cadastro de Viagem";
            WindowState = FormWindowState.Maximized;
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageRota.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webRota).EndInit();
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
        private TabPage tabPageRota;
        private ReaLTaiizor.Controls.MaterialButton btnRota;
        private SplitContainer splitContainer;
        private Microsoft.Web.WebView2.WinForms.WebView2 webRota;
        private ReaLTaiizor.Controls.MaterialComboBox cboOrigemRota;
        private ReaLTaiizor.Controls.MaterialComboBox cboDestinoRota;
        private ReaLTaiizor.Controls.MaterialButton btnRetornar;
    }
}