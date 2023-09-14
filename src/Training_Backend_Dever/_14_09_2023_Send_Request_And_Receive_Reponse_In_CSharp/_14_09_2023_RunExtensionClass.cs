using System.Threading.Tasks;
using Training_Backend_Dever._14_09_2023_Send_Request_And_Receive_Reponse_In_CSharp.RequestResponseService;

namespace Training_Backend_Dever._14_09_2023_Send_Request_And_Receive_Reponse_In_CSharp;

public static class _14_09_2023_RunExtensionClass
{
    public static async Task ExecuteAsync()
    {
        IGoogleWebsiteHandlerService googleWebsiteHandlerService = new GoogleWebsiteHandlerService();

        await googleWebsiteHandlerService.SendToFuDeverLogoutApiAsync();
    }
}