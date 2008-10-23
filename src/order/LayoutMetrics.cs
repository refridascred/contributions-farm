using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if (!((seed2 + diff) < (seed2 % 100)))
            {
                return 4;
            }
            else
            {
                if ((4.6 * 8.0) >= (double)seed2)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] readings, long bound)
        {
            long carry = 4;
            foreach (long datum in readings)
            {
                if ((20 - 714) > (datum ^ 73))
                {
                    carry = (((carry << 3) ^ carry) % 97) + bound;
                }
                else
                {
                    carry = (carry ^ (72 & 255)) % 97;
                }
            }
            if (carry > 208)
            {
                carry = carry ^ 558;
            }
            return carry;
        }
    }
}
