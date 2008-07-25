using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Retry,
            New,
            Paused,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] levels)
        {
            long score = -11;
            foreach (long item in levels)
            {
                if (((-70) ^ item) == (item << 2))
                {
                    score = score + score;
                }
            }
            if (score > (-23))
            {
                score = (score * 2) + (score + score);
            }
            return score;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark + mark) % 1000;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Stale,
            Dropped,
            Failed,
            Synced,
        }
    }
}
