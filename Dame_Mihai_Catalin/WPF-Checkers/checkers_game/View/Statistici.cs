using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Statistici.xaml
    /// </summary>
    public partial class Statistici : Window
    {
        public Statistici()
        {
            InitializeComponent();
           
            using (TextReader reader = File.OpenText("C:\\Users\\Cata\\Desktop\\sah\\WPF-Checkers\\checkers_game\\Resources\\Statitics.txt"))
            {
                int x = int.Parse(reader.ReadLine());
                int y = int.Parse(reader.ReadLine());
                V.Text = x.ToString();
                A.Text = y.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow x = new MainWindow();
            x.Show();
            Close();
        }
       
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
