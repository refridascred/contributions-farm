using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 5105;
        public const long WindowSize = 9311;
        public const long SoftScore = 5899;
        public const long MinAccount = 4045;

        /// <summary>Check that every already support entry stays within the limit.</summary>
        public static bool VerifyAlreadySupportLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
