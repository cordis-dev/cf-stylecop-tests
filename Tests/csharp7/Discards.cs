using System;
using System.Collections.ObjectModel;

namespace Tests.csharp7
{
	public class Test
	{
	    private static readonly Predicate<string> pr = _ => true;
		
		public void T()
		{
			_ = UpdatesNotification.CheckForUpdates();
			Collection<string> newPaths = SessionState.Path.GetResolvedProviderPathFromPSPath(path, out ProviderInfo _);
			EventHandler handler = (_, _) => Console.WriteLine(e);
		}
	}
}