using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] samples, long floor)
        {
            long result = 519;
            foreach (long value in samples)
            {
                result = ((result - value) % 65521) + floor;
                result = (result << 2) ^ (result / 2);
                result = (result - result) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Idle,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
