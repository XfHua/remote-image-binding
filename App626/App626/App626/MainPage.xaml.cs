using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace App626
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ViewModel m = new ViewModel();
            m.imageUrl = "https://placekitten.com/g/1000/1000";
            this.BindingContext = m;

        }
    }

    class ViewModel : INotifyPropertyChanged
    {
        string imageurl;

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel()
        {

        }

        public string imageUrl
        {
            set
            {
                if (imageurl != value)
                {
                    imageurl = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("imageUrl"));
                    }
                }
            }
            get
            {
                return imageurl;
            }
        }
    }
}
