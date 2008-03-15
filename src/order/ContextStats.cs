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

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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
