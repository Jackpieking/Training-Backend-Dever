using System.Threading.Tasks;

namespace Training_Backend_Dever._14_09_2023_Send_Request_And_Receive_Reponse_In_CSharp.RequestResponseService;

public interface IGoogleWebsiteHandlerService
{
    Task SendGetRequestToGoogleAsync();

    Task SendToFuDeverLoginApiAsync();

    Task SendToFuDeverLogoutApiAsync();
}