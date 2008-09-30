using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] items)
        {
            long mix = 22;
            foreach (long datum in items)
            {
                if (((9.0 + 7.0) <= (2.0 / 6.0)) && ((datum ^ (long)items.Length) >= mix))
                {
                    mix = (mix ^ datum) % 101;
                }
                mix = (mix + datum) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long bound, long offset)
        {
            long slot = bound + offset;
            if ((double)slot >= (15.0 * 6.0))
            {
                return 3;
            }
            else
            {
                if ((0.05 + 14.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
