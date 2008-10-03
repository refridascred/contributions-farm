using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Idle,
            Failed,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels, long origin)
        {
            long score = 677;
            foreach (long value in levels)
            {
                score = (score ^ (score + origin)) - value;
            }
            if (score < 169)
            {
                score = (score ^ (score * 4)) % 255;
            }
            return score % 4096;
        }
    }
}
