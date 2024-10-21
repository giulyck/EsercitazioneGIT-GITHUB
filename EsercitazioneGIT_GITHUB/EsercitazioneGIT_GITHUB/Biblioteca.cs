using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EsercitazioneGIT_GITHUB
{
    internal class Biblioteca
    {
        private string nome;
        private string indirizzo;
        private string orario_apertura_chiusura;
        private List<Libro> libri;

        public Biblioteca(string nome, string indirizzo, string orario_apertura_chiusura, List<Libro> libri)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.orario_apertura_chiusura = orario_apertura_chiusura;
            this.libri = libri;
        }

        public string getNome() { return nome; }
        public string getIndirizzo() { return indirizzo; }
        public string getOrario_apertura_chiusa() { return orario_apertura_chiusura; }
        public void getListaLibri()
        {
            for (int i = 0; i < libri.Count; i++)
            {
                Console.WriteLine(libri[i]);
            }
        }

        public void setNome(string nome) {  this.nome = nome; }
        public void setIndirizzo(string indirizzo) { this.indirizzo= indirizzo; }
        public void setOrario_apertura_chiusura(string orario_apertura_chiusera) { this.orario_apertura_chiusura = orario_apertura_chiusera; }
        public void setAddBiblioteca(Libro libro)
        {
            libri.Add(libro);
        }


    }
}
