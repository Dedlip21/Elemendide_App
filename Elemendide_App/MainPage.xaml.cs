using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendide_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            StackLayout st = new StackLayout();
            Button Ent_btn = new Button
            {
                Text = "Entry",
                BackgroundColor = Color.Fuchsia
            };
            st.Children.Add(Ent_btn);
            st.BackgroundColor = Color.Aqua;
            Content = st;

            Button Timer_btn = new Button
            {
                Text = "Entry",
                BackgroundColor = Color.Fuchsia
            }; 


            Ent_btn.Clicked += Ent_btn_Clicked;
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_Page());
        }
    }
}
