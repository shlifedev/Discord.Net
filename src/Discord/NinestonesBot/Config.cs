using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using RestSharp;
using Newtonsoft.Json;
namespace Unity
{

    public class Config
    {
   
        public static readonly string  path =  "https://build-api.cloud.unity3d.com/api/v1/";
        public static readonly string orga = "gamedevcom";
        public static readonly string projectID ="f15d8009-4472-4d5e-90dd-c8d911f79ba1";
        public static readonly string apikey = "Basic baff66f6b749016c38a758cf334f5fbd";

        public static readonly string discord_loginKey = "NTc3NzQ0NzgxMDgyMzYxODU3.XNph6g.SWkKEIUdw1LA2UxQzSfQXIOKATY";



    }
}
