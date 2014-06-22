﻿namespace CudaProfitCalc
{
    partial class CudaProfitCalc
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CudaProfitCalc));
            this.grpHashrates = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtJane13 = new System.Windows.Forms.TextBox();
            this.lblJane13 = new System.Windows.Forms.Label();
            this.txtJane15 = new System.Windows.Forms.TextBox();
            this.lblJane15 = new System.Windows.Forms.Label();
            this.txtScryptN = new System.Windows.Forms.TextBox();
            this.lblScryptN = new System.Windows.Forms.Label();
            this.txtHefty = new System.Windows.Forms.TextBox();
            this.lblHefty = new System.Windows.Forms.Label();
            this.txtX13 = new System.Windows.Forms.TextBox();
            this.lblX13 = new System.Windows.Forms.Label();
            this.txtX11 = new System.Windows.Forms.TextBox();
            this.lblX11 = new System.Windows.Forms.Label();
            this.txtScrypt = new System.Windows.Forms.TextBox();
            this.lblScrypt = new System.Windows.Forms.Label();
            this.txtQuark = new System.Windows.Forms.TextBox();
            this.lblQuark = new System.Windows.Forms.Label();
            this.txtNist5 = new System.Windows.Forms.TextBox();
            this.lblNist5 = new System.Windows.Forms.Label();
            this.txtJackpot = new System.Windows.Forms.TextBox();
            this.lblJha = new System.Windows.Forms.Label();
            this.txtKeccak = new System.Windows.Forms.TextBox();
            this.lblKeccak = new System.Windows.Forms.Label();
            this.txtFugue = new System.Windows.Forms.TextBox();
            this.lblFugue = new System.Windows.Forms.Label();
            this.txtMyrGroestl = new System.Windows.Forms.TextBox();
            this.lblMyrGroestl = new System.Windows.Forms.Label();
            this.txtGroestl = new System.Windows.Forms.TextBox();
            this.lblGroestl = new System.Windows.Forms.Label();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.ctxtStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmResultsToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHashratesToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.grpApiControl = new System.Windows.Forms.GroupBox();
            this.chkPoloniex = new System.Windows.Forms.CheckBox();
            this.chkCryptsy = new System.Windows.Forms.CheckBox();
            this.chkMintpal = new System.Windows.Forms.CheckBox();
            this.chkBittrex = new System.Windows.Forms.CheckBox();
            this.nudPoolpicker = new System.Windows.Forms.NumericUpDown();
            this.chkPoolpicker = new System.Windows.Forms.CheckBox();
            this.chkNiceHash = new System.Windows.Forms.CheckBox();
            this.stStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsProgressText = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpGeneralCoinInfo = new System.Windows.Forms.GroupBox();
            this.txtCointweakApiKey = new System.Windows.Forms.TextBox();
            this.chkWhattomine = new System.Windows.Forms.CheckBox();
            this.txtCoinwarzApiKey = new System.Windows.Forms.TextBox();
            this.chkCointweak = new System.Windows.Forms.CheckBox();
            this.chkCoinwarz = new System.Windows.Forms.CheckBox();
            this.grpMisc = new System.Windows.Forms.GroupBox();
            this.cbbFiat = new System.Windows.Forms.ComboBox();
            this.chkCoindesk = new System.Windows.Forms.CheckBox();
            this.chkWeight = new System.Windows.Forms.CheckBox();
            this.chkShowOnlyHealthy = new System.Windows.Forms.CheckBox();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoinName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Algo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsdPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EurPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbpPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CnyPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtcPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoinsPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestExchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestExchangePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExchangeVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpHashrates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.ctxtStrip.SuspendLayout();
            this.grpApiControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoolpicker)).BeginInit();
            this.stStatusStrip.SuspendLayout();
            this.grpGeneralCoinInfo.SuspendLayout();
            this.grpMisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHashrates
            // 
            this.grpHashrates.Controls.Add(this.label1);
            this.grpHashrates.Controls.Add(this.nudAmount);
            this.grpHashrates.Controls.Add(this.btnCalc);
            this.grpHashrates.Controls.Add(this.txtJane13);
            this.grpHashrates.Controls.Add(this.lblJane13);
            this.grpHashrates.Controls.Add(this.txtJane15);
            this.grpHashrates.Controls.Add(this.lblJane15);
            this.grpHashrates.Controls.Add(this.txtScryptN);
            this.grpHashrates.Controls.Add(this.lblScryptN);
            this.grpHashrates.Controls.Add(this.txtHefty);
            this.grpHashrates.Controls.Add(this.lblHefty);
            this.grpHashrates.Controls.Add(this.txtX13);
            this.grpHashrates.Controls.Add(this.lblX13);
            this.grpHashrates.Controls.Add(this.txtX11);
            this.grpHashrates.Controls.Add(this.lblX11);
            this.grpHashrates.Controls.Add(this.txtScrypt);
            this.grpHashrates.Controls.Add(this.lblScrypt);
            this.grpHashrates.Controls.Add(this.txtQuark);
            this.grpHashrates.Controls.Add(this.lblQuark);
            this.grpHashrates.Controls.Add(this.txtNist5);
            this.grpHashrates.Controls.Add(this.lblNist5);
            this.grpHashrates.Controls.Add(this.txtJackpot);
            this.grpHashrates.Controls.Add(this.lblJha);
            this.grpHashrates.Controls.Add(this.txtKeccak);
            this.grpHashrates.Controls.Add(this.lblKeccak);
            this.grpHashrates.Controls.Add(this.txtFugue);
            this.grpHashrates.Controls.Add(this.lblFugue);
            this.grpHashrates.Controls.Add(this.txtMyrGroestl);
            this.grpHashrates.Controls.Add(this.lblMyrGroestl);
            this.grpHashrates.Controls.Add(this.txtGroestl);
            this.grpHashrates.Controls.Add(this.lblGroestl);
            this.grpHashrates.Location = new System.Drawing.Point(12, 100);
            this.grpHashrates.Name = "grpHashrates";
            this.grpHashrates.Size = new System.Drawing.Size(1125, 105);
            this.grpHashrates.TabIndex = 0;
            this.grpHashrates.TabStop = false;
            this.grpHashrates.Text = "Hashrates (in MH/s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(830, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "X";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(844, 72);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(38, 20);
            this.nudAmount.TabIndex = 31;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(912, 71);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(80, 23);
            this.btnCalc.TabIndex = 26;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtJane13
            // 
            this.txtJane13.Location = new System.Drawing.Point(912, 45);
            this.txtJane13.Name = "txtJane13";
            this.txtJane13.Size = new System.Drawing.Size(80, 20);
            this.txtJane13.TabIndex = 30;
            this.txtJane13.Text = "0.0095";
            // 
            // lblJane13
            // 
            this.lblJane13.AutoSize = true;
            this.lblJane13.Location = new System.Drawing.Point(830, 48);
            this.lblJane13.Name = "lblJane13";
            this.lblJane13.Size = new System.Drawing.Size(62, 13);
            this.lblJane13.TabIndex = 29;
            this.lblJane13.Text = "Jane(Nf13):";
            // 
            // txtJane15
            // 
            this.txtJane15.Location = new System.Drawing.Point(912, 19);
            this.txtJane15.Name = "txtJane15";
            this.txtJane15.Size = new System.Drawing.Size(80, 20);
            this.txtJane15.TabIndex = 28;
            this.txtJane15.Text = "0.0009";
            // 
            // lblJane15
            // 
            this.lblJane15.AutoSize = true;
            this.lblJane15.Location = new System.Drawing.Point(830, 22);
            this.lblJane15.Name = "lblJane15";
            this.lblJane15.Size = new System.Drawing.Size(59, 13);
            this.lblJane15.TabIndex = 27;
            this.lblJane15.Text = "Jane(Nf15)";
            // 
            // txtScryptN
            // 
            this.txtScryptN.Location = new System.Drawing.Point(706, 71);
            this.txtScryptN.Name = "txtScryptN";
            this.txtScryptN.Size = new System.Drawing.Size(80, 20);
            this.txtScryptN.TabIndex = 25;
            this.txtScryptN.Text = "0.14";
            // 
            // lblScryptN
            // 
            this.lblScryptN.AutoSize = true;
            this.lblScryptN.Location = new System.Drawing.Point(624, 74);
            this.lblScryptN.Name = "lblScryptN";
            this.lblScryptN.Size = new System.Drawing.Size(51, 13);
            this.lblScryptN.TabIndex = 24;
            this.lblScryptN.Text = "Scrypt-N:";
            // 
            // txtHefty
            // 
            this.txtHefty.Location = new System.Drawing.Point(294, 71);
            this.txtHefty.Name = "txtHefty";
            this.txtHefty.Size = new System.Drawing.Size(80, 20);
            this.txtHefty.TabIndex = 14;
            this.txtHefty.Text = "13.1";
            // 
            // lblHefty
            // 
            this.lblHefty.AutoSize = true;
            this.lblHefty.Location = new System.Drawing.Point(212, 74);
            this.lblHefty.Name = "lblHefty";
            this.lblHefty.Size = new System.Drawing.Size(66, 13);
            this.lblHefty.TabIndex = 22;
            this.lblHefty.Text = "Hefty (HVC):";
            // 
            // txtX13
            // 
            this.txtX13.Location = new System.Drawing.Point(500, 45);
            this.txtX13.Name = "txtX13";
            this.txtX13.Size = new System.Drawing.Size(80, 20);
            this.txtX13.TabIndex = 21;
            this.txtX13.Text = "2";
            // 
            // lblX13
            // 
            this.lblX13.AutoSize = true;
            this.lblX13.Location = new System.Drawing.Point(418, 48);
            this.lblX13.Name = "lblX13";
            this.lblX13.Size = new System.Drawing.Size(29, 13);
            this.lblX13.TabIndex = 20;
            this.lblX13.Text = "X13:";
            // 
            // txtX11
            // 
            this.txtX11.Location = new System.Drawing.Point(500, 19);
            this.txtX11.Name = "txtX11";
            this.txtX11.Size = new System.Drawing.Size(80, 20);
            this.txtX11.TabIndex = 19;
            this.txtX11.Text = "2.6";
            // 
            // lblX11
            // 
            this.lblX11.AutoSize = true;
            this.lblX11.Location = new System.Drawing.Point(418, 22);
            this.lblX11.Name = "lblX11";
            this.lblX11.Size = new System.Drawing.Size(29, 13);
            this.lblX11.TabIndex = 18;
            this.lblX11.Text = "X11:";
            // 
            // txtScrypt
            // 
            this.txtScrypt.Location = new System.Drawing.Point(706, 45);
            this.txtScrypt.Name = "txtScrypt";
            this.txtScrypt.Size = new System.Drawing.Size(80, 20);
            this.txtScrypt.TabIndex = 16;
            this.txtScrypt.Text = "0.28";
            // 
            // lblScrypt
            // 
            this.lblScrypt.AutoSize = true;
            this.lblScrypt.Location = new System.Drawing.Point(624, 48);
            this.lblScrypt.Name = "lblScrypt";
            this.lblScrypt.Size = new System.Drawing.Size(40, 13);
            this.lblScrypt.TabIndex = 15;
            this.lblScrypt.Text = "Scrypt:";
            // 
            // txtQuark
            // 
            this.txtQuark.Location = new System.Drawing.Point(500, 71);
            this.txtQuark.Name = "txtQuark";
            this.txtQuark.Size = new System.Drawing.Size(80, 20);
            this.txtQuark.TabIndex = 23;
            this.txtQuark.Text = "4.5";
            // 
            // lblQuark
            // 
            this.lblQuark.AutoSize = true;
            this.lblQuark.Location = new System.Drawing.Point(418, 74);
            this.lblQuark.Name = "lblQuark";
            this.lblQuark.Size = new System.Drawing.Size(39, 13);
            this.lblQuark.TabIndex = 13;
            this.lblQuark.Text = "Quark:";
            // 
            // txtNist5
            // 
            this.txtNist5.Location = new System.Drawing.Point(294, 45);
            this.txtNist5.Name = "txtNist5";
            this.txtNist5.Size = new System.Drawing.Size(80, 20);
            this.txtNist5.TabIndex = 12;
            this.txtNist5.Text = "8.4";
            // 
            // lblNist5
            // 
            this.lblNist5.AutoSize = true;
            this.lblNist5.Location = new System.Drawing.Point(212, 48);
            this.lblNist5.Name = "lblNist5";
            this.lblNist5.Size = new System.Drawing.Size(71, 13);
            this.lblNist5.TabIndex = 11;
            this.lblNist5.Text = "NIST5 (TAC):";
            // 
            // txtJackpot
            // 
            this.txtJackpot.Location = new System.Drawing.Point(294, 19);
            this.txtJackpot.Name = "txtJackpot";
            this.txtJackpot.Size = new System.Drawing.Size(80, 20);
            this.txtJackpot.TabIndex = 10;
            this.txtJackpot.Text = "5.6";
            // 
            // lblJha
            // 
            this.lblJha.AutoSize = true;
            this.lblJha.Location = new System.Drawing.Point(212, 22);
            this.lblJha.Name = "lblJha";
            this.lblJha.Size = new System.Drawing.Size(58, 13);
            this.lblJha.TabIndex = 9;
            this.lblJha.Text = "JHA (JPC):";
            // 
            // txtKeccak
            // 
            this.txtKeccak.Location = new System.Drawing.Point(706, 19);
            this.txtKeccak.Name = "txtKeccak";
            this.txtKeccak.Size = new System.Drawing.Size(80, 20);
            this.txtKeccak.TabIndex = 7;
            this.txtKeccak.Text = "163.1";
            // 
            // lblKeccak
            // 
            this.lblKeccak.AutoSize = true;
            this.lblKeccak.Location = new System.Drawing.Point(624, 22);
            this.lblKeccak.Name = "lblKeccak";
            this.lblKeccak.Size = new System.Drawing.Size(44, 13);
            this.lblKeccak.TabIndex = 6;
            this.lblKeccak.Text = "Keccak";
            // 
            // txtFugue
            // 
            this.txtFugue.Location = new System.Drawing.Point(88, 71);
            this.txtFugue.Name = "txtFugue";
            this.txtFugue.Size = new System.Drawing.Size(80, 20);
            this.txtFugue.TabIndex = 5;
            this.txtFugue.Text = "93.9";
            // 
            // lblFugue
            // 
            this.lblFugue.AutoSize = true;
            this.lblFugue.Location = new System.Drawing.Point(6, 74);
            this.lblFugue.Name = "lblFugue";
            this.lblFugue.Size = new System.Drawing.Size(58, 13);
            this.lblFugue.TabIndex = 4;
            this.lblFugue.Text = "Fugue256:";
            // 
            // txtMyrGroestl
            // 
            this.txtMyrGroestl.Location = new System.Drawing.Point(88, 45);
            this.txtMyrGroestl.Name = "txtMyrGroestl";
            this.txtMyrGroestl.Size = new System.Drawing.Size(80, 20);
            this.txtMyrGroestl.TabIndex = 3;
            this.txtMyrGroestl.Text = "12.9";
            // 
            // lblMyrGroestl
            // 
            this.lblMyrGroestl.AutoSize = true;
            this.lblMyrGroestl.Location = new System.Drawing.Point(6, 48);
            this.lblMyrGroestl.Name = "lblMyrGroestl";
            this.lblMyrGroestl.Size = new System.Drawing.Size(63, 13);
            this.lblMyrGroestl.TabIndex = 2;
            this.lblMyrGroestl.Text = "Myr-Groestl:";
            // 
            // txtGroestl
            // 
            this.txtGroestl.Location = new System.Drawing.Point(88, 19);
            this.txtGroestl.Name = "txtGroestl";
            this.txtGroestl.Size = new System.Drawing.Size(80, 20);
            this.txtGroestl.TabIndex = 1;
            this.txtGroestl.Text = "7.7";
            // 
            // lblGroestl
            // 
            this.lblGroestl.AutoSize = true;
            this.lblGroestl.Location = new System.Drawing.Point(6, 22);
            this.lblGroestl.Name = "lblGroestl";
            this.lblGroestl.Size = new System.Drawing.Size(43, 13);
            this.lblGroestl.TabIndex = 0;
            this.lblGroestl.Text = "Groestl:";
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tag,
            this.CoinName,
            this.Algo,
            this.UsdPerDay,
            this.EurPerDay,
            this.GbpPerDay,
            this.CnyPerDay,
            this.BtcPerDay,
            this.CoinsPerDay,
            this.BestExchange,
            this.BestExchangePrice,
            this.ExchangeVolume,
            this.WeightedPrice,
            this.TotalVolume,
            this.Difficulty,
            this.BlockReward});
            this.dgView.ContextMenuStrip = this.ctxtStrip;
            this.dgView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgView.Location = new System.Drawing.Point(12, 211);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgView.Size = new System.Drawing.Size(1124, 351);
            this.dgView.TabIndex = 1;
            // 
            // ctxtStrip
            // 
            this.ctxtStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmResultsToClipboard,
            this.tsmHashratesToClipboard});
            this.ctxtStrip.Name = "ctxtStrip";
            this.ctxtStrip.Size = new System.Drawing.Size(156, 48);
            // 
            // tsmResultsToClipboard
            // 
            this.tsmResultsToClipboard.Name = "tsmResultsToClipboard";
            this.tsmResultsToClipboard.Size = new System.Drawing.Size(155, 22);
            this.tsmResultsToClipboard.Text = "Copy all results";
            this.tsmResultsToClipboard.Click += new System.EventHandler(this.tsmResultsToClipboard_Click);
            // 
            // tsmHashratesToClipboard
            // 
            this.tsmHashratesToClipboard.Name = "tsmHashratesToClipboard";
            this.tsmHashratesToClipboard.Size = new System.Drawing.Size(155, 22);
            this.tsmHashratesToClipboard.Text = "Copy hashrates";
            this.tsmHashratesToClipboard.Click += new System.EventHandler(this.tsmHashratesToClipboard_Click);
            // 
            // grpApiControl
            // 
            this.grpApiControl.Controls.Add(this.chkPoloniex);
            this.grpApiControl.Controls.Add(this.chkCryptsy);
            this.grpApiControl.Controls.Add(this.chkMintpal);
            this.grpApiControl.Controls.Add(this.chkBittrex);
            this.grpApiControl.Location = new System.Drawing.Point(12, 12);
            this.grpApiControl.Name = "grpApiControl";
            this.grpApiControl.Size = new System.Drawing.Size(199, 88);
            this.grpApiControl.TabIndex = 2;
            this.grpApiControl.TabStop = false;
            this.grpApiControl.Text = "Market APIs";
            // 
            // chkPoloniex
            // 
            this.chkPoloniex.AutoSize = true;
            this.chkPoloniex.Checked = true;
            this.chkPoloniex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPoloniex.Location = new System.Drawing.Point(106, 19);
            this.chkPoloniex.Name = "chkPoloniex";
            this.chkPoloniex.Size = new System.Drawing.Size(88, 17);
            this.chkPoloniex.TabIndex = 3;
            this.chkPoloniex.Text = "Use Poloniex";
            this.chkPoloniex.UseVisualStyleBackColor = true;
            // 
            // chkCryptsy
            // 
            this.chkCryptsy.AutoSize = true;
            this.chkCryptsy.Checked = true;
            this.chkCryptsy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCryptsy.Location = new System.Drawing.Point(6, 65);
            this.chkCryptsy.Name = "chkCryptsy";
            this.chkCryptsy.Size = new System.Drawing.Size(82, 17);
            this.chkCryptsy.TabIndex = 2;
            this.chkCryptsy.Text = "Use Cryptsy";
            this.chkCryptsy.UseVisualStyleBackColor = true;
            // 
            // chkMintpal
            // 
            this.chkMintpal.AutoSize = true;
            this.chkMintpal.Checked = true;
            this.chkMintpal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMintpal.Location = new System.Drawing.Point(6, 42);
            this.chkMintpal.Name = "chkMintpal";
            this.chkMintpal.Size = new System.Drawing.Size(82, 17);
            this.chkMintpal.TabIndex = 1;
            this.chkMintpal.Text = "Use Mintpal";
            this.chkMintpal.UseVisualStyleBackColor = true;
            // 
            // chkBittrex
            // 
            this.chkBittrex.AutoSize = true;
            this.chkBittrex.Checked = true;
            this.chkBittrex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBittrex.Location = new System.Drawing.Point(6, 19);
            this.chkBittrex.Name = "chkBittrex";
            this.chkBittrex.Size = new System.Drawing.Size(77, 17);
            this.chkBittrex.TabIndex = 0;
            this.chkBittrex.Text = "Use Bittrex";
            this.chkBittrex.UseVisualStyleBackColor = true;
            // 
            // nudPoolpicker
            // 
            this.nudPoolpicker.Location = new System.Drawing.Point(178, 63);
            this.nudPoolpicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPoolpicker.Name = "nudPoolpicker";
            this.nudPoolpicker.Size = new System.Drawing.Size(38, 20);
            this.nudPoolpicker.TabIndex = 33;
            this.nudPoolpicker.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // chkPoolpicker
            // 
            this.chkPoolpicker.AutoSize = true;
            this.chkPoolpicker.Checked = true;
            this.chkPoolpicker.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPoolpicker.Location = new System.Drawing.Point(6, 65);
            this.chkPoolpicker.Name = "chkPoolpicker";
            this.chkPoolpicker.Size = new System.Drawing.Size(246, 17);
            this.chkPoolpicker.TabIndex = 33;
            this.chkPoolpicker.Text = "Use PoolPicker, averaging over               days.";
            this.chkPoolpicker.UseVisualStyleBackColor = true;
            this.chkPoolpicker.CheckedChanged += new System.EventHandler(this.chkPoolpicker_CheckedChanged);
            // 
            // chkNiceHash
            // 
            this.chkNiceHash.AutoSize = true;
            this.chkNiceHash.Checked = true;
            this.chkNiceHash.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNiceHash.Location = new System.Drawing.Point(6, 42);
            this.chkNiceHash.Name = "chkNiceHash";
            this.chkNiceHash.Size = new System.Drawing.Size(156, 17);
            this.chkNiceHash.TabIndex = 31;
            this.chkNiceHash.Text = "Get actual NiceHash prices";
            this.chkNiceHash.UseVisualStyleBackColor = true;
            // 
            // stStatusStrip
            // 
            this.stStatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.stStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgressText,
            this.tsProgress,
            this.tsStatus});
            this.stStatusStrip.Location = new System.Drawing.Point(0, 569);
            this.stStatusStrip.Name = "stStatusStrip";
            this.stStatusStrip.Size = new System.Drawing.Size(1148, 22);
            this.stStatusStrip.SizingGrip = false;
            this.stStatusStrip.TabIndex = 3;
            this.stStatusStrip.Text = "Status Striper";
            // 
            // tsProgressText
            // 
            this.tsProgressText.Name = "tsProgressText";
            this.tsProgressText.Size = new System.Drawing.Size(55, 17);
            this.tsProgressText.Text = "Progress:";
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(96, 17);
            this.tsStatus.Text = "Ready for launch";
            // 
            // grpGeneralCoinInfo
            // 
            this.grpGeneralCoinInfo.Controls.Add(this.txtCointweakApiKey);
            this.grpGeneralCoinInfo.Controls.Add(this.chkWhattomine);
            this.grpGeneralCoinInfo.Controls.Add(this.txtCoinwarzApiKey);
            this.grpGeneralCoinInfo.Controls.Add(this.chkCointweak);
            this.grpGeneralCoinInfo.Controls.Add(this.chkCoinwarz);
            this.grpGeneralCoinInfo.Location = new System.Drawing.Point(217, 12);
            this.grpGeneralCoinInfo.Name = "grpGeneralCoinInfo";
            this.grpGeneralCoinInfo.Size = new System.Drawing.Size(470, 88);
            this.grpGeneralCoinInfo.TabIndex = 4;
            this.grpGeneralCoinInfo.TabStop = false;
            this.grpGeneralCoinInfo.Text = "Coin Info APIs";
            // 
            // txtCointweakApiKey
            // 
            this.txtCointweakApiKey.Enabled = false;
            this.txtCointweakApiKey.Location = new System.Drawing.Point(122, 44);
            this.txtCointweakApiKey.Name = "txtCointweakApiKey";
            this.txtCointweakApiKey.Size = new System.Drawing.Size(336, 20);
            this.txtCointweakApiKey.TabIndex = 30;
            this.txtCointweakApiKey.Text = "Enter your CoinTweak API key here.";
            // 
            // chkWhattomine
            // 
            this.chkWhattomine.AutoSize = true;
            this.chkWhattomine.Checked = true;
            this.chkWhattomine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWhattomine.Location = new System.Drawing.Point(6, 20);
            this.chkWhattomine.Name = "chkWhattomine";
            this.chkWhattomine.Size = new System.Drawing.Size(110, 17);
            this.chkWhattomine.TabIndex = 3;
            this.chkWhattomine.Text = "Use WhatToMine";
            this.chkWhattomine.UseVisualStyleBackColor = true;
            // 
            // txtCoinwarzApiKey
            // 
            this.txtCoinwarzApiKey.Enabled = false;
            this.txtCoinwarzApiKey.Location = new System.Drawing.Point(122, 65);
            this.txtCoinwarzApiKey.Name = "txtCoinwarzApiKey";
            this.txtCoinwarzApiKey.Size = new System.Drawing.Size(336, 20);
            this.txtCoinwarzApiKey.TabIndex = 27;
            this.txtCoinwarzApiKey.Text = "Enter your CoinWarz API key here.";
            // 
            // chkCointweak
            // 
            this.chkCointweak.AutoSize = true;
            this.chkCointweak.Location = new System.Drawing.Point(6, 43);
            this.chkCointweak.Name = "chkCointweak";
            this.chkCointweak.Size = new System.Drawing.Size(102, 17);
            this.chkCointweak.TabIndex = 28;
            this.chkCointweak.Text = "Use CoinTweak";
            this.chkCointweak.UseVisualStyleBackColor = true;
            this.chkCointweak.CheckedChanged += new System.EventHandler(this.chkCointweak_CheckedChanged);
            // 
            // chkCoinwarz
            // 
            this.chkCoinwarz.AutoSize = true;
            this.chkCoinwarz.Location = new System.Drawing.Point(6, 66);
            this.chkCoinwarz.Name = "chkCoinwarz";
            this.chkCoinwarz.Size = new System.Drawing.Size(94, 17);
            this.chkCoinwarz.TabIndex = 29;
            this.chkCoinwarz.Text = "Use CoinWarz";
            this.chkCoinwarz.UseVisualStyleBackColor = true;
            this.chkCoinwarz.CheckedChanged += new System.EventHandler(this.chkCoinwarz_CheckedChanged);
            // 
            // grpMisc
            // 
            this.grpMisc.Controls.Add(this.cbbFiat);
            this.grpMisc.Controls.Add(this.chkCoindesk);
            this.grpMisc.Controls.Add(this.chkWeight);
            this.grpMisc.Controls.Add(this.chkShowOnlyHealthy);
            this.grpMisc.Controls.Add(this.nudPoolpicker);
            this.grpMisc.Controls.Add(this.chkPoolpicker);
            this.grpMisc.Controls.Add(this.chkNiceHash);
            this.grpMisc.Location = new System.Drawing.Point(693, 12);
            this.grpMisc.Name = "grpMisc";
            this.grpMisc.Size = new System.Drawing.Size(444, 88);
            this.grpMisc.TabIndex = 5;
            this.grpMisc.TabStop = false;
            this.grpMisc.Text = "Misc.";
            // 
            // cbbFiat
            // 
            this.cbbFiat.AllowDrop = true;
            this.cbbFiat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFiat.FormattingEnabled = true;
            this.cbbFiat.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "CNY",
            "ALL"});
            this.cbbFiat.Location = new System.Drawing.Point(299, 39);
            this.cbbFiat.Name = "cbbFiat";
            this.cbbFiat.Size = new System.Drawing.Size(48, 21);
            this.cbbFiat.TabIndex = 35;
            this.cbbFiat.SelectedIndexChanged += new System.EventHandler(this.cbbFiat_SelectedIndexChanged);
            // 
            // chkCoindesk
            // 
            this.chkCoindesk.AutoSize = true;
            this.chkCoindesk.Checked = true;
            this.chkCoindesk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCoindesk.Location = new System.Drawing.Point(256, 42);
            this.chkCoindesk.Name = "chkCoindesk";
            this.chkCoindesk.Size = new System.Drawing.Size(126, 17);
            this.chkCoindesk.TabIndex = 4;
            this.chkCoindesk.Text = "Calc                  /day.";
            this.chkCoindesk.UseVisualStyleBackColor = true;
            this.chkCoindesk.CheckedChanged += new System.EventHandler(this.chkCoindesk_CheckedChanged);
            // 
            // chkWeight
            // 
            this.chkWeight.AutoSize = true;
            this.chkWeight.Checked = true;
            this.chkWeight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWeight.Location = new System.Drawing.Point(256, 20);
            this.chkWeight.Name = "chkWeight";
            this.chkWeight.Size = new System.Drawing.Size(171, 17);
            this.chkWeight.TabIndex = 34;
            this.chkWeight.Text = "Use weighted price calculation";
            this.chkWeight.UseVisualStyleBackColor = true;
            // 
            // chkShowOnlyHealthy
            // 
            this.chkShowOnlyHealthy.AutoSize = true;
            this.chkShowOnlyHealthy.Checked = true;
            this.chkShowOnlyHealthy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowOnlyHealthy.Location = new System.Drawing.Point(6, 19);
            this.chkShowOnlyHealthy.Name = "chkShowOnlyHealthy";
            this.chkShowOnlyHealthy.Size = new System.Drawing.Size(150, 17);
            this.chkShowOnlyHealthy.TabIndex = 32;
            this.chkShowOnlyHealthy.Text = "Show only \"healthy\" coins";
            this.chkShowOnlyHealthy.UseVisualStyleBackColor = true;
            // 
            // Tag
            // 
            this.Tag.HeaderText = "Tag";
            this.Tag.Name = "Tag";
            this.Tag.ReadOnly = true;
            this.Tag.Width = 51;
            // 
            // CoinName
            // 
            this.CoinName.HeaderText = "Name";
            this.CoinName.Name = "CoinName";
            this.CoinName.ReadOnly = true;
            this.CoinName.Width = 60;
            // 
            // Algo
            // 
            this.Algo.HeaderText = "Algo";
            this.Algo.Name = "Algo";
            this.Algo.ReadOnly = true;
            this.Algo.Width = 53;
            // 
            // UsdPerDay
            // 
            this.UsdPerDay.HeaderText = "USD per day";
            this.UsdPerDay.Name = "UsdPerDay";
            this.UsdPerDay.ReadOnly = true;
            this.UsdPerDay.Width = 93;
            // 
            // EurPerDay
            // 
            this.EurPerDay.HeaderText = "EUR per day";
            this.EurPerDay.Name = "EurPerDay";
            this.EurPerDay.ReadOnly = true;
            this.EurPerDay.Visible = false;
            this.EurPerDay.Width = 93;
            // 
            // GbpPerDay
            // 
            this.GbpPerDay.HeaderText = "GBP per day";
            this.GbpPerDay.Name = "GbpPerDay";
            this.GbpPerDay.ReadOnly = true;
            this.GbpPerDay.Visible = false;
            this.GbpPerDay.Width = 92;
            // 
            // CnyPerDay
            // 
            this.CnyPerDay.HeaderText = "CNY per day";
            this.CnyPerDay.Name = "CnyPerDay";
            this.CnyPerDay.ReadOnly = true;
            this.CnyPerDay.Visible = false;
            this.CnyPerDay.Width = 92;
            // 
            // BtcPerDay
            // 
            this.BtcPerDay.HeaderText = "BTC per day";
            this.BtcPerDay.Name = "BtcPerDay";
            this.BtcPerDay.ReadOnly = true;
            this.BtcPerDay.Visible = false;
            this.BtcPerDay.Width = 91;
            // 
            // CoinsPerDay
            // 
            this.CoinsPerDay.HeaderText = "Coins per day";
            this.CoinsPerDay.Name = "CoinsPerDay";
            this.CoinsPerDay.ReadOnly = true;
            this.CoinsPerDay.Width = 96;
            // 
            // BestExchange
            // 
            this.BestExchange.HeaderText = "Best exchange";
            this.BestExchange.Name = "BestExchange";
            this.BestExchange.ReadOnly = true;
            this.BestExchange.Width = 95;
            // 
            // BestExchangePrice
            // 
            this.BestExchangePrice.HeaderText = "Best exchange\'s price";
            this.BestExchangePrice.Name = "BestExchangePrice";
            this.BestExchangePrice.ReadOnly = true;
            this.BestExchangePrice.Width = 124;
            // 
            // ExchangeVolume
            // 
            this.ExchangeVolume.HeaderText = "Best exchange\'s volume";
            this.ExchangeVolume.Name = "ExchangeVolume";
            this.ExchangeVolume.ReadOnly = true;
            this.ExchangeVolume.Width = 134;
            // 
            // WeightedPrice
            // 
            this.WeightedPrice.HeaderText = "Weighted price";
            this.WeightedPrice.Name = "WeightedPrice";
            this.WeightedPrice.ReadOnly = true;
            this.WeightedPrice.Width = 96;
            // 
            // TotalVolume
            // 
            this.TotalVolume.HeaderText = "Total Volume";
            this.TotalVolume.Name = "TotalVolume";
            this.TotalVolume.ReadOnly = true;
            this.TotalVolume.Width = 87;
            // 
            // Difficulty
            // 
            this.Difficulty.HeaderText = "Difficulty";
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.ReadOnly = true;
            this.Difficulty.Width = 72;
            // 
            // BlockReward
            // 
            this.BlockReward.HeaderText = "Block reward";
            this.BlockReward.Name = "BlockReward";
            this.BlockReward.ReadOnly = true;
            this.BlockReward.Width = 87;
            // 
            // CudaProfitCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 591);
            this.Controls.Add(this.grpMisc);
            this.Controls.Add(this.grpGeneralCoinInfo);
            this.Controls.Add(this.stStatusStrip);
            this.Controls.Add(this.grpApiControl);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.grpHashrates);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CudaProfitCalc";
            this.Text = "Profit Calculator~ By KBomba";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CudaProfitCalc_FormClosing);
            this.grpHashrates.ResumeLayout(false);
            this.grpHashrates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ctxtStrip.ResumeLayout(false);
            this.grpApiControl.ResumeLayout(false);
            this.grpApiControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoolpicker)).EndInit();
            this.stStatusStrip.ResumeLayout(false);
            this.stStatusStrip.PerformLayout();
            this.grpGeneralCoinInfo.ResumeLayout(false);
            this.grpGeneralCoinInfo.PerformLayout();
            this.grpMisc.ResumeLayout(false);
            this.grpMisc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHashrates;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.TextBox txtGroestl;
        private System.Windows.Forms.Label lblGroestl;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtX13;
        private System.Windows.Forms.Label lblX13;
        private System.Windows.Forms.TextBox txtX11;
        private System.Windows.Forms.Label lblX11;
        private System.Windows.Forms.TextBox txtScrypt;
        private System.Windows.Forms.Label lblScrypt;
        private System.Windows.Forms.TextBox txtQuark;
        private System.Windows.Forms.Label lblQuark;
        private System.Windows.Forms.TextBox txtNist5;
        private System.Windows.Forms.Label lblNist5;
        private System.Windows.Forms.Label lblJha;
        private System.Windows.Forms.TextBox txtKeccak;
        private System.Windows.Forms.Label lblKeccak;
        private System.Windows.Forms.TextBox txtMyrGroestl;
        private System.Windows.Forms.Label lblMyrGroestl;
        private System.Windows.Forms.GroupBox grpApiControl;
        private System.Windows.Forms.CheckBox chkCryptsy;
        private System.Windows.Forms.CheckBox chkMintpal;
        private System.Windows.Forms.CheckBox chkBittrex;
        private System.Windows.Forms.TextBox txtJackpot;
        private System.Windows.Forms.TextBox txtFugue;
        private System.Windows.Forms.Label lblFugue;
        private System.Windows.Forms.TextBox txtHefty;
        private System.Windows.Forms.Label lblHefty;
        private System.Windows.Forms.StatusStrip stStatusStrip;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.ToolStripStatusLabel tsProgressText;
        private System.Windows.Forms.CheckBox chkNiceHash;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ContextMenuStrip ctxtStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmResultsToClipboard;
        private System.Windows.Forms.ToolStripMenuItem tsmHashratesToClipboard;
        private System.Windows.Forms.TextBox txtJane13;
        private System.Windows.Forms.Label lblJane13;
        private System.Windows.Forms.TextBox txtJane15;
        private System.Windows.Forms.Label lblJane15;
        private System.Windows.Forms.TextBox txtScryptN;
        private System.Windows.Forms.Label lblScryptN;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPoolpicker;
        private System.Windows.Forms.CheckBox chkPoolpicker;
        private System.Windows.Forms.GroupBox grpGeneralCoinInfo;
        private System.Windows.Forms.TextBox txtCointweakApiKey;
        private System.Windows.Forms.CheckBox chkWhattomine;
        private System.Windows.Forms.TextBox txtCoinwarzApiKey;
        private System.Windows.Forms.CheckBox chkCointweak;
        private System.Windows.Forms.CheckBox chkCoinwarz;
        private System.Windows.Forms.GroupBox grpMisc;
        private System.Windows.Forms.CheckBox chkPoloniex;
        private System.Windows.Forms.CheckBox chkWeight;
        private System.Windows.Forms.CheckBox chkShowOnlyHealthy;
        private System.Windows.Forms.CheckBox chkCoindesk;
        private System.Windows.Forms.ComboBox cbbFiat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoinName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Algo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsdPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EurPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn GbpPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn CnyPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn BtcPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoinsPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestExchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestExchangePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExchangeVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockReward;
    }
}

