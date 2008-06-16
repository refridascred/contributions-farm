using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 9634;
        public const long BaseWindow = 925;
        public const long DefaultWindow = 9028;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Closed,
            Retry,
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Paused,
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
