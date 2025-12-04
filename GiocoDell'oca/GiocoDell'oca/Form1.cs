using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiocoDell_oca
{
    public partial class Form1 : Form
    {

        Cella[] Listacelle = new Cella[63];
        Random dado;
        Giocatore Giocatore1;
        Giocatore Giocatore2;
        bool turno;
        public delegate void Avanza(int x);
        public delegate void ModificaStatoGiocatore(Giocatore player);
        public event Avanza Ripetimossa;
        public event ModificaStatoGiocatore ModificaStatoHandler;
        public Form1()
        {
            InitializeComponent();
            grd_Playground.RowHeadersVisible = false;
            grd_Playground.ColumnHeadersVisible = false;
            grd_Playground.ScrollBars = ScrollBars.None;
            grd_Playground.AllowUserToAddRows = false;
            grd_Playground.AllowUserToDeleteRows = false;
            grd_Playground.AllowUserToResizeColumns = false;
            grd_Playground.AllowUserToOrderColumns = false;


            Creacampo();
            //ColoraCelleSpeciali();
            dado = new Random(Environment.TickCount);
            turno = true;
            Legginomi();

            lbl_ActivePlayer.Text = $"é il turno di {Giocatore1.Nome}";

            Ripetimossa += MovePlayer;
            ModificaStatoHandler += ModificaStato;
        }

        private void btn_Trow_Dices_Click(object sender, EventArgs e)
        {
            ThrowDices();
        }

        private void Legginomi()
        {
            using (FormNomi form = new FormNomi())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    Giocatore1 = new Giocatore(form.FirstName);
                    Giocatore2 = new Giocatore(form.SecondName);
                }
                
            }

        }


        private void ThrowDices()
        {
            int dado1 = dado.Next(1, 7);
            int dado2 = dado.Next(1, 7);

            Pct_Dice_1.BackgroundImage = Image.FromFile($@"..\..\..\imgs\die_top_{dado1}.png");
            Pct_Dice_2.BackgroundImage = Image.FromFile($@"..\..\..\imgs\die_top_{dado2}.png");

            int somma = dado1 + dado2;
            lblTot.Text = $"Totale: {somma}";
            MovePlayer(somma);
        }


        private async void MovePlayer(int passi)
        {
            
            btn_Trow_Dices.Enabled = false;
            Giocatore MovingPlayer = null;
            Giocatore Staticplayer = null;
            string img;
            string secondaryimg;

            if (turno && !Giocatore1.InPrison)
            {
                MovingPlayer = Giocatore1;
                Staticplayer = Giocatore2;
                img = $@"..\..\..\imgs\Primo_Giocatore.png";
                secondaryimg = $@"..\..\..\imgs\Secondo_Giocatore.png";
            }
            else if(!turno && !Giocatore2.InPrison)
            {
                MovingPlayer = Giocatore2;
                Staticplayer = Giocatore1;
                img = $@"..\..\..\imgs\Secondo_Giocatore.png";
                secondaryimg = $@"..\..\..\imgs\Primo_Giocatore.png";
            }

            MovingPlayer.CambiaPosizioneIniziale();
            MovingPlayer.CambiaPosizioneIniziale();


            for (int i=0; i<passi; i++)
            {
                //Allinizio controliamo che la pedina sia nella tabella, se l' è cancelliamo la sua vecchia posizione
                //e se nella stesse ci fosse anche unaltra pedina perché sono sulla stessa posizione le lesciamo li; 
                int index = MovingPlayer.IndexPosizione;

                if (MovingPlayer.IndexPosizione >= 0)
                {
                    if(index == Staticplayer.IndexPosizione)
                    {
                        grd_Playground.Rows[Staticplayer.Posizione.Coordinate.y].Cells[Staticplayer.Posizione.Coordinate.x].Value = Image.FromFile(secondaryimg);
                    } else
                    {
                        grd_Playground.Rows[MovingPlayer.Posizione.Coordinate.y].Cells[MovingPlayer.Posizione.Coordinate.x].Value = null;
                    } 
                         
                }

                //avanzdo di uno 

                MovingPlayer.Avanza();

                //se è il suo ultimo spostamento, quindi effettivamente si ferma sulla cella selezionata
                if (i == passi - 1)
                {
                    index = MovingPlayer.IndexPosizione;

                    if (index == 62) // se è alla fine il giocatore ha vinto
                    {
                        MessageBox.Show(MovingPlayer.Nome + " ha vinto!!");
                        break;
                    }


                    if (index == 4 || (index +1)%9==0 || index == 5 || index == 18 
                        || index == 30 || index == 51 || index == 57) // se è sulle caselle speciali si attiva un data causa
                    {

                        Cellaspeciale(index, passi, MovingPlayer);

                    } else if(index == Staticplayer.IndexPosizione) //se si ferma su un cella già occupat ale scambia, quindi scambia posizione ed index iniziali della nuova arrivata con la vecchia
                    {
                        Staticplayer.InvertiPosizione(MovingPlayer);
                        grd_Playground.Rows[Staticplayer.Posizione.Coordinate.y].Cells[Staticplayer.Posizione.Coordinate.x].Value = Image.FromFile(secondaryimg);
                    }
                }

                //aggiurna visivamente lo spostamento     
                MovingPlayer.Posizione = Listacelle[MovingPlayer.IndexPosizione];
                grd_Playground.Rows[MovingPlayer.Posizione.Coordinate.y].Cells[MovingPlayer.Posizione.Coordinate.x].Value = Image.FromFile(img);

                await Task.Delay(500);
            }
            btn_Trow_Dices.Enabled = true;

            lbl_ActivePlayer.Text = turno ? $"é il turno di {Giocatore2.Nome}" : $"é il turno di {Giocatore1.Nome}";
            turno = !turno;
        }


        private void Cellaspeciale(int index, int passi, Giocatore player)
        {
            if ((index + 1) % 9 == 0 || index == 4)
            {
                Ripetimossa?.Invoke(passi);
                
            }

            switch (index)
            {
                case 5:
                    Ripetimossa?.Invoke(passi);
                    break;

                case 18:
                    
                    break;
                case 30:
                    
                    break;
                case 41:
                    
                    break;
                case 57:
                    
                    break;
            }
            turno = !turno;
        }

        private void ModificaStato(Giocatore player)
        {
            player.Changestatus();
        }

        private void Creacampo()
        {
            // Svuota la griglia
            grd_Playground.Columns.Clear();
            grd_Playground.Rows.Clear();

            // Aggiunge 7 colonne larghe 30
            for (int c = 0; c < 9; c++)
            {
                var col = new DataGridViewImageColumn();
                col.Name = "Col" + c;
                col.Width = 70;
                col.ImageLayout = DataGridViewImageCellLayout.Stretch; // Mantiene proporzioni
                col.DefaultCellStyle.NullValue = null;
                grd_Playground.Columns.Add(col);
            }

            // Aggiunge 9 righe alte 30
            grd_Playground.Rows.Add(7);
            foreach (DataGridViewRow row in grd_Playground.Rows)
            {
                row.Height = 70;
            }

            for(int i=0; i < grd_Playground.RowCount; i++) 
            { 
                for(int j=0; j < grd_Playground.ColumnCount; j++)
                {
                    int index = i * 9 + j;

                    var Cella = grd_Playground.Rows[i].Cells[j];

                    Listacelle[index] = new Cella(j,i);
                    
                    Cella.Value = null;//Listacelle[index].Index;
                    if (index%2 == 0)
                    {
                        Cella.Style.BackColor = Color.Azure;
                        
                    } else
                    {
                        Cella.Style.BackColor = Color.Beige;
                    }


                    if ((index + 1) % 9 == 0 || index == 4)
                    {
                        Cella.Style.BackColor = Color.FromArgb(245, 173, 71);
                        //Cella.Value = Image.FromFile(@"..\..\..\imgs\Oca.png");
                    }

                    switch (index)
                    {
                        case 5:
                            Cella.Style.BackColor = Color.FromArgb(133, 190, 255);
                            //Cella.Value = Image.FromFile(@"..\..\..\imgs\Ponte.png");
                            break;

                        case 18:
                            Cella.Style.BackColor = Color.FromArgb(100, 189, 10);
                            //Cella.Value = Image.FromFile(@"..\..\..\imgs\Casa.png");
                            break;
                        case 30:
                            Cella.Style.BackColor = Color.FromArgb(212, 212, 212);
                            //Cella.Value = Image.FromFile(@"..\..\..\imgs\Prigione.png");
                            break;
                        case 41:
                            Cella.Style.BackColor = Color.FromArgb(100, 189, 10);
                            //Cella.Value = Image.FromFile(@"..\..\..\imgs\Labirinto.png");
                            break;
                        case 57:
                            Cella.Style.BackColor = Color.FromArgb(201, 186, 212);
                            //Cella.Value = Image.FromFile(@"..\..\..\imgs\Scheletro.png");
                            break;
                    }

                }
            }

        }
        
    }
}
