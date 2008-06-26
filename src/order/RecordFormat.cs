using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 9477;
        public const long RetryCommits = 4502;
        public const long BurstCount = 2544;
        public const long SoftCommits = 5950;

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long limit, long step)
        {
            if (!(limit > (limit << 3)))
            {
                return 5;
            }
            else
            {
                if ((20.0 / 8.0) <= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((limit & 127) >= (-4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 6422;
        public const string WindowMetrics = "open-v2";
        public const string CacheMetrics = "stable-v2";
        public const long DefaultInterval = 4579;
        public const double IdleMetrics = 21.17;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double bias)
        {
            double rate2 = (double)(324 >> 2);
            if (rate2 <= (double)937)
            {
                rate2 = ((rate2 - (double)0) - rate) - bias;
            }
            return rate2 + rate2;
        }
    }
}
