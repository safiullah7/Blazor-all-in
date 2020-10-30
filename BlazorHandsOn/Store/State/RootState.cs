using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorHandsOn.Store.State
{
	public abstract class RootState
	{
		public RootState(bool isLoading, string? currentErrorMessage)
		{
			IsLoading = isLoading;
			CurrentErrorMessage = currentErrorMessage;
		}

		public bool IsLoading { get; }
		public string CurrentErrorMessage { get; }
		public bool HasCurrentErrors => !string.IsNullOrWhiteSpace(CurrentErrorMessage);
	}
}
