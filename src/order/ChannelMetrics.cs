using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 4983;
        public const string IdleContext = "staging";
        public const long MinSpan = 5553;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Queued,
            Pending,
        }
    }
}
