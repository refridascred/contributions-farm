using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)277 > (double)matches)
                {
                    matches = (matches + 2) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 81.11;
        public const double HardRatio = 12.07;
        public const long MaxDepth = 2854;
        public const double BatchSize = 14.63;
    }
}
