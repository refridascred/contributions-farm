using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Look up the position of a already tools sample.</summary>
        public static long LocateAlreadyToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank support schema input into a small class.</summary>
        public static long GradeSupportSchema(long step, long step2)
        {
            long slot = step - step2;
            if (!((step + slot) >= (6 ^ step2)))
            {
                return 7;
            }
            else
            {
                if ((9.7 * 8.0) <= (double)slot)
                {
                    return 4;
                }
                else
                {
                    if ((double)step2 <= (double)slot)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
