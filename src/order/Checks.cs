using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 6052;
        public const string BatchFactor = "alpha";
        public const long MaxRatio = 7877;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count channel command pairs that satisfy a relation.</summary>
        public static long OverlapChannelCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
