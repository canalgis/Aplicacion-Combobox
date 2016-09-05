# Aplicacion-Combobox
Aplicación que realiza el calculo a pagar de los clientes
<Page
    x:Class="App14.MainPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:App14"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d">

    <Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
        <StackPanel HorizontalAlignment="Left" Height="620" Margin="10,10,0,0" VerticalAlignment="Top" Width="340" BorderThickness="20,0,0,0" Grid.Row="12" Grid.Column="6">
            <ComboBox x:Name="comboBox" HorizontalAlignment="Left" VerticalAlignment="Stretch" Margin="53,0,0,0" Width="111" SelectionChanged="comboBox_SelectionChanged">
                <ComboBoxItem Content="1"/>
                <ComboBoxItem Content="2"/>
                <ComboBoxItem Content="3"/>
                <ComboBoxItem Content="4" IsSelected="True"/>

            </ComboBox>
            <TextBlock x:Name="PROPINA" TextWrapping="Wrap" Text="PROPINA %" HorizontalAlignment="Left" RenderTransformOrigin="-0.269,0.5" Margin="-20,0,70,0" Width="68"/>
            <ComboBox x:Name="comboBox1" HorizontalAlignment="Stretch" VerticalAlignment="Stretch" Margin="53,0,156,0">
                <ComboBoxItem Content="10" />
                <ComboBoxItem Content="15" IsSelected="True"/>
            </ComboBox>
            <TextBlock x:Name="textBlock1" TextWrapping="Wrap" Text="MONTO" HorizontalAlignment="Left" Margin="-10,0,70,0" Width="64"/>
            <TextBox x:Name="textBoxMonto" TextWrapping="Wrap" Text="" HorizontalAlignment="Left" Width="111" Margin="53,0,0,0"/>
            <TextBlock x:Name="textBlock2" TextWrapping="Wrap" Text="PAGO " HorizontalAlignment="Left"/>
            <TextBox x:Name="textBoxPago" TextWrapping="Wrap" Text="" Margin="53,0,156,0" TextChanged="textBoxPago_TextChanged"/>
            <Button x:Name="buttonPagar" Content="PAGAR" HorizontalAlignment="Center" VerticalAlignment="Stretch" Margin="53,20,156,0" Click="buttonPagar_Click"/>
            <TextBlock x:Name="ComboBoxResultTextBlock" TextWrapping="Wrap" Text="TextBlock" Margin="0,0,244,0"/>
            
            
        </StackPanel>
        <TextBlock x:Name="textBlock" HorizontalAlignment="Left" Margin="10,10,0,0" TextWrapping="Wrap" Text="CLIENTES" VerticalAlignment="Top"/>
    </Grid>
</Page>









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
             textBoxPago.Text = textBoxMonto. Text + ComboBoxResultTextBlock.Text;
        }

        private void textBoxPago_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

