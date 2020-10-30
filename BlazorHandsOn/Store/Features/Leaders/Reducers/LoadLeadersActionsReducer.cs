using BlazorHandsOn.Store.Features.Leaders.Actions.LoadLeaders;
using BlazorHandsOn.Store.State;
using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorHandsOn.Store.Features.Leaders.Reducers
{
	public static class LoadLeadersActionsReducer
	{
		[ReducerMethod]
		public static LeadersState ReduceLoadLeadersAction(LeadersState state, LoadLeadersAction action)
			=> new LeadersState(true, null, null, state.Leader);

		[ReducerMethod]
		public static LeadersState ReduceLoadLeadersSuccessAction(LeadersState state, LoadLeadersSuccessAction action)
			=> new LeadersState(false, null, action.Leaders, state.Leader);

		[ReducerMethod]
		public static LeadersState ReduceLoadLeadersFailureAction(LeadersState state, LoadLeadersFailureAction action)
			=> new LeadersState(false, action.ErrorMessage, null, state.Leader);
	}
}
