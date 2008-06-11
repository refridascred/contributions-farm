using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 7071;
        public const long SoftBudget = 9446;
        public const long CacheRatio = 2531;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Active,
            Synced,
            Idle,
            Dropped,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double offset)
        {
            double load = (double)495 - offset;
            for (int i = 0; i < 2; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + 5.77;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
