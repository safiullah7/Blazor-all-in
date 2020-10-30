using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AKSoftware.WebApi.Client;
using BlazorHandsOn.Shared.Models;

namespace BlazorHandsOn.Shared.Services
{
	public class AuthenticationService
	{
		private readonly string Base_Url;
		ServiceClient client = new ServiceClient();

		public AuthenticationService(string url)
		{
			Base_Url = url;
		}

		public async Task<UserManagerResponse> RegisterUserAsync(RegisterRequest request)
		{
			var response = await client.PostAsync<UserManagerResponse>($"{Base_Url}/api/auth/register", request);
			return response.Result;
		}

		public async Task<UserManagerResponse> LoginUserAsync(LoginRequest request)
		{
			var response = await client.PostAsync<UserManagerResponse>($"{Base_Url}/api/auth/login", request);
			return response.Result;
		}
		public async Task<IEnumerable<Leader>> GetLeadersAsync()
		{
			var response = await client.GetAsync<IEnumerable<Leader>>("http://localhost:3000/leaders");
			return response.Result;
		}
	}
}
