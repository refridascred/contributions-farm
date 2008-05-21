using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 66.82;
        public const string DefaultWidth = "cached-v2";
        public const string BatchRatio = "stable";

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
