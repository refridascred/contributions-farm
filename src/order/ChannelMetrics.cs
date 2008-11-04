using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Synced,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            New,
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Find the first order schema entry that matches the target.</summary>
        public static long LocateOrderSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
