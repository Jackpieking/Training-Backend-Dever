using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Training_Backend_Dever._14_09_2023_Send_Request_And_Receive_Reponse_In_CSharp.RequestResponseService;

public sealed class GoogleWebsiteHandlerService : IGoogleWebsiteHandlerService
{
    public async Task SendGetRequestToGoogleAsync()
    {
        const string Url = "https://www.google.com";

        using HttpClient httpClient = new()
        {
            Timeout = TimeSpan.FromSeconds(value: 30)
        };

        HttpRequestMessage requestMessage = new()
        {
            RequestUri = new(uriString: Url),
            Method = HttpMethod.Get
        };

        using var googleWebResponse = await httpClient.SendAsync(requestMessage);

        Console.WriteLine(value: (short)googleWebResponse.StatusCode);

        //200 - OK
    }

    public async Task SendToFuDeverLoginApiAsync()
    {
        const string Url = "https://fudeverapi.bsite.net/api/auth/login";

        using HttpClient httpClient = new()
        {
            Timeout = TimeSpan.FromSeconds(value: 30)
        };

        HttpRequestMessage httpRequestMessage = new()
        {
            RequestUri = new(uriString: Url),
            Method = HttpMethod.Post
        };

        var loginCredentials = new
        {
            Email = "ledinhdangkhoa10a9@gmail.com",
            Password = "Jackpie2003",
            RememberMe = false
        };

        httpRequestMessage.Content = JsonContent.Create(inputValue: loginCredentials);

        using var fuDeverLoginApiResponse = await httpClient.SendAsync(request: httpRequestMessage);

        Console.WriteLine(value: $"Reponse status code: {(short)fuDeverLoginApiResponse.StatusCode}");

        if (fuDeverLoginApiResponse.IsSuccessStatusCode)
        {
            Console.WriteLine(value: "body: ");
            Console.WriteLine(value: await fuDeverLoginApiResponse.Content.ReadAsStringAsync());
        }
    }

    public async Task SendToFuDeverLogoutApiAsync()
    {
        const string AccessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiJlNzBmNmY3MS1iYTBmLTQzYTctOGEzNS05ZjUxOTA3MmI5ZDciLCJpYXQiOjE2OTQ2OTI5NjksInN1YiI6ImZiYzE4ODE2LTU5YWYtNGJjMi1iMzc1LTA2Yzg5Y2E0MDRlNyIsImVtYWlsIjoibGVkaW5oZGFuZ2tob2ExMGE5QGdtYWlsLmNvbSIsIlVzZXJSb2xlIjoibWVtYmVyIiwicmVtZW1iZXItbWUiOiJGYWxzZSIsIm5iZiI6MTY5NDY5Mjk2OSwiZXhwIjoxNjk0Njk2NTY5LCJpc3MiOiJodHRwczovL2Z1ZGV2ZXJhcGkuYnNpdGUubmV0LyIsImF1ZCI6Imh0dHA6Ly9mdS1kZXZlci5jb20vIn0.g_KVCPGy6oGV4lpS2lfNxCGCCFRb6mbufqqSY-bZwV0";
        const string AuthorizationHeader = "Authorization";
        const string Url = "https://fudeverapi.bsite.net/api/auth/logout";

        using HttpClient httpClient = new()
        {
            Timeout = TimeSpan.FromSeconds(value: 30)
        };

        HttpRequestMessage httpRequestMessage = new()
        {
            RequestUri = new(uriString: Url),
            Method = HttpMethod.Post
        };

        httpRequestMessage.Headers.Add(name: AuthorizationHeader, value: $"Bearer {AccessToken}");

        using var fuDeverLoginApiResponse = await httpClient.SendAsync(request: httpRequestMessage);

        Console.WriteLine(value: $"Reponse status code: {(short)fuDeverLoginApiResponse.StatusCode}");

        if (fuDeverLoginApiResponse.IsSuccessStatusCode)
        {
            Console.WriteLine(value: "body: ");
            Console.WriteLine(value: await fuDeverLoginApiResponse.Content.ReadAsStringAsync());
        }
    }
}

//eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiJlNzBmNmY3MS1iYTBmLTQzYTctOGEzNS05ZjUxOTA3MmI5ZDciLCJpYXQiOjE2OTQ2OTI5NjksInN1YiI6ImZiYzE4ODE2LTU5YWYtNGJjMi1iMzc1LTA2Yzg5Y2E0MDRlNyIsImVtYWlsIjoibGVkaW5oZGFuZ2tob2ExMGE5QGdtYWlsLmNvbSIsIlVzZXJSb2xlIjoibWVtYmVyIiwicmVtZW1iZXItbWUiOiJGYWxzZSIsIm5iZiI6MTY5NDY5Mjk2OSwiZXhwIjoxNjk0Njk2NTY5LCJpc3MiOiJodHRwczovL2Z1ZGV2ZXJhcGkuYnNpdGUubmV0LyIsImF1ZCI6Imh0dHA6Ly9mdS1kZXZlci5jb20vIn0.g_KVCPGy6oGV4lpS2lfNxCGCCFRb6mbufqqSY-bZwV0