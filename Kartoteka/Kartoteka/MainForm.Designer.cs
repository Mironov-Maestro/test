namespace Kartoteka
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonSoiskatel = new System.Windows.Forms.Button();
            this.buttonOtchet = new System.Windows.Forms.Button();
            this.buttonSpisok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonUsers);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSoiskatel);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOtchet);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSpisok);
            this.splitContainer1.Size = new System.Drawing.Size(1535, 478);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Location = new System.Drawing.Point(8, 140);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(151, 38);
            this.buttonUsers.TabIndex = 3;
            this.buttonUsers.Text = "Пользователи";
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonSoiskatel
            // 
            this.buttonSoiskatel.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSoiskatel.FlatAppearance.BorderSize = 0;
            this.buttonSoiskatel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoiskatel.Location = new System.Drawing.Point(8, 52);
            this.buttonSoiskatel.Name = "buttonSoiskatel";
            this.buttonSoiskatel.Size = new System.Drawing.Size(151, 38);
            this.buttonSoiskatel.TabIndex = 2;
            this.buttonSoiskatel.Text = "Список соискателей";
            this.buttonSoiskatel.UseVisualStyleBackColor = false;
            this.buttonSoiskatel.Click += new System.EventHandler(this.buttonSoiskatel_Click);
            // 
            // buttonOtchet
            // 
            this.buttonOtchet.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonOtchet.FlatAppearance.BorderSize = 0;
            this.buttonOtchet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOtchet.Location = new System.Drawing.Point(8, 96);
            this.buttonOtchet.Name = "buttonOtchet";
            this.buttonOtchet.Size = new System.Drawing.Size(151, 38);
            this.buttonOtchet.TabIndex = 1;
            this.buttonOtchet.Text = "Отчёты";
            this.buttonOtchet.UseVisualStyleBackColor = false;
            this.buttonOtchet.Click += new System.EventHandler(this.buttonOtchet_Click);
            // 
            // buttonSpisok
            // 
            this.buttonSpisok.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSpisok.FlatAppearance.BorderSize = 0;
            this.buttonSpisok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpisok.Location = new System.Drawing.Point(8, 8);
            this.buttonSpisok.Name = "buttonSpisok";
            this.buttonSpisok.Size = new System.Drawing.Size(151, 38);
            this.buttonSpisok.TabIndex = 0;
            this.buttonSpisok.Text = "Список сотрудников";
            this.buttonSpisok.UseVisualStyleBackColor = false;
            this.buttonSpisok.Click += new System.EventHandler(this.buttonSpisok_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1535, 478);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Картотека";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonSoiskatel;
        private System.Windows.Forms.Button buttonOtchet;
        private System.Windows.Forms.Button buttonSpisok;
    }
}