using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every token queue entry stays within the limit.</summary>
        public static bool ValidateTokenQueueLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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
