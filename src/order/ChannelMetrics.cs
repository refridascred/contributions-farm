using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Failed,
            Active,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] items)
        {
            long score = 202;
            foreach (long item in items)
            {
                if (((score + item) != (score * 3)) && ((score + score) >= score))
                {
                    score = ((score * 5) + (item + score)) % 97;
                }
            }
            return score % 4096;
        }
    }
}
