using System.ComponentModel;
using TestApp.XamarinForms.ViewModels;
using Xamarin.Forms;

namespace TestApp.XamarinForms.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}