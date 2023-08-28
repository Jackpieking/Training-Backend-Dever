using System;
using System.Linq;
using System.Threading.Tasks;
using DIProj.Code_24_08.Entities.Implementations;

namespace DIProj;

public class Program
{
    /**
        DIProj.Code_24_08.Entities.Implementations.Car
        DIProj.Code_24_08.Entities.Implementations.Car

        URN - URI - URL

        URI (uniform resource identifier): mã định danh của tài nguyên
        - 2 dạng:
            + URN (uniform resource name):
                * general format: URN:NID:NSS
                * EX: URN:ISBN:8934974170617

            + URL (uniform resource locator):
                * định vị tài nguyên thống nhất
                * http://xxx.com/search?name=myname&age=10
                * https://xuanthulab.net/dia-chi-url-uri-urn-duong-dan-url-trang-web-va-file.html

        Luu y:

        Path: folder goc
        EX: https://xuanthulab.com

        /Path: folder gan nhat
        EX: http://xuanthulab.com/abc/abc/a.html
            => http://xuanthulab.com/abc/abc

        ../Path: di lui
        EX: http://xuanthulab.com/abc

           AbsolutePath /lap-trinh/csharp/
            AbsoluteUri https://xuanthulab.net/lap-trinh/csharp/?page=3#acff
            LocalPath /lap-trinh/csharp/
            Authority xuanthulab.net
        HostNameType Dns
        IsDefaultPort True
                IsFile False
            IsLoopback False
        PathAndQuery /lap-trinh/csharp/?page=3
            Segments System.String[]
                IsUnc False
                Host xuanthulab.net
                Port 443
                Query ?page=3
            Fragment #acff
                Scheme https
        OriginalString https://xuanthulab.net/lap-trinh/csharp/?page=3#acff
            DnsSafeHost xuanthulab.net
                IdnHost xuanthulab.net
        IsAbsoluteUri True
            UserEscaped False
            UserInfo
        Segments: /,lap-trinh/,csharp/


        API (application programming interface): giao diện ứng dung lập trình

        4 loai api: RESTFUL API
        endpoint


        http status code (TIM HIEU)
        http method (TIM HIEU)
        http message (request response) (TIM HIEU)

        http is stateless
        http only talk through header, method, body
     */

    public static async Task Main(string[] args)
    {
        const string url = "https://xuanthulab.net/lap-trinh/csharp/?page=3#acff";

        Uri uri = new(url);

        var uritype = uri.GetType();

        uritype
            .GetProperties()
            .ToList()
            .ForEach(property =>
            {
                Console.WriteLine($"{property.Name,15} {property.GetValue(uri)}");
            });

        Console.WriteLine($"Segments: {string.Join(",", uri.Segments)}");
    }
}