using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace BubbleWrap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            int rnd = rand.Next(1, 4);
            switch (rnd)
            {
                case 1:
                    SoundPlayer sound_1 = new SoundPlayer("comp.wav");
                    sound_1.Play();
                    break;
                case 2:
                    SoundPlayer sound_2 = new SoundPlayer("comp2.wav");
                    sound_2.Play();
                    break;
                case 3:
                    SoundPlayer sound_3 = new SoundPlayer("comp3.wav");
                    sound_3.Play();
                    break;
                case 4:

                    break;
                default:

                    break;
            }
            Button button = (Button)sender;
            button.IsEnabled = false;
        }
    }
}
