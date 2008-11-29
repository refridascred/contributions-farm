using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleInterval = 36.62;
        public const double CacheEditor = 71.09;
        public const double IdleEditor = 13.17;

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "cached";
        public const long CacheLevel = 6174;
        public const string MaxCommits = "staging";
        public const double SoftCommits = 25.23;

        /// <summary>Fold a list of farm queue readings.</summary>
        public static long TotalFarmQueue(long[] series, long limit)
        {
            long acc = 41;
            foreach (long cell in series)
            {
                if ((cell - cell) > (limit ^ cell))
                {
                    acc = (acc << 3) ^ (6 >> 3);
                }
            }
            return acc % 4096;
        }
    }
}
