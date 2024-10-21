using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneGIT_GITHUB
{
    class Libro
    {

        private string autore;
        private string titolo;
        private int anno_pubblicazione;
        private string editore;
        private int numero_pagine;

        

        public Libro(string autore, string titolo, int anno_pubblicazione, string editore, int numero_pagine)
        {
            this.autore = autore;
            this.titolo = titolo;
            this.anno_pubblicazione = anno_pubblicazione;
            this.editore = editore;
            this.numero_pagine = numero_pagine;
        }


        public string get_Autore()
        {
            return autore;
        }

        public void set_Autore(string autore)
        {
            this.autore = autore;
        }

        public string get_titolo()
        {
            return titolo;
        }

        public void set_titolo(string titolo)
        {
            this.titolo = titolo;
        }

        public int get_anno_pubblicazione()
        {
            return anno_pubblicazione;
        }

        public void set_anno_pubblicazione(int anno_pubblicazione)
        {
            this.anno_pubblicazione = anno_pubblicazione;
        }

        public string get_editore()
        {
            return editore;
        }

        public void set_editore(string editore)
        {
            this.editore = editore;
        }

        public int get_numeropagine()
        {
            return numero_pagine;
        }

        public void set_numero_pagine(int numero_pagine)
        {
            this.numero_pagine = numero_pagine;
        }


    }
}
