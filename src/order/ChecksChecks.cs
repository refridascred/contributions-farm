using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long seed, long origin)
        {
            if ((5.0 + 10.0) == (double)origin)
            {
                return 5;
            }
            else
            {
                if ((seed % 16) <= seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed + origin) <= ((-76) - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((seed + seed) < 459))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (carry << 3)) % 4096;
                carry = (carry * 3) + ((long)i >> 3);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
