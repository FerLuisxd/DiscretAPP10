using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiscretAPP7.Views
{
    using ViewModels;
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        Picker p;
        Switch s;
        public LoginPage ()
		{
			InitializeComponent();
            var listData = new List<string>();
            listData.Add("SW33");
            listData.Add("SW55");
            listData.Add("SI32");
            listData.Add("CC21");
            p =  this.FindByName<Picker>("picker");
            p.ItemsSource = listData;
            s = this.FindByName<Switch>("Switch");
        }
        void startUP() { }
        protected void Dis(object sender, EventArgs e)
        {
            string option = (string)p.SelectedItem;
            if (string.IsNullOrEmpty(option))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Elije una sección", "Aceptar");
                return;
            }
            MainViewModel.setString(option);
            if (s.IsEnabled==false)
            {
                p.SelectedItem = string.Empty;
                p.Title = string.Empty;
            }
            //this.Option = string.Empty;
            // MainViewModel.GetInstance().dis = new DisViewModel();

           Application.Current.MainPage.Navigation.PushAsync(new DisPage());
        }

    }
}