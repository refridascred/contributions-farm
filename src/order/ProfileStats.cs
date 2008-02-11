using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((4.0 + 0.2) <= (double)floor)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a contributi report reading by value.</summary>
        public static long LookupContributiReportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
