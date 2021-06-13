using System;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;

namespace checkers_game.ViewModel
{
    class VMBinding
    {
        public VMBinding()
        {

            string imagePath = "C:\\Users\\Cata\\Desktop\\New folder (6)\\WPF-Checkers\\checkers_game\\Imagini\\black.jpg";
            this.ImageSource = new BitmapImage(new Uri(imagePath, UriKind.Absolute));
        }


        private BitmapImage _ImageSource;
        public BitmapImage ImageSource
        {
            get { return this._ImageSource; }
            set { this._ImageSource = value; this.OnPropertyChanged("ImageSource"); }
        }

        private void OnPropertyChanged(string v)
        {
            // throw new NotImplementedException();
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
