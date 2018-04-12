using Android.Content;
using Android.Telephony;
using SendApp;
using System.Linq;
using Xamarin.Forms;

[assembly: Dependency(typeof(Sender))]
namespace SendApp
{
    public class Sender : ISender
    {

        public bool Send(string number, string message, int count)
        {
            //var context = MainActivity.Instance;
            //if (context == null)
              //  return false;
            number = "+" + number;

            SmsManager TestMsg = SmsManager.Default;

            for (int i = 0; i < count; i++)
            {
                TestMsg.SendTextMessage(number, null, message, null, null);
            }


            return true;
        }


    }


}