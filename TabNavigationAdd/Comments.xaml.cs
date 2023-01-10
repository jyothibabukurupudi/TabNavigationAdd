using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabNavigationAdd
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comments : ContentPage
    {

        RestApi restApi;
         public  Comments()
        {
            InitializeComponent();

            restApi = new RestApi();

   

        }
        

        private async void Button_Clicked(object sender, EventArgs e)
        {
            List<ModelComments> modelComments = await restApi.GetModelCommentsAsync(Constants.commentpoint);

            commentView.ItemsSource = modelComments;
        }
    }
}

    