using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        private string titolo;
        private string data;
        private readonly int capienza;
        private readonly int prenotazioni;
        public int prenotaposti;
        public int disdiciposti;


        public Evento(string titolo, string data, int capienza, int prenotazioni)
        {

            if (titolo == null || titolo == "")
            {
                throw new ArgumentOutOfRangeException("titolo", "L'evento deve avere un nome");
            }
            else
            {
                this.titolo = titolo;
            }
            this.data = data;
            if (capienza <= 0)
            {
                throw new ArgumentOutOfRangeException("capienza", "La capienza dell'evento non può essere minore o uguale a 0");
            }
            else
            {
                this.capienza = capienza;
            }
            this.prenotazioni = 0 + this.prenotaposti - this.disdiciposti;
        }

        public string Gettitolo()
        {
            return titolo;
        }
        public string Getdata()
        {
            return data;
        }
        public int Getcapienza()
        {
            return capienza;
        }
        public int Getprenotazioni()
        {
            return prenotazioni;
        }
        public int Getprenotaposti()
        {
            return prenotaposti;
        }
        public int Getdisdiciposti()
        {
            return disdiciposti;
        }

        public void Settitolo(string titolo)
        {
            if(titolo == null || titolo == "")
            {
                throw new ArgumentOutOfRangeException("titolo", "L'evento deve avere un nome");
            }
            else
            {
                this.titolo = titolo;
            }
            
        }
        public void Setdata(string data)
        {
           
            this.data = data;
        }
        public void Setprenotaposti(int prenotaposti)
        {
            if (prenotaposti > this.capienza)
            {
                throw new ArgumentOutOfRangeException("prenotaposti", "Non puoi prenotare più posti della capienza massima");
            }
            else if(prenotaposti < 0)
            {
                throw new ArgumentOutOfRangeException("prenotaposti", "Non puoi prenotare un numero negativo di posti");
            }
            else
            {
                this.prenotaposti = prenotaposti;
            }
            
        }
        public void Setdisdiciposti(int disdiciposti)
        {
            if ( disdiciposti > this.prenotazioni)
            {
                throw new ArgumentOutOfRangeException("disdiciposti", "Non puoi disdire più posti di quelli disponibili");
            }
            else if (disdiciposti < 0)
            {
                throw new ArgumentOutOfRangeException("disdiciposti", "Non puoi disdire un numero negativo di posti");
            }
            else
            {
                this.disdiciposti = disdiciposti;
            }
            
        }
    }
}
