namespace Calculadora
{
    partial class FrCalculadoraV2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrCalculadoraV2));
            TxtResultado = new TextBox();
            Bzero = new Button();
            Bponto = new Button();
            Bigual = new Button();
            BSoma = new Button();
            BUm = new Button();
            BDois = new Button();
            BTrês = new Button();
            BQuatro = new Button();
            BCinco = new Button();
            Bseis = new Button();
            BSub = new Button();
            Bsete = new Button();
            Boito = new Button();
            Bnove = new Button();
            BMul = new Button();
            Bclean = new Button();
            BDiv = new Button();
            BBackSpace = new Button();
            LBLAutor = new Label();
            LBLOperacao = new Label();
            SuspendLayout();
            // 
            // TxtResultado
            // 
            TxtResultado.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtResultado.Location = new Point(12, 3);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.ReadOnly = true;
            TxtResultado.Size = new Size(310, 47);
            TxtResultado.TabIndex = 0;
            TxtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // Bzero
            // 
            Bzero.BackColor = SystemColors.ActiveCaption;
            Bzero.FlatStyle = FlatStyle.Popup;
            Bzero.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bzero.Location = new Point(12, 296);
            Bzero.Name = "Bzero";
            Bzero.Size = new Size(73, 54);
            Bzero.TabIndex = 1;
            Bzero.Text = "0";
            Bzero.UseVisualStyleBackColor = false;
            Bzero.Click += Bzero_Click;
            // 
            // Bponto
            // 
            Bponto.BackColor = SystemColors.ActiveCaption;
            Bponto.FlatStyle = FlatStyle.Popup;
            Bponto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bponto.Location = new Point(91, 296);
            Bponto.Name = "Bponto";
            Bponto.Size = new Size(73, 54);
            Bponto.TabIndex = 2;
            Bponto.Text = ",";
            Bponto.UseVisualStyleBackColor = false;
            Bponto.Click += Bponto_Click;
            // 
            // Bigual
            // 
            Bigual.BackColor = SystemColors.ActiveCaption;
            Bigual.FlatStyle = FlatStyle.Popup;
            Bigual.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bigual.Location = new Point(170, 296);
            Bigual.Name = "Bigual";
            Bigual.Size = new Size(73, 54);
            Bigual.TabIndex = 3;
            Bigual.Text = "=";
            Bigual.UseVisualStyleBackColor = false;
            Bigual.Click += Bigual_Click;
            // 
            // BSoma
            // 
            BSoma.BackColor = SystemColors.ActiveCaption;
            BSoma.FlatStyle = FlatStyle.Popup;
            BSoma.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BSoma.Location = new Point(249, 236);
            BSoma.Name = "BSoma";
            BSoma.Size = new Size(73, 114);
            BSoma.TabIndex = 4;
            BSoma.Text = "+";
            BSoma.UseVisualStyleBackColor = false;
            BSoma.Click += BSoma_Click;
            // 
            // BUm
            // 
            BUm.BackColor = SystemColors.ActiveCaption;
            BUm.FlatStyle = FlatStyle.Popup;
            BUm.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUm.Location = new Point(12, 236);
            BUm.Name = "BUm";
            BUm.Size = new Size(73, 54);
            BUm.TabIndex = 5;
            BUm.Text = "1";
            BUm.UseVisualStyleBackColor = false;
            BUm.Click += BUm_Click;
            // 
            // BDois
            // 
            BDois.BackColor = SystemColors.ActiveCaption;
            BDois.FlatStyle = FlatStyle.Popup;
            BDois.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BDois.Location = new Point(91, 236);
            BDois.Name = "BDois";
            BDois.Size = new Size(73, 54);
            BDois.TabIndex = 6;
            BDois.Text = "2";
            BDois.UseVisualStyleBackColor = false;
            BDois.Click += BDois_Click;
            // 
            // BTrês
            // 
            BTrês.BackColor = SystemColors.ActiveCaption;
            BTrês.FlatStyle = FlatStyle.Popup;
            BTrês.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTrês.Location = new Point(170, 236);
            BTrês.Name = "BTrês";
            BTrês.Size = new Size(73, 54);
            BTrês.TabIndex = 7;
            BTrês.Text = "3";
            BTrês.UseVisualStyleBackColor = false;
            BTrês.Click += BTrês_Click;
            // 
            // BQuatro
            // 
            BQuatro.BackColor = SystemColors.ActiveCaption;
            BQuatro.FlatStyle = FlatStyle.Popup;
            BQuatro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BQuatro.Location = new Point(12, 176);
            BQuatro.Name = "BQuatro";
            BQuatro.Size = new Size(73, 54);
            BQuatro.TabIndex = 8;
            BQuatro.Text = "4";
            BQuatro.UseVisualStyleBackColor = false;
            BQuatro.Click += BQuatro_Click;
            // 
            // BCinco
            // 
            BCinco.BackColor = SystemColors.ActiveCaption;
            BCinco.FlatStyle = FlatStyle.Popup;
            BCinco.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCinco.Location = new Point(91, 176);
            BCinco.Name = "BCinco";
            BCinco.Size = new Size(73, 54);
            BCinco.TabIndex = 9;
            BCinco.Text = "5";
            BCinco.UseVisualStyleBackColor = false;
            BCinco.Click += BCinco_Click;
            // 
            // Bseis
            // 
            Bseis.BackColor = SystemColors.ActiveCaption;
            Bseis.FlatStyle = FlatStyle.Popup;
            Bseis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bseis.Location = new Point(170, 176);
            Bseis.Name = "Bseis";
            Bseis.Size = new Size(73, 54);
            Bseis.TabIndex = 10;
            Bseis.Text = "6";
            Bseis.UseVisualStyleBackColor = false;
            Bseis.Click += Bseis_Click;
            // 
            // BSub
            // 
            BSub.BackColor = SystemColors.ActiveCaption;
            BSub.FlatStyle = FlatStyle.Popup;
            BSub.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BSub.Location = new Point(249, 176);
            BSub.Name = "BSub";
            BSub.Size = new Size(73, 54);
            BSub.TabIndex = 11;
            BSub.Text = "-";
            BSub.UseVisualStyleBackColor = false;
            BSub.Click += BSub_Click;
            // 
            // Bsete
            // 
            Bsete.BackColor = SystemColors.ActiveCaption;
            Bsete.FlatStyle = FlatStyle.Popup;
            Bsete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bsete.Location = new Point(12, 116);
            Bsete.Name = "Bsete";
            Bsete.Size = new Size(73, 54);
            Bsete.TabIndex = 12;
            Bsete.Text = "7";
            Bsete.UseVisualStyleBackColor = false;
            Bsete.Click += Bsete_Click;
            // 
            // Boito
            // 
            Boito.BackColor = SystemColors.ActiveCaption;
            Boito.FlatStyle = FlatStyle.Popup;
            Boito.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Boito.Location = new Point(91, 116);
            Boito.Name = "Boito";
            Boito.Size = new Size(73, 54);
            Boito.TabIndex = 13;
            Boito.Text = "8";
            Boito.UseVisualStyleBackColor = false;
            Boito.Click += Boito_Click;
            // 
            // Bnove
            // 
            Bnove.BackColor = SystemColors.ActiveCaption;
            Bnove.FlatStyle = FlatStyle.Popup;
            Bnove.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bnove.Location = new Point(170, 116);
            Bnove.Name = "Bnove";
            Bnove.Size = new Size(73, 54);
            Bnove.TabIndex = 14;
            Bnove.Text = "9";
            Bnove.UseVisualStyleBackColor = false;
            Bnove.Click += Bnove_Click;
            // 
            // BMul
            // 
            BMul.BackColor = SystemColors.ActiveCaption;
            BMul.FlatStyle = FlatStyle.Popup;
            BMul.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BMul.Location = new Point(249, 116);
            BMul.Name = "BMul";
            BMul.Size = new Size(73, 54);
            BMul.TabIndex = 15;
            BMul.Text = "*";
            BMul.UseVisualStyleBackColor = false;
            BMul.Click += BMul_Click;
            // 
            // Bclean
            // 
            Bclean.BackColor = SystemColors.ActiveCaption;
            Bclean.FlatStyle = FlatStyle.Popup;
            Bclean.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bclean.Location = new Point(170, 56);
            Bclean.Name = "Bclean";
            Bclean.Size = new Size(73, 54);
            Bclean.TabIndex = 16;
            Bclean.Text = "C";
            Bclean.UseVisualStyleBackColor = false;
            Bclean.Click += Bclean_Click;
            // 
            // BDiv
            // 
            BDiv.BackColor = SystemColors.ActiveCaption;
            BDiv.FlatStyle = FlatStyle.Popup;
            BDiv.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BDiv.Location = new Point(249, 56);
            BDiv.Name = "BDiv";
            BDiv.Size = new Size(73, 54);
            BDiv.TabIndex = 17;
            BDiv.Text = "/";
            BDiv.UseVisualStyleBackColor = false;
            BDiv.Click += BDiv_Click;
            // 
            // BBackSpace
            // 
            BBackSpace.BackColor = SystemColors.ActiveCaption;
            BBackSpace.FlatStyle = FlatStyle.Popup;
            BBackSpace.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BBackSpace.Location = new Point(12, 56);
            BBackSpace.Name = "BBackSpace";
            BBackSpace.Size = new Size(152, 54);
            BBackSpace.TabIndex = 18;
            BBackSpace.Text = "←";
            BBackSpace.UseVisualStyleBackColor = false;
            BBackSpace.Click += BBackSpace_Click;
            // 
            // LBLAutor
            // 
            LBLAutor.AutoSize = true;
            LBLAutor.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBLAutor.Location = new Point(1, 353);
            LBLAutor.Name = "LBLAutor";
            LBLAutor.Size = new Size(331, 50);
            LBLAutor.TabIndex = 19;
            LBLAutor.Text = "DevJoel PT 2024 ©";
            // 
            // LBLOperacao
            // 
            LBLOperacao.AutoSize = true;
            LBLOperacao.Location = new Point(16, 7);
            LBLOperacao.Name = "LBLOperacao";
            LBLOperacao.Size = new Size(0, 20);
            LBLOperacao.TabIndex = 20;
            // 
            // FrCalculadoraV2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(330, 405);
            Controls.Add(LBLOperacao);
            Controls.Add(LBLAutor);
            Controls.Add(BBackSpace);
            Controls.Add(BDiv);
            Controls.Add(Bclean);
            Controls.Add(BMul);
            Controls.Add(Bnove);
            Controls.Add(Boito);
            Controls.Add(Bsete);
            Controls.Add(BSub);
            Controls.Add(Bseis);
            Controls.Add(BCinco);
            Controls.Add(BQuatro);
            Controls.Add(BTrês);
            Controls.Add(BDois);
            Controls.Add(BUm);
            Controls.Add(BSoma);
            Controls.Add(Bigual);
            Controls.Add(Bponto);
            Controls.Add(Bzero);
            Controls.Add(TxtResultado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrCalculadoraV2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora V2 DevJoelPT 2024©";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtResultado;
        private Button Bzero;
        private Button Bponto;
        private Button Bigual;
        private Button BSoma;
        private Button BUm;
        private Button BDois;
        private Button BTrês;
        private Button BQuatro;
        private Button BCinco;
        private Button Bseis;
        private Button BSub;
        private Button Bsete;
        private Button Boito;
        private Button Bnove;
        private Button BMul;
        private Button Bclean;
        private Button BDiv;
        private Button BBackSpace;
        private Label LBLAutor;
        private Label LBLOperacao;
    }
}
