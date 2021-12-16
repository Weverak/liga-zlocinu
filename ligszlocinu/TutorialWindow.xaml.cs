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
using System.Windows.Shapes;

namespace ligszlocinu
{
    /// <summary>
    /// Interakční logika pro TutorialWindow.xaml
    /// </summary>
    public partial class TutorialWindow : Window
    {
        public TutorialWindow()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            LevelsWindow levels = new LevelsWindow();
            MessageBoxResult message = MessageBox.Show("Jste si tím jisti?", "Opravdu", MessageBoxButton.YesNo);
            if (message == MessageBoxResult.Yes)
            {
                levels.Show();
                Close();
            }
            else if (message == MessageBoxResult.No)
                {

            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Text.Text="Výborně, ve hře máš vždy dvě možnosti a z nich vybíráš. Tvůj prví případ bude jednoduchý ukradené lízatko :). Máš výhodu že prodavač si toho všimnul a obchod hned zavřel. Tak jedeme";
            button1.Content = "Jedeme";
            button2.Content = "OK";

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = "Výborně, ve hře máš vždy dvě možnosti a z nich vybíráš. Tvůj prví případ bude jednoduchý ukradené lízatko :). Máš výhodu že prodavač si toho všimnul a obchod hned zavřel. Tak jedeme";
            button1.Content = "Jedeme";
            button2.Content = "OK";

        }
    }
}
