namespace Kartoteka.Controls
{
    partial class Users
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
            this.components = new System.ComponentModel.Container();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.labelKod_Sot = new System.Windows.Forms.Label();
            this.textBoxKS = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxPP = new System.Windows.Forms.TextBox();
            this.labelPravo = new System.Windows.Forms.Label();
            this.textBoxLP = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPasP = new System.Windows.Forms.TextBox();
            this.labelPas = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxKodUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.dataGridViewSpravka = new System.Windows.Forms.DataGridView();
            this.buttonSpravkaS = new System.Windows.Forms.Button();
            this.buttonSpravkaSot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpravka)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridUsers.Location = new System.Drawing.Point(0, 0);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.Size = new System.Drawing.Size(580, 471);
            this.dataGridUsers.TabIndex = 0;
            this.dataGridUsers.DoubleClick += new System.EventHandler(this.dataGridUsers_DoubleClick);
            // 
            // labelKod_Sot
            // 
            this.labelKod_Sot.AutoSize = true;
            this.labelKod_Sot.Location = new System.Drawing.Point(611, 28);
            this.labelKod_Sot.Name = "labelKod_Sot";
            this.labelKod_Sot.Size = new System.Drawing.Size(87, 13);
            this.labelKod_Sot.TabIndex = 1;
            this.labelKod_Sot.Text = "Код сотрудника";
            // 
            // textBoxKS
            // 
            this.textBoxKS.Location = new System.Drawing.Point(704, 25);
            this.textBoxKS.Name = "textBoxKS";
            this.textBoxKS.Size = new System.Drawing.Size(100, 20);
            this.textBoxKS.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxPP
            // 
            this.textBoxPP.Location = new System.Drawing.Point(968, 25);
            this.textBoxPP.Name = "textBoxPP";
            this.textBoxPP.Size = new System.Drawing.Size(100, 20);
            this.textBoxPP.TabIndex = 6;
            // 
            // labelPravo
            // 
            this.labelPravo.AutoSize = true;
            this.labelPravo.Location = new System.Drawing.Point(829, 28);
            this.labelPravo.Name = "labelPravo";
            this.labelPravo.Size = new System.Drawing.Size(133, 13);
            this.labelPravo.TabIndex = 5;
            this.labelPravo.Text = "Код права пользователя";
            // 
            // textBoxLP
            // 
            this.textBoxLP.Location = new System.Drawing.Point(1223, 25);
            this.textBoxLP.Name = "textBoxLP";
            this.textBoxLP.Size = new System.Drawing.Size(116, 20);
            this.textBoxLP.TabIndex = 8;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(1091, 28);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(112, 13);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Логин пользователя";
            // 
            // textBoxPasP
            // 
            this.textBoxPasP.Location = new System.Drawing.Point(736, 69);
            this.textBoxPasP.Name = "textBoxPasP";
            this.textBoxPasP.Size = new System.Drawing.Size(100, 20);
            this.textBoxPasP.TabIndex = 10;
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Location = new System.Drawing.Point(611, 72);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(119, 13);
            this.labelPas.TabIndex = 9;
            this.labelPas.Text = "Пароль пользователя";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Location = new System.Drawing.Point(614, 106);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 28;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(1236, 106);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 29;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(1128, 106);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 30;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(844, 165);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 75;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxKodUser
            // 
            this.textBoxKodUser.Location = new System.Drawing.Point(714, 166);
            this.textBoxKodUser.Name = "textBoxKodUser";
            this.textBoxKodUser.Size = new System.Drawing.Size(120, 20);
            this.textBoxKodUser.TabIndex = 74;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(611, 170);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(100, 13);
            this.labelUser.TabIndex = 73;
            this.labelUser.Text = "Код пользователя";
            // 
            // dataGridViewSpravka
            // 
            this.dataGridViewSpravka.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.dataGridViewSpravka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpravka.Location = new System.Drawing.Point(736, 236);
            this.dataGridViewSpravka.Name = "dataGridViewSpravka";
            this.dataGridViewSpravka.Size = new System.Drawing.Size(510, 219);
            this.dataGridViewSpravka.TabIndex = 72;
            // 
            // buttonSpravkaS
            // 
            this.buttonSpravkaS.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSpravkaS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpravkaS.Location = new System.Drawing.Point(978, 207);
            this.buttonSpravkaS.Name = "buttonSpravkaS";
            this.buttonSpravkaS.Size = new System.Drawing.Size(225, 23);
            this.buttonSpravkaS.TabIndex = 71;
            this.buttonSpravkaS.Text = "Справка по коду права пользователя";
            this.buttonSpravkaS.UseVisualStyleBackColor = false;
            this.buttonSpravkaS.Click += new System.EventHandler(this.buttonSpravkaS_Click);
            // 
            // buttonSpravkaSot
            // 
            this.buttonSpravkaSot.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSpravkaSot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpravkaSot.Location = new System.Drawing.Point(787, 207);
            this.buttonSpravkaSot.Name = "buttonSpravkaSot";
            this.buttonSpravkaSot.Size = new System.Drawing.Size(175, 23);
            this.buttonSpravkaSot.TabIndex = 70;
            this.buttonSpravkaSot.Text = "Справка по коду сотрудника";
            this.buttonSpravkaSot.UseVisualStyleBackColor = false;
            this.buttonSpravkaSot.Click += new System.EventHandler(this.buttonSpravkaSot_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxKodUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.dataGridViewSpravka);
            this.Controls.Add(this.buttonSpravkaS);
            this.Controls.Add(this.buttonSpravkaSot);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxPasP);
            this.Controls.Add(this.labelPas);
            this.Controls.Add(this.textBoxLP);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPP);
            this.Controls.Add(this.labelPravo);
            this.Controls.Add(this.textBoxKS);
            this.Controls.Add(this.labelKod_Sot);
            this.Controls.Add(this.dataGridUsers);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(1363, 471);
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpravka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Label labelKod_Sot;
        private System.Windows.Forms.TextBox textBoxKS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxPP;
        private System.Windows.Forms.Label labelPravo;
        private System.Windows.Forms.TextBox textBoxLP;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPasP;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxKodUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.DataGridView dataGridViewSpravka;
        private System.Windows.Forms.Button buttonSpravkaS;
        private System.Windows.Forms.Button buttonSpravkaSot;
    }
}
