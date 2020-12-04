using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Tracing;
using System.Security;
using System.Threading;

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
