using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace morraCinese
{
    public partial class Form1 : Form
    {

        public int mossaGiocatore = 0;
        public int mossaPc = 0;
        public int punteggioPC = 0;
        public int punteggioGiocatore = 0;



        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcV.Visible = false;
            giocatoreV.Visible = false;
            imCarta.Enabled = false;
            imCarta.Visible = false;
            imForbice.Enabled = false;  
            imForbice.Visible = false;
            imSasso.Enabled = false;
            imSasso.Visible = false;
            
        }
        
        private void imCarta_Click(object sender, EventArgs e)
        {
            mossaGiocatore = 1;
            imSceltaGiocatore.Image = Image.FromFile("C:/Users/bardo/source/repos/morraCinese/carta.png");
            MossaPc();
            EsitoMossa();

        }

        private void imSceltaGiocatore_Click(object sender, EventArgs e)
        {

        }

        private void imForbice_Click(object sender, EventArgs e)
        {
            mossaGiocatore = 2;
            imSceltaGiocatore.Image = Image.FromFile("C:/Users/bardo/source/repos/morraCinese/forbice.png");
            MossaPc();
            EsitoMossa();
        }

        private void imSasso_Click(object sender, EventArgs e)
        {
            mossaGiocatore = 3;
            imSceltaGiocatore.Image = Image.FromFile("C:/Users/bardo/source/repos/morraCinese/sasso.png");
            MossaPc();
            EsitoMossa();
        }

        //metodi

        public void MossaPc()
        {
            Random r = new Random();
            mossaPc = r.Next(3) + 1;
            switch (mossaPc)
            {
                case 1:
                    imSceltaPc.Image = Image.FromFile("C:/Users/bardo/source/repos/morraCinese/carta.png");
                    break;
                case 2:
                    imSceltaPc.Image = Image.FromFile("C:/Users/bardo/source/repos/morraCinese/forbice.png");
                    break;
                case 3:
                    imSceltaPc.Image = Image.FromFile("C:/Users/bardo/source/repos/morraCinese/sasso.png");
                    break;
                default:
                    break;
            }
        }

        public void EsitoMossa()
        {
            if ((mossaPc == 1 && mossaGiocatore == 1) || (mossaPc == 2 && mossaGiocatore == 2) || (mossaPc == 3 && mossaGiocatore == 3))
            {
                lbEsito.Text = "Pareggio!";

            }
            if((mossaPc == 1 && mossaGiocatore == 2) || (mossaPc == 2 && mossaGiocatore == 3) || (mossaPc == 3 && mossaGiocatore == 1))
            {
                lbEsito.Text = "Giocatore ha vinto!";

                punteggioGiocatore++;
                rsGiocatore.Text = Convert.ToString(punteggioGiocatore);
            }
            if ((mossaPc == 2 && mossaGiocatore == 1) || (mossaPc == 3 && mossaGiocatore == 2) || (mossaPc == 1 && mossaGiocatore == 3))
            {
                lbEsito.Text = "Computer ha vinto!";

                punteggioPC++;
                rsPc.Text = Convert.ToString(punteggioPC);
            }
            if(rsPc.Text == "5")
            {
                pcV.Visible = true;
                pcV.Text = "Il PC ha vinto!";
                giocatoreV.Visible = true;
                giocatoreV.Text = "Il giocatore ha perso!";
                imCarta.Visible = false;
                imForbice.Visible = false;
                imSasso.Visible = false;
                imPcV.Visible = true;
                imPcV.Enabled = true;
                playSimpleSound();

            }
            if (rsGiocatore.Text == "5")
            {
                giocatoreV.Visible = true;
                giocatoreV.Text = "Il giocatore ha vinto!";
                pcV.Visible = true;
                pcV.Text = "Il PC ha perso!";
                imCarta.Visible = false;
                imForbice.Visible = false;
                imSasso.Visible = false;
                imGiocatoreV.Visible = true;
                imGiocatoreV.Enabled = true;
                playSimpleSound();
            }
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("C:/Users/bardo/source/repos/morraCinese/suono.wav");
            simpleSound.Play();
        }
        private void playSimpleSoundStop()
        {
            SoundPlayer simpleSound = new SoundPlayer("C:/Users/bardo/source/repos/morraCinese/suono.wav");
            simpleSound.Stop();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            rsGiocatore.Text = "";
            rsPc.Text = "";
            punteggioGiocatore = 0;
            punteggioPC = 0;
            imCarta.Enabled = true;
            imCarta.Visible = true;
            imForbice.Enabled = true;
            imForbice.Visible = true;
            imSasso.Enabled = true;
            imSasso.Visible = true;
            imGiocatoreV.Visible = false;
            imGiocatoreV.Enabled = false;
            imPcV.Visible = false;
            imPcV.Enabled = false;
            playSimpleSoundStop();
        }

        
    }

        
    }
