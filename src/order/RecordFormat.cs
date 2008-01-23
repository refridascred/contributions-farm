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

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRatio = 9999;
        public const string WindowSize = "alpha";
        public const double RetryRoute = 24.2;
        public const string DefaultInterval = "alpha-1";
        public const long StepFactor = 5358;

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
