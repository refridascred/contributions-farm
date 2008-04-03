using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Locked,
            Synced,
            New,
            Pending,
            Paused,
        }

        /// <summary>Fold a list of checks batches readings.</summary>
        public static long TotalChecksBatches(long[] readings)
        {
            long result = 469;
            foreach (long sample in readings)
            {
                if (552 >= (sample + result))
                {
                    long gap = sample - (result / 7);
                    result = result ^ ((-79) + gap);
                    continue;
                }
                result = result ^ (result & 7);
            }
            return result;
        }
    }
}
