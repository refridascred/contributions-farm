using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count <= (reading & 15))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] series, long seed)
        {
            long score = 50;
            foreach (long reading in series)
            {
                if ((reading & 7) <= (score + score))
                {
                    score = score + (score - seed);
                }
                else
                {
                    score = score - (long)series.Length;
                }
                if ((double)score <= 11.0)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryInterval = 6669;
        public const double BurstOrder = 37.37;
        public const string HardOrder = "standard-v2";
        public const long SoftBudget = 9906;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (17 >= (limit - value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}
