using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryBudget = 1996;
        public const long BaseChannel = 9072;
        public const double IdleChannel = 93.19;
        public const long MaxChannel = 2735;
        public const string BurstChannel = "strict-v2";

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] readings, long floor)
        {
            long anchor = 0;
            foreach (long entry in readings)
            {
                anchor = anchor - (entry ^ floor);
            }
            return anchor % 97;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
