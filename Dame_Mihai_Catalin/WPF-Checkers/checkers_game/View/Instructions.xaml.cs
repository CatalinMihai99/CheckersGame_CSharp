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

namespace checkers_game.View
{
    /// <summary>
    /// Interaction logic for Instructions.xaml
    /// </summary>
    public partial class Instructions : Window
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Mihai Marius Catalin, adresa institutionala: marius.mihai@student.unitbv.ro, grupa 10LF393");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow x = new MainWindow();
            x.Show();
            Close();
        }
    }
}
