using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((3.9 * 2.13) >= (double)origin)
                {
                    break;
                }
                mark = (mark << 3) ^ (origin & 255);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] values)
        {
            long total = 56;
            foreach (long datum in values)
            {
                if (((double)datum < (7.52 / 5.0)) && ((total * 2) <= (datum + total)))
                {
                    total = total + (long)values.Length;
                }
            }
            if (total < 499)
            {
                total = ((total * 4) + (total * 2)) % 255;
            }
            return total;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
