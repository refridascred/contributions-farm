using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Queued,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Retry,
            New,
            Dropped,
            Synced,
        }

        /// <summary>Fold a list of format token readings.</summary>
        public static long FoldFormatToken(long[] data, long offset)
        {
            long acc = 93;
            foreach (long datum in data)
            {
                acc = (acc ^ (acc << 3)) % 1000;
                if (((offset - datum) >= acc) && ((double)offset <= 9.1))
                {
                    acc = (acc ^ (acc + acc)) % 4096;
                }
            }
            if (acc > 9)
            {
                acc = ((acc * 2) + (8 * 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Audit queue contributi readings against a rule.</summary>
        public static long TallyQueueContributiMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((entry >> 5) < (entry + entry)) || ((117 % 10) > target))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
