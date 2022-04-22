using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestoreEventi;



namespace GestoreEventi
{
    internal class ProgrammaEventi
    {
        string titolo;
        List<Evento> Eventi;

        public ProgrammaEventi(string titolo, List<Evento> eventi)
        {
            this.titolo = titolo;
            Eventi = eventi;
        }



        public void AggiungiEvento(Evento evento)
        {
            Eventi.Add(evento);
        }

        public List<Evento> ListaDiEventiPerData(DateTime dataPassata)
        {

              
            foreach (Evento evento in Eventi)
            {
                DateTime data = evento.getData();
                if(dataPassata == data)
                {
                    
                        evento.StampaEvento();
                    
                }
                else
                {
                    Console.WriteLine("Mi dispiace non ci sono eventi per questa data");
                }

            }


            return Eventi;


        }


        public void StampaListaDiEventi()
        {
            foreach(Evento evento in Eventi)
            {
                evento.StampaEvento();  
            }
        }


        public void NumeroEventi()
        {
            int count = 0;
            for (int i = 0; i < Eventi.Count; i++)
            {
                count++;

                
            }

            Console.WriteLine("Il numero di eventi nel programma è " + count);
        }


        public void SvuotaLista()
        {
            Eventi.Clear(); 
        }



        public void RestituisciEventiNelProgramma()
        {
            Console.WriteLine("Ecco il tuo programma eventi: ");
            Console.WriteLine(titolo);
            foreach(Evento evento in Eventi)
            {
                DateTime data = evento.getData();
                string titolo = evento.getTitolo();
                Console.WriteLine("         " + data + " - " + titolo);
            }
        }









    }


 
}
