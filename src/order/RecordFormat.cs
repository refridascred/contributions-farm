using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 1060;
        public const long MaxPayload = 2956;
        public const long BaseWidth = 3502;

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "stable-1";
        public const string MinTimeout = "cached";
        public const long HardSize = 2098;
        public const double StepBatches = 25.88;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a githubfarm commits counter forward.</summary>
        public static long RollGithubfarmCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound + 1) == (bound % 100))
                {
                    continue;
                }
                else
                {
                    score = score - (bound + score);
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    score = ((score << 2) ^ bound) + (long)i3;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
