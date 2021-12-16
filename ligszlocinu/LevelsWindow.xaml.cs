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
    /// Interakční logika pro LevelsWindow.xaml
    /// </summary>
    public partial class LevelsWindow : Window
    {
        public LevelsWindow()
        {
            InitializeComponent();
        }

        private void tutorialButton_Click(object sender, RoutedEventArgs e)
        {
            TutorialWindow tutorial = new TutorialWindow();
            tutorial.Show();
            Close();
        }
    }
}
