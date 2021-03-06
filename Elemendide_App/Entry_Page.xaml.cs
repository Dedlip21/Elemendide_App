using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendide_App
{
    public partial class Entry_Page : ContentPage
    {
        public Entry_Page()
        {
            StackLayout st = new StackLayout();
            Editor ed = new Editor
            {
                Placeholder = "Sisesta siia teksti",
                BackgroundColor = Color.White,
                TextColor = Color.Blue
            };
            st.Children.Add(ed);

            Button tagasi = new Button
            {
                Text = "Tagasi"
            };
            tagasi.Clicked += Tagasi_Clicked;


            st.BackgroundColor = Color.Black;
            Content = st;
        }

        private async void Tagasi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
