using System;
using System.IO;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using RestSharp;
using Unity;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
// Modules must be public and inherit from an IModuleBase
public class ShareModule_NineStones : ModuleBase<SocketCommandContext>
{
 
    private int buildNumber = 46;
    [Discord.Commands.DontInject]
    public int BuildNumber
    {
        get
        {
            return buildNumber;
        }

        set => buildNumber = value;
    }
 
    /// <summary>
    /// 해당번호로 가져오기 
    /// </summary>
    /// <param name="buildNumber"></param>
    /// <returns></returns>
    [Command("getDownloadUrl")]
    public async Task getDownloadURL(int buildNumber)
    {
        await GetDownloadURLAsync("build-android", buildNumber);
    }
    /// <summary>
    /// Latest로 가져오기 
    /// </summary>
    /// <returns></returns>
    [Command("getDownloadUrl")]
    public async Task getDownloadURL()
    {
        await GetDownloadURLAsync("build-android", BuildNumber);
    } 

    [Command("setDownloadBuildVersion")]
    public async Task SetDownloadURL(int value)
    {
        await DiscordBot.Bot.SendMessage(value + "버전으로 최신버전이 설정되었습니다.");
        BuildNumber = value;
    } 

    public async Task GetDownloadURLAsync(string buildID, int buildNumber)
    {

        await DiscordBot.Bot.SendMessage("빌드노예 햄스터가 다운로드 링크를 가져오고 있어용....", 577827869661855764);
        var client = new RestClient("http://example.com");
        var request = new RestRequest(Config.path + string.Format("orgs/{0}/projects/{1}/buildtargets/{2}/builds/{3}/share", Config.orga, Config.projectID, buildID, buildNumber), Method.DELETE, DataFormat.Json);
        request.Method = Method.GET;
        request.AddHeader("Content-Type", "application/json");
        request.AddHeader("Authorization", Config.apikey);


        var response = client.Post(request);

        var p = JsonConvert.DeserializeObject<ReceiveURL>(response.Content);

        await DiscordBot.Bot.SendMessage(" 다운로드 링크가 만들어졌어요! \n 버전 :: " + BuildNumber + "\n https://developer.cloud.unity3d.com/share/share.html?shareId =" + p.shareid, 577827869661855764);
   
    }


}
