using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorHandsOn.Shared.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Fluxor;
using System.Reflection;
using BlazorHandsOn.Services;

namespace BlazorHandsOn
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("app");

			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
			builder.Services.AddScoped<AuthenticationService>(iSerProv =>
			{
				return new AuthenticationService(Shared.Constants.Agent.BASE_URL);
			});
			builder.Services.AddOptions();
			builder.Services.AddAuthorizationCore();
			builder.Services.AddScoped<AuthenticationStateProvider, LocalAuthenticationStateProvider>();
			builder.Services.AddBlazoredLocalStorage();
			builder.Services.AddTelerikBlazor();
			builder.Services.AddScoped<StateFacade>();
			builder.Services.AddFluxor(options =>
			{
				options.ScanAssemblies(Assembly.GetExecutingAssembly());
				options.UseReduxDevTools();
			});

			await builder.Build().RunAsync();
		}
	}
}
