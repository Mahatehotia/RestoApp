namespace RestoApp
{
    partial class FrmIdentification
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIdentifier = new System.Windows.Forms.Button();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIdentifier);
            this.groupBox1.Controls.Add(this.tbxNom);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(355, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identification";
            // 
            // btnIdentifier
            // 
            this.btnIdentifier.Image = global::RestoApp.Properties.Resources.user_add;
            this.btnIdentifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIdentifier.Location = new System.Drawing.Point(94, 134);
            this.btnIdentifier.Name = "btnIdentifier";
            this.btnIdentifier.Size = new System.Drawing.Size(200, 40);
            this.btnIdentifier.TabIndex = 2;
            this.btnIdentifier.Text = "&S\'identifier";
            this.btnIdentifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIdentifier.UseVisualStyleBackColor = true;
            this.btnIdentifier.Click += new System.EventHandler(this.btnIdentifier_Click);
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(94, 32);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(200, 29);
            this.tbxNom.TabIndex = 1;
            this.tbxNom.TextChanged += new System.EventHandler(this.tbxNom_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 35);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(61, 24);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::RestoApp.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(968, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmIdentification
            // 
            this.AcceptButton = this.btnIdentifier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestoApp.Properties.Resources.fond_de_page;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1010, 650);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIdentification";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.FrmIdentification_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnIdentifier;
        private System.Windows.Forms.Button btnClose;
    }
}

