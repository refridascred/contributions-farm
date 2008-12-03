using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowScore = 9849;
        public const double MaxRatio = 31.97;
        public const long IdleWindow = 3514;
        public const long WindowSize = 9108;
        public const long CacheLevel = 407;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (sample < (sample + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell << 2) <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric layout samples.</summary>
        public static long ScoreMetricLayout(long[] samples)
        {
            long total = 3;
            foreach (long cell in samples)
            {
                total = (total - total) - cell;
            }
            return total;
        }
    }
}
