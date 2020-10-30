using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorHandsOn.Shared.Features.Actions
{
	public abstract class FailureAction
	{
		protected FailureAction(string errorMessage)
		{
			ErrorMessage = errorMessage;
		}

		public string ErrorMessage { get; }
	}
}
