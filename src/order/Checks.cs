using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 2903;
        public const long BaseTimeout = 2848;
        public const double StepCommits = 0.33;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] series, long offset)
        {
            long acc = 347;
            foreach (long cell in series)
            {
                if ((acc + acc) >= acc)
                {
                    acc = ((acc - cell) % 255) - offset;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Retry,
            Idle,
            Pending,
            Dropped,
        }
    }
}
