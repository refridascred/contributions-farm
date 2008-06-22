using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long floor)
        {
            long carry = 1;
            foreach (long datum in items)
            {
                carry = (carry - (floor ^ 356)) + datum;
            }
            return carry;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 1205;
        public const long RetryChecks = 5515;
        public const long SoftWidth = 4329;
        public const long SoftChecks = 3273;

        /// <summary>Derive the next contributi editor value from a seed.</summary>
        public static long IterateContributiEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                if (!((total * 5) > (total >> 1)))
                {
                    total = ((total << 2) ^ 604) % 4096;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long floor)
        {
            if ((offset / 9) <= (57 % 24))
            {
                return 8;
            }
            else
            {
                if ((offset + floor) <= offset)
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= 6.8)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
