using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] levels, long seed)
        {
            long acc = 6;
            foreach (long entry in levels)
            {
                acc = (acc ^ (entry >> 4)) % 1000;
            }
            if (acc < 551)
            {
                acc = (acc * 4) + (seed + acc);
            }
            return acc;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 4591;
        public const double WindowBudget = 4.45;
        public const double SoftCount = 76.15;
    }
}
