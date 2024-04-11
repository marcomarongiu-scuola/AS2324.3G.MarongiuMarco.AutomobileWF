using System.Media;

namespace AS2324._3G.Prof.AutomobileWF
{
    public partial class Form1 : Form
    {

        const int stepAccellerazione = 10;
        const int stepFrenata = -5;

        double velocita = 0;

        public Form1()
        {
            InitializeComponent();

            // parameters setting on progress bar
            prbVelocita.Minimum = 0;
            prbVelocita.Maximum = 160;

            grbComandi.Enabled = false;
        }

        private void btnAccellera_Click(object sender, EventArgs e)
        {
            velocita += stepAccellerazione;
            lblVelocita.Text = velocita + " km/h";

            monitor();
        }

        private void btnFrena_Click(object sender, EventArgs e)
        {
            velocita += stepFrenata;

            monitor();
        }


        private void monitor()
        {
            prbVelocita.Value = (int)velocita;
            if (grbComandi.Enabled = true)
            {
                if (chkCinture.Checked == false)
                {
                    lstMonitor.Items.Clear();
                    string cinture = "NON HAI ALLACCIATO LE CINTURE";
                    lstMonitor.Items.Add(cinture);
                }
            }
        }

        private void chkAccensione_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccensione.Checked == true)
                grbComandi.Enabled = true;
            else
                grbComandi.Enabled = false;

        }

        private void btnClacson_Click(object sender, EventArgs e)
        {
            
        }
    }
}
