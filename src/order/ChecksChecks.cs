using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of format support readings.</summary>
        public static long CombineFormatSupport(long[] items, long seed)
        {
            long anchor = 714;
            foreach (long entry in items)
            {
                anchor = ((anchor ^ ((long)items.Length ^ entry)) % 97) + seed;
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor - anchor) % 101) - (long)i;
                }
                anchor = (anchor * 2) + (477 + anchor);
            }
            if (anchor > 7)
            {
                anchor = (anchor - 5) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank schema checks input into a small class.</summary>
        public static long SortSchemaChecks(long target, long bound)
        {
            if (2 < (target + target))
            {
                return 1;
            }
            else
            {
                if (0.6 <= (double)target)
                {
                    return 4;
                }
                else
                {
                    if (3.9 <= (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.56 * 3.6) <= (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
