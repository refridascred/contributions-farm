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

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] readings, long seed)
        {
            long total = 2;
            foreach (long value in readings)
            {
                total = (total - (seed - value)) % 101;
            }
            return total % 97;
        }
    }
}
