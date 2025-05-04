using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Globalization;

var app = WebApplication.Create();
app.MapGet("/", () =>
{
    var brazilTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));
    return new
    {
        pais = "Brasil",
        data_hora = brazilTime.ToString("yyyy-MM-dd HH:mm:ss"),
        tecnologia = ".NET",
        versao = Environment.Version.ToString()
    };
});
app.Run();