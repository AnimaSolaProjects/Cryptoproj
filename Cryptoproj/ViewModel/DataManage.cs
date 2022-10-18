using Cryptoproj.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace Cryptoproj.ViewModel
{
    public class DataManage : INotifyPropertyChanged
    {
        // View module of the cryptocurrency list
        public ObservableCollection<Assets> assetsList { get; } = DataFilling.GetAllCurrencies().data;
        public ObservableCollection<Assets> top10Assets { get; } = DataFilling.Get10TopCurrencies();
        // View module of the selected cryptocurrency
        public Assets selectedAssets;
        public Assets SelectedAssets
        {
            get { return selectedAssets; }
            set
            {
                selectedAssets = value;
                OnPropertyChanged("SelectedAssets");
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
