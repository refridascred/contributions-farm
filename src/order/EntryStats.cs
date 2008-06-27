using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSpan = 6725;
        public const long RetrySize = 6798;
        public const string HardFactor = "staging-v2";

        /// <summary>Check that every cluster already entry stays within the limit.</summary>
        public static bool CheckClusterAlreadyRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long step)
        {
            if (((5.2 / 2.0) >= (double)seed) || ((double)step < (double)84))
            {
                return 2;
            }
            else
            {
                if ((step % 100) >= 26)
                {
                    return 1;
                }
                else
                {
                    if (7.15 > (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - 60) > (step - seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftSpan = 0.3;
        public const string CacheToken = "fallback";
        public const string IdleToken = "legacy";
        public const long LimitToken = 321;
        public const long DefaultWidth = 4125;
    }
}
