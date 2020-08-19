namespace Inazuma_Eleven_Toolbox.Forms
{
    partial class StatsForm
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
            this.cmbBoxGameVer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxRGN = new System.Windows.Forms.ComboBox();
            this.btn_Show_Stats = new System.Windows.Forms.Button();
            this.dataGridViewStats = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxGameVer
            // 
            this.cmbBoxGameVer.FormattingEnabled = true;
            this.cmbBoxGameVer.Items.AddRange(new object[] {
            "Inazuma Eleven",
            "Inazuma Eleven 2",
            "Inazuma Eleven 3"});
            this.cmbBoxGameVer.Location = new System.Drawing.Point(94, 11);
            this.cmbBoxGameVer.Name = "cmbBoxGameVer";
            this.cmbBoxGameVer.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxGameVer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Region:";
            // 
            // cmbBoxRGN
            // 
            this.cmbBoxRGN.FormattingEnabled = true;
            this.cmbBoxRGN.Items.AddRange(new object[] {
            "EUR",
            "JAP"});
            this.cmbBoxRGN.Location = new System.Drawing.Point(271, 11);
            this.cmbBoxRGN.Name = "cmbBoxRGN";
            this.cmbBoxRGN.Size = new System.Drawing.Size(69, 21);
            this.cmbBoxRGN.TabIndex = 3;
            // 
            // btn_Show_Stats
            // 
            this.btn_Show_Stats.Location = new System.Drawing.Point(346, 9);
            this.btn_Show_Stats.Name = "btn_Show_Stats";
            this.btn_Show_Stats.Size = new System.Drawing.Size(93, 23);
            this.btn_Show_Stats.TabIndex = 4;
            this.btn_Show_Stats.Text = "Load Stats!";
            this.btn_Show_Stats.UseVisualStyleBackColor = true;
            this.btn_Show_Stats.Click += new System.EventHandler(this.btn_Show_Stats_Click);
            // 
            // dataGridViewStats
            // 
            this.dataGridViewStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25,
            this.Column26,
            this.Column27});
            this.dataGridViewStats.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewStats.Name = "dataGridViewStats";
            this.dataGridViewStats.Size = new System.Drawing.Size(1046, 556);
            this.dataGridViewStats.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 323.0309F;
            this.Column1.HeaderText = "Full Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 240.0436F;
            this.Column2.HeaderText = "Nickname";
            this.Column2.Name = "Column2";
            this.Column2.Width = 89;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 65.7506F;
            this.Column3.HeaderText = "Position";
            this.Column3.Name = "Column3";
            this.Column3.Width = 25;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 107.8355F;
            this.Column4.HeaderText = "Gender";
            this.Column4.Name = "Column4";
            this.Column4.Width = 40;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 103.9886F;
            this.Column5.HeaderText = "Size";
            this.Column5.Name = "Column5";
            this.Column5.Width = 38;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 100.3336F;
            this.Column6.HeaderText = "Element";
            this.Column6.Name = "Column6";
            this.Column6.Width = 38;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 58.11647F;
            this.Column7.HeaderText = "FP";
            this.Column7.Name = "Column7";
            this.Column7.Width = 21;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 57.29548F;
            this.Column8.HeaderText = "TP";
            this.Column8.Name = "Column8";
            this.Column8.Width = 21;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 47.08255F;
            this.Column9.HeaderText = "Kick";
            this.Column9.Name = "Column9";
            this.Column9.Width = 18;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 46.67342F;
            this.Column10.HeaderText = "Body";
            this.Column10.Name = "Column10";
            this.Column10.Width = 17;
            // 
            // Column11
            // 
            this.Column11.FillWeight = 46.27449F;
            this.Column11.HeaderText = "Control";
            this.Column11.Name = "Column11";
            this.Column11.Width = 17;
            // 
            // Column12
            // 
            this.Column12.FillWeight = 45.8855F;
            this.Column12.HeaderText = "Guard";
            this.Column12.Name = "Column12";
            this.Column12.Width = 17;
            // 
            // Column13
            // 
            this.Column13.FillWeight = 45.5062F;
            this.Column13.HeaderText = "Speed";
            this.Column13.Name = "Column13";
            this.Column13.Width = 17;
            // 
            // Column14
            // 
            this.Column14.FillWeight = 45.13638F;
            this.Column14.HeaderText = "Stamina";
            this.Column14.Name = "Column14";
            this.Column14.Width = 17;
            // 
            // Column15
            // 
            this.Column15.FillWeight = 44.77575F;
            this.Column15.HeaderText = "Guts";
            this.Column15.Name = "Column15";
            this.Column15.Width = 17;
            // 
            // Column16
            // 
            this.Column16.FillWeight = 53.30896F;
            this.Column16.HeaderText = "Freedom";
            this.Column16.Name = "Column16";
            this.Column16.Width = 20;
            // 
            // Column17
            // 
            this.Column17.FillWeight = 87.71959F;
            this.Column17.HeaderText = "Total";
            this.Column17.Name = "Column17";
            this.Column17.Width = 32;
            // 
            // Column18
            // 
            this.Column18.FillWeight = 84.87558F;
            this.Column18.HeaderText = "Max Total";
            this.Column18.Name = "Column18";
            this.Column18.Width = 32;
            // 
            // Column19
            // 
            this.Column19.FillWeight = 213.6507F;
            this.Column19.HeaderText = "Move 1";
            this.Column19.Name = "Column19";
            this.Column19.Width = 79;
            // 
            // Column20
            // 
            this.Column20.FillWeight = 102.2722F;
            this.Column20.HeaderText = "Learns At";
            this.Column20.Name = "Column20";
            this.Column20.Width = 38;
            // 
            // Column21
            // 
            this.Column21.FillWeight = 180.6535F;
            this.Column21.HeaderText = "Move 2";
            this.Column21.Name = "Column21";
            this.Column21.Width = 67;
            // 
            // Column22
            // 
            this.Column22.FillWeight = 86.80738F;
            this.Column22.HeaderText = "Learns At";
            this.Column22.Name = "Column22";
            this.Column22.Width = 32;
            // 
            // Column23
            // 
            this.Column23.FillWeight = 153.9375F;
            this.Column23.HeaderText = "Move 3";
            this.Column23.Name = "Column23";
            this.Column23.Width = 58;
            // 
            // Column24
            // 
            this.Column24.FillWeight = 74.28635F;
            this.Column24.HeaderText = "Learns At";
            this.Column24.Name = "Column24";
            this.Column24.Width = 27;
            // 
            // Column25
            // 
            this.Column25.FillWeight = 132.3071F;
            this.Column25.HeaderText = "Move 4";
            this.Column25.Name = "Column25";
            this.Column25.Width = 49;
            // 
            // Column26
            // 
            this.Column26.FillWeight = 64.14883F;
            this.Column26.HeaderText = "Learns At";
            this.Column26.Name = "Column26";
            this.Column26.Width = 24;
            // 
            // Column27
            // 
            this.Column27.FillWeight = 88.30315F;
            this.Column27.HeaderText = "Player HEX ID";
            this.Column27.Name = "Column27";
            this.Column27.Width = 33;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 606);
            this.Controls.Add(this.dataGridViewStats);
            this.Controls.Add(this.btn_Show_Stats);
            this.Controls.Add(this.cmbBoxRGN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxGameVer);
            this.Name = "StatsForm";
            this.Text = "Player Stats";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxGameVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxRGN;
        private System.Windows.Forms.Button btn_Show_Stats;
        private System.Windows.Forms.DataGridView dataGridViewStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
    }
}