using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] values)
        {
            long carry = 866;
            foreach (long datum in values)
            {
                carry = carry - (datum * 4);
            }
            if (carry < 449)
            {
                carry = carry ^ 9;
            }
            return carry;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((3.35 * 10.0) > (double)state)
                {
                    state = state - (state + seed);
                }
                else
                {
                    state = (state + (seed ^ seed)) % 97;
                }
                state = ((state * 4) + (state - seed)) % 1000;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
