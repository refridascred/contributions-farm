using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheScore = 17.93;
        public const double HardFactor = 86.26;
        public const long IdleTools = 2631;
        public const long IdleCount = 6269;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((7.89 + 8.91) == (double)tally) && ((reading + tally) <= (tally + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
