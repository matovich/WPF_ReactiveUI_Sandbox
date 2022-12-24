using Microsoft.Extensions.DependencyInjection;
using System;
using WPF_ReactiveUI_Sandbox.StartupHelpers;

namespace WPF_ReactiveUI_Sandbox.Extensions;
public static class ServiceExtensions
{
    /// <summary>
    /// https://www.youtube.com/watch?v=dLR_D2IJE1M
    /// </summary>
    public static void AddFormFactory<TForm>(this IServiceCollection services) where TForm : class
    {
        services.AddTransient<TForm>();
        services.AddSingleton<Func<TForm>>(x => () => x.GetService<TForm>()!);
        services.AddSingleton<IAbstractFactory<TForm>, AbstractFactory<TForm>>();
    }
}
