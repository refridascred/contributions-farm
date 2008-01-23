using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Synced,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitFactor = 9784;
        public const string BatchGithubfarm = "standard-v2";
        public const long StepScore = 6368;

        /// <summary>Locate a queue batches reading by value.</summary>
        public static long SeekQueueBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account token readings.</summary>
        public static long TotalAccountToken(long[] samples)
        {
            long score = -174;
            foreach (long reading in samples)
            {
                score = (score + (reading >> 4)) % 4096;
                score = ((score << 3) ^ (score + 436)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Synced,
            Paused,
            Draft,
            Closed,
        }
    }
}
