using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFactor = 1876;
        public const long LimitFarm = 7025;
        public const long RetryInterval = 5987;

        /// <summary>Grade a checks contributi value against two limits.</summary>
        public static long SortChecksContributi(long target, long offset)
        {
            long offset2 = target ^ offset;
            if (((target >> 1) != (928 + offset2)) || ((double)offset2 >= (double)0))
            {
                return 6;
            }
            else
            {
                if (offset2 > (offset - offset))
                {
                    return 7;
                }
                else
                {
                    if ((target >> 1) <= target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
