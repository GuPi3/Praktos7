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

namespace Praktos5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Pair firstPair = new Pair();
        Pair secondPair = new Pair();
        public MainWindow()
        {
            InitializeComponent();
            firstPairBox.Text = firstPair.First.ToString() + " " + firstPair.Second;
            secondPairBox.Text= secondPair.First.ToString() + " " + secondPair.Second;
        }

        private void FirstPairFill(object sender, RoutedEventArgs e)
        {
            firstPair = new Pair(Convert.ToInt32(firstPairFirstNumberBox.Text), Convert.ToInt32(firstPairSecondNumberBox.Text));
            firstPairBox.Text = firstPair.First.ToString() + " " + firstPair.Second;
        }

        private void SecondPairFill(object sender, RoutedEventArgs e)
        {
            secondPair = new Pair(Convert.ToInt32(secondPairFirstNumber.Text), Convert.ToInt32(secondPairSecondNumber.Text));
            secondPairBox.Text = secondPair.First.ToString() + " " + secondPair.Second;
        }

        private void CountComposition(object sender, RoutedEventArgs e)
        {
            //compositionBox.Text = firstPair.Composition(secondPair).First.ToString() + " " + firstPair.Second.ToString();
            compositionBox.Text = (firstPair * secondPair).First.ToString() + " " + (firstPair * secondPair).Second.ToString();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать класс Pair (пара четных чисел). Создать необходимые методы и свойства. Определить метод вычисления произведения чисел.Создать перегруженный методдля вычисления произведения 2 пар чисел – (а, b) * (с, d) = (a * c), (b * d).");
        }
    }
}
