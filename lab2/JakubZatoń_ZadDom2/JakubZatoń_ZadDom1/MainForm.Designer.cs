namespace JakubZatoń_ZadDom1
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelStud = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelChair = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAka = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxStud = new System.Windows.Forms.TextBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.textBoxChair = new System.Windows.Forms.TextBox();
            this.textBoxFood = new System.Windows.Forms.TextBox();
            this.textBoxAka = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonChair = new System.Windows.Forms.Button();
            this.buttonFood = new System.Windows.Forms.Button();
            this.buttonAka = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.buttonKier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSprzataczka = new System.Windows.Forms.Button();
            this.buttonPortierka = new System.Windows.Forms.Button();
            this.textBoxNameKier = new System.Windows.Forms.TextBox();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.progressBarEnemy = new System.Windows.Forms.ProgressBar();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDemolish = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(667, 384);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(121, 54);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerStart
            // 
            this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(164, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(439, 57);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "AKADEMIK - Jakub Zatoń";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelStud
            // 
            this.labelStud.AutoSize = true;
            this.labelStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStud.Location = new System.Drawing.Point(716, 69);
            this.labelStud.Name = "labelStud";
            this.labelStud.Size = new System.Drawing.Size(72, 20);
            this.labelStud.TabIndex = 3;
            this.labelStud.Text = "Studenci";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMoney.Location = new System.Drawing.Point(710, 239);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(78, 20);
            this.labelMoney.TabIndex = 4;
            this.labelMoney.Text = "Pieniądze";
            // 
            // labelChair
            // 
            this.labelChair.AutoSize = true;
            this.labelChair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChair.Location = new System.Drawing.Point(716, 330);
            this.labelChair.Name = "labelChair";
            this.labelChair.Size = new System.Drawing.Size(62, 20);
            this.labelChair.TabIndex = 5;
            this.labelChair.Text = "Krzesła";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 9;
            // 
            // labelAka
            // 
            this.labelAka.AutoSize = true;
            this.labelAka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAka.Location = new System.Drawing.Point(12, 197);
            this.labelAka.Name = "labelAka";
            this.labelAka.Size = new System.Drawing.Size(134, 20);
            this.labelAka.TabIndex = 7;
            this.labelAka.Text = "Ilość akademików";
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFood.Location = new System.Drawing.Point(12, 330);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(58, 20);
            this.labelFood.TabIndex = 8;
            this.labelFood.Text = "Obiady";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatus.Location = new System.Drawing.Point(12, 69);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(57, 20);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "Ranga";
            // 
            // textBoxStud
            // 
            this.textBoxStud.Location = new System.Drawing.Point(714, 92);
            this.textBoxStud.Name = "textBoxStud";
            this.textBoxStud.Size = new System.Drawing.Size(74, 20);
            this.textBoxStud.TabIndex = 11;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(714, 261);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(74, 20);
            this.textBoxMoney.TabIndex = 12;
            // 
            // textBoxChair
            // 
            this.textBoxChair.Location = new System.Drawing.Point(714, 307);
            this.textBoxChair.Name = "textBoxChair";
            this.textBoxChair.Size = new System.Drawing.Size(74, 20);
            this.textBoxChair.TabIndex = 13;
            // 
            // textBoxFood
            // 
            this.textBoxFood.Location = new System.Drawing.Point(16, 307);
            this.textBoxFood.Name = "textBoxFood";
            this.textBoxFood.Size = new System.Drawing.Size(74, 20);
            this.textBoxFood.TabIndex = 14;
            // 
            // textBoxAka
            // 
            this.textBoxAka.Location = new System.Drawing.Point(16, 220);
            this.textBoxAka.Name = "textBoxAka";
            this.textBoxAka.Size = new System.Drawing.Size(74, 20);
            this.textBoxAka.TabIndex = 15;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(16, 92);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(74, 20);
            this.textBoxStatus.TabIndex = 16;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 384);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(121, 54);
            this.buttonClose.TabIndex = 17;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonChair
            // 
            this.buttonChair.Location = new System.Drawing.Point(636, 304);
            this.buttonChair.Name = "buttonChair";
            this.buttonChair.Size = new System.Drawing.Size(72, 46);
            this.buttonChair.TabIndex = 18;
            this.buttonChair.Text = "Kup krzesła za 100";
            this.buttonChair.UseVisualStyleBackColor = true;
            this.buttonChair.Click += new System.EventHandler(this.buttonChair_Click);
            // 
            // buttonFood
            // 
            this.buttonFood.Location = new System.Drawing.Point(96, 307);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(72, 46);
            this.buttonFood.TabIndex = 19;
            this.buttonFood.Text = "Kup obiady za 50";
            this.buttonFood.UseVisualStyleBackColor = true;
            this.buttonFood.Click += new System.EventHandler(this.buttonFood_Click);
            // 
            // buttonAka
            // 
            this.buttonAka.Location = new System.Drawing.Point(96, 220);
            this.buttonAka.Name = "buttonAka";
            this.buttonAka.Size = new System.Drawing.Size(72, 61);
            this.buttonAka.TabIndex = 20;
            this.buttonAka.Text = "Kup akademik za 1000";
            this.buttonAka.UseVisualStyleBackColor = true;
            this.buttonAka.Click += new System.EventHandler(this.buttonAka_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(96, 78);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(72, 46);
            this.buttonStatus.TabIndex = 21;
            this.buttonStatus.Text = "Kup range za 5000";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // buttonKier
            // 
            this.buttonKier.Location = new System.Drawing.Point(158, 415);
            this.buttonKier.Name = "buttonKier";
            this.buttonKier.Size = new System.Drawing.Size(81, 23);
            this.buttonKier.TabIndex = 22;
            this.buttonKier.Text = "Kierowniczka";
            this.buttonKier.UseVisualStyleBackColor = true;
            this.buttonKier.Click += new System.EventHandler(this.buttonKier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Wybierz klasę kierowniczki";
            // 
            // buttonSprzataczka
            // 
            this.buttonSprzataczka.Location = new System.Drawing.Point(245, 415);
            this.buttonSprzataczka.Name = "buttonSprzataczka";
            this.buttonSprzataczka.Size = new System.Drawing.Size(82, 23);
            this.buttonSprzataczka.TabIndex = 24;
            this.buttonSprzataczka.Text = "Sprzataczka";
            this.buttonSprzataczka.UseVisualStyleBackColor = true;
            this.buttonSprzataczka.Click += new System.EventHandler(this.buttonSprzataczka_Click);
            // 
            // buttonPortierka
            // 
            this.buttonPortierka.Location = new System.Drawing.Point(333, 415);
            this.buttonPortierka.Name = "buttonPortierka";
            this.buttonPortierka.Size = new System.Drawing.Size(87, 23);
            this.buttonPortierka.TabIndex = 25;
            this.buttonPortierka.Text = "Portierka";
            this.buttonPortierka.UseVisualStyleBackColor = true;
            this.buttonPortierka.Click += new System.EventHandler(this.buttonPortierka_Click);
            // 
            // textBoxNameKier
            // 
            this.textBoxNameKier.Location = new System.Drawing.Point(295, 381);
            this.textBoxNameKier.Name = "textBoxNameKier";
            this.textBoxNameKier.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameKier.TabIndex = 26;
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Location = new System.Drawing.Point(401, 381);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(100, 20);
            this.textBoxLevel.TabIndex = 27;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(429, 362);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(29, 13);
            this.labelLevel.TabIndex = 28;
            this.labelLevel.Text = "level";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(429, 420);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(75, 13);
            this.labelPrice.TabIndex = 29;
            this.labelPrice.Text = "Koszt - 2000zł";
            // 
            // progressBarEnemy
            // 
            this.progressBarEnemy.Location = new System.Drawing.Point(609, 131);
            this.progressBarEnemy.Maximum = 1000;
            this.progressBarEnemy.Name = "progressBarEnemy";
            this.progressBarEnemy.Size = new System.Drawing.Size(179, 23);
            this.progressBarEnemy.Step = 1;
            this.progressBarEnemy.TabIndex = 30;
            // 
            // buttonAttack
            // 
            this.buttonAttack.Location = new System.Drawing.Point(609, 160);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(179, 23);
            this.buttonAttack.TabIndex = 31;
            this.buttonAttack.Text = "kup wrogiego menela 300zł";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Zniszczenie wrogiego akademika";
            // 
            // buttonDemolish
            // 
            this.buttonDemolish.Location = new System.Drawing.Point(612, 218);
            this.buttonDemolish.Name = "buttonDemolish";
            this.buttonDemolish.Size = new System.Drawing.Size(98, 23);
            this.buttonDemolish.TabIndex = 33;
            this.buttonDemolish.Text = "Buldożer - 900zł";
            this.buttonDemolish.UseVisualStyleBackColor = true;
            this.buttonDemolish.Click += new System.EventHandler(this.buttonDemolish_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(610, 92);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(78, 20);
            this.textBoxAmount.TabIndex = 34;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(609, 74);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(75, 13);
            this.labelAmount.TabIndex = 35;
            this.labelAmount.Text = "Wielkość armii";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Kup wrogi akademik - 10000zł";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.buttonDemolish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAttack);
            this.Controls.Add(this.progressBarEnemy);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.textBoxNameKier);
            this.Controls.Add(this.buttonPortierka);
            this.Controls.Add(this.buttonSprzataczka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKier);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.buttonAka);
            this.Controls.Add(this.buttonFood);
            this.Controls.Add(this.buttonChair);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxAka);
            this.Controls.Add(this.textBoxFood);
            this.Controls.Add(this.textBoxChair);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.textBoxStud);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.labelAka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelChair);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelStud);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonStart);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStud;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelChair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAka;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxStud;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.TextBox textBoxChair;
        private System.Windows.Forms.TextBox textBoxFood;
        private System.Windows.Forms.TextBox textBoxAka;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonChair;
        private System.Windows.Forms.Button buttonFood;
        private System.Windows.Forms.Button buttonAka;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.Button buttonKier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSprzataczka;
        private System.Windows.Forms.Button buttonPortierka;
        private System.Windows.Forms.TextBox textBoxNameKier;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ProgressBar progressBarEnemy;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDemolish;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button button1;
    }
}

