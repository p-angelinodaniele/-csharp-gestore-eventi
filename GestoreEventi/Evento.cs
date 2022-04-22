using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        private static DateTime dataOraAttuale = DateTime.Now;
        private string titolo;
        private DateTime data;
        private int capienzaMassima;
        int numeroPostiPrenotati;

        public Evento(string titolo, DateTime data, int capienzaMassima)
        {
            this.titolo = titolo;
            this.data = data;
            this.capienzaMassima = capienzaMassima;
            this.numeroPostiPrenotati = 0;



            if (data < dataOraAttuale)
            {
                throw new ArgumentException("dataTime", "Mi dispiace non puoi andare indietro nel tempo");
            }

            if(String.IsNullOrEmpty(titolo))
            {
                throw new ArgumentNullException("Mi dispiace il titolo non può essere nullo");
            }

            if(capienzaMassima < 0)
            {
                throw new ArgumentOutOfRangeException("caienza massima", "Mi dispiace ma la capienza non può essere negativa ");
            }


        }


        public string getTitolo()
        {
            return titolo;
        }

        public int getCapienzaMassima()
        {
            return capienzaMassima;
        }

        public int getNumeroPostiPrenotati()
        {
            return numeroPostiPrenotati;
        }

        public DateTime getData()
        {
            return data;
        }


        public void setTitolo(string nuovoTitolo)
        {
            titolo = nuovoTitolo;   
        }

        public void set(DateTime nuovaData)
        {
            data = nuovaData;
        }


        public void PrenotaPosti(int postiPassati)
        {
            numeroPostiPrenotati += postiPassati;
            capienzaMassima-= postiPassati;
            if(postiPassati > capienzaMassima)
            {
                throw new ArgumentOutOfRangeException("postiPassati", "Mi dispiace hai prenotato più posti rispetto alla capienza massima o i posti sono esauriti");
            }

        }


        public void DisdiciPosti(int postiPassati)
        {
            numeroPostiPrenotati -= postiPassati;   
            capienzaMassima+= postiPassati;
        }



        public void StampaEvento()
        {
            Console.WriteLine("-----EVENTO------");
            Console.WriteLine("nome dell'evento: " + titolo);
            Console.WriteLine("data dell'evento: " + data);
            Console.WriteLine("capienza dell'evento: " + capienzaMassima);

        }




    }
}
