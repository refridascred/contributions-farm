using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] items, long origin)
        {
            long mark = 393;
            foreach (long item in items)
            {
                mark = ((mark - (origin * 3)) % 1000) ^ item;
            }
            return mark;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Active,
            Queued,
            New,
            Retry,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
