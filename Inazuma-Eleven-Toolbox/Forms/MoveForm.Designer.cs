namespace Inazuma_Eleven_Toolbox.Forms
{
    partial class MoveForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Show_Move_Stats = new System.Windows.Forms.Button();
            this.cmbBoxRGN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbBoxGameVer = new System.Windows.Forms.ComboBox();
            this.MoveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovePwr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveMaxPwr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveTPCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveFoulRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveEvolveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveType2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEXID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveRestriction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game Version:";
            // 
            // btn_Show_Move_Stats
            // 
            this.btn_Show_Move_Stats.Location = new System.Drawing.Point(346, 10);
            this.btn_Show_Move_Stats.Name = "btn_Show_Move_Stats";
            this.btn_Show_Move_Stats.Size = new System.Drawing.Size(93, 23);
            this.btn_Show_Move_Stats.TabIndex = 7;
            this.btn_Show_Move_Stats.Text = "Load Moves!";
            this.btn_Show_Move_Stats.UseVisualStyleBackColor = true;
            this.btn_Show_Move_Stats.Click += new System.EventHandler(this.btn_Show_Stats_Click);
            // 
            // cmbBoxRGN
            // 
            this.cmbBoxRGN.FormattingEnabled = true;
            this.cmbBoxRGN.Items.AddRange(new object[] {
            "EUR",
            "JAP"});
            this.cmbBoxRGN.Location = new System.Drawing.Point(271, 12);
            this.cmbBoxRGN.Name = "cmbBoxRGN";
            this.cmbBoxRGN.Size = new System.Drawing.Size(69, 21);
            this.cmbBoxRGN.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Region:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MoveName,
            this.MoveType,
            this.MoveElement,
            this.MovePwr,
            this.MoveMaxPwr,
            this.MoveTPCost,
            this.MoveFoulRate,
            this.MoveEvolveType,
            this.MoveType2,
            this.MoveSummary,
            this.HEXID,
            this.MoveRestriction});
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 413);
            this.dataGridView1.TabIndex = 8;
            // 
            // cmbBoxGameVer
            // 
            this.cmbBoxGameVer.FormattingEnabled = true;
            this.cmbBoxGameVer.Items.AddRange(new object[] {
            "Inazuma Eleven",
            "Inazuma Eleven 2",
            "Inazuma Eleven 3"});
            this.cmbBoxGameVer.Location = new System.Drawing.Point(94, 12);
            this.cmbBoxGameVer.Name = "cmbBoxGameVer";
            this.cmbBoxGameVer.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxGameVer.TabIndex = 9;
            // 
            // MoveName
            // 
            this.MoveName.HeaderText = "Move Name";
            this.MoveName.Name = "MoveName";
            this.MoveName.Width = 150;
            // 
            // MoveType
            // 
            this.MoveType.HeaderText = "Type";
            this.MoveType.Name = "MoveType";
            this.MoveType.Width = 50;
            // 
            // MoveElement
            // 
            this.MoveElement.HeaderText = "Element";
            this.MoveElement.Name = "MoveElement";
            this.MoveElement.Width = 50;
            // 
            // MovePwr
            // 
            this.MovePwr.HeaderText = "Base Power";
            this.MovePwr.Name = "MovePwr";
            this.MovePwr.Width = 50;
            // 
            // MoveMaxPwr
            // 
            this.MoveMaxPwr.HeaderText = "Max Power";
            this.MoveMaxPwr.Name = "MoveMaxPwr";
            this.MoveMaxPwr.Width = 50;
            // 
            // MoveTPCost
            // 
            this.MoveTPCost.HeaderText = "TP Cost";
            this.MoveTPCost.Name = "MoveTPCost";
            this.MoveTPCost.Width = 50;
            // 
            // MoveFoulRate
            // 
            this.MoveFoulRate.HeaderText = "Foul Rate";
            this.MoveFoulRate.Name = "MoveFoulRate";
            this.MoveFoulRate.Width = 50;
            // 
            // MoveEvolveType
            // 
            this.MoveEvolveType.HeaderText = "Evolve Type";
            this.MoveEvolveType.Name = "MoveEvolveType";
            this.MoveEvolveType.Width = 50;
            // 
            // MoveType2
            // 
            this.MoveType2.HeaderText = "Secondary Type";
            this.MoveType2.Name = "MoveType2";
            this.MoveType2.Width = 50;
            // 
            // MoveSummary
            // 
            this.MoveSummary.HeaderText = "Summary";
            this.MoveSummary.Name = "MoveSummary";
            // 
            // HEXID
            // 
            this.HEXID.HeaderText = "HEX ID";
            this.HEXID.Name = "HEXID";
            // 
            // MoveRestriction
            // 
            this.MoveRestriction.HeaderText = "Restriction";
            this.MoveRestriction.Name = "MoveRestriction";
            // 
            // MoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 464);
            this.Controls.Add(this.cmbBoxGameVer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Show_Move_Stats);
            this.Controls.Add(this.cmbBoxRGN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MoveForm";
            this.Text = "MoveForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Show_Move_Stats;
        private System.Windows.Forms.ComboBox cmbBoxRGN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbBoxGameVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovePwr;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveMaxPwr;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveTPCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveFoulRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveEvolveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveType2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEXID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveRestriction;
    }
}