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
        Label semaa;
        Label pippo;
        Button VSemA;
        Button VSemS;
        int sem;
        public DisPage()
        {
            InitializeComponent();
            asd();
        }
        private void asd()
        {
            VSemA = this.FindByName<Button>("BSemA");
            VSemS = this.FindByName<Button>("BSemS");
            pippo = this.FindByName<Label>("notLabel");
            //pippo.Text = DateTime.Now.ToString();
            pippo.Text = MainViewModel.getString();
            DateTime dtOne = new System.DateTime(2018, 3, 19);
            DateTime two = DateTime.Now;
            double answer = (two - dtOne).TotalDays;
            sem = ((int)answer / 7) + 1;
            semaa = this.FindByName<Label>("Semana");
            semaa.Text = "Semana : " + sem.ToString();
            if (sem == 8) semaa.Text = "Semana : " + sem.ToString() + " Parcial";
        }
        protected void SemS(object sender, EventArgs e)
        {
            if (sem < 16)
            {
                sem++;
                semaa.Text = "Semana : " + sem.ToString();
            }
            if (sem == 8) semaa.Text = "Semana : " + sem.ToString() + " Parcial";
        }
        protected void SemA(object sender, EventArgs e)
        {
            if (sem > 1)
            {
                sem--;
                semaa.Text = "Semana : " + sem.ToString();
            }
           if(sem == 8) semaa.Text = "Semana : " + sem.ToString() + " Parcial"; 
        }
        protected void GoLink1(object sender, EventArgs e)
        { 
            if(sem == 1) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130053_1"));
            if (sem == 2) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130043_1"));
            if (sem == 3) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130071_1"));
            if (sem == 4) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130015_1"));
            if (sem == 5) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130083_1"));
            if (sem == 6) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130078_1"));
            if (sem == 7) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130021_1"));
            if (sem == 8) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130076_1"));//PARCIAL
            if (sem == 9) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130061_1"));
            if (sem == 10) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130087_1"));
            if (sem == 11) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130067_1"));
            if (sem == 12) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130025_1"));
            if (sem == 13) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130057_1"));
            if (sem == 14) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130036_1m"));
            if (sem == 15)
            if(sem == 16) { }
           
        }
        protected void GoLink2(object sender, EventArgs e)
        {
            if(sem == 1) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130054_1"));
            if (sem == 2) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130044_1"));
            if (sem == 3) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130072_1"));
            if (sem == 4) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130016_1"));
            if (sem == 5) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130084_1"));
            if (sem == 6) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130079_1"));
            if (sem == 7) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130022_1"));
            if (sem == 8)
            if(sem == 9) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130062_1"));
            if (sem == 10) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130088_1"));
            if (sem == 11) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130068_1"));
            if (sem == 12) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130026_1"));
            if (sem == 13) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130058_1"));
            if (sem == 14) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130037_1"));
            if (sem == 15)
            if(sem == 16) { }
          
        }
        protected void GoLink3(object sender, EventArgs e)
        {
            if(sem == 1) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130055_1"));
            if (sem == 2) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130045_1"));
            if (sem == 3) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130073_1"));
            if (sem == 4) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130017_1"));
            if (sem == 5) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130085_1"));
            if (sem == 6) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130080_1"));
            if (sem == 7) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130023_1"));
            if (sem == 8)
            if(sem == 9) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130064_1"));
            if (sem == 10) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130089_1"));
            if (sem == 11) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130069_1"));
            if (sem == 12) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130027_1"));
            if (sem == 13) Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130059_1"));
            if (sem == 14)Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130038_1"));
            if(sem == 15)
            if(sem == 16) { }
           
        }
        protected void Next(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new CalcPage());
        }
    }
}