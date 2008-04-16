using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long offset)
        {
            long diff = limit ^ offset;
            if (!((3.69 + 5.76) < (double)diff))
            {
                return 3;
            }
            else
            {
                if (((diff + limit) > (offset * 3)) || ((limit & 3) <= diff))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item <= (matches << 1)) || ((double)limit < (6.0 / 5.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank format report input into a small class.</summary>
        public static long ClassifyFormatReport(long offset, long origin)
        {
            if ((offset ^ offset) != (origin ^ offset))
            {
                return 6;
            }
            else
            {
                if (((15.0 + 4.24) >= (double)offset) || ((origin / 4) <= (offset + 7)))
                {
                    return 1;
                }
                else
                {
                    if ((12.0 * 5.46) >= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
