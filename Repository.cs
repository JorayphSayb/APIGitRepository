using System;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TestApiGitHub
{
    public class Repository
    {
     
         [JsonProperty("name")]
        public string Name { get; set; }
         
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("full_name")]
        public string Full_name { get; set; }

        [JsonProperty("html_url")]
        public string GitHubHomeUrl { get; set; }

        [JsonProperty("homepage")]
        public Uri Homepage { get; set; }

        [JsonProperty("watchers")]
        public int Watchers { get; set; }
        
       [JsonProperty("node_id")]
       public string Node_id { get; set; }
        
        [JsonProperty("private")]
        public string Private { get; set; }
       
        [JsonProperty("owner")]
        public Owner Owner { get; set; }


    }


    public class Owner 
    {

        [JsonProperty("login")]
        public string Login { get; set; }
        
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("node_id")]
        public string Node_id { get; set; }
       
        [JsonProperty("avatar_url")]
        public string Avata_url { get; set; }
        
        [JsonProperty("gravatar_id")]
        public string Gravatar_id { get; set; }
        
        [JsonProperty("url")]
        public string Url { get; set; }
        
        [JsonProperty("html_url")]
        public string Html_url { get; set; }
        
        [JsonProperty("followers_url")]
        public string Followers_url { get; set; }
        
        [JsonProperty("following_url")]
        public string Following_url { get; set; }
        
        [JsonProperty("gists_url")]
        public string Gists_url { get; set; }
        
        [JsonProperty("starred_url")]
        public string Starred_url { get; set; }
        
        [JsonProperty("subscriptions_url")]
        public string Subscriptions_url { get; set; }
        
        [JsonProperty("organizations_url")]
        public string Organizations_url { get; set; }
       
        [JsonProperty("repos_url")]
        public string Repos_url { get; set; }
        
        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }
        
        [JsonProperty("received_events_url")]
        public string Received_events_url { get; set; }
        
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("site_admin")]
        public string Site_admin { get; set; }

    }

}




