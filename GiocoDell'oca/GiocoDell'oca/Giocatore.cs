using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDell_oca
{
    class Giocatore
    { 
        public Cella Posizione { get; set; }
        public Cella PosizioneVecchia { get; private set; }

        public int IndexPosizione { get; set; }
        public int StartingIndex { get; set; }

        public string Nome { get; private set; }

        public Giocatore(string name)
        {
            Nome = name;
            IndexPosizione = -1;
            StartingIndex = IndexPosizione;
            Posizione = new Cella(0, 0);
            PosizioneVecchia = new Cella(0, 0);
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
    }
}
