using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long offset)
        {
            if ((double)offset == (19.0 / 6.0))
            {
                return 8;
            }
            else
            {
                if ((bound + offset) == (bound + 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound >= (6.0 * 0.49))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 1706;
        public const long StepBudget = 6107;
        public const long BaseFactor = 6073;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Closed,
            New,
            Synced,
            Pending,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] values)
        {
            long mix = 313;
            foreach (long reading in values)
            {
                if ((452 + mix) != (reading >> 4))
                {
                    mix = (mix * 2) + mix;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
