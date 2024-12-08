namespace IFSPStore.app.Outros
{
    partial class Rota
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
            splitContainer1 = new SplitContainer();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            txtHoraChegada = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtHoraSaida = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            dataChegada = new DateTimePicker();
            dataSaida = new DateTimePicker();
            lblSaida = new ReaLTaiizor.Controls.BigLabel();
            lblChegada = new ReaLTaiizor.Controls.BigLabel();
            btnViagem = new ReaLTaiizor.Controls.MaterialButton();
            cboViagem = new ReaLTaiizor.Controls.MaterialComboBox();
            webRota = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webRota).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 64);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(materialButton1);
            splitContainer1.Panel1.Controls.Add(txtHoraChegada);
            splitContainer1.Panel1.Controls.Add(txtHoraSaida);
            splitContainer1.Panel1.Controls.Add(dataChegada);
            splitContainer1.Panel1.Controls.Add(dataSaida);
            splitContainer1.Panel1.Controls.Add(lblSaida);
            splitContainer1.Panel1.Controls.Add(lblChegada);
            splitContainer1.Panel1.Controls.Add(btnViagem);
            splitContainer1.Panel1.Controls.Add(cboViagem);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(webRota);
            splitContainer1.Size = new Size(1074, 653);
            splitContainer1.SplitterDistance = 119;
            splitContainer1.TabIndex = 3;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(712, 8);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(143, 47);
            materialButton1.TabIndex = 23;
            materialButton1.Text = "Filtrar Viagens";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
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
            txtHoraChegada.Hint = "Hora Chegada";
            txtHoraChegada.InsertKeyMode = InsertKeyMode.Default;
            txtHoraChegada.LeadingIcon = null;
            txtHoraChegada.Location = new Point(597, 8);
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
            txtHoraChegada.Size = new Size(108, 48);
            txtHoraChegada.SkipLiterals = true;
            txtHoraChegada.TabIndex = 22;
            txtHoraChegada.TabStop = false;
            txtHoraChegada.Text = "  :";
            txtHoraChegada.TextAlign = HorizontalAlignment.Left;
            txtHoraChegada.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtHoraChegada.TrailingIcon = null;
            txtHoraChegada.UseSystemPasswordChar = false;
            txtHoraChegada.ValidatingType = null;
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
            txtHoraSaida.Hint = "Hora Saída";
            txtHoraSaida.InsertKeyMode = InsertKeyMode.Default;
            txtHoraSaida.LeadingIcon = null;
            txtHoraSaida.Location = new Point(346, 8);
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
            txtHoraSaida.TabIndex = 21;
            txtHoraSaida.TabStop = false;
            txtHoraSaida.Text = "  :";
            txtHoraSaida.TextAlign = HorizontalAlignment.Left;
            txtHoraSaida.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtHoraSaida.TrailingIcon = null;
            txtHoraSaida.UseSystemPasswordChar = false;
            txtHoraSaida.ValidatingType = null;
            // 
            // dataChegada
            // 
            dataChegada.CalendarForeColor = SystemColors.ControlDarkDark;
            dataChegada.CalendarTitleForeColor = SystemColors.AppWorkspace;
            dataChegada.CustomFormat = "dd/MM/yyyy";
            dataChegada.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataChegada.Format = DateTimePickerFormat.Short;
            dataChegada.Location = new Point(463, 21);
            dataChegada.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dataChegada.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dataChegada.Name = "dataChegada";
            dataChegada.Size = new Size(128, 35);
            dataChegada.TabIndex = 19;
            dataChegada.Value = new DateTime(2024, 12, 5, 0, 0, 0, 0);
            // 
            // dataSaida
            // 
            dataSaida.CalendarForeColor = SystemColors.ControlDarkDark;
            dataSaida.CalendarTitleForeColor = SystemColors.AppWorkspace;
            dataSaida.CustomFormat = "dd/MM/yyyy";
            dataSaida.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataSaida.Format = DateTimePickerFormat.Short;
            dataSaida.Location = new Point(205, 21);
            dataSaida.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dataSaida.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dataSaida.Name = "dataSaida";
            dataSaida.Size = new Size(135, 35);
            dataSaida.TabIndex = 17;
            dataSaida.Value = new DateTime(2024, 12, 5, 0, 0, 0, 0);
            // 
            // lblSaida
            // 
            lblSaida.AutoSize = true;
            lblSaida.BackColor = Color.Transparent;
            lblSaida.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSaida.ForeColor = Color.Gray;
            lblSaida.Location = new Point(205, 2);
            lblSaida.Name = "lblSaida";
            lblSaida.Size = new Size(89, 20);
            lblSaida.TabIndex = 18;
            lblSaida.Text = "Data Saída";
            // 
            // lblChegada
            // 
            lblChegada.AutoSize = true;
            lblChegada.BackColor = Color.Transparent;
            lblChegada.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblChegada.ForeColor = Color.Gray;
            lblChegada.Location = new Point(463, 2);
            lblChegada.Name = "lblChegada";
            lblChegada.Size = new Size(113, 20);
            lblChegada.TabIndex = 20;
            lblChegada.Text = "Data Chegada";
            // 
            // btnViagem
            // 
            btnViagem.AutoSize = false;
            btnViagem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnViagem.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnViagem.Depth = 0;
            btnViagem.HighEmphasis = true;
            btnViagem.Icon = null;
            btnViagem.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnViagem.Location = new Point(820, 66);
            btnViagem.Margin = new Padding(4, 6, 4, 6);
            btnViagem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnViagem.Name = "btnViagem";
            btnViagem.NoAccentTextColor = Color.Empty;
            btnViagem.Size = new Size(174, 47);
            btnViagem.TabIndex = 1;
            btnViagem.Text = "Reservar Viagem";
            btnViagem.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnViagem.UseAccentColor = false;
            btnViagem.UseVisualStyleBackColor = true;
            btnViagem.Click += btnViagem_Click;
            // 
            // cboViagem
            // 
            cboViagem.AutoResize = false;
            cboViagem.BackColor = Color.FromArgb(255, 255, 255);
            cboViagem.Depth = 0;
            cboViagem.DrawMode = DrawMode.OwnerDrawVariable;
            cboViagem.DropDownHeight = 174;
            cboViagem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboViagem.DropDownWidth = 121;
            cboViagem.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboViagem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboViagem.FormattingEnabled = true;
            cboViagem.Hint = "Viagens";
            cboViagem.IntegralHeight = false;
            cboViagem.ItemHeight = 43;
            cboViagem.Location = new Point(18, 65);
            cboViagem.MaxDropDownItems = 4;
            cboViagem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboViagem.Name = "cboViagem";
            cboViagem.Size = new Size(795, 49);
            cboViagem.StartIndex = 0;
            cboViagem.TabIndex = 0;
            cboViagem.SelectedIndexChanged += cboViagem_SelectedIndexChanged;
            // 
            // webRota
            // 
            webRota.AllowExternalDrop = true;
            webRota.CreationProperties = null;
            webRota.DefaultBackgroundColor = Color.White;
            webRota.Dock = DockStyle.Fill;
            webRota.Location = new Point(0, 0);
            webRota.Name = "webRota";
            webRota.Size = new Size(1074, 530);
            webRota.TabIndex = 0;
            webRota.ZoomFactor = 1D;
            // 
            // Rota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 720);
            Controls.Add(splitContainer1);
            Name = "Rota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rotas";
            WindowState = FormWindowState.Maximized;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webRota).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private ReaLTaiizor.Controls.MaterialButton btnViagem;
        private ReaLTaiizor.Controls.MaterialComboBox cboViagem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webRota;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtHoraChegada;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtHoraSaida;
        private DateTimePicker dataChegada;
        private DateTimePicker dataSaida;
        private ReaLTaiizor.Controls.BigLabel lblSaida;
        private ReaLTaiizor.Controls.BigLabel lblChegada;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
    }
}