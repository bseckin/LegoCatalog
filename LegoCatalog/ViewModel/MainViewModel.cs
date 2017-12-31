using GalaSoft.MvvmLight;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace LegoCatalog.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        // Properties to observe
        public ObservableCollection<LegoItemVM> Items { get; set; }
        private LegoItemVM currentLegoItem;

        public LegoItemVM CurrentLegoItem {
            get { return currentLegoItem; }
            set { currentLegoItem = value; RaisePropertyChanged(); }
        }


        // Constructor
        public MainViewModel()
        {
            Items = new ObservableCollection<LegoItemVM>();
            DemoDataGenerator();
        }


        // ---- DEMO DATA ---- 
        private void DemoDataGenerator()
        {
            var demoItem1 = new LegoItemVM("Assassins Creed", 300, "20+", new BitmapImage(new Uri("Images/ac.jpg", UriKind.Relative)));
            var demoItem2 = new LegoItemVM("Berries", 300, "1+", new BitmapImage(new Uri("Images/berries.jpg", UriKind.Relative)));
            var demoItem3 = new LegoItemVM("Pinguin", 300, "6+", new BitmapImage(new Uri("Images/pingu.jpg", UriKind.Relative)));
            Items.Add(demoItem1);
            Items.Add(demoItem2);
            Items.Add(demoItem3);
        }
    }
}