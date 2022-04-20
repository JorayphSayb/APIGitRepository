using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TestApiGitHub
{
     class Program
    {

        private static readonly HttpClient client = new HttpClient();
        private readonly string _baseURL = "https://api.github.com/repos/";


        static async Task Main(string[] args)
        {
            try
            {
                await ProcessRepositoriesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
               
       

        }

        private static async Task ProcessRepositoriesAsync()
        {

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");


            var stringTask = client.GetStringAsync( _baseURL + "nalmeida94/empreendedorismoII");
            var repositories =  JsonConvert.DeserializeObject<Repository>(await stringTask);

      
            Console.WriteLine("Name: " + repositories.Name);
            Console.WriteLine("Id: " + repositories.Id);
            Console.WriteLine("Full_Name: " + repositories.Full_name);
            Console.WriteLine("Node_id: " + repositories.Node_id);
            Console.WriteLine("Private: " + repositories.Private);
            Console.WriteLine("html: " + repositories.Owner.Login);
            Console.WriteLine("html: " + repositories.Owner.Site_admin);
            Console.WriteLine("html: " + repositories.GitHubHomeUrl);
            


        }
    }
}
