namespace JakubZatonLab2
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
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAddHorse = new System.Windows.Forms.Button();
            this.textBoxFavNumber = new System.Windows.Forms.TextBox();
            this.textBoxHorseName = new System.Windows.Forms.TextBox();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelFav = new System.Windows.Forms.Label();
            this.textBoxCornColor = new System.Windows.Forms.TextBox();
            this.labelNameHorn = new System.Windows.Forms.Label();
            this.buttonAddUnicorn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(581, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(207, 39);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Jakub Zatoń";
            // 
            // buttonAddHorse
            // 
            this.buttonAddHorse.Location = new System.Drawing.Point(65, 144);
            this.buttonAddHorse.Name = "buttonAddHorse";
            this.buttonAddHorse.Size = new System.Drawing.Size(138, 45);
            this.buttonAddHorse.TabIndex = 1;
            this.buttonAddHorse.Text = "Add Horse";
            this.buttonAddHorse.UseVisualStyleBackColor = true;
            this.buttonAddHorse.Click += new System.EventHandler(this.buttonAddHorse_Click);
            // 
            // textBoxFavNumber
            // 
            this.textBoxFavNumber.Location = new System.Drawing.Point(188, 99);
            this.textBoxFavNumber.Name = "textBoxFavNumber";
            this.textBoxFavNumber.Size = new System.Drawing.Size(71, 20);
            this.textBoxFavNumber.TabIndex = 2;
            // 
            // textBoxHorseName
            // 
            this.textBoxHorseName.Location = new System.Drawing.Point(134, 42);
            this.textBoxHorseName.Name = "textBoxHorseName";
            this.textBoxHorseName.Size = new System.Drawing.Size(125, 20);
            this.textBoxHorseName.TabIndex = 3;
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Location = new System.Drawing.Point(62, 45);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(66, 13);
            this.labelName2.TabIndex = 4;
            this.labelName2.Text = "Horse Name";
            // 
            // labelFav
            // 
            this.labelFav.AutoSize = true;
            this.labelFav.Location = new System.Drawing.Point(37, 102);
            this.labelFav.Name = "labelFav";
            this.labelFav.Size = new System.Drawing.Size(91, 13);
            this.labelFav.TabIndex = 5;
            this.labelFav.Text = "Favourite Number";
            this.labelFav.Click += new System.EventHandler(this.labelFav_Click);
            // 
            // textBoxCornColor
            // 
            this.textBoxCornColor.Location = new System.Drawing.Point(661, 222);
            this.textBoxCornColor.Name = "textBoxCornColor";
            this.textBoxCornColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxCornColor.TabIndex = 6;
            // 
            // labelNameHorn
            // 
            this.labelNameHorn.AutoSize = true;
            this.labelNameHorn.Location = new System.Drawing.Point(570, 225);
            this.labelNameHorn.Name = "labelNameHorn";
            this.labelNameHorn.Size = new System.Drawing.Size(60, 13);
            this.labelNameHorn.TabIndex = 7;
            this.labelNameHorn.Text = "Kolor Rogu";
            // 
            // buttonAddUnicorn
            // 
            this.buttonAddUnicorn.Location = new System.Drawing.Point(588, 259);
            this.buttonAddUnicorn.Name = "buttonAddUnicorn";
            this.buttonAddUnicorn.Size = new System.Drawing.Size(138, 45);
            this.buttonAddUnicorn.TabIndex = 8;
            this.buttonAddUnicorn.Text = "Add Unicorn";
            this.buttonAddUnicorn.UseVisualStyleBackColor = true;
            this.buttonAddUnicorn.Click += new System.EventHandler(this.buttonAddUnicorn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddUnicorn);
            this.Controls.Add(this.labelNameHorn);
            this.Controls.Add(this.textBoxCornColor);
            this.Controls.Add(this.labelFav);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.textBoxHorseName);
            this.Controls.Add(this.textBoxFavNumber);
            this.Controls.Add(this.buttonAddHorse);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAddHorse;
        private System.Windows.Forms.TextBox textBoxFavNumber;
        private System.Windows.Forms.TextBox textBoxHorseName;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelFav;
        private System.Windows.Forms.TextBox textBoxCornColor;
        private System.Windows.Forms.Label labelNameHorn;
        private System.Windows.Forms.Button buttonAddUnicorn;
    }
}

