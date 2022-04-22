﻿using GestoreEventi;


Console.Write("Inserisci il nome dell'evento: ");
string nomeEvento = Console.ReadLine();

Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
DateTime dataEvento = DateTime.Parse(Console.ReadLine());

Console.Write("Inserisci il numero di posti totali: ");
int postiTotali = int.Parse(Console.ReadLine());

Evento evento1 = new Evento(nomeEvento, dataEvento, postiTotali);

Console.Write("Quanti posti desideri prenotare? ");
int postiDaPrenotare = int.Parse(Console.ReadLine());
evento1.PrenotaPosti(postiDaPrenotare);



Console.WriteLine();
int postiPrenotati = evento1.getNumeroPostiPrenotati();
Console.WriteLine("Numero di posti prenotati = " + postiPrenotati);
int numeroPostiDsiponibili = evento1.getCapienzaMassima();
Console.WriteLine("Numero posti disponibili = " + numeroPostiDsiponibili);

bool flag=false;
while(flag == false)
{
    Console.WriteLine();
    Console.Write("Vuoi disdire dei posti (si/no)? ");
    string risposta = Console.ReadLine();

    switch (risposta)
    {
        case "si":
            
            Console.Write("Indica il numero di posti da disdire: ");
            int postiDaDisdire = int.Parse(Console.ReadLine());
            evento1.DisdiciPosti(postiDaDisdire);


            Console.WriteLine();
            postiPrenotati = evento1.getNumeroPostiPrenotati();
            Console.WriteLine("Numero di posti prenotati = " + postiPrenotati);
            numeroPostiDsiponibili = evento1.getCapienzaMassima();
            Console.WriteLine("Numero posti disponibili = " + numeroPostiDsiponibili);
            break;

        case "no":

            Console.WriteLine("Ok va bene!");

            Console.WriteLine();
            postiPrenotati = evento1.getNumeroPostiPrenotati();
            Console.WriteLine("Numero di posti prenotati = " + postiPrenotati);
            numeroPostiDsiponibili = evento1.getCapienzaMassima();
            Console.WriteLine("Numero posti disponibili = " + numeroPostiDsiponibili);

            flag = true;
            break;
    }
}






