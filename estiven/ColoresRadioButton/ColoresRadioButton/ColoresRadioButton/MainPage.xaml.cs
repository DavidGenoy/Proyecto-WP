using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ColoresRadioButton
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void cambiarColor(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush();

            if(sender == btnAzul){
                hexTitle.Text = "#0000FF";
                nameColorTitle.Text = "Azul";
                brush.Color = Color.FromArgb(255,0,0,255);
            }else if(sender == btnAmarillo){
                hexTitle.Text = "#FFFF00";
                nameColorTitle.Text = "Amarillo";
                brush.Color = Color.FromArgb(255,255,255,0);
            }else{
                hexTitle.Text = "#FF0000";
                nameColorTitle.Text = "Rojo";
                brush.Color = Color.FromArgb(255,255,0,0);
            }
            rectangulo.Fill = brush;
        }
    }
}