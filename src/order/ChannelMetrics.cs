using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            New,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Stale,
            Synced,
            Pending,
            New,
        }
    }
}
