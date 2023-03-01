using CounterStrikeOdev.Classes;

namespace CounterStrikeForm
{
    public partial class SilahSec : Form
    {
        public SilahSec()
        {
            InitializeComponent();
         


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            SilahGoster bicak = new SilahGoster();
            bicak.SecilenSilah = new Bicak(); ;
            bicak.Show();

        }
        
        private void btnTabanca_Click(object sender, EventArgs e)
        {
            
            SilahGoster tabanca = new SilahGoster();
            tabanca.SecilenSilah = new Tabanca();
            tabanca.Show();

        }

        private void btnTaramaliTufek_Click(object sender, EventArgs e)
        {
            
            SilahGoster taramali = new SilahGoster();
            taramali.SecilenSilah = new TaramaliTufek();
            taramali.Show();
        }

        private void btnPompaliTufek_Click(object sender, EventArgs e)
        {
            
            SilahGoster pompali = new SilahGoster();
            pompali.SecilenSilah = new PompaliTufek();
            pompali.Show();

        }

        private void btnRoketAtar_Click(object sender, EventArgs e)
        {
            
            SilahGoster roketatar = new SilahGoster();
            roketatar.SecilenSilah = new RoketAtar();
            roketatar.Show();
        }

        private void lblSilahSeciminiYap_Click(object sender, EventArgs e)
        {

        }
    }
}