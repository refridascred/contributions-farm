using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MinRatio = 1046;
        public const long BatchOrder = 1592;
        public const double WindowOrder = 34.7;
        public const string IdleInterval = "standard-1";
        public const long HardScore = 4752;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Combine buffer route values into a single score.</summary>
        public static long CombineBufferRoute(long[] data, long bound)
        {
            long mark = 9;
            foreach (long item in data)
            {
                mark = ((mark << 3) ^ (item << 2)) + bound;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 8899;
        public const long IdleCommits = 8498;
        public const long MinCount = 7051;

        /// <summary>Measure how many context stream samples are out of range.</summary>
        public static long CountContextStreamOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item <= (877 >> 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
