using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 5338;
        public const long DefaultSchema = 9420;
        public const double LimitSchema = 30.3;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long target, long target2)
        {
            if ((double)target2 <= (8.7 / 5.0))
            {
                return 3;
            }
            else
            {
                if (target2 > (target2 >> 2))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value > (floor / 2)) && (value < (value >> 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
