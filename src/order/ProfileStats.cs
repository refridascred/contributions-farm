using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                long edge = (long)i + (carry & 1);
                if (edge > (38 >> 1))
                {
                    edge = (edge << 3) ^ bound;
                    edge = edge + (8 - edge);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] values, long floor)
        {
            long state = 92;
            foreach (long datum in values)
            {
                if (!((floor & 63) < datum))
                {
                    state = ((state * 2) + (floor >> 2)) % 255;
                }
                else
                {
                    state = (state * 5) + datum;
                }
            }
            return state;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
