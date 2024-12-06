namespace IFSPStore.app.Cadastros
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
            tblPnl = new TableLayoutPanel();
            cboViagem = new ReaLTaiizor.Controls.MaterialComboBox();
            cboPassageiro = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageAssento.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Controls.Add(tabPageAssento);
            tabControlCadastro.Size = new Size(846, 384);
            tabControlCadastro.Controls.SetChildIndex(tabPageAssento, 0);
            tabControlCadastro.Controls.SetChildIndex(tabPageConsulta, 0);
            tabControlCadastro.Controls.SetChildIndex(tabPageCadastro, 0);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboPassageiro);
            tabPageCadastro.Controls.Add(cboViagem);
            tabPageCadastro.Size = new Size(838, 349);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(cboViagem, 0);
            tabPageCadastro.Controls.SetChildIndex(cboPassageiro, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(504, 268);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(597, 268);
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
            tabPageAssento.Controls.Add(tblPnl);
            tabPageAssento.ImageKey = "Seat - Icon.png";
            tabPageAssento.Location = new Point(4, 31);
            tabPageAssento.Name = "tabPageAssento";
            tabPageAssento.Padding = new Padding(3);
            tabPageAssento.Size = new Size(838, 349);
            tabPageAssento.TabIndex = 2;
            tabPageAssento.Text = "Assento";
            tabPageAssento.UseVisualStyleBackColor = true;
            // 
            // tblPnl
            // 
            tblPnl.BackgroundImage = (Image)resources.GetObject("tblPnl.BackgroundImage");
            tblPnl.BackgroundImageLayout = ImageLayout.Stretch;
            tblPnl.ColumnCount = 1;
            tblPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPnl.Dock = DockStyle.Fill;
            tblPnl.Location = new Point(3, 3);
            tblPnl.Name = "tblPnl";
            tblPnl.Padding = new Padding(25);
            tblPnl.RowCount = 1;
            tblPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666718F));
            tblPnl.Size = new Size(832, 343);
            tblPnl.TabIndex = 0;
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
            cboViagem.Location = new Point(39, 69);
            cboViagem.MaxDropDownItems = 4;
            cboViagem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboViagem.Name = "cboViagem";
            cboViagem.Size = new Size(765, 49);
            cboViagem.StartIndex = 0;
            cboViagem.TabIndex = 2;
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
            cboPassageiro.Location = new Point(39, 159);
            cboPassageiro.MaxDropDownItems = 4;
            cboPassageiro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPassageiro.Name = "cboPassageiro";
            cboPassageiro.Size = new Size(765, 49);
            cboPassageiro.StartIndex = 0;
            cboPassageiro.TabIndex = 4;
            // 
            // CadastroReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 450);
            Name = "CadastroReserva";
            Text = "CadastroReserva";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageAssento.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageAssento;
        private TableLayoutPanel tblPnl;
        private ReaLTaiizor.Controls.MaterialComboBox cboPassageiro;
        private ReaLTaiizor.Controls.MaterialComboBox cboViagem;
    }
}