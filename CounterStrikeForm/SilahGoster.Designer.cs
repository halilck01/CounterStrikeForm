namespace CounterStrikeForm
{
    partial class SilahGoster
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
            this.pbSilahResmi = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblAgirlik = new System.Windows.Forms.Label();
            this.lblMermiSayisi = new System.Windows.Forms.Label();
            this.btnAtesEtKes = new System.Windows.Forms.Button();
            this.btnSarjorBiley = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnZoomAc = new System.Windows.Forms.Button();
            this.lblZoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilahResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSilahResmi
            // 
            this.pbSilahResmi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pbSilahResmi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSilahResmi.Location = new System.Drawing.Point(63, 22);
            this.pbSilahResmi.Name = "pbSilahResmi";
            this.pbSilahResmi.Size = new System.Drawing.Size(197, 186);
            this.pbSilahResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSilahResmi.TabIndex = 0;
            this.pbSilahResmi.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silah Detayları: ";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(82, 272);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(53, 15);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model :  ";
            this.lblModel.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAgirlik
            // 
            this.lblAgirlik.AutoSize = true;
            this.lblAgirlik.Location = new System.Drawing.Point(82, 297);
            this.lblAgirlik.Name = "lblAgirlik";
            this.lblAgirlik.Size = new System.Drawing.Size(50, 15);
            this.lblAgirlik.TabIndex = 3;
            this.lblAgirlik.Text = "Agirlik : ";
            // 
            // lblMermiSayisi
            // 
            this.lblMermiSayisi.AutoSize = true;
            this.lblMermiSayisi.Location = new System.Drawing.Point(82, 322);
            this.lblMermiSayisi.Name = "lblMermiSayisi";
            this.lblMermiSayisi.Size = new System.Drawing.Size(83, 15);
            this.lblMermiSayisi.TabIndex = 4;
            this.lblMermiSayisi.Text = "Mermi Sayisi : ";
            // 
            // btnAtesEtKes
            // 
            this.btnAtesEtKes.Location = new System.Drawing.Point(82, 425);
            this.btnAtesEtKes.Name = "btnAtesEtKes";
            this.btnAtesEtKes.Size = new System.Drawing.Size(163, 34);
            this.btnAtesEtKes.TabIndex = 5;
            this.btnAtesEtKes.Text = "Ates Et / Kes";
            this.btnAtesEtKes.UseVisualStyleBackColor = true;
            this.btnAtesEtKes.Click += new System.EventHandler(this.btnAtesEtKes_Click);
            // 
            // btnSarjorBiley
            // 
            this.btnSarjorBiley.Location = new System.Drawing.Point(82, 465);
            this.btnSarjorBiley.Name = "btnSarjorBiley";
            this.btnSarjorBiley.Size = new System.Drawing.Size(163, 34);
            this.btnSarjorBiley.TabIndex = 6;
            this.btnSarjorBiley.Text = "Sarjor Doldur / Bileyle";
            this.btnSarjorBiley.UseVisualStyleBackColor = true;
            this.btnSarjorBiley.Click += new System.EventHandler(this.btnSarjorBiley_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(82, 505);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(163, 34);
            this.btnGeriDon.TabIndex = 7;
            this.btnGeriDon.Text = "Baska Silah Sec";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnZoomAc
            // 
            this.btnZoomAc.Location = new System.Drawing.Point(82, 385);
            this.btnZoomAc.Name = "btnZoomAc";
            this.btnZoomAc.Size = new System.Drawing.Size(163, 34);
            this.btnZoomAc.TabIndex = 8;
            this.btnZoomAc.Text = "Zoom Ac/Kapat";
            this.btnZoomAc.UseVisualStyleBackColor = true;
            this.btnZoomAc.Click += new System.EventHandler(this.btnZoomAc_Click);
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(82, 347);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(95, 15);
            this.lblZoom.TabIndex = 9;
            this.lblZoom.Text = "Zoom Durumu : ";
            // 
            // SilahGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 596);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.btnZoomAc);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnSarjorBiley);
            this.Controls.Add(this.btnAtesEtKes);
            this.Controls.Add(this.lblMermiSayisi);
            this.Controls.Add(this.lblAgirlik);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSilahResmi);
            this.Name = "SilahGoster";
            this.Text = "SilahGoster";
            this.Load += new System.EventHandler(this.SilahGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSilahResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbSilahResmi;
        private Label label1;
        private Label lblModel;
        private Label lblAgirlik;
        private Label lblMermiSayisi;
        private Button btnAtesEtKes;
        private Button btnSarjorBiley;
        private Button btnGeriDon;
        private Button btnZoomAc;
        private Label lblZoom;
    }
}