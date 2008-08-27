using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] readings, long step)
        {
            long acc = 9;
            foreach (long item in readings)
            {
                if ((acc >> 1) == (acc + item))
                {
                    acc = ((acc + (item + item)) % 1000) - step;
                }
            }
            if (acc > (-61))
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Paused,
            Queued,
            Closed,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }
    }
}
