using BlazorHandsOn.Shared.Constants;
using BlazorHandsOn.Shared.Models;
using BlazorHandsOn.Shared.Services;
using BlazorHandsOn.Store.Features.Leaders.Actions.LoadLeaders;
using Fluxor;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorHandsOn.Store.Features.Leaders.Effects
{
	public class LoadLeadersEffect: Effect<LoadLeadersAction>
	{
		private readonly ILogger<LoadLeadersEffect> logger;
		private readonly AuthenticationService auth;

		public LoadLeadersEffect(ILogger<LoadLeadersEffect> logger, AuthenticationService auth)
		{
			this.logger = logger;
			this.auth = auth;
		}

		protected async override Task HandleAsync(LoadLeadersAction action, IDispatcher dispatcher)
		{
			try
			{
				logger.LogInformation("Loading Leaders...");

				// Add a little extra latency for dramatic effect...
				await Task.Delay(TimeSpan.FromMilliseconds(1000));
				var leaders = await auth.GetLeadersAsync();

				logger.LogInformation("Leaders loaded successfully");
				dispatcher.Dispatch(new LoadLeadersSuccessAction(leaders));
			}
			catch(Exception e)
			{
				logger.LogInformation($"Error loading leaders, reason: {e.Message}");
				dispatcher.Dispatch(new LoadLeadersFailureAction(e.Message));
			}
		}
	}
}
