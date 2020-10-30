using BlazorHandsOn.Shared.Features.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorHandsOn.Store.Features.Leaders.Actions.LoadLeaders
{
	public class LoadLeadersFailureAction : FailureAction
	{
		public LoadLeadersFailureAction(string errorMessage) : base(errorMessage)
		{
		}
	}
}
