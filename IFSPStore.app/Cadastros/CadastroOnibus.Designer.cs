﻿namespace IFSPStore.app.Cadastros
{
    partial class CadastroOnibus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroOnibus));
            txtPlaca = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            groupBox1 = new GroupBox();
            wifiNao = new RadioButton();
            wifiSim = new RadioButton();
            cboAssentos = new ReaLTaiizor.Controls.MaterialComboBox();
            txtModelo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(797, 329);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtModelo);
            tabPageCadastro.Controls.Add(cboAssentos);
            tabPageCadastro.Controls.Add(groupBox1);
            tabPageCadastro.Controls.Add(txtPlaca);
            tabPageCadastro.Size = new Size(789, 294);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPlaca, 0);
            tabPageCadastro.Controls.SetChildIndex(groupBox1, 0);
            tabPageCadastro.Controls.SetChildIndex(cboAssentos, 0);
            tabPageCadastro.Controls.SetChildIndex(txtModelo, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(789, 294);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(532, 243);
            btnCancelar.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(634, 243);
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
            // txtPlaca
            // 
            txtPlaca.AnimateReadOnly = false;
            txtPlaca.AutoCompleteMode = AutoCompleteMode.None;
            txtPlaca.AutoCompleteSource = AutoCompleteSource.None;
            txtPlaca.BackgroundImageLayout = ImageLayout.None;
            txtPlaca.CharacterCasing = CharacterCasing.Normal;
            txtPlaca.Depth = 0;
            txtPlaca.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPlaca.HideSelection = true;
            txtPlaca.Hint = "Placa";
            txtPlaca.LeadingIcon = null;
            txtPlaca.Location = new Point(16, 62);
            txtPlaca.MaxLength = 32767;
            txtPlaca.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.PasswordChar = '\0';
            txtPlaca.PrefixSuffixText = null;
            txtPlaca.ReadOnly = false;
            txtPlaca.RightToLeft = RightToLeft.No;
            txtPlaca.SelectedText = "";
            txtPlaca.SelectionLength = 0;
            txtPlaca.SelectionStart = 0;
            txtPlaca.ShortcutsEnabled = true;
            txtPlaca.Size = new Size(221, 48);
            txtPlaca.TabIndex = 0;
            txtPlaca.TabStop = false;
            txtPlaca.TextAlign = HorizontalAlignment.Left;
            txtPlaca.TrailingIcon = null;
            txtPlaca.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(wifiNao);
            groupBox1.Controls.Add(wifiSim);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(16, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 74);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Wifi";
            // 
            // wifiNao
            // 
            wifiNao.AutoSize = true;
            wifiNao.Location = new Point(128, 34);
            wifiNao.Name = "wifiNao";
            wifiNao.Size = new Size(70, 34);
            wifiNao.TabIndex = 1;
            wifiNao.Text = "Não";
            wifiNao.UseVisualStyleBackColor = true;
            // 
            // wifiSim
            // 
            wifiSim.AutoSize = true;
            wifiSim.Checked = true;
            wifiSim.Location = new Point(30, 34);
            wifiSim.Name = "wifiSim";
            wifiSim.Size = new Size(65, 34);
            wifiSim.TabIndex = 0;
            wifiSim.TabStop = true;
            wifiSim.Text = "Sim";
            wifiSim.UseVisualStyleBackColor = true;
            // 
            // cboAssentos
            // 
            cboAssentos.AutoResize = false;
            cboAssentos.BackColor = Color.FromArgb(255, 255, 255);
            cboAssentos.Depth = 0;
            cboAssentos.DrawMode = DrawMode.OwnerDrawVariable;
            cboAssentos.DropDownHeight = 174;
            cboAssentos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAssentos.DropDownWidth = 121;
            cboAssentos.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAssentos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAssentos.FormattingEnabled = true;
            cboAssentos.Hint = "Quantidade de Assentos";
            cboAssentos.IntegralHeight = false;
            cboAssentos.ItemHeight = 43;
            cboAssentos.Items.AddRange(new object[] { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50" });
            cboAssentos.Location = new Point(265, 149);
            cboAssentos.MaxDropDownItems = 4;
            cboAssentos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAssentos.Name = "cboAssentos";
            cboAssentos.Size = new Size(453, 49);
            cboAssentos.StartIndex = 0;
            cboAssentos.TabIndex = 3;
            // 
            // txtModelo
            // 
            txtModelo.AnimateReadOnly = false;
            txtModelo.AutoCompleteMode = AutoCompleteMode.None;
            txtModelo.AutoCompleteSource = AutoCompleteSource.None;
            txtModelo.BackgroundImageLayout = ImageLayout.None;
            txtModelo.CharacterCasing = CharacterCasing.Normal;
            txtModelo.Depth = 0;
            txtModelo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtModelo.HideSelection = true;
            txtModelo.Hint = "Modelo";
            txtModelo.LeadingIcon = null;
            txtModelo.Location = new Point(265, 62);
            txtModelo.MaxLength = 32767;
            txtModelo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtModelo.Name = "txtModelo";
            txtModelo.PasswordChar = '\0';
            txtModelo.PrefixSuffixText = null;
            txtModelo.ReadOnly = false;
            txtModelo.RightToLeft = RightToLeft.No;
            txtModelo.SelectedText = "";
            txtModelo.SelectionLength = 0;
            txtModelo.SelectionStart = 0;
            txtModelo.ShortcutsEnabled = true;
            txtModelo.Size = new Size(453, 48);
            txtModelo.TabIndex = 1;
            txtModelo.TabStop = false;
            txtModelo.TextAlign = HorizontalAlignment.Left;
            txtModelo.TrailingIcon = null;
            txtModelo.UseSystemPasswordChar = false;
            // 
            // CadastroOnibus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 395);
            Name = "CadastroOnibus";
            Text = "Cadastro de Ônibus";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPlaca;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialComboBox cboAssentos;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtModelo;
        private RadioButton wifiNao;
        private RadioButton wifiSim;
    }
}