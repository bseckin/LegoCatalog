using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace LegoCatalog.ViewModel
{
    public class LegoItemVM : ViewModelBase
    {
        // Properties
        private string description;
        private int amountParts { get; set; }
        private string  ageRecom { get; set; }
        public BitmapImage Image { get; set; }

        public string Description {
            get { return description; }
            set {
                description = value;
                RaisePropertyChanged();
            }
        }

        public int AmountParts {
            get { return amountParts; }
            set {
                amountParts = value;
                RaisePropertyChanged();
            }
        }

        public string AgeRecom {
            get { return ageRecom; }
            set {
                ageRecom = value;
                RaisePropertyChanged();
            }
        }

        // Constructor
        public LegoItemVM(string description, int amountParts, string ageRecom, BitmapImage image)
        {
            Description = description;
            AmountParts = amountParts;
            AgeRecom = ageRecom;
            Image = image;
        }

        // Methods
    }
}
