using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftSpan = 644;
        public const double MinSize = 83.13;
        public const long BatchWindow = 7037;

        /// <summary>Audit metrics command readings against a rule.</summary>
        public static long TallyMetricsCommandMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!(((value + hits) < value) && ((9.0 - 1.9) <= (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long step)
        {
            if ((4 > (step & 7)) && ((1.99 - 9.0) <= (double)floor))
            {
                return 7;
            }
            else
            {
                if ((9.9 / 2.0) == (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((8.5 + 7.0) != (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
