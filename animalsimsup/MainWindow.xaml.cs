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
        private Game game;

        public static MainWindow mainwindow;
        public MainWindow()
        {
            game = new Game();
            InitializeComponent();

            mainwindow = this;
            DispatcherTimer gametimer = new DispatcherTimer();

            gametimer.Interval = TimeSpan.FromSeconds(1);
            gametimer.Tick += timetick;
            gametimer.Start();
        }

        private void timetick(object sender, EventArgs e)
        {
            foreach (var item in Game.animals)
            {
                item.timer();
            }
            
        }

        private void Update_Time(object sender,  RoutedEventArgs e)
        {
            game.update();
            K_Liebe.Value = game.get_current_animal_liebe();
            K_Essen.Value = game.get_current_animal_essen();
            K_Sauberkeit.Value = game.get_current_animal_sauberkeit();
            // K_Schlaf.Value = game.k.get_schlaf();
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



    }
}
