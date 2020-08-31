namespace Convertion
{
    partial class frmConversion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBinaire = new System.Windows.Forms.TextBox();
            this.txtHexa = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBinaire = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnHexa = new System.Windows.Forms.Button();
            this.btnSortie = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversion de valeurs non signées";
            // 
            // txtBinaire
            // 
            this.txtBinaire.Location = new System.Drawing.Point(156, 149);
            this.txtBinaire.Name = "txtBinaire";
            this.txtBinaire.ReadOnly = true;
            this.txtBinaire.Size = new System.Drawing.Size(100, 20);
            this.txtBinaire.TabIndex = 1;
            // 
            // txtHexa
            // 
            this.txtHexa.Location = new System.Drawing.Point(360, 149);
            this.txtHexa.Name = "txtHexa";
            this.txtHexa.ReadOnly = true;
            this.txtHexa.Size = new System.Drawing.Size(100, 20);
            this.txtHexa.TabIndex = 2;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(550, 149);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.ReadOnly = true;
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Binaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hexadécimal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Décimal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHexa);
            this.groupBox1.Controls.Add(this.btnDecimal);
            this.groupBox1.Controls.Add(this.btnBinaire);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtValeur);
            this.groupBox1.Location = new System.Drawing.Point(156, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 193);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtValeur
            // 
            this.txtValeur.Location = new System.Drawing.Point(157, 55);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(100, 20);
            this.txtValeur.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Valeur à convertir";
            // 
            // btnBinaire
            // 
            this.btnBinaire.Location = new System.Drawing.Point(7, 162);
            this.btnBinaire.Name = "btnBinaire";
            this.btnBinaire.Size = new System.Drawing.Size(75, 23);
            this.btnBinaire.TabIndex = 2;
            this.btnBinaire.Text = "Binaire";
            this.btnBinaire.UseVisualStyleBackColor = true;
            this.btnBinaire.Click += new System.EventHandler(this.btnBinaire_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(355, 162);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnDecimal.TabIndex = 3;
            this.btnDecimal.Text = "Décimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            // 
            // btnHexa
            // 
            this.btnHexa.Location = new System.Drawing.Point(194, 162);
            this.btnHexa.Name = "btnHexa";
            this.btnHexa.Size = new System.Drawing.Size(75, 23);
            this.btnHexa.TabIndex = 4;
            this.btnHexa.Text = "Hexadécimal";
            this.btnHexa.UseVisualStyleBackColor = true;
            // 
            // btnSortie
            // 
            this.btnSortie.Location = new System.Drawing.Point(598, 395);
            this.btnSortie.Name = "btnSortie";
            this.btnSortie.Size = new System.Drawing.Size(75, 23);
            this.btnSortie.TabIndex = 5;
            this.btnSortie.Text = "Sortie";
            this.btnSortie.UseVisualStyleBackColor = true;
            // 
            // frmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSortie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtHexa);
            this.Controls.Add(this.txtBinaire);
            this.Controls.Add(this.label1);
            this.Name = "frmConversion";
            this.Text = "Programme Conversion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBinaire;
        private System.Windows.Forms.TextBox txtHexa;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHexa;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnBinaire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.Button btnSortie;
    }
}

