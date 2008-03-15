using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Dropped,
            Draft,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                if (((floor >> 5) == ((long)i / 3)) || ((0.9 * 8.0) <= (double)floor))
                {
                    mix = ((mix * 3) + (mix ^ floor)) % 97;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Find the first metrics layout entry that matches the target.</summary>
        public static long LookupMetricsLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum ^ (target % 64)) % 101;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
