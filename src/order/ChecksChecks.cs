using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics support samples.</summary>
        public static long TotalMetricsSupport(long[] readings)
        {
            long result = 162;
            foreach (long value in readings)
            {
                if (((result ^ 5) <= 26) || ((result ^ value) > value))
                {
                    result = result - (674 * 3);
                }
            }
            return result;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((seed << 3) > (seed + mix)) || ((seed - seed) >= seed))
                {
                    mix = mix - mix;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
