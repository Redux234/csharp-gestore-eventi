using GestoreEventi;
using System.Linq.Expressions;

Evento evento1 = new Evento();

try
{
    Console.WriteLine("Inserisci il nome dell'evento: ");
    evento1.Settitolo(Console.ReadLine());
    Console.WriteLine("Inserisci la data dell'evento (gg/mm/yyyy): ");
    evento1.Setdata(Console.ReadLine());
    Console.WriteLine("Inserisci il numero di posti totali: ");
    evento1.Setcapienza(int.Parse(Console.ReadLine()));
    Console.WriteLine("Quanti posti desideri prenotare? ");
    evento1.Setprenotazioni(int.Parse(Console.ReadLine()));
    Console.WriteLine();
    Console.WriteLine("Numero di posti prenotati = " + evento1.Getprenotazioni());
    Console.WriteLine("Numero di posti disponibili = " + (evento1.Getcapienza() - evento1.Getprenotazioni()));
    
    while(evento1.Getprenotazioni() < evento1.Getcapienza())
    {
        Console.WriteLine("Vuoi disdire dei posti (si/no)? ");
        if (Console.ReadLine() == "si")
        {
            Console.WriteLine("Indica il numero di posti da disdire? ");
            evento1.Setdisdiciposti(int.Parse(Console.ReadLine()));
            Console.WriteLine("Numero di posti prenotati = " + (evento1.Getprenotazioni() - evento1.Getdisdiciposti()));
            Console.WriteLine("Numero di posti disponibili = " + (evento1.Getcapienza() - evento1.Getprenotazioni() + evento1.Getdisdiciposti()));
        }
        else
        {
            Console.WriteLine("Ok va bene!");
            Console.WriteLine("Numero di posti prenotati = " + (evento1.Getprenotazioni() - evento1.Getdisdiciposti()));
            Console.WriteLine("Numero di posti disponibili = " + (evento1.Getcapienza() - evento1.Getprenotazioni() + evento1.Getdisdiciposti()));
            break;
        }
    }
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);

    
}



ProgrammaEventi programmaEventi = new ProgrammaEventi();
ProgrammaEventi evento2 = new ProgrammaEventi("Ciao","17/12/2022", "ciao", "17/12/2022", 200, 50);
ProgrammaEventi evento3 = new ProgrammaEventi("SUS", "17/12/2022", "sus", "22/12/2022", 300, 20);

programmaEventi.AddEvent(evento2);
programmaEventi.AddEvent(evento3);
programmaEventi.DateElemnt(evento2);

