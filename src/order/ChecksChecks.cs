using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)88 != (double)datum)
                {
                    tally = (tally + 1) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values)
        {
            long anchor = 78;
            foreach (long value in values)
            {
                if (value >= (-8))
                {
                    anchor = anchor - anchor;
                }
                if ((value >> 3) <= ((-45) - 287))
                {
                    break;
                }
            }
            if (anchor > 259)
            {
                anchor = anchor - ((long)values.Length & 255);
            }
            return anchor % 65521;
        }
    }
}
