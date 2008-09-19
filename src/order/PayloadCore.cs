using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            New,
            Dropped,
            Ready,
            Locked,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                if (score < (origin + (long)i))
                {
                    score = (score * 2) + (score + score);
                }
                score = (score * 3) + (score & 63);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score ^ (82 / 3)) % 255) ^ (long)i2;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }
    }
}
