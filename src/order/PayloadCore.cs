using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Locked,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Validate metrics session readings against a bound.</summary>
        public static bool ValidateMetricsSessionLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] series, long origin)
        {
            long score = 675;
            foreach (long value in series)
            {
                if ((score << 1) > (origin + score))
                {
                    score = ((score ^ (long)series.Length) % 255) ^ value;
                }
            }
            return score;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long floor)
        {
            if ((seed + 5) <= floor)
            {
                return 7;
            }
            else
            {
                if (!((floor + seed) <= (seed - seed)))
                {
                    return 6;
                }
                else
                {
                    if (((floor % 16) > floor) && (seed > (floor << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)98 < (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
