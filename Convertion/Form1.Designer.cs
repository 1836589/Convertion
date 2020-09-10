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
            this.btnHexa = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnBinaire = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.btnSortie = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversion de valeurs non signées";
            // 
            // txtBinaire
            // 
            this.txtBinaire.Location = new System.Drawing.Point(208, 183);
            this.txtBinaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBinaire.Name = "txtBinaire";
            this.txtBinaire.ReadOnly = true;
            this.txtBinaire.Size = new System.Drawing.Size(132, 22);
            this.txtBinaire.TabIndex = 1;
            // 
            // txtHexa
            // 
            this.txtHexa.Location = new System.Drawing.Point(480, 183);
            this.txtHexa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHexa.Name = "txtHexa";
            this.txtHexa.ReadOnly = true;
            this.txtHexa.Size = new System.Drawing.Size(132, 22);
            this.txtHexa.TabIndex = 2;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(733, 183);
            this.txtDecimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.ReadOnly = true;
            this.txtDecimal.Size = new System.Drawing.Size(132, 22);
            this.txtDecimal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Binaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hexadécimal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(729, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(208, 277);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(581, 238);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnHexa
            // 
            this.btnHexa.Location = new System.Drawing.Point(259, 199);
            this.btnHexa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHexa.Name = "btnHexa";
            this.btnHexa.Size = new System.Drawing.Size(100, 28);
            this.btnHexa.TabIndex = 4;
            this.btnHexa.Text = "Hexadécimal";
            this.btnHexa.UseVisualStyleBackColor = true;
            this.btnHexa.Click += new System.EventHandler(this.btnHexa_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(473, 199);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(100, 28);
            this.btnDecimal.TabIndex = 3;
            this.btnDecimal.Text = "Décimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnBinaire
            // 
            this.btnBinaire.Location = new System.Drawing.Point(9, 199);
            this.btnBinaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBinaire.Name = "btnBinaire";
            this.btnBinaire.Size = new System.Drawing.Size(100, 28);
            this.btnBinaire.TabIndex = 2;
            this.btnBinaire.Text = "Binaire";
            this.btnBinaire.UseVisualStyleBackColor = true;
            this.btnBinaire.Click += new System.EventHandler(this.btnBinaire_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Valeur à convertir";
            // 
            // txtValeur
            // 
            this.txtValeur.Location = new System.Drawing.Point(209, 68);
            this.txtValeur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(132, 22);
            this.txtValeur.TabIndex = 0;
            // 
            // btnSortie
            // 
            this.btnSortie.Location = new System.Drawing.Point(797, 486);
            this.btnSortie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSortie.Name = "btnSortie";
            this.btnSortie.Size = new System.Drawing.Size(100, 28);
            this.btnSortie.TabIndex = 5;
            this.btnSortie.Text = "Sortie";
            this.btnSortie.UseVisualStyleBackColor = true;
            this.btnSortie.Click += new System.EventHandler(this.btnSortie_Click);
            // 
            // frmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSortie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtHexa);
            this.Controls.Add(this.txtBinaire);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

