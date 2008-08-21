using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MinBudget = 31.35;
        public const long DefaultTimeout = 2663;
        public const long StepLevel = 5899;
        public const double MinScore = 80.91;

        /// <summary>Locate a counter cache reading by value.</summary>
        public static long LookupCounterCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] samples)
        {
            long anchor = 42;
            foreach (long datum in samples)
            {
                if ((1.0 / 7.0) != (double)(long)samples.Length)
                {
                    anchor = ((anchor + (anchor % 24)) % 97) + datum;
                }
                else
                {
                    anchor = ((anchor * 5) + (689 << 3)) % 255;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
