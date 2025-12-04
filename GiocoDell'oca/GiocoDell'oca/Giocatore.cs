using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDell_oca
{
    public class Giocatore
    { 
        public Cella Posizione { get; set; }
        public Cella PosizioneVecchia { get; private set; }

        public int IndexPosizione { get; set; }
        public int StartingIndex { get; set; }

        public string Nome { get; private set; }
        public bool InPrison { get; private set; }

        private int turnifermo;

        public Giocatore(string name)
        {
            Nome = name;
            InPrison = false;
            IndexPosizione = -1;
            StartingIndex = IndexPosizione;
            Posizione = new Cella(0, 0);
            PosizioneVecchia = new Cella(0, 0);
            turnifermo = 0;
        } 

        public void Avanza()
        {
            IndexPosizione++;
        }

        public void CambiaPosizioneIniziale()
        {
            PosizioneVecchia = Posizione;
            StartingIndex = IndexPosizione;
        }

        public void InvertiPosizione(Giocatore player)
        {
            Posizione = player.PosizioneVecchia;
            IndexPosizione = player.StartingIndex;
        }

        public void Changestatus()
        {
            InPrison = !InPrison;
        }

        public bool FermoCasa()
        {
            if(turnifermo == 3)
            {
                Changestatus();
            }
            turnifermo++;

            return InPrison;
        } 
    }
}
