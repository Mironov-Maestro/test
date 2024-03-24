namespace Kartoteka.Controls
{
    partial class Soiskateli
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
            this.dataGridViewSpravka = new System.Windows.Forms.DataGridView();
            this.buttonSpravkaS = new System.Windows.Forms.Button();
            this.buttonSpravkaO = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxSpec = new System.Windows.Forms.TextBox();
            this.textBoxObr = new System.Windows.Forms.TextBox();
            this.labelSpec = new System.Windows.Forms.Label();
            this.labelObr = new System.Windows.Forms.Label();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxPol = new System.Windows.Forms.TextBox();
            this.labelPol = new System.Windows.Forms.Label();
            this.textBoxDR = new System.Windows.Forms.TextBox();
            this.textBoxNP = new System.Windows.Forms.TextBox();
            this.labelDR = new System.Windows.Forms.Label();
            this.labelNP = new System.Windows.Forms.Label();
            this.textBoxSP = new System.Windows.Forms.TextBox();
            this.labelSP = new System.Windows.Forms.Label();
            this.textBoxOtc = new System.Windows.Forms.TextBox();
            this.textBoxIma = new System.Windows.Forms.TextBox();
            this.labelOtc = new System.Windows.Forms.Label();
            this.labelIma = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxFam = new System.Windows.Forms.TextBox();
            this.labelFam = new System.Windows.Forms.Label();
            this.textBoxKodSois = new System.Windows.Forms.TextBox();
            this.labelSois = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoiskateli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpravka)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSoiskateli
            // 
            this.dataGridViewSoiskateli.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.dataGridViewSoiskateli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoiskateli.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewSoiskateli.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSoiskateli.Name = "dataGridViewSoiskateli";
            this.dataGridViewSoiskateli.Size = new System.Drawing.Size(671, 471);
            this.dataGridViewSoiskateli.TabIndex = 0;
            this.dataGridViewSoiskateli.DoubleClick += new System.EventHandler(this.dataGridViewSoiskateli_DoubleClick);
            // 
            // dataGridViewSpravka
            // 
            this.dataGridViewSpravka.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.dataGridViewSpravka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpravka.Location = new System.Drawing.Point(855, 278);
            this.dataGridViewSpravka.Name = "dataGridViewSpravka";
            this.dataGridViewSpravka.Size = new System.Drawing.Size(354, 193);
            this.dataGridViewSpravka.TabIndex = 62;
            // 
            // buttonSpravkaS
            // 
            this.buttonSpravkaS.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSpravkaS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpravkaS.Location = new System.Drawing.Point(1028, 249);
            this.buttonSpravkaS.Name = "buttonSpravkaS";
            this.buttonSpravkaS.Size = new System.Drawing.Size(192, 23);
            this.buttonSpravkaS.TabIndex = 61;
            this.buttonSpravkaS.Text = "Справка по коду специальности";
            this.buttonSpravkaS.UseVisualStyleBackColor = false;
            this.buttonSpravkaS.Click += new System.EventHandler(this.buttonSpravkaS_Click);
            // 
            // buttonSpravkaO
            // 
            this.buttonSpravkaO.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSpravkaO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpravkaO.Location = new System.Drawing.Point(830, 249);
            this.buttonSpravkaO.Name = "buttonSpravkaO";
            this.buttonSpravkaO.Size = new System.Drawing.Size(175, 23);
            this.buttonSpravkaO.TabIndex = 60;
            this.buttonSpravkaO.Text = "Справка по коду образования";
            this.buttonSpravkaO.UseVisualStyleBackColor = false;
            this.buttonSpravkaO.Click += new System.EventHandler(this.buttonSpravkaO_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Location = new System.Drawing.Point(698, 155);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 58;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(1268, 155);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 57;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxSpec
            // 
            this.textBoxSpec.Location = new System.Drawing.Point(1150, 118);
            this.textBoxSpec.Name = "textBoxSpec";
            this.textBoxSpec.Size = new System.Drawing.Size(92, 20);
            this.textBoxSpec.TabIndex = 56;
            // 
            // textBoxObr
            // 
            this.textBoxObr.Location = new System.Drawing.Point(789, 114);
            this.textBoxObr.Name = "textBoxObr";
            this.textBoxObr.Size = new System.Drawing.Size(120, 20);
            this.textBoxObr.TabIndex = 55;
            // 
            // labelSpec
            // 
            this.labelSpec.AutoSize = true;
            this.labelSpec.Location = new System.Drawing.Point(1001, 121);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(143, 13);
            this.labelSpec.TabIndex = 54;
            this.labelSpec.Text = "Код специальности (Проф)";
            // 
            // labelObr
            // 
            this.labelObr.AutoSize = true;
            this.labelObr.Location = new System.Drawing.Point(686, 118);
            this.labelObr.Name = "labelObr";
            this.labelObr.Size = new System.Drawing.Size(95, 13);
            this.labelObr.TabIndex = 53;
            this.labelObr.Text = "Код образования";
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(1045, 88);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(298, 20);
            this.textBoxAdres.TabIndex = 50;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(855, 84);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(120, 20);
            this.textBoxTel.TabIndex = 49;
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(1001, 91);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(38, 13);
            this.labelAdres.TabIndex = 48;
            this.labelAdres.Text = "Адрес";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(797, 87);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(52, 13);
            this.labelTel.TabIndex = 47;
            this.labelTel.Text = "Телефон";
            // 
            // textBoxPol
            // 
            this.textBoxPol.Location = new System.Drawing.Point(728, 84);
            this.textBoxPol.Name = "textBoxPol";
            this.textBoxPol.Size = new System.Drawing.Size(45, 20);
            this.textBoxPol.TabIndex = 46;
            // 
            // labelPol
            // 
            this.labelPol.AutoSize = true;
            this.labelPol.Location = new System.Drawing.Point(685, 87);
            this.labelPol.Name = "labelPol";
            this.labelPol.Size = new System.Drawing.Size(27, 13);
            this.labelPol.TabIndex = 45;
            this.labelPol.Text = "Пол";
            // 
            // textBoxDR
            // 
            this.textBoxDR.Location = new System.Drawing.Point(1191, 44);
            this.textBoxDR.Name = "textBoxDR";
            this.textBoxDR.Size = new System.Drawing.Size(152, 20);
            this.textBoxDR.TabIndex = 44;
            // 
            // textBoxNP
            // 
            this.textBoxNP.Location = new System.Drawing.Point(973, 44);
            this.textBoxNP.Name = "textBoxNP";
            this.textBoxNP.Size = new System.Drawing.Size(120, 20);
            this.textBoxNP.TabIndex = 43;
            // 
            // labelDR
            // 
            this.labelDR.AutoSize = true;
            this.labelDR.Location = new System.Drawing.Point(1099, 51);
            this.labelDR.Name = "labelDR";
            this.labelDR.Size = new System.Drawing.Size(86, 13);
            this.labelDR.TabIndex = 42;
            this.labelDR.Text = "Дата рождения";
            // 
            // labelNP
            // 
            this.labelNP.AutoSize = true;
            this.labelNP.Location = new System.Drawing.Point(881, 51);
            this.labelNP.Name = "labelNP";
            this.labelNP.Size = new System.Drawing.Size(91, 13);
            this.labelNP.TabIndex = 41;
            this.labelNP.Text = "Номер паспорта";
            // 
            // textBoxSP
            // 
            this.textBoxSP.Location = new System.Drawing.Point(779, 44);
            this.textBoxSP.Name = "textBoxSP";
            this.textBoxSP.Size = new System.Drawing.Size(85, 20);
            this.textBoxSP.TabIndex = 40;
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Location = new System.Drawing.Point(685, 47);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(88, 13);
            this.labelSP.TabIndex = 39;
            this.labelSP.Text = "Серия паспорта";
            // 
            // textBoxOtc
            // 
            this.textBoxOtc.Location = new System.Drawing.Point(1191, 5);
            this.textBoxOtc.Name = "textBoxOtc";
            this.textBoxOtc.Size = new System.Drawing.Size(152, 20);
            this.textBoxOtc.TabIndex = 38;
            // 
            // textBoxIma
            // 
            this.textBoxIma.Location = new System.Drawing.Point(954, 5);
            this.textBoxIma.Name = "textBoxIma";
            this.textBoxIma.Size = new System.Drawing.Size(152, 20);
            this.textBoxIma.TabIndex = 37;
            // 
            // labelOtc
            // 
            this.labelOtc.AutoSize = true;
            this.labelOtc.Location = new System.Drawing.Point(1131, 8);
            this.labelOtc.Name = "labelOtc";
            this.labelOtc.Size = new System.Drawing.Size(54, 13);
            this.labelOtc.TabIndex = 36;
            this.labelOtc.Text = "Отчество";
            // 
            // labelIma
            // 
            this.labelIma.AutoSize = true;
            this.labelIma.Location = new System.Drawing.Point(919, 12);
            this.labelIma.Name = "labelIma";
            this.labelIma.Size = new System.Drawing.Size(29, 13);
            this.labelIma.TabIndex = 35;
            this.labelIma.Text = "Имя";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(1134, 155);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 34;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxFam
            // 
            this.textBoxFam.Location = new System.Drawing.Point(747, 5);
            this.textBoxFam.Name = "textBoxFam";
            this.textBoxFam.Size = new System.Drawing.Size(152, 20);
            this.textBoxFam.TabIndex = 33;
            // 
            // labelFam
            // 
            this.labelFam.AutoSize = true;
            this.labelFam.Location = new System.Drawing.Point(685, 8);
            this.labelFam.Name = "labelFam";
            this.labelFam.Size = new System.Drawing.Size(56, 13);
            this.labelFam.TabIndex = 32;
            this.labelFam.Text = "Фамилия";
            // 
            // textBoxKodSois
            // 
            this.textBoxKodSois.Location = new System.Drawing.Point(800, 196);
            this.textBoxKodSois.Name = "textBoxKodSois";
            this.textBoxKodSois.Size = new System.Drawing.Size(120, 20);
            this.textBoxKodSois.TabIndex = 64;
            // 
            // labelSois
            // 
            this.labelSois.AutoSize = true;
            this.labelSois.Location = new System.Drawing.Point(697, 200);
            this.labelSois.Name = "labelSois";
            this.labelSois.Size = new System.Drawing.Size(88, 13);
            this.labelSois.TabIndex = 63;
            this.labelSois.Text = "Код соискателя";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(930, 195);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 65;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Soiskateli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxKodSois);
            this.Controls.Add(this.labelSois);
            this.Controls.Add(this.dataGridViewSpravka);
            this.Controls.Add(this.buttonSpravkaS);
            this.Controls.Add(this.buttonSpravkaO);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxSpec);
            this.Controls.Add(this.textBoxObr);
            this.Controls.Add(this.labelSpec);
            this.Controls.Add(this.labelObr);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.textBoxPol);
            this.Controls.Add(this.labelPol);
            this.Controls.Add(this.textBoxDR);
            this.Controls.Add(this.textBoxNP);
            this.Controls.Add(this.labelDR);
            this.Controls.Add(this.labelNP);
            this.Controls.Add(this.textBoxSP);
            this.Controls.Add(this.labelSP);
            this.Controls.Add(this.textBoxOtc);
            this.Controls.Add(this.textBoxIma);
            this.Controls.Add(this.labelOtc);
            this.Controls.Add(this.labelIma);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxFam);
            this.Controls.Add(this.labelFam);
            this.Controls.Add(this.dataGridViewSoiskateli);
            this.Name = "Soiskateli";
            this.Size = new System.Drawing.Size(1363, 471);
            this.Load += new System.EventHandler(this.Soiskateli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoiskateli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpravka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSoiskateli;
        private System.Windows.Forms.DataGridView dataGridViewSpravka;
        private System.Windows.Forms.Button buttonSpravkaS;
        private System.Windows.Forms.Button buttonSpravkaO;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxSpec;
        private System.Windows.Forms.TextBox textBoxObr;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.Label labelObr;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBoxPol;
        private System.Windows.Forms.Label labelPol;
        private System.Windows.Forms.TextBox textBoxDR;
        private System.Windows.Forms.TextBox textBoxNP;
        private System.Windows.Forms.Label labelDR;
        private System.Windows.Forms.Label labelNP;
        private System.Windows.Forms.TextBox textBoxSP;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.TextBox textBoxOtc;
        private System.Windows.Forms.TextBox textBoxIma;
        private System.Windows.Forms.Label labelOtc;
        private System.Windows.Forms.Label labelIma;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxFam;
        private System.Windows.Forms.Label labelFam;
        private System.Windows.Forms.TextBox textBoxKodSois;
        private System.Windows.Forms.Label labelSois;
        private System.Windows.Forms.Button buttonDelete;
    }
}
