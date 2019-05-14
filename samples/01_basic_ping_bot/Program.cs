using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using RestSharp;
using Newtonsoft.Json;
namespace Unity
{

    public class REST
    {
        public Discord discord;

        public readonly string  path =  Config.path;
        public readonly string orga = Config.orga;
        public readonly string projectID = Config.projectID;
        public readonly string apikey = Config.apikey;

        public async void Build(string buildID)
        {
            var client = new RestClient("http://example.com");
            await discord.SendMessage("빌드노예 에비츄는.. 이제부터 빌드를 할거에요.. 알림이 울리지 않더라도 기다리도록 하세여..");

            var request = new RestRequest(path + string.Format("orgs/{0}/projects/{1}/buildtargets/{2}/builds", orga, projectID, buildID), Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", apikey);

            var response = client.Post(request);

            Console.WriteLine();
            Console.WriteLine(response.Content);
            Console.WriteLine();


            if (response.Content.Contains("aleady a build pending."))
            {
                await discord.SendMessage("현재 보류된 빌드가 존재합니다. (너무 많은 요청, 혹은 빌드서버 과부하 등으로 보류되는거라 곧 빌드가 진행됩니다.)");
            }
        }

        public async void CancelAll(string buildID)
        {
            var client = new RestClient("http://example.com");
            await discord.SendMessage("모든 빌드를 취소했답니다?");
            var request = new RestRequest(path + string.Format("orgs/{0}/projects/{1}/buildtargets/{2}/builds/", orga, projectID, buildID), Method.DELETE, DataFormat.Json);
            request.Method = Method.DELETE;
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", apikey);

            var response = client.Delete(request);
            Console.WriteLine();
            Console.WriteLine(response.Request.Method);
            Console.WriteLine(response.Content);
            Console.WriteLine(response.StatusCode);
            Console.WriteLine();
        }
    }
    public class Discord
    {
        REST rest = new REST();
        private readonly DiscordSocketClient _client;

        public readonly string login_key = Config.discord_loginKey;

        ulong serverid = 577384911405711380;
        ulong apk_build = 577739512898256917;
        static void Main(string[] args)
        {
            new Discord().MainAsync().GetAwaiter().GetResult();
        }

        public Discord()
        {
            rest.discord = this;
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
            await _client.LoginAsync(TokenType.Bot, login_key);
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


        public async Task SendMessage(string value)
        {
            var p = await _client.GetGuild(serverid).GetTextChannel(apk_build).SendMessageAsync(value);
        }
        // This is not the recommended way to write a bot - consider
        // reading over the Commands Framework sample.
        private async Task MessageReceivedAsync(SocketMessage message)
        {
            // The bot should never respond to itself.
            if (message.Author.Id == _client.CurrentUser.Id)
                return;

            if (message.Channel.Id == 577739512898256917)
            {
                if (message.Content == "!build-android")
                {
                    rest.Build("build-android");
                }
                if (message.Content == "!build-android-cancel")
                {
                    rest.CancelAll("build-android");
                }
            }
        }

    }
}
