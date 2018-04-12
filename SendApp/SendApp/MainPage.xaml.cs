using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SendApp
{
    public partial class MainPage : ContentPage
    {
        String number;
        String message;
        int count;

        public MainPage()
        {
            InitializeComponent();
        }


        async void OnSend(object sender, EventArgs e)
        {
            number = phoneNumberText.Text;
            message = messageText.Text;
            count = int.Parse(countText.Text);

            if (await this.DisplayAlert(
                    "Dial a Number",
                    "Would you like to send " + count + " messages to " + number + "?",
                    "Yes",
                    "No"))
            {
                var text = DependencyService.Get<ISender>();
                if (text != null)
                    text.Send(number, message, count);
                var clo = DependencyService.Get<ICloseApplication>();
                if (clo != null)
                clo.CloseApplication();
            }
        }

    }
}
