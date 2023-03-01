using CounterStrikeForm.Enums;
using CounterStrikeOdev.Classes;

namespace CounterStrikeForm
{
    public partial class SilahGoster : Form
    {

        public Silahlar SecilenSilah { get; set; }
        public SilahGoster()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void SilahGoster_Load(object sender, EventArgs e)
        {
            lblZoom.Visible = false;
            btnZoomAc.Visible = false;
            lblModel.Text += SecilenSilah.Model;
            lblAgirlik.Text += SecilenSilah.Agirlik;
            if (SecilenSilah is Bicak)
            {
                lblMermiSayisi.Text = "Biley Durumu : " + ((Bicak)(SecilenSilah)).BileyDurumu.ToString();
                btnAtesEtKes.Text = "Kes";
                btnSarjorBiley.Text = "Bileyle";
                pbSilahResmi.ImageLocation = SecilenSilah.ResimLokasyonu;
            }
            else
            {
                lblMermiSayisi.Text = ((AtesliSilahlar)(SecilenSilah)).MermiSayisi.ToString();
                btnAtesEtKes.Text = "Ates Et";
                btnSarjorBiley.Text = "Sarjoru Doldur";
                pbSilahResmi.ImageLocation = SecilenSilah.ResimLokasyonu;
                
                if (SecilenSilah is TaramaliTufek)
                {

                    btnZoomAc.Visible = true;
                    lblZoom.Visible = true;
                    lblZoom.Text = "Zoom Durumu : " + ((TaramaliTufek)(SecilenSilah)).zoom;

                }
                if (SecilenSilah is RoketAtar)
                {

                    btnZoomAc.Visible = true;
                    lblZoom.Visible = true;
                    lblZoom.Text = "Zoom Durumu : " + ((RoketAtar)(SecilenSilah)).zoom;
                }
            }
        }
        private void btnZoomAc_Click(object sender, EventArgs e)
        {
            if (SecilenSilah is TaramaliTufek)
                ((TaramaliTufek)(SecilenSilah)).ZoomChange();
            if (SecilenSilah is RoketAtar)
                ((RoketAtar)(SecilenSilah)).ZoomChange();
        }

        private void btnAtesEtKes_Click(object sender, EventArgs e)
        {
            if (SecilenSilah is Bicak)
            {

                ((Bicak)(SecilenSilah)).Kes();
                lblMermiSayisi.Text = "Biley Durumu : " + ((Bicak)(SecilenSilah)).BileyDurumu.ToString();
            }

            else
            {
                ((AtesliSilahlar)(SecilenSilah)).AtesEt();
                lblMermiSayisi.Text = ((AtesliSilahlar)(SecilenSilah)).MermiSayisi.ToString();
            }
        }

        private void btnSarjorBiley_Click(object sender, EventArgs e)
        {
            if (SecilenSilah is Bicak)
            {
                ((Bicak)(SecilenSilah)).Bileyle();
                lblMermiSayisi.Text = "Biley Durumu : " + ((Bicak)(SecilenSilah)).BileyDurumu.ToString();
            }
            else if (SecilenSilah is PompaliTufek)
            {
                ((PompaliTufek)(SecilenSilah)).SarjorDoldur();
                lblMermiSayisi.Text = ((AtesliSilahlar)(SecilenSilah)).MermiSayisi.ToString();
            }
            else
            {
                ((AtesliSilahlar)(SecilenSilah)).SarjorDoldur();
                lblMermiSayisi.Text = ((AtesliSilahlar)(SecilenSilah)).MermiSayisi.ToString();
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
