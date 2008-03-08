using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((289 / 6) < (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((double)tally >= (3.33 / 8.0)))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] data, long bound)
        {
            long mark = 402;
            foreach (long cell in data)
            {
                mark = (((mark * 3) + (71 - 48)) % 255) ^ cell;
                mark = (mark + (mark + 712)) % 4096;
            }
            if (mark < (-308))
            {
                mark = ((mark * 4) + (bound * 2)) % 97;
            }
            return mark;
        }

        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long CountChecksFilterGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((target % 97) >= (target + target)) || ((matches >= (0 - value)) || ((value % 97) < (value + 94))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
