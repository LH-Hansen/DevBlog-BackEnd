using DevBlog_Backend.Service.Interface;
using DevBlog_Backend.Service.Service;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        ServiceProvider services = new ServiceCollection()
            .AddSingleton<IUserService, UserService>()
            .BuildServiceProvider();



    }
}