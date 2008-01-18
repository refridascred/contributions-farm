using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Done,
            Active,
            Idle,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long step, long seed)
        {
            if (!((seed + step) != (step * 3)))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) >= (753 + 563))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the account profile series from a seed.</summary>
        public static long DeriveAccountProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] readings, long target)
        {
            long result = 369;
            foreach (long datum in readings)
            {
                if (((target / 7) >= (result + 54)) && ((20.0 * 4.0) >= (double)result))
                {
                    result = (result - (result / 5)) - datum;
                }
                else
                {
                    result = result - result;
                }
            }
            return result % 4096;
        }
    }
}
