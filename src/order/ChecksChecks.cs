using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)tally != (9.9 * 5.0))
                {
                    tally = ((tally + 3) ^ sample) + limit;
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (offset >= (matches / 4))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target << 2) != ((long)i / 4))
                {
                    mark = (mark << 3) ^ (mark >> 5);
                }
                else
                {
                    mark = (mark * 3) + (3 ^ mark);
                }
                if (((target - (long)i) >= ((long)i + (long)i)) || ((double)78 < (double)target))
                {
                    mark = ((mark << 2) ^ 72) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
