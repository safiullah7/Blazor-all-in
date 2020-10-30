using BlazorHandsOn.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorHandsOn.Store.Features.Leaders.Actions.LoadLeaders
{
	public class LoadLeadersSuccessAction
	{
		public LoadLeadersSuccessAction(IEnumerable<Leader> leaders)
		{
			Leaders = leaders;
		}

		public IEnumerable<Leader> Leaders { get; }
	}
}
