using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using RestSharp;
using Newtonsoft.Json;
using Discord.Commands;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading;

namespace Unity
{
    public class ReceiveURL
    {
        public string shareid = null;
    }
    public class REST
    {
        public DiscordBot discord;

        public readonly string  path =  Config.path;
        public readonly string orga = Config.orga;
        public readonly string projectID = Config.projectID;
        public readonly string apikey = Config.apikey;





    }

    public class ThreadPool
    {
        public static List<System.Threading.Thread> threadList = new List<System.Threading.Thread>();
        public static void AddThread(System.Threading.ParameterizedThreadStart targetMethod)
        {
            Thread th = new Thread(targetMethod);
            threadList.Add(th);
            th.IsBackground = true;
            th.Start();
        }
    }
    public class DiscordBot
    {

        static System.Threading.Thread botThread;
        private static DiscordBot bot;

        REST  rest = new REST();
        ulong serverid = 577384911405711380;
        ulong apk_build = 577739512898256917;
        public readonly string login_key = Config.discord_loginKey;

        public static DiscordBot Bot { get => bot; set => bot = value; }

        private DiscordSocketClient _client;
        public static IServiceProvider SERVICE = null;


        static void Main(string[] args)
        {
            if (Bot == null)
                Bot = new DiscordBot();


            ThreadPool.AddThread(new System.Threading.ParameterizedThreadStart(RunBot));

            while (true)
            {

            }
        }

        static void RunBot(object thread)
        {
            Bot.MainAsync().GetAwaiter().GetResult();
        }
        public async Task MainAsync()
        {

            using (var services = ConfigureServices())
            {
                rest.discord = this;
                // It is recommended to Dispose of a client when you are finished
                // using it, at the end of your app's lifetime.
                _client = services.GetRequiredService<DiscordSocketClient>();

                _client.Log += LogAsync;
                _client.Ready += ReadyAsync;
                _client.MessageReceived += MessageReceivedAsync;



                services.GetRequiredService<CommandService>().Log += LogAsync;

                // Tokens should be considered secret data, and never hard-coded.
                await _client.LoginAsync(TokenType.Bot, login_key);
                await _client.StartAsync();
                await services.GetRequiredService<CommandHandlingService>().InitializeAsync();


                // Block the program until it is closed.
                await Task.Delay(-1);

                SERVICE = services;

            }
        }

        private ServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                .AddSingleton<DiscordSocketClient>()
                .AddSingleton<CommandService>()
                .AddSingleton<CommandHandlingService>()
                .AddSingleton<HttpClient>()
                .BuildServiceProvider();
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


        public async Task SendMessage(string value, ulong chID = 0)
        {
            var p = await _client.GetGuild(serverid).GetTextChannel(
                chID == 0 ? apk_build : chID)
                .SendMessageAsync(value);
        }


        // This is not the recommended way to write a bot - consider
        // reading over the Commands Framework sample.
        private async Task MessageReceivedAsync(SocketMessage message)
        {
            Console.WriteLine(message);
        }

    }
}



