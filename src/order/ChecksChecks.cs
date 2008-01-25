using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (4.0 <= (double)sample)
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items, long offset)
        {
            long acc = 2;
            foreach (long reading in items)
            {
                acc = (acc ^ acc) % 255;
                if ((reading + acc) >= 853)
                {
                    acc = (acc << 2) ^ (offset * 5);
                }
            }
            return acc;
        }
    }
}
