using BlazorHandsOn.Store.Features.Leaders.Actions.LoadLeaders;
using Fluxor;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorHandsOn.Services
{
	public class StateFacade
	{
		private readonly ILogger<StateFacade> logger;
		private readonly IDispatcher dispatcher;

		public StateFacade(ILogger<StateFacade> logger, IDispatcher dispatcher)
			=> (this.logger, this.dispatcher) = (logger, dispatcher);

		public void LoadLeaders()
		{
			logger.LogInformation("Issuing action to load leaders...");
			dispatcher.Dispatch(new LoadLeadersAction());
		}
	}
}
