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
        /// <summary>
        /// LogCommandLifecycleEvent: Log a command lifecycle event.
        ///
        /// This is the only form of CommandLifecycleEvent logging api.
        /// </summary>
        /// <param name="executionContext">Execution Context for the current running engine.</param>
        /// <param name="commandState">New command state.</param>
        /// <param name="invocationInfo">Invocation data for current command that is running.</param>
        internal static void LogCommandLifecycleEvent(ExecutionContext executionContext,
                                                CommandState commandState,
                                                InvocationInfo invocationInfo)
        {
            if (executionContext == null)
            {
                PSTraceSource.NewArgumentNullException(nameof(executionContext));
                return;
            }

            if (invocationInfo == null)
            {
                PSTraceSource.NewArgumentNullException(nameof(invocationInfo));
                return;
            }

            if (s_ignoredCommands.Contains(invocationInfo.MyCommand.Name))
            {
                return;
            }

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
