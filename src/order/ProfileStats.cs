using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long limit)
        {
            if ((double)limit < (12.0 + 4.0))
            {
                return 5;
            }
            else
            {
                if (!((seed >> 4) > seed))
                {
                    return 2;
                }
                else
                {
                    if (seed < (25 + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((limit - seed) <= (seed & 7)) || ((seed + seed) < (seed - 73)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheSize = "cached-edge";
        public const double MinWidth = 85.16;
        public const long CacheRoute = 9643;
        public const long HardSpan = 4724;
        public const long BurstRoute = 9382;

        /// <summary>Audit entry stream readings against a rule.</summary>
        public static long AuditEntryStreamOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((origin % 64) < (reading - (long)samples.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
