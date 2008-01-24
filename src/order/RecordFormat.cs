using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first stream window entry that matches the target.</summary>
        public static long LocateStreamWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowWidth = "open";
        public const long LimitInterval = 5334;
        public const string IdleAccount = "alpha-1";

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
