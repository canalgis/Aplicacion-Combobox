using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App14
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void CLIENTES_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxResultTextBlock == null) return;

            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;
            ComboBoxResultTextBlock.Text = item.Content.ToString();

        }

        private void buttonPagar_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxMonto.Text == "") return;
            if (Clientes.SelectedItem == null) return;
            if (Propina.SelectedItem == null) return;

            decimal vResultado1 = 0;
            decimal vResultado2 = 0;
            Decimal vCta = Convert.ToDecimal(textBoxMonto.Text);
            var vPer = (ComboBoxItem)Clientes.SelectedItem;
            var vPro = (ComboBoxItem)Propina.SelectedItem;


            vResultado1 = 1 + (Convert.ToDecimal(vPro.Content) / 100);
            vResultado2 = vCta * vResultado1;
            vResultado1 = vResultado2 / Convert.ToInt32(vPer.Content);
            textBoxPago.Text =  vResultado1.ToString("#,###.00");
        }
        
        private void textBoxPago_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
