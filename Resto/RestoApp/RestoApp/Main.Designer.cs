namespace RestoApp
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.tcChoix = new System.Windows.Forms.TabControl();
            this.tpAcceuil = new System.Windows.Forms.TabPage();
            this.tpPlat = new System.Windows.Forms.TabPage();
            this.tpDessert = new System.Windows.Forms.TabPage();
            this.tpBoisson = new System.Windows.Forms.TabPage();
            this.lklblEntree = new System.Windows.Forms.LinkLabel();
            this.lklblAccueil = new System.Windows.Forms.LinkLabel();
            this.lklblPlat = new System.Windows.Forms.LinkLabel();
            this.lbPlat = new System.Windows.Forms.ListBox();
            this.lklblDessert = new System.Windows.Forms.LinkLabel();
            this.lbDessert = new System.Windows.Forms.ListBox();
            this.lklblBoisson = new System.Windows.Forms.LinkLabel();
            this.lbBoisson = new System.Windows.Forms.ListBox();
            this.lbEntree = new System.Windows.Forms.ListBox();
            this.imageListEntree = new System.Windows.Forms.ImageList(this.components);
            this.tcChoix.SuspendLayout();
            this.tpAcceuil.SuspendLayout();
            this.tpPlat.SuspendLayout();
            this.tpDessert.SuspendLayout();
            this.tpBoisson.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.Location = new System.Drawing.Point(12, 9);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(86, 24);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "Bonjour, ";
            // 
            // tcChoix
            // 
            this.tcChoix.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcChoix.Controls.Add(this.tpAcceuil);
            this.tcChoix.Controls.Add(this.tpPlat);
            this.tcChoix.Controls.Add(this.tpDessert);
            this.tcChoix.Controls.Add(this.tpBoisson);
            this.tcChoix.ItemSize = new System.Drawing.Size(50, 10);
            this.tcChoix.Location = new System.Drawing.Point(298, 13);
            this.tcChoix.Name = "tcChoix";
            this.tcChoix.SelectedIndex = 0;
            this.tcChoix.Size = new System.Drawing.Size(700, 625);
            this.tcChoix.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcChoix.TabIndex = 1;
            // 
            // tpAcceuil
            // 
            this.tpAcceuil.Controls.Add(this.lbEntree);
            this.tpAcceuil.Location = new System.Drawing.Point(4, 14);
            this.tpAcceuil.Name = "tpAcceuil";
            this.tpAcceuil.Padding = new System.Windows.Forms.Padding(3);
            this.tpAcceuil.Size = new System.Drawing.Size(692, 607);
            this.tpAcceuil.TabIndex = 1;
            this.tpAcceuil.UseVisualStyleBackColor = true;
            // 
            // tpPlat
            // 
            this.tpPlat.Controls.Add(this.lbPlat);
            this.tpPlat.Location = new System.Drawing.Point(4, 14);
            this.tpPlat.Name = "tpPlat";
            this.tpPlat.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlat.Size = new System.Drawing.Size(692, 607);
            this.tpPlat.TabIndex = 3;
            this.tpPlat.UseVisualStyleBackColor = true;
            // 
            // tpDessert
            // 
            this.tpDessert.Controls.Add(this.lbDessert);
            this.tpDessert.Location = new System.Drawing.Point(4, 14);
            this.tpDessert.Name = "tpDessert";
            this.tpDessert.Padding = new System.Windows.Forms.Padding(3);
            this.tpDessert.Size = new System.Drawing.Size(692, 607);
            this.tpDessert.TabIndex = 4;
            this.tpDessert.UseVisualStyleBackColor = true;
            // 
            // tpBoisson
            // 
            this.tpBoisson.Controls.Add(this.lbBoisson);
            this.tpBoisson.Location = new System.Drawing.Point(4, 14);
            this.tpBoisson.Name = "tpBoisson";
            this.tpBoisson.Padding = new System.Windows.Forms.Padding(3);
            this.tpBoisson.Size = new System.Drawing.Size(692, 607);
            this.tpBoisson.TabIndex = 5;
            this.tpBoisson.UseVisualStyleBackColor = true;
            // 
            // lklblEntree
            // 
            this.lklblEntree.AutoSize = true;
            this.lklblEntree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblEntree.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklblEntree.Location = new System.Drawing.Point(12, 150);
            this.lklblEntree.Name = "lklblEntree";
            this.lklblEntree.Size = new System.Drawing.Size(66, 24);
            this.lklblEntree.TabIndex = 2;
            this.lklblEntree.TabStop = true;
            this.lklblEntree.Text = "Entrée";
            this.lklblEntree.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblEntree_LinkClicked);
            // 
            // lklblAccueil
            // 
            this.lklblAccueil.AutoSize = true;
            this.lklblAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblAccueil.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklblAccueil.Location = new System.Drawing.Point(12, 124);
            this.lklblAccueil.Name = "lklblAccueil";
            this.lklblAccueil.Size = new System.Drawing.Size(73, 24);
            this.lklblAccueil.TabIndex = 3;
            this.lklblAccueil.TabStop = true;
            this.lklblAccueil.Text = "Accueil";
            this.lklblAccueil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblAccueil_LinkClicked);
            // 
            // lklblPlat
            // 
            this.lklblPlat.AutoSize = true;
            this.lklblPlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblPlat.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklblPlat.Location = new System.Drawing.Point(12, 174);
            this.lklblPlat.Name = "lklblPlat";
            this.lklblPlat.Size = new System.Drawing.Size(40, 24);
            this.lklblPlat.TabIndex = 4;
            this.lklblPlat.TabStop = true;
            this.lklblPlat.Text = "Plat";
            this.lklblPlat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblPlat_LinkClicked);
            // 
            // lbPlat
            // 
            this.lbPlat.FormattingEnabled = true;
            this.lbPlat.Location = new System.Drawing.Point(4, 4);
            this.lbPlat.Name = "lbPlat";
            this.lbPlat.Size = new System.Drawing.Size(700, 615);
            this.lbPlat.TabIndex = 0;
            // 
            // lklblDessert
            // 
            this.lklblDessert.AutoSize = true;
            this.lklblDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblDessert.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklblDessert.Location = new System.Drawing.Point(12, 198);
            this.lklblDessert.Name = "lklblDessert";
            this.lklblDessert.Size = new System.Drawing.Size(73, 24);
            this.lklblDessert.TabIndex = 5;
            this.lklblDessert.TabStop = true;
            this.lklblDessert.Text = "Dessert";
            this.lklblDessert.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblDessert_LinkClicked_1);
            // 
            // lbDessert
            // 
            this.lbDessert.FormattingEnabled = true;
            this.lbDessert.Location = new System.Drawing.Point(3, 3);
            this.lbDessert.Name = "lbDessert";
            this.lbDessert.Size = new System.Drawing.Size(700, 615);
            this.lbDessert.TabIndex = 0;
            // 
            // lklblBoisson
            // 
            this.lklblBoisson.AutoSize = true;
            this.lklblBoisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblBoisson.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklblBoisson.Location = new System.Drawing.Point(12, 222);
            this.lklblBoisson.Name = "lklblBoisson";
            this.lklblBoisson.Size = new System.Drawing.Size(77, 24);
            this.lklblBoisson.TabIndex = 6;
            this.lklblBoisson.TabStop = true;
            this.lklblBoisson.Text = "Boisson";
            this.lklblBoisson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblBoisson_LinkClicked);
            // 
            // lbBoisson
            // 
            this.lbBoisson.FormattingEnabled = true;
            this.lbBoisson.Location = new System.Drawing.Point(0, 0);
            this.lbBoisson.Name = "lbBoisson";
            this.lbBoisson.Size = new System.Drawing.Size(700, 615);
            this.lbBoisson.TabIndex = 0;
            // 
            // lbEntree
            // 
            this.lbEntree.FormattingEnabled = true;
            this.lbEntree.Location = new System.Drawing.Point(0, 0);
            this.lbEntree.Name = "lbEntree";
            this.lbEntree.Size = new System.Drawing.Size(120, 95);
            this.lbEntree.TabIndex = 0;
            // 
            // imageListEntree
            // 
            this.imageListEntree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListEntree.ImageStream")));
            this.imageListEntree.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListEntree.Images.SetKeyName(0, "Salade_nicoise.png");
            this.imageListEntree.Images.SetKeyName(1, "Salade_de_lentilles.png");
            this.imageListEntree.Images.SetKeyName(2, "Salade_grecque.png");
            this.imageListEntree.Images.SetKeyName(3, "Salade_lyonnaise.png");
            this.imageListEntree.Images.SetKeyName(4, "Salade_cesar.png");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 650);
            this.Controls.Add(this.lklblBoisson);
            this.Controls.Add(this.lklblDessert);
            this.Controls.Add(this.lklblPlat);
            this.Controls.Add(this.lklblAccueil);
            this.Controls.Add(this.lklblEntree);
            this.Controls.Add(this.tcChoix);
            this.Controls.Add(this.lblBienvenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tcChoix.ResumeLayout(false);
            this.tpAcceuil.ResumeLayout(false);
            this.tpPlat.ResumeLayout(false);
            this.tpDessert.ResumeLayout(false);
            this.tpBoisson.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.TabControl tcChoix;
        private System.Windows.Forms.TabPage tpAcceuil;
        private System.Windows.Forms.LinkLabel lklblEntree;
        private System.Windows.Forms.TabPage tpPlat;
        private System.Windows.Forms.TabPage tpDessert;
        private System.Windows.Forms.TabPage tpBoisson;
        private System.Windows.Forms.LinkLabel lklblAccueil;
        private System.Windows.Forms.LinkLabel lklblPlat;
        private System.Windows.Forms.ListBox lbPlat;
        private System.Windows.Forms.LinkLabel lklblDessert;
        private System.Windows.Forms.ListBox lbDessert;
        private System.Windows.Forms.LinkLabel lklblBoisson;
        private System.Windows.Forms.ListBox lbBoisson;
        private System.Windows.Forms.ListBox lbEntree;
        private System.Windows.Forms.ImageList imageListEntree;
    }
}