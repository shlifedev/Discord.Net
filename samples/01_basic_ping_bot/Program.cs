using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using RestSharp;

namespace Unity
{

    public class REST
    {
        public readonly string  path = "https://build-api.cloud.unity3d.com/api/v1/";
        public readonly string orga = "gamedevcom";

        public void Build(string buildID)
        {
            var client = new RestClient("http://example.com");

            var request = new RestRequest(path + string.Format("orgs/gamedevcom/projects/f15d8009-4472-4d5e-90dd-c8d911f79ba1/buildtargets/{0}/builds", buildID), Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Basic  ");

            var response = client.Post(request);
            var content = response.Content; // raw content as string
        }
    }
    class Program
    {
        REST rest = new REST();
        private readonly DiscordSocketClient _client;

  
        static void Main(string[] args)
        { 
            new Program().MainAsync().GetAwaiter().GetResult();
        }

        public Program()
        {
            // It is recommended to Dispose of a client when you are finished
            // using it, at the end of your app's lifetime.
            _client = new DiscordSocketClient();

            _client.Log += LogAsync;
            _client.Ready += ReadyAsync;
            _client.MessageReceived += MessageReceivedAsync;
        }

        public async Task MainAsync()
        {
            // Tokens should be considered secret data, and never hard-coded.
            await _client.LoginAsync(TokenType.Bot, " ");
            await _client.StartAsync();

            // Block the program until it is closed.
            await Task.Delay(-1);
        }

        private Task LogAsync(LogMessage log)
        {
            Console.WriteLine(log.ToString());
            return Task.CompletedTask;
        }

        // The Ready event indicates that the client has opened a
        // connection and it is now safe to access the cache.
        private Task ReadyAsync()
        {
            Console.WriteLine($"{_client.CurrentUser} is connected!");

            return Task.CompletedTask;
        }

        // This is not the recommended way to write a bot - consider
        // reading over the Commands Framework sample.
        private async Task MessageReceivedAsync(SocketMessage message)
        {
            // The bot should never respond to itself.
            if (message.Author.Id == _client.CurrentUser.Id)
                return;

            if (message.Content == "!android-build")
            {
                await message.Channel.SendMessageAsync("Android Build Start");
                rest.Build("build-android");
            }
        }
    }
}
