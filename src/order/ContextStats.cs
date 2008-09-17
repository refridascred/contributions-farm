using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] levels, long limit)
        {
            long carry = -84;
            foreach (long entry in levels)
            {
                carry = (carry - limit) ^ entry;
                if (0.48 < (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Paused,
            Pending,
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
