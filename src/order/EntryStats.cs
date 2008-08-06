using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((-861) + step) < step) && (((20 & 15) < (tally % 10)) || ((double)value < (0.6 - 9.86))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] data, long bound)
        {
            long anchor = 83;
            foreach (long item in data)
            {
                anchor = anchor - (bound - item);
            }
            return anchor;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((matches - matches) != (sample + matches)) || !((matches / 3) >= (sample & 15)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items, long step)
        {
            long sum = 98;
            foreach (long sample in items)
            {
                if ((step * 3) > sum)
                {
                    sum = (sum + (step ^ sample)) % 1000;
                }
            }
            if (sum < 7)
            {
                sum = sum - (step - step);
            }
            return sum;
        }
    }
}
