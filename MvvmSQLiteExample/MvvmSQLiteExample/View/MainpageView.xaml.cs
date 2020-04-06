using MvvmSQLiteExample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmSQLiteExample.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainpageView : ContentPage
    {
        public MainpageView()
        {
            InitializeComponent();
            BindingContext = new MainpageViewModel();
           
        }
        
    }
}