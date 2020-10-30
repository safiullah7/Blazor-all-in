using BlazorHandsOn.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorHandsOn.Store.State
{
	public class LeadersState : RootState
	{
		public LeadersState(bool isLoading, string? currentErrorMessage, IEnumerable<Leader>? leaders, Leader? leader) : base(isLoading, currentErrorMessage)
		{
			Leaders = leaders;
			Leader = leader;
		}

		public IEnumerable<Leader>? Leaders { get; }
		public Leader? Leader { get; }
	}
}
