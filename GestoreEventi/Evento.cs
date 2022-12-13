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
        public string titolo;
        public DateTime data;
        public int capienza;
        public int prenotazioni;
        public int prenotaposti;
        public int disdiciposti;

        public Evento()
        {

        }
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

            this.data = DateTime.Parse(data);
            if (this.data < DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("data", "Un nuovo evento non può avere luogo nel passato");
            }
            else
            {
                this.data = DateTime.Parse(data);
            }


            if (capienza <= 0)
            {
                throw new ArgumentOutOfRangeException("capienza", "La capienza dell'evento non può essere minore o uguale a 0");
            }
            else
            {
                this.capienza = capienza;
            }
            if(this.prenotazioni > this.capienza)
            {
                throw new ArgumentOutOfRangeException("prenotazioni", "Non puoi prenotare più posti di quelli disponibili");
            }
            else
            {
                this.prenotazioni = prenotazioni;
            }
            
        }


        public string Gettitolo()
        {
            return titolo;
        }
        public string Getdata()
        {
            return data.ToString();
        }
        public int Getcapienza()
        {
            return capienza;
        }
        public int Getprenotazioni()
        {
            if (this.prenotazioni > this.capienza)
            {
                throw new ArgumentOutOfRangeException("prenotazioni", "Non puoi prenotare più posti di quelli disponibili");
            }
            else
            {
                return prenotazioni;
            }

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
           
            this.data = DateTime.Parse(data);
            if (this.data < DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("data", "Un nuovo evento non può avere luogo nel passato");
            }
            else
            {
                this.data = DateTime.Parse(data);
            }
        }

        public void Setcapienza(int capienza)
        {
            this.capienza = capienza;
        }
        public void Setprenotazioni(int prenotazioni)
        {
            if (this.prenotazioni > this.capienza)
            {
                throw new ArgumentOutOfRangeException("prenotazioni", "Non puoi prenotare più posti di quelli disponibili");
            }
            else
            {
                this.prenotazioni = prenotazioni;
            }
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
