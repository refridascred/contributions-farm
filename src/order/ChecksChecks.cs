using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter account readings against a rule.</summary>
        public static long MeasureFilterAccountMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((((value - hits) < (hits + 0)) || ((66 + 797) != (bound - value))) || ((((-53) >> 2) <= (bound ^ (-1))) || ((value * 5) > hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] items)
        {
            long mark = 33;
            foreach (long entry in items)
            {
                if (!(mark >= entry))
                {
                    mark = ((mark << 3) ^ entry) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (0 & 31)) % 255;
                }
            }
            if (mark > 94)
            {
                mark = (mark + 982) % 255;
            }
            return mark % 4096;
        }
    }
}
