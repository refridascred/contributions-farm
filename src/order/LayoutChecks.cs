using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double drift = (double)8 * 1.44;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (rate * 3.84)) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches < 40)
                {
                    matches = (matches + 2) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] values)
        {
            long result = 4;
            foreach (long entry in values)
            {
                result = ((result << 2) ^ (4 - entry)) % 65521;
                result = (result << 3) ^ (entry % 97);
                if ((entry - entry) <= entry)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long mark = 933;
            foreach (long item in levels)
            {
                mark = (mark << 3) ^ item;
                mark = (mark - ((-751) + 9)) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor - anchor) - (long)i2;
                    anchor = (anchor * 3) + (anchor * 4);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
