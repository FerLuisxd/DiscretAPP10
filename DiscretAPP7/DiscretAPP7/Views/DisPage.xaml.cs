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
	public partial class DisPage : ContentPage
	{
        public DisPage()
        {
            InitializeComponent();
            asd();
        }
        private void asd()
        {
            var pippo = this.FindByName<Label>("notLabel");
            //pippo.Text = DateTime.Now.ToString();
            pippo.Text = MainViewModel.getString();
            DateTime dtOne = new System.DateTime(2018, 3, 19);
            DateTime two = DateTime.Now;
            double answer = (two - dtOne).TotalDays;
            int sem = ((int)answer / 7) + 1;
            var semaa = this.FindByName<Label>("Semana");
            semaa.Text = "Semana Actual : " + sem.ToString();
        }
        protected void GoLink1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130036_1m"));
        }
        protected void GoLink2(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130037_1"));
        }
        protected void GoLink3(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130038_1"));
        }
        protected void Next(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new CalcPage());
        }
    }
}