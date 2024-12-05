namespace IFSPStore.app
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cidadeToolStripMenuItem = new ToolStripMenuItem();
            reservaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            cidadeToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            onibusToolStripMenuItem = new ToolStripMenuItem();
            viagemToolStripMenuItem = new ToolStripMenuItem();
            rotasToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, rotasToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cidadeToolStripMenuItem, reservaToolStripMenuItem, toolStripMenuItem1, cidadeToolStripMenuItem1, toolStripMenuItem2, onibusToolStripMenuItem, viagemToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(180, 22);
            cidadeToolStripMenuItem.Text = "Passageiro";
            cidadeToolStripMenuItem.Click += cidadeToolStripMenuItem_Click;
            // 
            // reservaToolStripMenuItem
            // 
            reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            reservaToolStripMenuItem.Size = new Size(180, 22);
            reservaToolStripMenuItem.Text = "Reserva";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // cidadeToolStripMenuItem1
            // 
            cidadeToolStripMenuItem1.Name = "cidadeToolStripMenuItem1";
            cidadeToolStripMenuItem1.Size = new Size(180, 22);
            cidadeToolStripMenuItem1.Text = "Cidade";
            cidadeToolStripMenuItem1.Click += cidadeToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 6);
            // 
            // onibusToolStripMenuItem
            // 
            onibusToolStripMenuItem.Name = "onibusToolStripMenuItem";
            onibusToolStripMenuItem.Size = new Size(180, 22);
            onibusToolStripMenuItem.Text = "Onibus";
            onibusToolStripMenuItem.Click += onibusToolStripMenuItem_Click;
            // 
            // viagemToolStripMenuItem
            // 
            viagemToolStripMenuItem.Name = "viagemToolStripMenuItem";
            viagemToolStripMenuItem.Size = new Size(180, 22);
            viagemToolStripMenuItem.Text = "Viagem";
            viagemToolStripMenuItem.Click += viagemToolStripMenuItem_Click;
            // 
            // rotasToolStripMenuItem
            // 
            rotasToolStripMenuItem.Name = "rotasToolStripMenuItem";
            rotasToolStripMenuItem.Size = new Size(48, 20);
            rotasToolStripMenuItem.Text = "Rotas";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IFSP Travel";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem cidadeToolStripMenuItem;
        private ToolStripMenuItem reservaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem cidadeToolStripMenuItem1;
        private ToolStripMenuItem onibusToolStripMenuItem;
        private ToolStripMenuItem viagemToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem rotasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}