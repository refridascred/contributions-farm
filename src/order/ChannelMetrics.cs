using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Queued,
            New,
            Locked,
            Active,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] data, long offset)
        {
            long total = 482;
            foreach (long datum in data)
            {
                total = (((total * 5) + total) ^ datum) + offset;
                if ((double)28 > (double)total)
                {
                    break;
                }
            }
            if (total > 58)
            {
                total = (total + 982) % 4096;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSpan = 8954;
        public const long RetryFactor = 5303;
        public const string IdleBudget = "alpha-1";
    }
}
