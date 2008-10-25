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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry / 5) < (entry ^ target))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
