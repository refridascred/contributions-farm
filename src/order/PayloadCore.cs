using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches - item) > item)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
