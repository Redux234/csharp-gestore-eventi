using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi : Evento
    {
        private string Titolo;
        private List<Evento> eventi;
        private DateTime dataiserita;

        public ProgrammaEventi()
        {

        }

        public ProgrammaEventi(string Titolo, string datainserita, string titolo, string data, int capienza, int prenotazioni) : base(titolo, data, capienza, prenotazioni)
        {
            this.Titolo = Titolo;
            this.eventi = new List<Evento>();
            this.dataiserita = DateTime.Parse(datainserita);
        }

        public string GetTitolo()
        {
            return this.Titolo;
        }
        public string Getdatainserita()
        {
            return dataiserita.ToString();
        }
        public void SetTitolo(string Titolo)
        {
            this.Titolo = Titolo;
        }
        public void SetLista(List<Evento> eventi)
        {
            this.eventi = eventi;
        }
        public void Setdatainserita(string datainserita)
        {
            this.dataiserita = DateTime.Parse(datainserita);
        }    

        public void AddEvent(Evento evento)
        {
            eventi.Add(evento);
        }
        public void DateElemnt(Evento evento)
        {
            foreach (Evento events in eventi) 
            {
                if (this.dataiserita == this.data)
                {
                    Console.WriteLine("In questa data sono presenti gli eventi: " + this.titolo);
                }
            
            }
        }
        public void Clear(Evento evento)
        {
            eventi.Clear();
        }
    }
        

    
}
