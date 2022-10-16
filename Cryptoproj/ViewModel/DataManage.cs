using Cryptoproj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cryptoproj.ViewModel
{
    public class DataManage : INotifyPropertyChanged
    {
        public AssetsList assetsList { get; set; } 
        
        private Assets selectedAssets;
        public Assets SelectedAssets
        {
            get { return selectedAssets; }
            set
            {
                selectedAssets = value;
                OnPropertyChanged("SelectedPhone");
            }
        }

        public DataManage()
        {
            assetsList = DataFilling.GetAllCurrencies();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
