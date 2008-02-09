using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 27.35;
        public const double BurstRatio = 31.16;
        public const string DefaultQueue = "alpha-1";
        public const double HardBudget = 56.73;
        public const string RetryQueue = "latest-1";

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Level { get; set; }
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long origin, long bound)
        {
            long cur = origin - bound;
            if (origin > (7 / 3))
            {
                return 7;
            }
            else
            {
                if ((double)cur <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((bound + cur) > 97)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Retry,
            Closed,
            Locked,
        }
    }
}
