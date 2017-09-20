using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorldPCL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotePage : ContentPage
    {
        private int _index = 0;
        private string[] quotes = new string[] { "a", "b", "c", "d", "e", "f" };
        public QuotePage()
        {
            InitializeComponent();
            currentQuote.Text = quotes[_index];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _index++;
            if (_index >= quotes.Length) _index = 0;
            currentQuote.Text = quotes[_index];
        }
    }
}