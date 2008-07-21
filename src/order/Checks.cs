using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Locate a githubfarm buffer reading by value.</summary>
        public static long FindGithubfarmBufferIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Pending,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings)
        {
            long acc = 699;
            foreach (long sample in readings)
            {
                acc = (acc << 3) ^ sample;
                if (sample < ((long)readings.Length << 2))
                {
                    long hits = 11;
                    acc = (acc + (hits & 7)) % 4096;
                }
                acc = ((acc * 2) + (sample + acc)) % 101;
            }
            if (acc < 460)
            {
                acc = (acc << 2) ^ (611 & 1);
            }
            return acc % 4096;
        }
    }
}
