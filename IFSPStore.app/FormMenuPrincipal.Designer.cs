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
            toolStripMenuItem3 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, rotasToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(3, 85);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(908, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cidadeToolStripMenuItem, toolStripMenuItem1, cidadeToolStripMenuItem1, toolStripMenuItem2, onibusToolStripMenuItem, viagemToolStripMenuItem, toolStripMenuItem3, reservaToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(162, 26);
            cidadeToolStripMenuItem.Text = "Passageiro";
            cidadeToolStripMenuItem.Click += cidadeToolStripMenuItem_Click;
            // 
            // reservaToolStripMenuItem
            // 
            reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            reservaToolStripMenuItem.Size = new Size(162, 26);
            reservaToolStripMenuItem.Text = "Reserva";
            reservaToolStripMenuItem.Click += reservaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(159, 6);
            // 
            // cidadeToolStripMenuItem1
            // 
            cidadeToolStripMenuItem1.Name = "cidadeToolStripMenuItem1";
            cidadeToolStripMenuItem1.Size = new Size(162, 26);
            cidadeToolStripMenuItem1.Text = "Cidade";
            cidadeToolStripMenuItem1.Click += cidadeToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(159, 6);
            // 
            // onibusToolStripMenuItem
            // 
            onibusToolStripMenuItem.Name = "onibusToolStripMenuItem";
            onibusToolStripMenuItem.Size = new Size(162, 26);
            onibusToolStripMenuItem.Text = "Onibus";
            onibusToolStripMenuItem.Click += onibusToolStripMenuItem_Click;
            // 
            // viagemToolStripMenuItem
            // 
            viagemToolStripMenuItem.Name = "viagemToolStripMenuItem";
            viagemToolStripMenuItem.Size = new Size(162, 26);
            viagemToolStripMenuItem.Text = "Viagem";
            viagemToolStripMenuItem.Click += viagemToolStripMenuItem_Click;
            // 
            // rotasToolStripMenuItem
            // 
            rotasToolStripMenuItem.Name = "rotasToolStripMenuItem";
            rotasToolStripMenuItem.Size = new Size(60, 24);
            rotasToolStripMenuItem.Text = "Rotas";
            rotasToolStripMenuItem.Click += rotasToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(159, 6);
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenuPrincipal";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IFSP Travel";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMenuPrincipal_FormClosing;
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
        private ToolStripSeparator toolStripMenuItem3;
    }
}