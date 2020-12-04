using System.Collections.Concurrent;

namespace System.Management.Automation
{
    internal static class MshLog
    {
        internal static void LogCommandLifecycleEvent(ExecutionContext executionContext,
                                                CommandState commandState,
                                                InvocationInfo invocationInfo)
        {
            LogContext logContext = null;
            foreach (LogProvider provider in GetLogProvider(executionContext))
            {
                if (NeedToLogCommandLifecycleEvent(provider, executionContext))
                {

                }
            }
        }
    }
}
