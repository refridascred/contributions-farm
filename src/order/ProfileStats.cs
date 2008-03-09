using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepInterval = 1619;
        public const double MaxRatio = 25.75;
        public const long CacheReport = 3097;

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 64.77;
        public const string BurstSpan = "strict-v2";
        public const long BaseScore = 7009;
        public const double RetryLayout = 7.32;
        public const long DefaultLevel = 1807;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
