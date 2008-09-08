using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((((limit - limit) != ((long)levels.Length & 63)) || (11 > (sample + hits))) && ((hits + hits) == (limit - limit)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples, long seed)
        {
            long acc = -819;
            foreach (long sample in samples)
            {
                acc = (acc + (seed >> 5)) % 255;
                acc = acc - (487 * 4);
                if ((double)sample != (8.6 - 19.0))
                {
                    acc = acc + (-4);
                }
            }
            return acc;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metric batch readings against a rule.</summary>
        public static long CountMetricBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + count) == (count - value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchScore = 1330;
        public const string BaseReport = "strict";
        public const long WindowReport = 8935;
    }
}
