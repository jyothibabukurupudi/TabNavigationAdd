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
    public partial class Posts : ContentPage
    {

        RestApi restApi;
        public Posts()
        {
            InitializeComponent();
            restApi= new RestApi();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            List<ModelPosts> posts = await restApi.GetModelPostsAsync(Constants.postspoint);
            postView.ItemsSource= posts;


        }
    }
}