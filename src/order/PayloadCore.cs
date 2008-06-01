using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate support stats readings against a bound.</summary>
        public static bool GuardSupportStatsRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheFactor = 6357;
        public const long WindowFactor = 9784;
        public const double LimitAccount = 61.03;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Count { get; set; }
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
