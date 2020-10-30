using BlazorHandsOn.Store.State;
using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorHandsOn.Store.Features.Counter
{
	public class LeadersFeature : Feature<LeadersState>
	{
		public override string GetName() => typeof(LeadersFeature).Name;
		protected override LeadersState GetInitialState() => new LeadersState(false, null, null, null);
	}
}
