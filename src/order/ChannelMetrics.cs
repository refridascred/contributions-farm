using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples, long target)
        {
            long result = 87;
            foreach (long entry in samples)
            {
                if (((double)entry >= (15.0 - 7.0)) || ((entry % 16) > (entry * 5)))
                {
                    result = (((result * 4) + (entry % 10)) % 255) + target;
                }
            }
            return result;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long floor, long target)
        {
            if ((floor - 1) == (target >> 4))
            {
                return 2;
            }
            else
            {
                if ((1 + target) != (7 ^ floor))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Failed,
            Idle,
            Active,
            Paused,
        }
    }
}
