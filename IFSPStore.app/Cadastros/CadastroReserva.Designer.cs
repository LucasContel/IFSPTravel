﻿namespace IFSPStore.app.Cadastros
{
    partial class CadastroReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroReserva));
            tabPageAssento = new TabPage();
            splitContainer1 = new SplitContainer();
            tblPnl = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            btnCancelarAssento = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvarAssento = new ReaLTaiizor.Controls.MaterialButton();
            cboViagem = new ReaLTaiizor.Controls.MaterialComboBox();
            cboPassageiro = new ReaLTaiizor.Controls.MaterialComboBox();
            btnProximo = new ReaLTaiizor.Controls.MaterialButton();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageAssento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Controls.Add(tabPageAssento);
            tabControlCadastro.Location = new Point(0, 113);
            tabControlCadastro.Margin = new Padding(3, 4, 3, 4);
            tabControlCadastro.Size = new Size(1080, 540);
            tabControlCadastro.Controls.SetChildIndex(tabPageAssento, 0);
            tabControlCadastro.Controls.SetChildIndex(tabPageConsulta, 0);
            tabControlCadastro.Controls.SetChildIndex(tabPageCadastro, 0);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btnProximo);
            tabPageCadastro.Controls.Add(cboPassageiro);
            tabPageCadastro.Controls.Add(cboViagem);
            tabPageCadastro.Margin = new Padding(3, 4, 3, 4);
            tabPageCadastro.Padding = new Padding(3, 4, 3, 4);
            tabPageCadastro.Size = new Size(1072, 505);
            tabPageCadastro.Controls.SetChildIndex(cboViagem, 0);
            tabPageCadastro.Controls.SetChildIndex(cboPassageiro, 0);
            tabPageCadastro.Controls.SetChildIndex(btnProximo, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Margin = new Padding(3, 4, 3, 4);
            tabPageConsulta.Padding = new Padding(3, 4, 3, 4);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(443, 357);
            btnCancelar.Margin = new Padding(6, 7, 6, 7);
            btnCancelar.Size = new Size(110, 48);
            btnCancelar.TabIndex = 3;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Location = new Point(271, 357);
            btnSalvar.Margin = new Padding(6, 7, 6, 7);
            btnSalvar.Size = new Size(110, 48);
            btnSalvar.TabIndex = 4;
            btnSalvar.Visible = false;
            // 
            // imageList1
            // 
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            imageList1.Images.SetKeyName(2, "Seat - Icon.png");
            // 
            // tabPageAssento
            // 
            tabPageAssento.Controls.Add(splitContainer1);
            tabPageAssento.ImageKey = "Seat - Icon.png";
            tabPageAssento.Location = new Point(4, 31);
            tabPageAssento.Margin = new Padding(3, 4, 3, 4);
            tabPageAssento.Name = "tabPageAssento";
            tabPageAssento.Padding = new Padding(3, 4, 3, 4);
            tabPageAssento.Size = new Size(1072, 505);
            tabPageAssento.TabIndex = 2;
            tabPageAssento.Text = "Assento";
            tabPageAssento.UseVisualStyleBackColor = true;
            tabPageAssento.Enter += tabPageAssento_Enter;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 4);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tblPnl);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(btnCancelarAssento);
            splitContainer1.Panel2.Controls.Add(btnSalvarAssento);
            splitContainer1.Size = new Size(1066, 497);
            splitContainer1.SplitterDistance = 378;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // tblPnl
            // 
            tblPnl.BackgroundImage = (Image)resources.GetObject("tblPnl.BackgroundImage");
            tblPnl.BackgroundImageLayout = ImageLayout.Stretch;
            tblPnl.ColumnCount = 1;
            tblPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPnl.Dock = DockStyle.Fill;
            tblPnl.Location = new Point(0, 0);
            tblPnl.Margin = new Padding(3, 4, 3, 4);
            tblPnl.Name = "tblPnl";
            tblPnl.Padding = new Padding(57, 33, 29, 33);
            tblPnl.RowCount = 1;
            tblPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPnl.Size = new Size(1066, 378);
            tblPnl.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 29);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnCancelarAssento
            // 
            btnCancelarAssento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelarAssento.AutoSize = false;
            btnCancelarAssento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelarAssento.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelarAssento.Depth = 0;
            btnCancelarAssento.Font = new Font("Segoe UI", 9F);
            btnCancelarAssento.HighEmphasis = true;
            btnCancelarAssento.Icon = null;
            btnCancelarAssento.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelarAssento.Location = new Point(750, 52);
            btnCancelarAssento.Margin = new Padding(5, 8, 5, 8);
            btnCancelarAssento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelarAssento.Name = "btnCancelarAssento";
            btnCancelarAssento.NoAccentTextColor = Color.Empty;
            btnCancelarAssento.Size = new Size(107, 36);
            btnCancelarAssento.TabIndex = 1;
            btnCancelarAssento.Text = "Cancelar";
            btnCancelarAssento.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelarAssento.UseAccentColor = false;
            btnCancelarAssento.UseVisualStyleBackColor = true;
            btnCancelarAssento.Click += btnCancelarAssento_Click_1;
            // 
            // btnSalvarAssento
            // 
            btnSalvarAssento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvarAssento.AutoSize = false;
            btnSalvarAssento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvarAssento.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvarAssento.Depth = 0;
            btnSalvarAssento.Font = new Font("Segoe UI", 9F);
            btnSalvarAssento.HighEmphasis = true;
            btnSalvarAssento.Icon = null;
            btnSalvarAssento.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvarAssento.Location = new Point(898, 52);
            btnSalvarAssento.Margin = new Padding(5, 8, 5, 8);
            btnSalvarAssento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvarAssento.Name = "btnSalvarAssento";
            btnSalvarAssento.NoAccentTextColor = Color.Empty;
            btnSalvarAssento.Size = new Size(107, 36);
            btnSalvarAssento.TabIndex = 0;
            btnSalvarAssento.Text = "Salvar";
            btnSalvarAssento.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvarAssento.UseAccentColor = false;
            btnSalvarAssento.UseVisualStyleBackColor = true;
            btnSalvarAssento.Click += btnSalvarAssento_Click_1;
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
            cboViagem.Hint = "Viagem";
            cboViagem.IntegralHeight = false;
            cboViagem.ItemHeight = 43;
            cboViagem.Location = new Point(45, 92);
            cboViagem.Margin = new Padding(3, 4, 3, 4);
            cboViagem.MaxDropDownItems = 4;
            cboViagem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboViagem.Name = "cboViagem";
            cboViagem.Size = new Size(935, 49);
            cboViagem.StartIndex = 0;
            cboViagem.TabIndex = 0;
            // 
            // cboPassageiro
            // 
            cboPassageiro.AutoResize = false;
            cboPassageiro.BackColor = Color.FromArgb(255, 255, 255);
            cboPassageiro.Depth = 0;
            cboPassageiro.DrawMode = DrawMode.OwnerDrawVariable;
            cboPassageiro.DropDownHeight = 174;
            cboPassageiro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPassageiro.DropDownWidth = 121;
            cboPassageiro.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPassageiro.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPassageiro.FormattingEnabled = true;
            cboPassageiro.Hint = "Passageiro";
            cboPassageiro.IntegralHeight = false;
            cboPassageiro.ItemHeight = 43;
            cboPassageiro.Location = new Point(45, 212);
            cboPassageiro.Margin = new Padding(3, 4, 3, 4);
            cboPassageiro.MaxDropDownItems = 4;
            cboPassageiro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPassageiro.Name = "cboPassageiro";
            cboPassageiro.Size = new Size(935, 49);
            cboPassageiro.StartIndex = 0;
            cboPassageiro.TabIndex = 1;
            // 
            // btnProximo
            // 
            btnProximo.AutoSize = false;
            btnProximo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProximo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnProximo.Depth = 0;
            btnProximo.Font = new Font("Segoe UI", 9F);
            btnProximo.HighEmphasis = true;
            btnProximo.Icon = null;
            btnProximo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnProximo.Location = new Point(618, 357);
            btnProximo.Margin = new Padding(5, 8, 5, 8);
            btnProximo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnProximo.Name = "btnProximo";
            btnProximo.NoAccentTextColor = Color.Empty;
            btnProximo.Size = new Size(107, 36);
            btnProximo.TabIndex = 2;
            btnProximo.Text = "Próximo";
            btnProximo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProximo.UseAccentColor = false;
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // CadastroReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 657);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroReserva";
            Padding = new Padding(0, 113, 3, 4);
            Text = "Cadastro de Reserva";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageAssento.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageAssento;
        private ReaLTaiizor.Controls.MaterialComboBox cboPassageiro;
        private ReaLTaiizor.Controls.MaterialComboBox cboViagem;
        private ReaLTaiizor.Controls.MaterialButton btnProximo;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tblPnl;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialButton btnCancelarAssento;
        private ReaLTaiizor.Controls.MaterialButton btnSalvarAssento;
    }
}