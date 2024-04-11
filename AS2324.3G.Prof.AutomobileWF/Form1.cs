using System.Media;

namespace AS2324._3G.Prof.AutomobileWF
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer;


        const int stepAccellerazione = 10;
        const int stepFrenata = -5;

        double velocita = 0;

        double vento = 0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();

            // parameters setting on progress bar
            prbVelocita.Minimum = 0;
            prbVelocita.Maximum = 160;

            grbComandi.Enabled = false;
            soundPlayer = new SoundPlayer();
            // Imposta il percorso del file audio
            soundPlayer.SoundLocation = @"C:\Users\coent\Downloads\goofy-ahh-car-horn-200870.wav";
        }

        private void btnAccellera_Click(object sender, EventArgs e)
        {
                vento = random.Next(-1, 3);
                label1.Text = "Vento " + vento * 10 + " km/h";
                velocita += stepAccellerazione + vento;
                lblVelocita.Text = velocita + " km/h";
            switch (cmbStrada.Text)
            {
                case "Autostrada(130 km / h)":

                    string autostrada = "Benvenuto in autostrada ti ricordiamo che qua il limite è di 130km/h";
                    lstMonitor.Items.Add(autostrada);
                    prbVelocita.Maximum = 130;
                    break;
                case "Extraurbana(90 km / h)":

                    string extraurbana = "Benvenuto in strada extraurbana ti ricordiamo che qua il limite è di 110 km/h";
                    lstMonitor.Items.Add(extraurbana);
                    prbVelocita.Maximum = 110;
                    break;
                case "Urbana(50 km / h)":

                    string urbana = "Benvenuto in strada urbana ti ricordiamo che il limite qua è di 50 km/h";
                    lstMonitor.Items.Add(urbana);
                    prbVelocita.Maximum = 50;
                    break;
                default:
                    break;
            }


            monitor();
        }

        private void btnFrena_Click(object sender, EventArgs e)
        {
            velocita += stepFrenata + vento;
            vento = random.Next(-1, 3);
            label1.Text = "Vento " + vento*10 + " km/h";
            lblVelocita.Text = velocita + " km/h";
            switch (cmbStrada.Text)
            {
                case "Autostrada(130 km / h)":

                    string autostrada = "Benvenuto in autostrada ti ricordiamo che qua il limite è di 130km/h";
                    lstMonitor.Items.Add(autostrada);
                    prbVelocita.Maximum = 130;
                    break;
                case "Extraurbana(90 km / h)":

                    string extraurbana = "Benvenuto in strada extraurbana ti ricordiamo che qua il limite è di 110 km/h";
                    lstMonitor.Items.Add(extraurbana);
                    prbVelocita.Maximum = 110;
                    break;
                case "Urbana(50 km / h)":

                    string urbana = "Benvenuto in strada urbana ti ricordiamo che il limite qua è di 50 km/h";
                    lstMonitor.Items.Add(urbana);
                    prbVelocita.Maximum = 50;
                    break;
                default:
                    break;
            }

            monitor();
        }


        private void monitor()
        {
            prbVelocita.Value = (int)velocita;
            if (grbComandi.Enabled == true)
            {
                
                if (chkCinture.Checked == false)
                {
                    
                    string cinture = "NON HAI ALLACCIATO LE CINTURE";
                    lstMonitor.Items.Add(cinture);
                }
            }

            
        }

        private void chkAccensione_CheckedChanged(object sender, EventArgs e)
        {
            lstMonitor.Items.Clear();
            if (chkAccensione.Checked == true && cmbStrada.Text != "")
            {
                grbComandi.Enabled = true;
            }      
            else
            {
                string strada = "DEVI SCEGLIERE UNA STRADA";
                lstMonitor.Items.Add(strada);
                grbComandi.Enabled = false;
            }
                

        }

        private void btnClacson_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
        }
    }
}
