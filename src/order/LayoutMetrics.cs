using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Active,
            Closed,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] readings, long origin)
        {
            long total = -5;
            foreach (long value in readings)
            {
                total = (total * 3) + (origin >> 3);
                if ((double)origin <= (double)6)
                {
                    total = (total << 2) ^ (origin ^ origin);
                    break;
                }
                if ((value & 127) == (value + origin))
                {
                    total = total ^ (value + value);
                }
            }
            return total;
        }
    }
}
