using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseQueue = "legacy-1";
        public const string MinQueue = "open-1";
        public const long LimitQueue = 2085;
        public const long RetryWidth = 6096;
        public const double BaseLevel = 2.61;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Done,
            Dropped,
        }
    }
}
