using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;

namespace TabNavigationAdd
{
    public class RestApi
    {
        HttpClient _client;

        public RestApi()
        {
            _client = new HttpClient();

            if (Device.RuntimePlatform == Device.UWP)
            {
                _client.DefaultRequestHeaders.Add("User", ".NEt");
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            }
        }

        public async Task<List<ModelPosts>> GetModelPostsAsync(string uri)
        {
            List<ModelPosts> getposts = null;

            try
            {
                HttpResponseMessage httpResponse = await _client.GetAsync(uri);
                if(httpResponse != null)
                {
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    getposts = JsonConvert.DeserializeObject<List<ModelPosts>>(content);
                }
            }catch(Exception e)
            {
                Debug.WriteLine(e);
            }


            return getposts;
        }

        public async Task<List<ModelComments>> GetModelCommentsAsync(string uri)
        {
            List<ModelComments> getcomments = null;

            try
            {
                HttpResponseMessage httpResponse = await _client.GetAsync(uri);
                if (httpResponse != null)
                {
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    getcomments = JsonConvert.DeserializeObject<List<ModelComments>>(content);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }


            return getcomments;
        }
    }
}
