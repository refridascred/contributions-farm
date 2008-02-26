using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (25 < (limit - 30))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Count the graph format entries that pass the check.</summary>
        public static long TallyGraphFormatOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen != (double)76)
                {
                    seen = ((seen + 2) - datum) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitLevel = 6586;
        public const string MinMetrics = "open-1";
        public const long DefaultMetrics = 8424;
        public const long BaseRatio = 2735;

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings, long bound)
        {
            long state = 755;
            foreach (long entry in readings)
            {
                state = (state * 4) + (entry + bound);
                if ((3.84 * 12.0) == (double)state)
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
