namespace Kartoteka.Controls
{
    partial class Otcheti
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewSoiskateli = new System.Windows.Forms.DataGridView();
            this.dataGridViewSotrudniki = new System.Windows.Forms.DataGridView();
            this.buttonSotOtchet = new System.Windows.Forms.Button();
            this.buttonSoisOtchet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoiskateli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSotrudniki)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSoiskateli
            // 
            this.dataGridViewSoiskateli.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.dataGridViewSoiskateli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoiskateli.Location = new System.Drawing.Point(701, 34);
            this.dataGridViewSoiskateli.Name = "dataGridViewSoiskateli";
            this.dataGridViewSoiskateli.Size = new System.Drawing.Size(662, 352);
            this.dataGridViewSoiskateli.TabIndex = 1;
            // 
            // dataGridViewSotrudniki
            // 
            this.dataGridViewSotrudniki.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.dataGridViewSotrudniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSotrudniki.Location = new System.Drawing.Point(0, 34);
            this.dataGridViewSotrudniki.Name = "dataGridViewSotrudniki";
            this.dataGridViewSotrudniki.Size = new System.Drawing.Size(667, 352);
            this.dataGridViewSotrudniki.TabIndex = 2;
            // 
            // buttonSotOtchet
            // 
            this.buttonSotOtchet.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSotOtchet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSotOtchet.Location = new System.Drawing.Point(214, 402);
            this.buttonSotOtchet.Name = "buttonSotOtchet";
            this.buttonSotOtchet.Size = new System.Drawing.Size(182, 48);
            this.buttonSotOtchet.TabIndex = 59;
            this.buttonSotOtchet.Text = "Сформировать отчёт";
            this.buttonSotOtchet.UseVisualStyleBackColor = false;
            this.buttonSotOtchet.Click += new System.EventHandler(this.buttonSotOtchet_Click);
            // 
            // buttonSoisOtchet
            // 
            this.buttonSoisOtchet.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSoisOtchet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoisOtchet.Location = new System.Drawing.Point(944, 402);
            this.buttonSoisOtchet.Name = "buttonSoisOtchet";
            this.buttonSoisOtchet.Size = new System.Drawing.Size(182, 48);
            this.buttonSoisOtchet.TabIndex = 60;
            this.buttonSoisOtchet.Text = "Сформировать отчёт";
            this.buttonSoisOtchet.UseVisualStyleBackColor = false;
            this.buttonSoisOtchet.Click += new System.EventHandler(this.buttonSoisOtchet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Список сотрудников";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(987, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Список соискателей";
            // 
            // Otcheti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSoisOtchet);
            this.Controls.Add(this.buttonSotOtchet);
            this.Controls.Add(this.dataGridViewSotrudniki);
            this.Controls.Add(this.dataGridViewSoiskateli);
            this.Name = "Otcheti";
            this.Size = new System.Drawing.Size(1363, 471);
            this.Load += new System.EventHandler(this.Otcheti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoiskateli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSotrudniki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSoiskateli;
        private System.Windows.Forms.DataGridView dataGridViewSotrudniki;
        private System.Windows.Forms.Button buttonSotOtchet;
        private System.Windows.Forms.Button buttonSoisOtchet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
