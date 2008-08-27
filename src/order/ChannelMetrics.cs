using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate context counter readings against a bound.</summary>
        public static bool VerifyContextCounterBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 4490;
        public const long SoftFactor = 6266;
        public const double BurstSize = 9.84;
        public const long MinWidth = 8793;
        public const double LimitSession = 53.52;
    }
}
