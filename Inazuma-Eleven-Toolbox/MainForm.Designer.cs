namespace Inazuma_Eleven_Toolbox
{
    partial class Form1
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
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnStatsFormShow = new System.Windows.Forms.Button();
            this.btn_Save_Editor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(156, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Open Move Analyzer";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(12, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Open EXP Analyzer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(156, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Open Item Extractor";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(156, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Open Team Extractor";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnStatsFormShow
            // 
            this.btnStatsFormShow.Location = new System.Drawing.Point(12, 12);
            this.btnStatsFormShow.Name = "btnStatsFormShow";
            this.btnStatsFormShow.Size = new System.Drawing.Size(138, 23);
            this.btnStatsFormShow.TabIndex = 6;
            this.btnStatsFormShow.Text = "View Player Stats";
            this.btnStatsFormShow.UseVisualStyleBackColor = true;
            this.btnStatsFormShow.Click += new System.EventHandler(this.btnStatsFormShow_Click);
            // 
            // btn_Save_Editor
            // 
            this.btn_Save_Editor.Location = new System.Drawing.Point(12, 41);
            this.btn_Save_Editor.Name = "btn_Save_Editor";
            this.btn_Save_Editor.Size = new System.Drawing.Size(138, 23);
            this.btn_Save_Editor.TabIndex = 12;
            this.btn_Save_Editor.Text = "Save Editor";
            this.btn_Save_Editor.UseVisualStyleBackColor = true;
            this.btn_Save_Editor.Click += new System.EventHandler(this.btn_Save_Editor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 175);
            this.Controls.Add(this.btn_Save_Editor);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnStatsFormShow);
            this.Name = "Form1";
            this.Text = "Inazuma Eleven Toolbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnStatsFormShow;
        private System.Windows.Forms.Button btn_Save_Editor;
    }
}

