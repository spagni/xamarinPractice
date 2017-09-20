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
	public partial class ImageGallery : ContentPage
	{
        private int currentImageId = 1;

        public ImageGallery ()
		{
			InitializeComponent ();
            currentImageId = 1;
            loadImage();
		}

        void loadImage()
        {
            image.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("http://lorempixel.com/1920/1080/city/{0}", currentImageId)),
                CachingEnabled = false
            };
        }

        void Previous_Clicked(object sender, System.EventArgs e)
        {
            currentImageId--;
            if (currentImageId == 0)
                currentImageId = 10;

            loadImage();
        }

        void Next_Clicked(object sender, System.EventArgs e)
        {
            currentImageId++;
            if (currentImageId == 10)
                currentImageId = 0;

            loadImage();
        }

    }
}