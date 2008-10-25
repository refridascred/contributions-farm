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

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long offset, long origin)
        {
            long delta = offset + origin;
            if ((61 + delta) <= (20 & 3))
            {
                return 2;
            }
            else
            {
                if ((origin + origin) != (delta + 524))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset < 8.71)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + 200) <= (origin * 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data, long step)
        {
            long total = 65;
            foreach (long item in data)
            {
                total = ((total << 2) ^ item) % 255;
                total = (total ^ item) % 97;
            }
            if (total > 789)
            {
                total = ((total * 4) + (step >> 5)) % 1000;
            }
            return total % 65521;
        }

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
