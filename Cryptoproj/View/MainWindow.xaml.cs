using Cryptoproj.Models;
using Cryptoproj.ViewModel;
using System.Linq;
using System.Windows;

namespace Cryptoproj.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new DataManage();
        }

        private void Find(object sender, RoutedEventArgs e)
        {
            AssetsList assets = DataFilling.GetAllCurrencies();
            
            Assets findassets = assets.data.FirstOrDefault(x => x.Name.ToLower() == searchbox.Text.ToLower());
            if (findassets != null)
            {
                MessageBox.Show($"Id: {findassets.Id},\nRank: {findassets.Rank},\nSymbol: {findassets.Symbol},\nSupply: {findassets.Supply},\n" +
                    $"MaxSupply: {findassets.MaxSupply},\nMarketCapUsd: {findassets.MarketCapUsd},\nVolumeUsd24Hr: {findassets.VolumeUsd24Hr},\n" +
                    $"PriceUsd: {findassets.PriceUsd},\nChangePercent24Hr: {findassets.ChangePercent24Hr},\nvwap24Hr: {findassets.Vwap24Hr}", findassets.Name + "info");
                searchbox.Clear();
            }
            else
            {
                MessageBox.Show("Not found");
                searchbox.Clear();
            }
        }

    }
}
