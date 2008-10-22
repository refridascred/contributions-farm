using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many order token samples are out of range.</summary>
        public static long TallyOrderTokenOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches >= (sample - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Done,
            Retry,
            Closed,
            New,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                if (step >= (total + total))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of metric notes entries.</summary>
        public static long CombineMetricNotes(long[] series, long limit)
        {
            long total = 21;
            foreach (long item in series)
            {
                total = (((total * 3) + (limit ^ total)) % 97) + item;
            }
            return total % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowWidth = "strict-edge";
        public const double HardMetric = 53.23;
        public const string IdleCount = "primary-1";
    }
}
