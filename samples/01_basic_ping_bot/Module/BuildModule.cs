using System;
using System.IO;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using RestSharp;
using Unity;
using Microsoft.Extensions.DependencyInjection;
// Modules must be public and inherit from an IModuleBase
public class BuildModule : ModuleBase<SocketCommandContext>
{


    [Command("build")]
    public async Task BuildAsync(string buildID)
    {
        await buildAsync(buildID);
        await DiscordBot.Bot.SendMessage("빌드노예 에비츄는.. 이제부터 빌드를 할거에요.. 알림이 울리지 않더라도 기다리도록 하세여..");
    }
    [Command("buildcancel")]
    public async Task CancelAllAsync(string buildID)
    {
        await DiscordBot.Bot.SendMessage("빌드를 취소중입니다..");
        await CancelAsync(buildID);
        await DiscordBot.Bot.SendMessage("모든 빌드를 취소했답니다?");
    }

    public async Task CancelAsync(string buildID)
    {
        var client = new RestClient("http://example.com"); 
        

        var request = new RestRequest(Config.path + string.Format("orgs/{0}/projects/{1}/buildtargets/{2}/builds/", Config.orga, Config.projectID, buildID), Method.DELETE, DataFormat.Json);
        request.Method = Method.DELETE;
        request.AddHeader("Content-Type", "application/json");
        request.AddHeader("Authorization", Config.apikey); 
        var response = client.Delete(request);  

    } 

    private async Task buildAsync(string buildID)
    {
        var client = new RestClient("http://example.com"); 
        var request = new RestRequest(Config.path + string.Format("orgs/{0}/projects/{1}/buildtargets/{2}/builds", Config.orga, Config.projectID, buildID), Method.GET);
        request.AddHeader("Content-Type", "application/json");
        request.AddHeader("Authorization", Config.apikey); 
        var response = client.Post(request); 

        /////////////////////////////////////////////////////////////////////
        if (response.Content.Contains("aleady a build pending."))
        {
            await DiscordBot.Bot.SendMessage("현재 보류된 빌드가 존재합니다. (너무 많은 요청, 혹은 빌드서버 과부하 등으로 보류되는거라 곧 빌드가 진행됩니다.)");
        }
    }
     

}
