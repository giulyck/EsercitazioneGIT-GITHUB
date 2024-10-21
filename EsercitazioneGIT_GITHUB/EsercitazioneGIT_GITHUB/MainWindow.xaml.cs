using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EsercitazioneGIT_GITHUB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Libro libro;
        static Biblioteca biblioteca;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreaLibro_Click(object sender, RoutedEventArgs e)
        {
            libro = new Libro(Autore.Text, Titolo.Text, AnnoPubblicazione.Text, Editore.Text, NumeroPagine.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InfoLibro.Text = libro.to_String();
        }

        private void Biblioteca_Click(object sender, RoutedEventArgs e)
        {
           biblioteca.nome = nome.Text;
           biblioteca.indirizzo = indirizzo.Text;
           biblioteca.orario_apertura_chiusura = orario.Text;
           
        }

        private void ListaLibri_Click(object sender, RoutedEventArgs e)
        {
            lista_libri.Text = biblioteca.getListaLibri();
        }

        private void CercaLibroDatitolo_Click(object sender, RoutedEventArgs e)
        {
            
        }

        //modificaaa
        
    }
}
