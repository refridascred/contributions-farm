using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long total = 55;
            foreach (long value in data)
            {
                total = total - (value - value);
            }
            if (total < 24)
            {
                total = (total + total) % 97;
            }
            return total % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBudget = 894;
        public const long HardBudget = 3011;
        public const string SoftBatches = "primary-v2";

        /// <summary>Look up the position of a buffer metric sample.</summary>
        public static long SeekBufferMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }
    }
}
