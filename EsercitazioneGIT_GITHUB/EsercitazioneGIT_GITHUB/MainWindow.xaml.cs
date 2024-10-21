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
           
        }
    }
}