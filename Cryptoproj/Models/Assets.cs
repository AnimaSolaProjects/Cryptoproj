using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Cryptoproj.Models
{
    public class Assets : INotifyPropertyChanged
    {
        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");

            }
        }
        private string rank;
        public string Rank
        {
            get { return rank; }
            set
            {
                rank = value;
                OnPropertyChanged("Rank");
            }
        }
        private string symbol;
        public string Symbol
        {
            get { return symbol; }
            set
            {
                symbol = value;
                OnPropertyChanged("Symbol");
            }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        private string supply;
        public string Supply
        {
            get { return supply; }
            set
            {
                supply = value;
                OnPropertyChanged("Supply");
            }
        }
        private string maxSupply;
        public string MaxSupply
        {
            get { return maxSupply; }
            set
            {
                maxSupply = value;
                OnPropertyChanged("MaxSupply");
            }
        }
        private string marketCapUsd;
        public string MarketCapUsd
        {
            get { return marketCapUsd; }
            set
            {
                marketCapUsd = value;
                OnPropertyChanged("MarketCapUsd");
            }
        }
        private string volumeUsd24Hr;
        public string VolumeUsd24Hr
        {
            get { return volumeUsd24Hr; }
            set
            {
                volumeUsd24Hr = value;
                OnPropertyChanged("VolumeUsd24Hr");
            }
        }
        private string priceUsd;
        public string PriceUsd
        {
            get { return priceUsd; }
            set
            {
                priceUsd = value;
                OnPropertyChanged("PriceUsd");
            }
        }
        private string changePercent24Hr;
        public string ChangePercent24Hr
        {
            get { return changePercent24Hr; }
            set
            {
                changePercent24Hr = value;
                OnPropertyChanged("ChangePercent24Hr");
            }
        }
        private string vwap24Hr;
        public string Vwap24Hr
        {
            get { return vwap24Hr; }
            set
            {
                vwap24Hr = value;
                OnPropertyChanged("Vwap24Hr");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
