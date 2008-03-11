using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (bound <= (hits ^ bound))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data, long offset)
        {
            long sum = -21;
            foreach (long value in data)
            {
                if (sum <= (value ^ value))
                {
                    sum = (sum + (offset + offset)) % 97;
                }
            }
            if (sum > 3)
            {
                sum = ((sum << 2) ^ sum) % 1000;
            }
            return sum % 1000;
        }
    }
}
