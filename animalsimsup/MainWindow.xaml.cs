using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace animalsimsup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Atribute
        private Game game;
        public static MainWindow mainwindow;

        // Methoden
        public MainWindow()
        {
            game = new Game();
            InitializeComponent();

            mainwindow = this;
            DispatcherTimer gametimer = new DispatcherTimer();

            gametimer.Interval = TimeSpan.FromSeconds(1);
            gametimer.Tick += update;
            gametimer.Start();
        }

        private void update(object sender, EventArgs e)
        {
            game.update();
        }

        private void Nahrung(object sender, RoutedEventArgs e)
        {
            game.nahrung();
        }

        private void Liebe(object sender, RoutedEventArgs e)
        {
            game.liebe();
        }

        private void Putzen(object sender, RoutedEventArgs e)
        {
            game.putzen();
        }

        private void Verkaufen(object sender, RoutedEventArgs e)
        {
            game.verkaufen();
        }

        private void Kaufen(object sender, RoutedEventArgs e)
        {
            game.kaufen();
        }

        private void KatzeButton_Click(object sender, RoutedEventArgs e)
        {
            game.set_current_animal(0);
        }

        private void FischButton_Click(object sender, RoutedEventArgs e)
        {
            game.set_current_animal(1);
        }
    }
}
