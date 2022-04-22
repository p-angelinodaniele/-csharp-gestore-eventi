using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
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

        }


        public void DisdiciPosti(int postiPassati)
        {
            numeroPostiPrenotati -= postiPassati;   
            capienzaMassima+= postiPassati;
        }



     




    }
}
