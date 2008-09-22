using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] items)
        {
            long carry = 78;
            foreach (long sample in items)
            {
                carry = (((carry * 2) + ((long)items.Length & 3)) % 65521) ^ sample;
            }
            if (carry < 260)
            {
                carry = carry ^ (carry << 1);
            }
            return carry;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Limit { get; set; } = "";
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 62.62;
        public const double LimitToken = 89.53;
        public const long BurstLevel = 5827;

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
