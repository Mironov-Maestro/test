namespace Kartoteka.Controls
{
    partial class Sotrudniki
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
            this.dataGridViewSotrudniki = new System.Windows.Forms.DataGridView();
            this.labelFam = new System.Windows.Forms.Label();
            this.textBoxFam = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelIma = new System.Windows.Forms.Label();
            this.labelOtc = new System.Windows.Forms.Label();
            this.textBoxIma = new System.Windows.Forms.TextBox();
            this.textBoxOtc = new System.Windows.Forms.TextBox();
            this.textBoxDR = new System.Windows.Forms.TextBox();
            this.textBoxNP = new System.Windows.Forms.TextBox();
            this.labelDR = new System.Windows.Forms.Label();
            this.labelNP = new System.Windows.Forms.Label();
            this.textBoxSP = new System.Windows.Forms.TextBox();
            this.labelSP = new System.Windows.Forms.Label();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxPol = new System.Windows.Forms.TextBox();
            this.labelPol = new System.Windows.Forms.Label();
            this.textBoxSpec = new System.Windows.Forms.TextBox();
            this.textBoxObr = new System.Windows.Forms.TextBox();
            this.labelSpec = new System.Windows.Forms.Label();
            this.labelObr = new System.Windows.Forms.Label();
            this.textBoxDol = new System.Windows.Forms.TextBox();
            this.labelDol = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSpravkaD = new System.Windows.Forms.Button();
            this.buttonSpravkaO = new System.Windows.Forms.Button();
            this.buttonSpravkaS = new System.Windows.Forms.Button();
            this.dataGridViewSpravka = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxKodSot = new System.Windows.Forms.TextBox();
            this.labelSot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSotrudniki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpravka)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSotrudniki
            // 
            this.dataGridViewSotrudniki.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.dataGridViewSotrudniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSotrudniki.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewSotrudniki.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSotrudniki.Name = "dataGridViewSotrudniki";
            this.dataGridViewSotrudniki.Size = new System.Drawing.Size(667, 471);
            this.dataGridViewSotrudniki.TabIndex = 0;
            this.dataGridViewSotrudniki.DoubleClick += new System.EventHandler(this.dataGridViewSotrudniki_DoubleClick);
            // 
            // labelFam
            // 
            this.labelFam.AutoSize = true;
            this.labelFam.Location = new System.Drawing.Point(673, 12);
            this.labelFam.Name = "labelFam";
            this.labelFam.Size = new System.Drawing.Size(56, 13);
            this.labelFam.TabIndex = 1;
            this.labelFam.Text = "Фамилия";
            // 
            // textBoxFam
            // 
            this.textBoxFam.Location = new System.Drawing.Point(735, 9);
            this.textBoxFam.Name = "textBoxFam";
            this.textBoxFam.Size = new System.Drawing.Size(152, 20);
            this.textBoxFam.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(1122, 159);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelIma
            // 
            this.labelIma.AutoSize = true;
            this.labelIma.Location = new System.Drawing.Point(907, 16);
            this.labelIma.Name = "labelIma";
            this.labelIma.Size = new System.Drawing.Size(29, 13);
            this.labelIma.TabIndex = 4;
            this.labelIma.Text = "Имя";
            // 
            // labelOtc
            // 
            this.labelOtc.AutoSize = true;
            this.labelOtc.Location = new System.Drawing.Point(1119, 12);
            this.labelOtc.Name = "labelOtc";
            this.labelOtc.Size = new System.Drawing.Size(54, 13);
            this.labelOtc.TabIndex = 5;
            this.labelOtc.Text = "Отчество";
            // 
            // textBoxIma
            // 
            this.textBoxIma.Location = new System.Drawing.Point(942, 9);
            this.textBoxIma.Name = "textBoxIma";
            this.textBoxIma.Size = new System.Drawing.Size(152, 20);
            this.textBoxIma.TabIndex = 6;
            // 
            // textBoxOtc
            // 
            this.textBoxOtc.Location = new System.Drawing.Point(1179, 9);
            this.textBoxOtc.Name = "textBoxOtc";
            this.textBoxOtc.Size = new System.Drawing.Size(152, 20);
            this.textBoxOtc.TabIndex = 7;
            // 
            // textBoxDR
            // 
            this.textBoxDR.Location = new System.Drawing.Point(1179, 48);
            this.textBoxDR.Name = "textBoxDR";
            this.textBoxDR.Size = new System.Drawing.Size(152, 20);
            this.textBoxDR.TabIndex = 13;
            // 
            // textBoxNP
            // 
            this.textBoxNP.Location = new System.Drawing.Point(961, 48);
            this.textBoxNP.Name = "textBoxNP";
            this.textBoxNP.Size = new System.Drawing.Size(120, 20);
            this.textBoxNP.TabIndex = 12;
            // 
            // labelDR
            // 
            this.labelDR.AutoSize = true;
            this.labelDR.Location = new System.Drawing.Point(1087, 55);
            this.labelDR.Name = "labelDR";
            this.labelDR.Size = new System.Drawing.Size(86, 13);
            this.labelDR.TabIndex = 11;
            this.labelDR.Text = "Дата рождения";
            // 
            // labelNP
            // 
            this.labelNP.AutoSize = true;
            this.labelNP.Location = new System.Drawing.Point(869, 55);
            this.labelNP.Name = "labelNP";
            this.labelNP.Size = new System.Drawing.Size(91, 13);
            this.labelNP.TabIndex = 10;
            this.labelNP.Text = "Номер паспорта";
            // 
            // textBoxSP
            // 
            this.textBoxSP.Location = new System.Drawing.Point(767, 48);
            this.textBoxSP.Name = "textBoxSP";
            this.textBoxSP.Size = new System.Drawing.Size(85, 20);
            this.textBoxSP.TabIndex = 9;
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Location = new System.Drawing.Point(673, 51);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(88, 13);
            this.labelSP.TabIndex = 8;
            this.labelSP.Text = "Серия паспорта";
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(1033, 92);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(298, 20);
            this.textBoxAdres.TabIndex = 19;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(843, 88);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(120, 20);
            this.textBoxTel.TabIndex = 18;
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(989, 95);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(38, 13);
            this.labelAdres.TabIndex = 17;
            this.labelAdres.Text = "Адрес";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(785, 91);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(52, 13);
            this.labelTel.TabIndex = 16;
            this.labelTel.Text = "Телефон";
            // 
            // textBoxPol
            // 
            this.textBoxPol.Location = new System.Drawing.Point(716, 88);
            this.textBoxPol.Name = "textBoxPol";
            this.textBoxPol.Size = new System.Drawing.Size(45, 20);
            this.textBoxPol.TabIndex = 15;
            // 
            // labelPol
            // 
            this.labelPol.AutoSize = true;
            this.labelPol.Location = new System.Drawing.Point(673, 91);
            this.labelPol.Name = "labelPol";
            this.labelPol.Size = new System.Drawing.Size(27, 13);
            this.labelPol.TabIndex = 14;
            this.labelPol.Text = "Пол";
            // 
            // textBoxSpec
            // 
            this.textBoxSpec.Location = new System.Drawing.Point(1239, 130);
            this.textBoxSpec.Name = "textBoxSpec";
            this.textBoxSpec.Size = new System.Drawing.Size(92, 20);
            this.textBoxSpec.TabIndex = 25;
            // 
            // textBoxObr
            // 
            this.textBoxObr.Location = new System.Drawing.Point(961, 130);
            this.textBoxObr.Name = "textBoxObr";
            this.textBoxObr.Size = new System.Drawing.Size(120, 20);
            this.textBoxObr.TabIndex = 24;
            // 
            // labelSpec
            // 
            this.labelSpec.AutoSize = true;
            this.labelSpec.Location = new System.Drawing.Point(1090, 133);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(143, 13);
            this.labelSpec.TabIndex = 23;
            this.labelSpec.Text = "Код специальности (Проф)";
            // 
            // labelObr
            // 
            this.labelObr.AutoSize = true;
            this.labelObr.Location = new System.Drawing.Point(858, 134);
            this.labelObr.Name = "labelObr";
            this.labelObr.Size = new System.Drawing.Size(95, 13);
            this.labelObr.TabIndex = 22;
            this.labelObr.Text = "Код образования";
            // 
            // textBoxDol
            // 
            this.textBoxDol.Location = new System.Drawing.Point(763, 127);
            this.textBoxDol.Name = "textBoxDol";
            this.textBoxDol.Size = new System.Drawing.Size(85, 20);
            this.textBoxDol.TabIndex = 21;
            // 
            // labelDol
            // 
            this.labelDol.AutoSize = true;
            this.labelDol.Location = new System.Drawing.Point(673, 130);
            this.labelDol.Name = "labelDol";
            this.labelDol.Size = new System.Drawing.Size(84, 13);
            this.labelDol.TabIndex = 20;
            this.labelDol.Text = "Код должности";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(1256, 159);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 26;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Location = new System.Drawing.Point(686, 159);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 27;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSpravkaD
            // 
            this.buttonSpravkaD.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSpravkaD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpravkaD.Location = new System.Drawing.Point(686, 261);
            this.buttonSpravkaD.Name = "buttonSpravkaD";
            this.buttonSpravkaD.Size = new System.Drawing.Size(181, 23);
            this.buttonSpravkaD.TabIndex = 28;
            this.buttonSpravkaD.Text = "Справка по коду должности";
            this.buttonSpravkaD.UseVisualStyleBackColor = false;
            this.buttonSpravkaD.Click += new System.EventHandler(this.buttonSpravkaD_Click);
            // 
            // buttonSpravkaO
            // 
            this.buttonSpravkaO.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSpravkaO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpravkaO.Location = new System.Drawing.Point(887, 261);
            this.buttonSpravkaO.Name = "buttonSpravkaO";
            this.buttonSpravkaO.Size = new System.Drawing.Size(175, 23);
            this.buttonSpravkaO.TabIndex = 29;
            this.buttonSpravkaO.Text = "Справка по коду образования";
            this.buttonSpravkaO.UseVisualStyleBackColor = false;
            this.buttonSpravkaO.Click += new System.EventHandler(this.buttonSpravkaO_Click);
            // 
            // buttonSpravkaS
            // 
            this.buttonSpravkaS.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSpravkaS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpravkaS.Location = new System.Drawing.Point(1081, 261);
            this.buttonSpravkaS.Name = "buttonSpravkaS";
            this.buttonSpravkaS.Size = new System.Drawing.Size(195, 23);
            this.buttonSpravkaS.TabIndex = 30;
            this.buttonSpravkaS.Text = "Справка по коду специальности";
            this.buttonSpravkaS.UseVisualStyleBackColor = false;
            this.buttonSpravkaS.Click += new System.EventHandler(this.buttonSpravkaS_Click);
            // 
            // dataGridViewSpravka
            // 
            this.dataGridViewSpravka.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.dataGridViewSpravka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpravka.Location = new System.Drawing.Point(843, 290);
            this.dataGridViewSpravka.Name = "dataGridViewSpravka";
            this.dataGridViewSpravka.Size = new System.Drawing.Size(354, 181);
            this.dataGridViewSpravka.TabIndex = 31;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(918, 199);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 68;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxKodSot
            // 
            this.textBoxKodSot.Location = new System.Drawing.Point(788, 200);
            this.textBoxKodSot.Name = "textBoxKodSot";
            this.textBoxKodSot.Size = new System.Drawing.Size(120, 20);
            this.textBoxKodSot.TabIndex = 67;
            // 
            // labelSot
            // 
            this.labelSot.AutoSize = true;
            this.labelSot.Location = new System.Drawing.Point(685, 204);
            this.labelSot.Name = "labelSot";
            this.labelSot.Size = new System.Drawing.Size(87, 13);
            this.labelSot.TabIndex = 66;
            this.labelSot.Text = "Код сотрудника";
            // 
            // Sotrudniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxKodSot);
            this.Controls.Add(this.labelSot);
            this.Controls.Add(this.dataGridViewSpravka);
            this.Controls.Add(this.buttonSpravkaS);
            this.Controls.Add(this.buttonSpravkaO);
            this.Controls.Add(this.buttonSpravkaD);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxSpec);
            this.Controls.Add(this.textBoxObr);
            this.Controls.Add(this.labelSpec);
            this.Controls.Add(this.labelObr);
            this.Controls.Add(this.textBoxDol);
            this.Controls.Add(this.labelDol);
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
            this.Controls.Add(this.dataGridViewSotrudniki);
            this.Name = "Sotrudniki";
            this.Size = new System.Drawing.Size(1363, 471);
            this.Load += new System.EventHandler(this.Sotrudniki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSotrudniki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpravka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSotrudniki;
        private System.Windows.Forms.Label labelFam;
        private System.Windows.Forms.TextBox textBoxFam;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelIma;
        private System.Windows.Forms.Label labelOtc;
        private System.Windows.Forms.TextBox textBoxIma;
        private System.Windows.Forms.TextBox textBoxOtc;
        private System.Windows.Forms.TextBox textBoxDR;
        private System.Windows.Forms.TextBox textBoxNP;
        private System.Windows.Forms.Label labelDR;
        private System.Windows.Forms.Label labelNP;
        private System.Windows.Forms.TextBox textBoxSP;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBoxPol;
        private System.Windows.Forms.Label labelPol;
        private System.Windows.Forms.TextBox textBoxSpec;
        private System.Windows.Forms.TextBox textBoxObr;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.Label labelObr;
        private System.Windows.Forms.TextBox textBoxDol;
        private System.Windows.Forms.Label labelDol;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSpravkaD;
        private System.Windows.Forms.Button buttonSpravkaO;
        private System.Windows.Forms.Button buttonSpravkaS;
        private System.Windows.Forms.DataGridView dataGridViewSpravka;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxKodSot;
        private System.Windows.Forms.Label labelSot;
    }
}
